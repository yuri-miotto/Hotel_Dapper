using API.Models;

namespace API.Repositories
{
    public interface ICidadeRepository
    {
        bool Insert(Cidade cidade);

        List<Cidade> GetAll();
    }
}
