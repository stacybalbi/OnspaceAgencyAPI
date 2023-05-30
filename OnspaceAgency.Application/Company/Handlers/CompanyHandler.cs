using AutoMapper;
using OnspaceAgency.Application.Company.Dto;
using OnspaceAgency.Application.Generic.Handlers;
using OnspaceAgency.Application.Generic.Interfaces;
using OnspaceAgency.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Company.Handlers
{
    public interface ICompanyHandler : IBaseCrudHandler<CompanyDto, Domain.Entities.Company>
    {
        new Task<CompanyDto> GetById(int id);
        new Task<CompanyDto> Update(CompanyDto dto);
        new Task<CompanyDto> Update(int id, CompanyDto dto);
        new Task<CompanyDto> Create(CompanyDto dto);
        new Task<List<CompanyDto>> Get(int top);
    }
    public class CompanyHandler : BaseCrudHandler<CompanyDto, Domain.Entities.Company>, ICompanyHandler
    {
        private readonly ICompanyService _crudService;
        private readonly IMapper _mapper;

        public CompanyHandler(ICompanyService crudService, IMapper mapper) : base(crudService, mapper)
        {
            _crudService = crudService;
            _mapper = mapper;
        }

        public new async Task<CompanyDto> GetById(int id)
        {
            var Company = await base.GetById(id);

            if (Company == null) throw new Exception("Company not found");

            return Company;

        }

        public new async Task<CompanyDto> Update(CompanyDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<CompanyDto> Update(int id, CompanyDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<CompanyDto> Create(CompanyDto dto)
        {

            return await base.Create(dto);

        }

        public async Task<List<CompanyDto>> Get(int top)
        {
            return await base.Get(top);
        }

    }
}
