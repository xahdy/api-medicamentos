using System.ComponentModel.DataAnnotations;

namespace api.Medicamentos
{
    public class CreateUpdateMedicamentoDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
    }
}
