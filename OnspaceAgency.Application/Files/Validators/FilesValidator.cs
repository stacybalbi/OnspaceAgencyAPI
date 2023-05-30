using FluentValidation;
using OnspaceAgency.Application.Files.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Files.Validators
{
    public class FilesValidator : AbstractValidator<FilesDto>
    {
        public FilesValidator() {

            RuleFor(x => x.companyId).NotEmpty().WithMessage("CompanyId is required");
            RuleFor(x => x.name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.img).NotEmpty().WithMessage("Img is required");
        }
    }
}
