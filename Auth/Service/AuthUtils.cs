using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace OrganizerBlazor.Auth.Service
{
    public class AuthUtils : IAuthUtils
    {
        private readonly ILocalStorageService _localStorage;
        private readonly NavigationManager _navigationManager;

        public AuthUtils(ILocalStorageService localStorage, NavigationManager navigationManager)
        {
            _localStorage = localStorage;
            _navigationManager = navigationManager;
        }

        public async Task RemoveCredentialsAsync()
        {
            // Implement the method to remove credentials from local storage
            await _localStorage.RemoveItemAsync("jwtToken");
            _navigationManager.NavigateTo("/login", true);
        }
    }
}
