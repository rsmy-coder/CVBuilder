using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Data.Models
{
    public class BaseIntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime UpdatedBy { get; set; }
        public DateTime CreatedBy { get; set; }
        public bool IsDelete { get; set; }

    }
}
