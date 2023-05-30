using OnspaceAgency.Application.Generic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Application.Files.Dto
{
    public class FilesDto : BaseDto
    {
        public int companyId { get; set; }
        public string name { get; set; }
        public string img { get; set; }
    }
}
