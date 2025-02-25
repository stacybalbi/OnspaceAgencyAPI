﻿using OnspaceAgency.Application.Company.Dto;
using OnspaceAgency.Application.Generic.Interfaces;
using OnspaceAgency.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Interfaces
{
    public interface ICompanyService : IBaseCrudService<Domain.Entities.Company>
    {
        Task Put(CompanyDto dto);
        Task Push(int companyId);

    }
}
