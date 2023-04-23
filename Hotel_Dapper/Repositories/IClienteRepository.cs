using API.Models;

namespace API.Repositories
{
    public interface IClienteRepository
    {
        bool Insert(Cliente cliente);

        List<Cliente> GetAll();
    }
}
