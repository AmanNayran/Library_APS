using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Catalog
    {
        [Display(Name = "Código do livro")]
        public int CatalogId { get; set; }
        [Display(Name = "Nome do autor")]
        public string? Authorname { get; set; }
        [Display(Name = "Quantidade de copias")]
        public int Noofcopies { get; set; }

        // Método para atualizar informações no catálogo
        public void UpdateInfo()
        {}

        // Método para pesquisar livros no catálogo
        public void Searching()
        {}

        // Relacionamento com Books
        public virtual ICollection<Books>? Books { get; set; }

    }
}