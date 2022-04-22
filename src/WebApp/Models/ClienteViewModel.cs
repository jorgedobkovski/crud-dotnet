using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ClienteViewModel
    {
        public Guid Id { get; set; }
        [Required (ErrorMessage= "Erro: deu erro.")]
        public string Nome { get; set; }
        public string CPF { get; set; }
        [Required(ErrorMessage = "Erro: deu erro.")]
        public string RG { get; set; }
        [Required(ErrorMessage = "Erro: deu erro.")]
        public DateTime DataNascimento { get; set; }

    }
}
