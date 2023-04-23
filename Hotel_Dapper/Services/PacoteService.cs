using API.Models;
using API.Repositories;

namespace API.Services
{
    public class PacoteService
    {
        private IPacoteRepository _pacoteRepository;

        public PacoteService()
        {
            _pacoteRepository = new PacoteRepository();
        }

        public bool Insert(Pacote pacote)
        {
            return _pacoteRepository.Insert(pacote);
        }

        public List<Pacote> GetAll()
        {
            return _pacoteRepository.GetAll();
        }
    }
}
