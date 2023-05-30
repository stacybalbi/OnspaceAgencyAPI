using AutoMapper;
using OnspaceAgency.Application.Portfolio.Dto;
using OnspaceAgency.Application.Generic.Handlers;
using OnspaceAgency.Application.Generic.Interfaces;
using OnspaceAgency.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Portfolio.Handlers
{
    public interface IPortfolioHandler : IBaseCrudHandler<PortfolioDto, Domain.Entities.Portfolio>
    {
        new Task<PortfolioDto> GetById(int id);
        new Task<PortfolioDto> Update(PortfolioDto dto);
        new Task<PortfolioDto> Update(int id, PortfolioDto dto);
        new Task<PortfolioDto> Create(PortfolioDto dto);
        new Task<List<PortfolioDto>> Get(int top);
    }
    public class PortfolioHandler : BaseCrudHandler<PortfolioDto, Domain.Entities.Portfolio>, IPortfolioHandler
    {
        private readonly IPortfolioService _crudService;
        private readonly IMapper _mapper;

        public PortfolioHandler(IPortfolioService crudService, IMapper mapper) : base(crudService, mapper)
        {
            _crudService = crudService;
            _mapper = mapper;
        }

        public new async Task<PortfolioDto> GetById(int id)
        {
            var Portfolio = await base.GetById(id);

            if (Portfolio == null) throw new Exception("Portfolio not found");

            return Portfolio;

        }

        public new async Task<PortfolioDto> Update(PortfolioDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<PortfolioDto> Update(int id, PortfolioDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<PortfolioDto> Create(PortfolioDto dto)
        {

            return await base.Create(dto);

        }

        public async Task<List<PortfolioDto>> Get(int top)
        {
            return await base.Get(top);
        }

    }
}
