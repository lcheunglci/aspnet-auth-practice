using ImageGallery.Model;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace ImageGallery.Client.PostConfigurationOptions
{
    public class OpenIdConnectOptionsPostConfigureOptions : IPostConfigureOptions<OpenIdConnectOptions>
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public OpenIdConnectOptionsPostConfigureOptions(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public void PostConfigure(string name, OpenIdConnectOptions options)
        {
            options.Events = new OpenIdConnectEvents()
            {
                OnTicketReceived = async ticketReceivedContext =>
                {
                    var subject = ticketReceivedContext.Principal.Claims.FirstOrDefault(c => c.Type == "sub").Value;

                    var apiClient = _httpClientFactory.CreateClient("APIClient");

                    var request = new HttpRequestMessage(
                        HttpMethod.Get,
                        $"/api/applicationuserprofiles/{subject}");

                    var response = await apiClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead).ConfigureAwait(false);

                    response.EnsureSuccessStatusCode();

                    var applicationUserProfile = new ApplicationUserProfile();
                    using (var responseStream = await response.Content.ReadAsStreamAsync())
                    {
                        applicationUserProfile = await JsonSerializer.Deserialize<ApplicationUserProfile>(responseStream);
                    }


                }
            };
        }
    }
}
