using DojoDDD.Api.Infrastructure;
using DojoDDD.Domain.Cliente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Infrastructure.Cliente
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly DataStore _dataStore;

        public ClienteRepositorio(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public async Task<Domain.Entities.Cliente> ConsultarPorId(string id)
        {
            var cliente = _dataStore.Clientes.Find(x => x.Id.Equals(id));
            return await Task.FromResult(cliente).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Domain.Entities.Cliente>> ConsultarTodosCliente()
            => await Task.FromResult(_dataStore.Clientes).ConfigureAwait(false);
    }
}