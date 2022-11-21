using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEmpresa.Models.ViewModel
{
    public class EmpregadoViewModel
    {
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo é obrigatorio")]
        public string Sobrenome { get; set; }

        [Column("CPF ou CNPJ")]
        [Required(ErrorMessage = "O campo é obrigatorio")]
        public string CPF_CNPJ { get; set; }

        [Required(ErrorMessage = "O campo é obrigatorio")]
        public string Telefone { get; set; }
    }
}
