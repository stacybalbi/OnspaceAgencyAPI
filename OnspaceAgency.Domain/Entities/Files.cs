using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Domain.Entities
{
    public class Files : BaseEntity
    {
        public int companyId { get; set; }
        public string name { get; set; }
        public string img { get; set; }

        [ForeignKey("companyId")]
        public virtual Company Company { get; set; }

    }
}
