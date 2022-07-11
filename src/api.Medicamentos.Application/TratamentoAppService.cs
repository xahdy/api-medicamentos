using Abp.Runtime.Validation;
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

    public class TratamentoAppService : ApplicationService
    {

        private readonly IRepository<Tratamento, Guid> TratamentoRepository;
        public TratamentoAppService(IRepository<Tratamento, Guid> tratamentoRepository, IRepository<Paciente, Guid> pacienteRepository, IRepository<Medicamento, Guid> medicamentoRepository)
        {
            TratamentoRepository = tratamentoRepository;
            PacienteRepository = pacienteRepository;
            MedicamentoRepository = medicamentoRepository;
        }
        public IRepository<Paciente, Guid> PacienteRepository { get; }
        public IRepository<Medicamento, Guid> MedicamentoRepository { get; }

        [HttpGet("api/app/tratamento/paciente/")]
        public async Task<int> CountPacienteAsync(Guid idPaciente)
        {
            return await TratamentoRepository.CountAsync(p => p.Paciente.ToString().Contains(idPaciente.ToString()));
        }

        [HttpGet("api/app/tratamento/medicamento/")]
        public async Task<int> CountMedicamentoAsync(Guid idMedicamento)
        {
            return await TratamentoRepository.CountAsync(p => p.Medicamento.ToString().Contains(idMedicamento.ToString()));
        }

        public async Task<TratamentoDto> CreateAsync(Guid idPaciente, Guid idMedicamento)
        {
            var paciente = await PacienteRepository.GetAsync(p => p.Id.ToString().Contains(idPaciente.ToString()));
            var medicamento = await MedicamentoRepository.GetAsync(p => p.Id.ToString().Contains(idMedicamento.ToString()));
            var item = await TratamentoRepository.InsertAsync(
                  new Tratamento { Paciente = paciente.Id, Medicamento = medicamento.Id }
              );

            return new TratamentoDto
            {
                Id = item.Id,
                Paciente = item.Paciente,
                PacienteNome = paciente.Name,
                Medicamento = item.Medicamento,
                MedicamentoNome = medicamento.Name

            };

        }

        public async Task<List<TratamentoDto>> GetListAsync()
        {
            var items = await TratamentoRepository.GetListAsync();

            return items
                .Select(item =>
                {
                    var paciente = PacienteRepository.GetAsync(item.Paciente).Result;
                    var medicamento = MedicamentoRepository.GetAsync(item.Medicamento).Result;
                    return new TratamentoDto
                    {
                        Id = item.Id,
                        Paciente = item.Paciente,
                        PacienteNome = paciente.Name,
                        Medicamento = item.Medicamento,
                        MedicamentoNome = medicamento.Name,
                    };
                }).ToList();
        }
    }
}