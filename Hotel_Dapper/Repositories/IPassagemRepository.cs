using API.Models;

namespace API.Repositories
{
    public interface IPassagemRepository
    {
        bool Insert(Passagem passagem);

        List<Passagem> GetAll();
    }
}
