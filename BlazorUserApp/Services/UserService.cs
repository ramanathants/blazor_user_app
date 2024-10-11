// Services/UserService.cs
using BlazorUserApp.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BlazorUserApp.Services
{
    public class UserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<User>>("https://localhost:7133/api/user");
        }

        public async Task<User> GetUserById(int id)
        {
            return await _httpClient.GetFromJsonAsync<User>($"https://localhost:7133/api/user/{id}");
        }

        public async Task AddUser(User user)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:7133/api/user", user);
        }

        public async Task UpdateUser(int id, User user)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7133/api/user/{id}", user);
        }

        public async Task DeleteUser(int id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7133/api/user/{id}");
        }
    }
}
