﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Data.Models
{
    public class User :IdentityUser
    {
        public string  FullName { get; set; }
        public string CurrentPosition { get; set; }
        public string UserCity { get; set; }
        public string UserStreet { get; set; }
        public string? ImgUrl { get; set; }
        public string Password { get; set; }
        public bool IsDelete { get; set; }
        public List<ProjectsDbEntity>? Projects { get; set; }
        public List<ExperienceDbEntity>? Experiences { get; set; }
        public List<Award>? Awards { get; set; }
        public List<Skills>? Skills { get; set; }
        public List<EducationDbEntity>? EducationDbEntities { get; set; }
    }
}
