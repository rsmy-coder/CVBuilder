using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;
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
        Task<string> Create(CreateUserDto dto);
        Task<string> Update(UpdateUserDto dto);
        Task<string> Delete(string id);
        Task<UserViewModel> Get(string id);
    }
}
