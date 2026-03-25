namespace LibraryDev.Application.ViewModels.Livros;

public class AvaliacaoResumidaViewModel
{
    public int Id { get; set; }
    public int Nota { get; set; }
    public string? Descricao { get; set; }
    public int IdUsuario { get; set; }
    public string NomeUsuario { get; set; } = string.Empty;
    public DateTime DataInicioLeitura { get; set; }
    public DateTime DataFimLeitura { get; set; }
    public DateTime DataCriacao { get; set; }
}
