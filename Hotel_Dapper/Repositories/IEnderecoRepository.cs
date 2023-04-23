using API.Models;

namespace API.Repositories
{
    public interface IEnderecoRepository
    {
        bool Insert(Endereco endereco);

        List<Endereco> GetAll();
    }
}
