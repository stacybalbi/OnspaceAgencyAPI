using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnspaceAgency.Domain.Entities
{
    public class Company : BaseEntity
    {
        public string name { get; set; }
        public string description { get; set; }
    }
}
