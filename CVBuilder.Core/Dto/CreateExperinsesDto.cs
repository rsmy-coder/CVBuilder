using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Core.Dto
{
    public class CreateExperinsesDto
    {
        public string CompanyName { get; set; } 
        public string CompanyLocation { get; set; }
        public string JopTitle { get; set; } 
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public string Detailes { get; set; }
       // public string? UserId { get; set; }
    }
}
