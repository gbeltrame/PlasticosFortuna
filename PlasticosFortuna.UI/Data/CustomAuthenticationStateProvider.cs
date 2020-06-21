using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.Authorization;
using PlasticosFortuna.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PlasticosFortuna.UI.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorageService;
        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService = sessionStorageService;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            ClaimsIdentity identity;

            var loginId = await _sessionStorageService.GetItemAsync<string>("loginId");

            if (loginId != null)
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, loginId),

                }, "apiauth_type");

            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var user = new ClaimsPrincipal(identity);

            return await Task.FromResult(new AuthenticationState(user));
        }

        public void MarkUserAsAutheticated(UserModel user)
        {
            var identity = GetClaimsIdentity(user);

            var claimsPrincipal = new ClaimsPrincipal(identity);

            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }

        private ClaimsIdentity GetClaimsIdentity(UserModel user)
        {
            var claimsIdentity = new ClaimsIdentity(new[]
{
                new Claim(ClaimTypes.Name, user.LoginId),
                new Claim(ClaimTypes.Role, user.UserRole.RoleName)

            }, "apiauth_type");

            return claimsIdentity;
        }

        public void MarkUserAsLoggedOut()
        {
            _sessionStorageService.RemoveItemAsync("loginId");
            _sessionStorageService.RemoveItemAsync("X-AuthenticationToken");
            var identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
    }
}
