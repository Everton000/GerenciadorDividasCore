using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using GerenciadorDividasCore.Models.Serialize;

namespace GerenciadorDividasCore.HttpClients
{
    public class ClienteApiClient
    {
        private readonly HttpClient _httpClient;

        public ClienteApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IList<Cliente>> GetClientesAsync()
        {
            HttpResponseMessage resposta = await _httpClient.GetAsync("users");
            resposta.EnsureSuccessStatusCode();

            return await JsonSerializer.DeserializeAsync<IList<Cliente>>(
                await resposta.Content.ReadAsStreamAsync());
        }
    }
}