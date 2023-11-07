using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Books
    {
        [Display(Name = "Código do livro")]
        public int BooksId { get; set; }
        [Display(Name = "Nome do autor")]
        public string? Authorname { get; set; }
        [Display(Name = "Titulo do livro")]
        public string? Title { get; set; }
        [Display(Name = "Quantidade do livro")]
        public int Noofbooks { get; set; }

        // Método para remover do catálogo
        public void RemoveFromCatalog()
        {}

        // Método para adicionar ao catálogo
        public void AddToCatalog()
        {}

    }
}

