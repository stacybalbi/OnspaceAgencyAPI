using FluentValidation;
using OnspaceAgency.Application.Company.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Company.Validators
{
    public class CompanyValidator : AbstractValidator<CompanyDto>
    {
        public CompanyValidator() {

            RuleFor(x => x.name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.description).NotEmpty().WithMessage("Description is required");
        }
    }
}
