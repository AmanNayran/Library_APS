using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Faculty : Member
    {
        [Display(Name = "Faculdade")]
        public string? Facultycoll { get; set; }
        [Display(Name = "Curso")]
        public string? Facultycourse { get; set; }

        // Método para verificar saída de livros
        public void CheckoutBook()
        {}

    }
}