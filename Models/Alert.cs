using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Alert
    {
        [Display(Name = "Código do alerta")]
        public int AlertId { get; set; }
        [Display(Name = "Data de emissão")]
        public DateTime Issuedate { get; set; }
        [Display(Name = "Nome do livro")]
        public string? Bookname { get; set; }
        [Display(Name = "Data de retorno")]
        public DateTime Returndate { get; set; }
        [Display(Name = "Multa")]
        public int Fine { get; set; }

        // Método para calcular multa
        public void CalculateFine()
        {}

        // Método para visualizar alertas
        public void ViewAlert()
        {}

        // Método para enviar alerta ao bibliotecário
        public void SendToLibrarian()
        {}

        // Método para excluir alerta por número
        public void DeleteAlertByNumber()
        {}

        // Relacionamento com Librarian
        public int LibrarianId { get; set; }

    }
}