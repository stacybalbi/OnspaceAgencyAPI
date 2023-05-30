using OnspaceAgency.Application.Generic.Dto;
using System;
using System.Collections.Generic;
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
    }
}
