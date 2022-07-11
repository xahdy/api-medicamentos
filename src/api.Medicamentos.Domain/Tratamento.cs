using System;

using Volo.Abp.Domain.Entities.Auditing;

namespace api.Medicamentos
{
    public class Tratamento : AuditedAggregateRoot<Guid>
    {

        public Guid Paciente { get; set; }
        public Guid Medicamento { get; set; }
    }
}
