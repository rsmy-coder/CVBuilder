using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;
using CVBuilder.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Infostructure.Services.Users
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetAll(string serachKey);
        Task<ResponseUserDto> Create(CreateUserDto dto);
        Task<string> Update(UpdateUserDto dto);
        Task<string> Delete(string id);
        Task<ResponseUserDto> Get(string id);
    }
}
