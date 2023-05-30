﻿using AutoMapper;
using OnspaceAgency.Application.Portfolio.Dto;
using OnspaceAgency.Application.Interfaces;
using OnspaceAgency.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Infrastructure.Services
{
    public class PortfolioService : BaseCrudService<Domain.Entities.Portfolio>, IPortfolioService
    {
        private readonly IMapper _mapper;
        public IOnspaceAgencyDbContext _dbContext;
        public PortfolioService(IOnspaceAgencyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }


        public Task Push(int studentId)
        {
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task Put(PortfolioDto dto)
        {
            await _dbSet.AddAsync(_mapper.Map<Domain.Entities.Portfolio>(dto));
            _dbContext.SaveChanges();
        }

    }
}
