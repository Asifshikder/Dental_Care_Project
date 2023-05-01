using Microsoft.AspNetCore.Components.Authorization;
using Project.Shared.Authentications;
using Project.Shared.Common;
using Project.Web.Models;
using System.Net.Http.Json;

namespace Project.Web.Services.Authentications
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;
        public AuthService(HttpClient http)
        {
            _http = http;
        }
        public async Task<Response<AuthenticationResponse>> Login(AuthenticationRequest request)
        {
            var result = await _http.PostAsJsonAsync("https://localhost:7216/api/auth/login", request);
            return await result.Content.ReadFromJsonAsync<Response<AuthenticationResponse>>();
        }
    }
}
