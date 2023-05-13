using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Core.Dto
{
    public class UpdateProjectDto
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string BriefDescription { get; set; }
        public string MoreDetailes { get; set; }
    }
}
