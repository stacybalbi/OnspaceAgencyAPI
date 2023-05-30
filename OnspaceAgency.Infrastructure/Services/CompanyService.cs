using AutoMapper;
using OnspaceAgency.Application.Company.Dto;
using OnspaceAgency.Application.Interfaces;
using OnspaceAgency.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Infrastructure.Services
{
    public class CompanyService : BaseCrudService<Domain.Entities.Company>, ICompanyService
    {
        private readonly IMapper _mapper;
        public IOnspaceAgencyDbContext _dbContext;
        public CompanyService(IOnspaceAgencyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }


        public Task Push(int studentId)
        {
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task Put(CompanyDto dto)
        {
            await _dbSet.AddAsync(_mapper.Map<Domain.Entities.Company>(dto));
            _dbContext.SaveChanges();
        }

    }
}
