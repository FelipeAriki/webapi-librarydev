using LibraryDev.Application.Commands.Livros;

namespace LibraryDev.Application.Interfaces;

public interface ILivroService
{
    Task<int> CriarLivro(CriarLivroCommand command);
}
