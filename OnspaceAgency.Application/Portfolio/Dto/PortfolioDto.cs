using OnspaceAgency.Application.Company.Dto;
using OnspaceAgency.Application.Files.Dto;
using OnspaceAgency.Application.Generic.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Portfolio.Dto
{
    public class PortfolioDto : BaseDto
    {
        public int filesId { get; set; }

        public int companyId { get; set; }
        public string name { get; set; }
        public string cover_page { get; set; }

        public string description { get; set; }
        public string _company { get; set; }
        public string _files { get; set; }
    }
}
