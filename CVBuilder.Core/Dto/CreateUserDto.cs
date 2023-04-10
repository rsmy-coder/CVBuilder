using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Core.Dto
{
    public class CreateUserDto
    {
        public string  FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string CurrentPosition { get; set; }
        public string UserCity { get; set; }
        public string UserStreet { get; set; }
        public string Password { get; set; }
        public IFormFile? ImgUrl { get; set; }
    }
}
