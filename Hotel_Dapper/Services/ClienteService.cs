using API.Models;
using API.Repositories;

namespace API.Services
{
    public class ClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteService()
        {
            _clienteRepository = new ClienteRepository();
        }

        public bool Insert(Cliente cliente)
        {
            return _clienteRepository.Insert(cliente);
        }

        public List<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }
    }
}
