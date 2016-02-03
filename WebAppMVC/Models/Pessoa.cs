using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O {0} é obrigatório.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "A quantidade de caracteres deve ser entre {2} e {1}")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "A quantidade de caracteres deve ser entre {2} e {1}")]
        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "A quantidade de caracteres deve ser entre {2} e {1}")]
        [DisplayName("Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "A quantidade de caracteres deve ser entre {2} e {1}")]
        [DataType(DataType.EmailAddress, ErrorMessage = "O {0} não está em um formato válido")]
        [DisplayName("E-Mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório.")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "A quantidade de caracteres deve ser entre {2} e {1}")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "O {0} não está em um formato válido")]
        [DisplayName("Fone")]
        public string Fone { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório.")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "A quantidade de caracteres deve ser entre {2} e {1}")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "O {0} não está em um formato válido.")]
        [DisplayName("Celular")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "A {0} é obrigatória.")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "A quantidade de caracteres deve ser entre {2} e {1}")]
        [DisplayName("Observação")]
        public string Observacao { get; set; }
    }
}
