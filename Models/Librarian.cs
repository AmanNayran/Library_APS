using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Librarian
    {
        [Display(Name = "Código do bibliotecário")]
        public int LibrarianId { get; set; }
        [Display(Name = "Nome")]
        public string? Name { get; set; }
        [Display(Name = "Endereço")]
        public string? Address { get; set; }
        [Display(Name = "Número de celular")]
        public string? Mobileno { get; set; }

        // Método para atualizar informações do bibliotecário
        public void UpdateInfo()
        {}

        // Método para emitir livros
        public void IssueBooks()
        {}

        // Método para gerenciar informações de membros
        public void MemberInfo()
        {}

        // Método para pesquisar livros
        public void SearchBook()
        {}

        // Método para registrar devolução de livros
        public void ReturnBook()
        {}

        // Relacionamento com Alert
        public virtual ICollection<Alert>? Alerts { get; set; }
    }
}