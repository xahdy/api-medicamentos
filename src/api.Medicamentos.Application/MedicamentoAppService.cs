using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace api.Medicamentos
{
    public class MedicamentoAppService :
        CrudAppService<
            Medicamento, 
            MedicamentoDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateMedicamentoDto>, 
        IMedicamentoAppService 
    {
        public MedicamentoAppService(IRepository<Medicamento, Guid> repository)
            : base(repository)
        {

        }
    }
}