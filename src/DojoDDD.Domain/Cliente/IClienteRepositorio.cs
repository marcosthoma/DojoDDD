using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Domain.Cliente
{
    public interface IClienteRepositorio
    {
        Task<Entities.Cliente> ConsultarPorId(string id);
        Task<IEnumerable<Entities.Cliente>> ConsultarTodosCliente();
    }
}