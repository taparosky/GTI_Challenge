using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O CPF deve ser informado", AllowEmptyStrings = false)]
        [Range(0, long.MaxValue, ErrorMessage = "Valor não aceito como CPF")]
        [MaxLength(11,ErrorMessage = "Limite de caracteres excedido")]
        [MinLength(11, ErrorMessage = "Limite de caracteres não atendido")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O nome deve ser informado", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "Valor não aceito como RG")]
        public string? RG { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Expedição")]
        public DateTime? DataExpedicao { get; set; }

        [Display(Name = "Órgão de Expedição")]
        public string? OrgaoExpedicao { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use apenas letras")]
        [MaxLength(2, ErrorMessage = "Limite de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Limite de caracteres não atendido")]
        [Display(Name = "UF Expedição")]
        public string? UF { get; set; }

        [Required(ErrorMessage = "A data de nascimento deve ser informada", AllowEmptyStrings = false)]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use apenas letras")]
        [Required(ErrorMessage = "O sexo deve ser informado", AllowEmptyStrings = false)]
        public string Sexo { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use apenas letras")]
        [Required(ErrorMessage = "O estado civil deve ser informado", AllowEmptyStrings = false)]
        [Display(Name = "Estado Civil")]
        public string EstadoCivil { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "Valor não aceito como CEP")]
        [MaxLength(8, ErrorMessage = "Limite de caracteres excedido")]
        [MinLength(8, ErrorMessage = "Limite de caracteres não atendido")]
        [Required(ErrorMessage = "O CEP deve ser informado", AllowEmptyStrings = false)]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O logradouro deve ser informado", AllowEmptyStrings = false)]
        public string Logradouro { get; set; }

        [Range(0, long.MaxValue, ErrorMessage = "Valor não aceito como número")]
        [Required(ErrorMessage = "O número deve ser informado", AllowEmptyStrings = false)]
        public int Numero { get; set; }
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "O bairro deve ser informado", AllowEmptyStrings = false)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "A cidade deve ser informada", AllowEmptyStrings = false)]
        public string Cidade { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use apenas letras")]
        [Required(ErrorMessage = "A UF deve ser informada", AllowEmptyStrings = false)]
        [MaxLength(2, ErrorMessage = "Limite de caracteres excedido")]
        [MinLength(2, ErrorMessage = "Limite de caracteres não atendido")]
        [Display(Name = "UF Endereço")]
        public string UfEndereco { get; set; }
    }
}
