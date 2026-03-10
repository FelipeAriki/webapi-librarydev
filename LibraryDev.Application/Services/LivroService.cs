using LibraryDev.Application.Commands.Livros;
using LibraryDev.Application.Interfaces;
using LibraryDev.Domain.Interfaces.Livros;

namespace LibraryDev.Application.Services;

public class LivroService : ILivroService
{
    private readonly ILivroCommandRepository _livroRepository;

    public LivroService(ILivroCommandRepository livroRepository)
    {
        _livroRepository = livroRepository;
    }

    public Task<int> CriarLivro(CriarLivroCommand command)
    {
        var idLivroCriado = _livroRepository.CriarLivroAsync(CriarLivroCommand.ToEntity(command));
        return idLivroCriado;
    }
}
