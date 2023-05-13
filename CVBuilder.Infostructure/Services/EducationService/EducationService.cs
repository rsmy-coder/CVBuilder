using AutoMapper;
using CVBuilder.API.Data;
using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;
using CVBuilder.Data.Models;
using CVBuilder.Infostructure.Services.Files;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Infostructure.Services.EducationService
{
    public class EducationService : IEducationService
    {
        private readonly CVBuilderDbContext _db;
        private readonly IMapper _mapper;
        public EducationService(CVBuilderDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public List<EducationViewModel> Get(string UserId)
        {
            var project = _db.EducationDbEntities.Where(x => !x.IsDelete && x.UserId == UserId);
            return _mapper.Map<List<EducationViewModel>>(project);
        }
        public string Create(List<CreateEducationDto> dto, string UserId)
        {
            var project = _mapper.Map<List<EducationDbEntity>>(dto);
            foreach (var x in project)
            {
                x.UserId = UserId;
                _db.EducationDbEntities.Add(x);
                _db.SaveChanges();
            }
            return "Added successfully";
        }
        public EducationViewModel Update(UpdateEducationDto dto)
        {
            var education = _db.EducationDbEntities.SingleOrDefault(x => !x.IsDelete && x.Id == dto.Id);
            var educationMap = _mapper.Map<UpdateEducationDto , EducationDbEntity>(dto,education);
            _db.EducationDbEntities.Update(educationMap);
            _db.SaveChanges();
            return _mapper.Map<EducationViewModel>(educationMap);
        }

        public string Delete(string UserId)
        {
            var project = _db.EducationDbEntities.Where(x => !x.IsDelete && x.UserId == UserId).ToList();
            foreach (var x in project)
            {
                x.IsDelete = true;
                _db.EducationDbEntities.Update(x);
                _db.SaveChanges();
            }
            return "Deleted successfully";
        }
    }
}
