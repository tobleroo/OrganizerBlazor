using System.Collections.Specialized;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using Blazored.LocalStorage;
using OrganizerBlazor.Pages;


namespace OrganizerBlazor.Auth
{
    public class LoginService : ILoginService
    {

        private readonly HttpClient _httpClient;
        // get ilocalstorage from blazor
        private readonly ILocalStorageService _localStorage;

        public LoginService(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }
        

        private async Task LoginAsync(string Username, string Password)
        {
            var loginModel = new
            {
                username = Username,
                password = Password
            };

            try
            {
                // Send a POST request to your backend API for login
                var response = await _httpClient.PostAsJsonAsync("api/Auth/login", loginModel);

                if (response.IsSuccessStatusCode)
                {
                    var jsonContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the response to get the JWT token
                    //var result = await response.Content.ReadFromJsonAsync<LoginResult>();
                    //jwtToken = result?.JwtToken;
                    //Console.WriteLine("jwt ->" + jwtToken);
                }
                else
                {
                    // Handle login failure here
                    Console.WriteLine("non success");
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., network error)
                Console.WriteLine(ex);
            }
        }

        private async Task<string> getJwtToken(){
            var jwtToken = await _localStorage.GetItemAsync<string>("jwtToken");
            return jwtToken;
        }

        Task ILoginService.LoginAsync(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        Task<string> ILoginService.getJwtToken()
        {
            throw new NotImplementedException();
        }
    }
}