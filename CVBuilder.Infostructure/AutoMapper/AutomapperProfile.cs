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
        }
    }
}
