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

namespace CVBuilder.Infostructure.Services.AwardService
{
    public class AwardService : IAwardService
    {

        private readonly CVBuilderDbContext _db;
        private readonly IMapper _mapper;
        public AwardService(CVBuilderDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<SkillAwordViewModel> Get(string UserId)
        {
            var award = _db.Awards.Where(x => !x.IsDelete && x.UserId == UserId).ToList();
            return _mapper.Map<List<SkillAwordViewModel>>(award);
        }
        public string Create(List<CreateSkillAwordDto> dto , string UserId)
        {
            var project = _mapper.Map<List<Award>>(dto);
            foreach (var y in project)
            {
                y.UserId = UserId;
                _db.Awards.Add(y);
                _db.SaveChanges();
            }
            return "Sucesses";
        } 
        public string Delete(string id)
        {
            var project = _db.Awards.Where(x => !x.IsDelete && x.UserId == id).ToList();
            foreach(var x in project)
            {
                x.IsDelete = true;
                _db.Awards.Update(x);
                _db.SaveChanges();
            }

            
            return "The Delete Is Sucesess";
        }
    }
}
