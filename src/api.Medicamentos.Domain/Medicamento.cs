using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace api.Medicamentos
{
    public class Medicamento : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
    }
}
