using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Domain.Entities
{
    public class Portfolio : BaseEntity
    {
        public int filesId { get; set; }

        public int companyId { get; set; }
        public string name { get; set; }
        public string cover_page { get; set; }

        public string description { get; set; }

        public string _company { get; set; }
        public string _files { get; set; }

        [ForeignKey("filesId")]

        public virtual Files Files { get; set; }

        [ForeignKey("companyId")]

        public virtual Company Company { get; set; }
    }


       
}
