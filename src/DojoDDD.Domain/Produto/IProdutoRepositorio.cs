using System.Collections.Generic;
using System.Threading.Tasks;

namespace DojoDDD.Domain.Produto
{
    public interface IProdutoRepositorio
    {
        Task<Domain.Entities.Produto> ConsultarPorId(int id);
        Task<IEnumerable<Domain.Entities.Produto>> Consultar();
    }
}