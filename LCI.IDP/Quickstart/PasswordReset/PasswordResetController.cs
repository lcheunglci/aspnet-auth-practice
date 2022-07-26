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


    }
}
