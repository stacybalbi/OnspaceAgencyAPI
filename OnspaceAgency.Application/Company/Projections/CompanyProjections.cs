
using OnspaceAgency.Application.Company.Dto;
using OnspaceAgency.Application.Company.Dto;
using System.Linq.Expressions;

namespace OnspaceAgency.Application.Company.Projections;

public class CompanyProjection
{
    public Expression<Func<Domain.Entities.Company, CompanyDto>> GetCompanyProjection()
    {
        return x => new CompanyDto
        {
            name = x.name,
            description = x.description
        };
    }

}