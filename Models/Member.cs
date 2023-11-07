using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Member
    {
        [Display(Name = "Código do membro")]
        public int MemberId { get; set; }
        [Display(Name = "Nome")]
        public string? Mname { get; set; }
        [Display(Name = "Endereço")]
        public string? Maddress { get; set; }
        [Display(Name = "Número de celular")]
        public int Mno { get; set; }

        // Método para solicitar livros
        public void RequestForBook()
        {}

        // Método para devolver livros
        public void ReturnBook()
        {}

        // Relacionamento com Book
        public virtual ICollection<Books>? Books { get; set; }
    }
}