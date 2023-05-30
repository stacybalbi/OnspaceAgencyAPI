using AutoMapper;
using OnspaceAgency.Application.Company.Dto;
using OnspaceAgency.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Company.Mappings
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile() {

            CreateMap<Domain.Entities.Company, CompanyDto>();
            CreateMap<CompanyDto, Domain.Entities.Company>();
        }
    }
}
