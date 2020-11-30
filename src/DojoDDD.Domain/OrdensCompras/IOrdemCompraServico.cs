﻿using System.Threading.Tasks;

namespace DojoDDD.Domain.OrdensCompras
{
    public interface IOrdemCompraServico
    {
        Task<bool> AlterarStatudOrdemDeCompraParaEmAnalise(string ordemDeCompraId);
        Task<string> RegistrarOrdemCompra(string clienteId, int produtoId, int quantidadeCompra);
    }
}