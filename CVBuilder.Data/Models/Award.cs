using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Data.Models
{
    public class Award
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public string? Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? UserId { get; set; }
        public User? User { get; set; }
    }
}
