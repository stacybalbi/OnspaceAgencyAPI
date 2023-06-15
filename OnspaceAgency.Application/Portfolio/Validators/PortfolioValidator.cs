using FluentValidation;
using OnspaceAgency.Application.Portfolio.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Portfolio.Validators
{
    public class PortfolioValidator : AbstractValidator<PortfolioDto>
    {
        public PortfolioValidator() {

            RuleFor(x => x.filesId).NotEmpty().WithMessage("FilesId is required");
            RuleFor(x => x.companyId).NotEmpty().WithMessage("CompanyId is required");
            RuleFor(x => x.name).NotEmpty().WithMessage("name is required");
            RuleFor(x => x.cover_page).NotEmpty().WithMessage("cover_page is required");
            RuleFor(x => x.description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x._company).NotEmpty().WithMessage("cover_page is required");
            RuleFor(x => x._files).NotEmpty().WithMessage("Description is required");
        }
    }
}
