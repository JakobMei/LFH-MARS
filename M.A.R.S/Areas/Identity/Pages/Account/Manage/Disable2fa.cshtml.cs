using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace M.A.R.S.Areas.Identity.Pages.Account.Manage
{
    public class Disable2faModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<Disable2faModel> _logger;

        public Disable2faModel(
            UserManager<IdentityUser> userManager,
            ILogger<Disable2faModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Benutzer mit der ID '{_userManager.GetUserId(User)}' kann nicht geladen werden.");
            }

            if (!await _userManager.GetTwoFactorEnabledAsync(user))
            {
                throw new InvalidOperationException($"Kann 2FA für Benutzer mit ID '{_userManager.GetUserId(User)}' nicht deaktivieren, da es derzeit nicht aktiviert ist.");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Benutzer mit der ID '{_userManager.GetUserId(User)}' kann nicht geladen werden.");
            }

            var disable2faResult = await _userManager.SetTwoFactorEnabledAsync(user, false);
            if (!disable2faResult.Succeeded)
            {
                throw new InvalidOperationException($"Unerwarteter Fehler ist aufgetreten und deaktiviert 2FA für Benutzer mit der ID '{_userManager.GetUserId(User)}'.");
            }

            _logger.LogInformation("Benutzer mit der ID '{UserId}' hat 2fa deaktiviert.", _userManager.GetUserId(User));
            StatusMessage = "2fa wurde deaktiviert. Sie können 2fa wieder aktivieren, wenn Sie eine Authentifizierungsanwendung einrichten.";
            return RedirectToPage("./TwoFactorAuthentication");
        }
    }
}