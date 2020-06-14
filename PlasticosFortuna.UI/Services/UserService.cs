using Blazored.SessionStorage;
using Newtonsoft.Json;
using PlasticosFortuna.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PlasticosFortuna.UI.Services
{
    public class UserService : IUserService
    {
        private HttpClient _httpClient { get; }
        private ISessionStorageService _sessionStorageService { get; }

        public UserService(HttpClient httpClient, ISessionStorageService sessionStorageService)
        {
            _httpClient = httpClient;
            _sessionStorageService = sessionStorageService;
        }
        public async Task<UserModel> LoginAsync(UserModel user)
        {
            string serializedUser = JsonConvert.SerializeObject(user);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "Login");
            requestMessage.Content = new StringContent(serializedUser);

            requestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            Task<HttpResponseMessage> response = _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.Result.StatusCode;

            var responseBody = await response.Result.Content.ReadAsStringAsync();

            var authToken = response.Result.Headers.FirstOrDefault(q => q.Key == "X-AuthenticationToken").Value.FirstOrDefault();

            await _sessionStorageService.SetItemAsync("X-AuthenticationToken", authToken);

            var returnedUser = JsonConvert.DeserializeObject<UserModel>(responseBody);

            await _sessionStorageService.SetItemAsync("loginId", returnedUser.LoginId);

            return await Task.FromResult(returnedUser);
        }

    }
}
