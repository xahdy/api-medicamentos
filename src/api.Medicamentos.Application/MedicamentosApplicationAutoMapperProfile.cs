using AutoMapper;

namespace api.Medicamentos;

public class MedicamentosApplicationAutoMapperProfile : Profile
{
    public MedicamentosApplicationAutoMapperProfile()
    {
        CreateMap<Paciente, PacienteDto>();
        CreateMap<CreateUpdatePacienteDto, Paciente>();
        CreateMap<Medicamento, MedicamentoDto>();
        CreateMap<CreateUpdateMedicamentoDto, Medicamento>();
        CreateMap<Tratamento, TratamentoDto>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
