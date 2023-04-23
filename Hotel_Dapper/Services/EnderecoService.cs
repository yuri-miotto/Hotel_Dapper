using API.Models;
using API.Repositories;

namespace API.Services
{
    public class EnderecoService
    {
        private IEnderecoRepository _enderecoRepository;

        public EnderecoService()
        {
            _enderecoRepository = new EnderecoRepository();
        }

        public bool Insert(Endereco endereco)
        {
            return _enderecoRepository.Insert(endereco);
        }

        public List<Endereco> GetAll()
        {
            return _enderecoRepository.GetAll();
        }
    }
}
