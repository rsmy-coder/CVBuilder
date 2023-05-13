using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Data.Models
{
    public class ExperienceDbEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; } = false;
        public string  CompanyName { get; set; } = string.Empty;
        public string CompanyLocation { get; set; } = string.Empty;
        public string JopTitle { get; set; } = string.Empty;
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public string Detailes { get; set; } = string.Empty;
        public string? UserId { get; set; }
        public User? User { get; set; }


    }
}
