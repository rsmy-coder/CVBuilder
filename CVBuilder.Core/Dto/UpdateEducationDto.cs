using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Core.Dto
{
    public class UpdateEducationDto
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string Location { get; set; }
        public double Degree { get; set; }
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public string Detailes { get; set; }
    }
}
