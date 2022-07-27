using LCI.IDP.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LCI.IDP.PasswordReset
{
    public class PasswordResetController : Controller
    {
        private readonly ILocalUserService _localUserService;

        public PasswordResetController(ILocalUserService localUserService)
        {
            _localUserService = localUserService ?? throw new System.ArgumentNullException(nameof(localUserService));
        }

        [HttpGet]
        public IActionResult RequestPassword()
        {
            var vm = new RequestPasswordViewModel();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RequestPassword(RequestPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var securityCode = await _localUserService
                .InitiatePasswordResetRequest(model.Email);

            await _localUserService.SaveChangesAsync();

            // create an activation link
            var link = Url.ActionLink("ResetPassword", "PasswordReset", new { securityCode });

            // this should be replace with a SMTP client to send out an email.
            Debug.WriteLine(link);

            return View("PasswordResetRequestSent");

        }

        [HttpGet]
        public IActionResult ResetPassword(string securityCode)
        {
            var vm = new ResetPasswordViewModel()
            {
                SecurityCode = securityCode
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (await _localUserService.SetPassword(model.SecurityCode, model.Password))
            {
                ViewData["Message"] = "Your password was successfully changed. " +
                    "Navigate to your client application to log in.";
            }
            else
            {
                ViewData["Message"] = "Your password couldn't be changed, please" +
                    " contact your administrator.";
            }

            await _localUserService.SaveChangesAsync();

            return View("ResetPasswordResult");
        }

    }
}
