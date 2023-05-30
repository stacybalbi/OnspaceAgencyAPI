using AutoMapper;
using OnspaceAgency.Application.Portfolio.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Portfolio.Mappings
{
    public class PortfolioProfile : Profile
    {
        public PortfolioProfile() {

            CreateMap<Domain.Entities.Portfolio, PortfolioDto>();
            CreateMap<PortfolioDto, Domain.Entities.Portfolio>();
        }
    }
}
