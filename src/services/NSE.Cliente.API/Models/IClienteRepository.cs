using NSE.Core.Data;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSE.Clientes.API.Models
{
    public interface IClienteRepository : IRepository<Cliente.API.Models.Cliente>
    {
        void Adicionar(Cliente.API.Models.Cliente cliente);
        Task<IEnumerable<Cliente.API.Models.Cliente>> ObterTodos();
        Task<Cliente.API.Models.Cliente> ObterPorCpf(string cpf);
    }
}
