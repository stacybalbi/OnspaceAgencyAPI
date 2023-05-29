using OnspaceAgency.Application.Files.Dto;
using OnspaceAgency.Application.Generic.Interfaces;
using OnspaceAgency.Application.Portfolio.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Interfaces
{
    public interface IPortfolioService : IBaseCrudService<Domain.Entities.Portfolio>
    {
        Task Put(PortfolioDto dto);
        Task Push(int portfolioId);
    }
}
