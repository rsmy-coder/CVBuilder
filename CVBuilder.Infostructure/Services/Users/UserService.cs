using AutoMapper;
using CVBuilder.API.Data;
using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;
using CVBuilder.Data.Models;
using CVBuilder.Infostructure.Services.Files;
using Microsoft.AspNetCore.Identity;

namespace CVBuilder.Infostructure.Services.Users
{
    public class UserService : IUserService
    {
       
            private readonly CVBuilderDbContext _db;
            private readonly IMapper _mapper;
            private readonly UserManager<User> _userManager;
            private readonly IFileService _fileService;

        public UserService()
        {}
        public UserService(IFileService fileService,CVBuilderDbContext db, IMapper mapper, UserManager<User> userManager)
        {
            _db = db;
            _mapper = mapper;
            _userManager = userManager;
            _fileService = fileService;
        }

        public async Task<List<UserViewModel>> GetAll(string serachKey)
        {
            var users = _db.Users.Where(x =>!x.IsDelete && x.FullName.Contains(serachKey) || x.PhoneNumber.Contains(serachKey) || string.IsNullOrWhiteSpace(serachKey)).ToList();
            return _mapper.Map<List<UserViewModel>>(users);
        }

        public async Task<ResponseUserDto> Create(CreateUserDto dto)
        {
            var user = _mapper.Map<User>(dto);
            user.UserName = dto.Email;
            if (dto.ImgUrl != null)
            {
                user.ImgUrl = await _fileService.SaveFile(dto.ImgUrl, "Images");

            }

             await _userManager.CreateAsync(user, dto.Password);

            return _mapper.Map<ResponseUserDto>(user);
          
        }

        public async Task<string> Update(UpdateUserDto dto)
        {
            var user = _db.Users.SingleOrDefault(x => x.Id == dto.Id);
            if (user == null)
            {
                //throw 
            }
            var updatedUser = _mapper.Map(dto, user);
            _db.Users.Update(updatedUser);
            _db.SaveChanges();
            return user.Id;
        }

        public async Task<string> Delete(string Id)
        {
            var user = _db.Users.SingleOrDefault(x => x.Id == Id);
            if (user == null)
            {
                //throw     
            }
            user.IsDelete = true;
            _db.Users.Update(user);
            _db.SaveChanges();
            return user.Id;
        }

        public async Task<UserViewModel> Get(string id)
        {
            var user = _db.Users.SingleOrDefault(x => x.Id == id && !x.IsDelete);
            if (user == null)
            {
                //throw 
            }
            return _mapper.Map<UserViewModel>(user);
        }
    }
        
}
