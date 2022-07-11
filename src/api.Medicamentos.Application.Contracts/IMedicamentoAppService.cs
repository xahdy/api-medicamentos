using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace api.Medicamentos
{
    public interface IMedicamentoAppService :
        ICrudAppService< 
            MedicamentoDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateMedicamentoDto> 
    {
    }
}