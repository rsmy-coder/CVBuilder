using AutoMapper;
using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;
using CVBuilder.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Infostructure.AutoMapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<CreateUserDto,User>().ForMember(x => x.ImgUrl, x => x.Ignore());
            CreateMap<UpdateUserDto,User>().ForMember(x => x.ImgUrl, x => x.Ignore());
            CreateMap<User,UserViewModel>();
            CreateMap<User , ResponseUserDto>();

            CreateMap<EducationDbEntity, EducationViewModel>();
            CreateMap<CreateEducationDto, EducationDbEntity>();
            CreateMap<UpdateEducationDto, EducationDbEntity>();

            CreateMap<ProjectsDbEntity,ProjectViewModel>();
            CreateMap<CreateProjectDto, ProjectsDbEntity>();
            CreateMap<UpdateProjectDto, ProjectsDbEntity>();

            CreateMap<ExperienceDbEntity, ExperinsesViewModel>();
            CreateMap<CreateExperinsesDto, ExperienceDbEntity>();

            CreateMap<Skills, SkillAwordViewModel>();
            CreateMap<CreateSkillAwordDto, Skills>();

            CreateMap<Award, SkillAwordViewModel>();
            CreateMap<CreateSkillAwordDto, Award>();
        }
    }
}
