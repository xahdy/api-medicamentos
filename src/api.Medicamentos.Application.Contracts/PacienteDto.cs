using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace api.Medicamentos
{
    public class PacienteDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
