using API.Models;
using API.Repositories;

namespace API.Services
{
    public class PassagemService
    {
        private IPassagemRepository _passagemRepository;

        public PassagemService()
        {
            _passagemRepository = new PassagemRepository();
        }

        public bool Insert(Passagem passagem)
        {
            return _passagemRepository.Insert(passagem);
        }

        public List<Passagem> GetAll()
        {
            return _passagemRepository.GetAll();
        }
    }
}
