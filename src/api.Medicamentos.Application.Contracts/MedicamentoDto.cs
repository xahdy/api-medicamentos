using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace api.Medicamentos
{
    public class MedicamentoDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
