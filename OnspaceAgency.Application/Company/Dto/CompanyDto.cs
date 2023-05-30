using OnspaceAgency.Application.Generic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Company.Dto
{
    public class CompanyDto : BaseDto
    {
        public string name { get; set; }
        public string description { get; set; }
    }
}
