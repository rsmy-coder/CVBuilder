using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Data.Models
{
    public class ProjectsDbEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; } = false;
        public string ProjectName { get; set; } = string.Empty;
        public string BriefDescription { get; set; } = string.Empty;
        public string MoreDetailes { get; set; } = string.Empty;
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
