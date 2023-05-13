using AutoMapper;
using CVBuilder.API.Data;
using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;
using CVBuilder.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Infostructure.Services.ExperincecService
{
    public class ExperincecService : IExperincecService
    {
        private readonly CVBuilderDbContext _db;
        private readonly IMapper _mapper;
        public ExperincecService(CVBuilderDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public List<ExperinsesViewModel> Get(string UserId)
        {
            var project = _db.ExperienceDbEntities.Where(x => !x.IsDelete && x.UserId == UserId);
            return _mapper.Map<List<ExperinsesViewModel>>(project);
        }

        public string Create(List<CreateExperinsesDto> dto, string UserId)
        {
            var project = _mapper.Map<List<ExperienceDbEntity>>(dto);
            foreach (var x in project)
            {
                x.UserId = UserId;
                _db.ExperienceDbEntities.Add(x);
                _db.SaveChanges();
            }
            return "Added successfully";
        }
        //  public List<ExperinsesViewModel> Create(CreateExperinsesDto dto)
        //{
        //  var exp = _mapper.Map<ExperienceDbEntity>(dto);
        //_db.ExperienceDbEntities.Add(exp);
        //_db.SaveChanges();

        //var ListExp = _db.ExperienceDbEntities.Where(x => !x.IsDelete && x.UserId == dto.UserId).ToList();
        // return _mapper.Map<List<ExperinsesViewModel>>(ListExp);
        //}
        public string Delete(string UserId)
        {
            var project = _db.ExperienceDbEntities.Where(x => !x.IsDelete && x.UserId == UserId).ToList();
            foreach (var x in project)
            {
                x.IsDelete = true;
                _db.ExperienceDbEntities.Update(x);
                _db.SaveChanges();
            }
            return "Deleted successfully";
        }
    }
}
