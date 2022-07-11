using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace api.Medicamentos
{
    public class TratamentoDto : AuditedEntityDto<Guid>
    {
        public Guid Paciente { get; set; }
        public String PacienteNome { get; set; }
        public Guid Medicamento { get; set; }
        public String MedicamentoNome { get; set; }
    }
}
