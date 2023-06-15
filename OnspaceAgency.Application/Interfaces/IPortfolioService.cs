using OnspaceAgency.Application.Company.Dto;
using OnspaceAgency.Application.Files.Dto;
using OnspaceAgency.Application.Generic.Interfaces;
using OnspaceAgency.Application.Portfolio.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Interfaces
{
    public interface IPortfolioService : IBaseCrudService<Domain.Entities.Portfolio>
    {
        //Task<PortfolioDto> ExecuteAsync(int id);

        //static Expression<Func<Domain.Entities.Portfolio, PortfolioDto>> GetPortfolioProjection;
        
        Task Put(PortfolioDto dto);
        Task Push(int portfolioId);
    }
}
