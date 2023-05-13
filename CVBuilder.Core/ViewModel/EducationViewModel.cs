﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Core.ViewModel
{
    public class EducationViewModel
    {
        public string SchoolName { get; set; }
        public string Location { get; set; }
        public double Degree { get; set; }
        public DateTime StartPeriod { get; set; }
        public DateTime EndPeriod { get; set; }
        public string Detailes { get; set; }
    }
}
