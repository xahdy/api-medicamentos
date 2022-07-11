using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace api.Medicamentos
{
    public interface IPacienteAppService :
        ICrudAppService< 
            PacienteDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdatePacienteDto> 
    {
    }
}