using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage= "Erro: deu erro.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Erro: deu erro.")]
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
