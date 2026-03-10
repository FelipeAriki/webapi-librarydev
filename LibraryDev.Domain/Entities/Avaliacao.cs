using System;

namespace LibraryDev.Domain.Entities
{
    public class Avaliacao
    {
        public int Id { get; set; }
        public int Nota { get; set; } // 1 a 5
        public string? Descricao { get; set; }
        public int IdUsuario { get; set; }
        public Usuario? Usuario { get; set; }
        public int IdLivro { get; set; }
        public Livro? Livro { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
