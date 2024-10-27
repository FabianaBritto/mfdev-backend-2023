using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mfdev_backend_2023.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar a Placa!")]
        public string Placa { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar o ano de fabricação!")]
        [Display(Name = "Ano de fabricação")]
        public string AnoFabricacao { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar o ano do modelo!")]
        [Display(Name = "Ano de Modelo")]
        public string AnoModelo { get; set; }
    }
}

