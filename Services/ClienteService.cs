using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GerenciadorDividasCore.HttpClients;
using GerenciadorDividasCore.Models.Serialize;

namespace GerenciadorDividasCore.Services
{
    public interface ISClienteService
    {
        Task<IList<Cliente>> GetClientesAsync();
    }

    public class ClienteService : ISClienteService
    {
        private readonly ClienteApiClient _api;

        public ClienteService(ClienteApiClient api)
        {
            _api = api;
        }

        public async Task<IList<Cliente>> GetClientesAsync()
        {
            return await _api.GetClientesAsync();
        }
    }
}