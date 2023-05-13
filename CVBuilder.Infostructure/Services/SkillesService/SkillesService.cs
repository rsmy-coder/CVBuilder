using AutoMapper;
using CVBuilder.API.Data;
using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;
using CVBuilder.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Infostructure.Services.SkillesService
{
    public class SkillesService : ISkillesService
    {
        private readonly CVBuilderDbContext _db;
        private readonly IMapper _mapper;
        public SkillesService(CVBuilderDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public List<SkillAwordViewModel> Get(string UserId)
        {
            var skill = _db.Skills.Where(x => !x.IsDelete && x.UserId == UserId);
            return _mapper.Map<List<SkillAwordViewModel>>(skill);
        }
        public string Create(List<CreateSkillAwordDto> dto , string UserId)
        {
            var project = _mapper.Map<List<Skills>>(dto);
            foreach(var x in project)
            {
                x.UserId = UserId;
                _db.Skills.Add(x);
                _db.SaveChanges();
            }
            return "Added successfully";
        }
        public string Delete(string UserId)
        {
            var project = _db.Skills.Where(x => !x.IsDelete && x.UserId == UserId).ToList();
            foreach (var x in project)
            {
                x.IsDelete = true;
                _db.Skills.Update(x);
                _db.SaveChanges();
            }
            return "Deleted successfully";
        }
    }
}
