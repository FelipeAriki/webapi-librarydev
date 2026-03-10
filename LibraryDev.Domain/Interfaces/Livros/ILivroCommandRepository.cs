using LibraryDev.Domain.Entities;

namespace LibraryDev.Domain.Interfaces.Livros;

public interface ILivroCommandRepository
{
    public Task<int> CriarLivroAsync(Livro livro);
}
