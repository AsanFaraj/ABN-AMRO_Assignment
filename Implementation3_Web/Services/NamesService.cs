using Domain.Models;
using Implementation3_Web.Models;
using Microsoft.AspNetCore.Components;

namespace Implementation3_Web.Services
{
    public class NamesService
    {
        private readonly HttpClient _httpClient;
        private readonly NavigationManager _navigationManager;
        public NamesService(HttpClient httpClient, NavigationManager navigationManager)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
            _httpClient.BaseAddress = new Uri(_navigationManager.BaseUri+"api/names");
        }

        public async Task<Guid> CalculateNames(CalculationRequest req)
        {
            var response = await _httpClient.PostAsJsonAsync(_httpClient.BaseAddress, req);

            var responseContent = await response.Content.ReadAsStringAsync();

            //Response returns extra quotation marks, need to trim them
            var trimmedContent = responseContent.Trim('"');

            return Guid.Parse(trimmedContent);
        }

        public async Task<StatusObject> GetStatusObject(Guid guid)
        {
            var statusObject = await _httpClient.GetFromJsonAsync<StatusObject>($"{_httpClient.BaseAddress}/{guid}");

            return statusObject;
        }

    }
}
