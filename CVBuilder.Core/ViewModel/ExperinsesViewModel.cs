using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Core.ViewModel
{
    public class ExperinsesViewModel 
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }
        public string JopTitle { get; set; }
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public string Detailes { get; set; }
    }
}
