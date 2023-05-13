using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Data.Models
{
    public class EducationDbEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; } = false;
        public string SchoolName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public double Degree { get; set; } = 0;
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public string Detailes { get; set; } = string.Empty;
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
