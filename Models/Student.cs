using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Student : Member
    {
        [Display(Name = "Escola")]
        public string? Studentcoll { get; set; }
        [Display(Name = "Série")]
        public string? Studentclass { get; set; }

        // Método para verificar saída de livros
        public void CheckoutBook()
        {}

    }
}