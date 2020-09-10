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
    public class ResetAuthenticatorModel : PageModel
    {
        UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        ILogger<ResetAuthenticatorModel> _logger;

        public ResetAuthenticatorModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<ResetAuthenticatorModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Benutzer mit der ID '{_userManager.GetUserId(User)}' kann nicht geladen werden.");
            }

            await _userManager.SetTwoFactorEnabledAsync(user, false);
            await _userManager.ResetAuthenticatorKeyAsync(user);
            _logger.LogInformation("Benutzer mit der ID '{UserId}' hat seinen Authentifizierungs-App-Schlüssel zurückgesetzt.", user.Id);

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Ihr Schlüssel für die Authentifizierungsapplikation wurde zurückgesetzt, Sie müssen Ihre Authentifizierungsapplikation mit dem neuen Schlüssel konfigurieren.";

            return RedirectToPage("./EnableAuthenticator");
        }
    }
}