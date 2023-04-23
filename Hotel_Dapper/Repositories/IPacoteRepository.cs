using API.Models;

namespace API.Repositories
{
    public interface IPacoteRepository
    {
        bool Insert(Pacote pacote);

        List<Pacote> GetAll();
    }
}
