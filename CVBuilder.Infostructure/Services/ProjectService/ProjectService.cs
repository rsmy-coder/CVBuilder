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

namespace CVBuilder.Infostructure.Services.ProjectService
{
    public class ProjectService : IProjectService
    {
        private readonly CVBuilderDbContext _db;
        private readonly IMapper _mapper;
        public ProjectService(CVBuilderDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public List<ProjectViewModel> Get(string UserId)
        {
            var project = _db.ProjectsDbEntities.Where(x => !x.IsDelete && x.UserId == UserId);
            return _mapper.Map<List<ProjectViewModel>>(project);
        }
        public string Create(List<CreateProjectDto> dto, string UserId)
        {
            var project = _mapper.Map<List<ProjectsDbEntity>>(dto);
            foreach (var x in project)
            {
                x.UserId = UserId;
                _db.ProjectsDbEntities.Add(x);
                _db.SaveChanges();
            }
            return "Added successfully";
        }
        public ProjectViewModel Update(UpdateProjectDto dto)
        {
            var project = _db.ProjectsDbEntities.SingleOrDefault(x => !x.IsDelete && x.Id == dto.Id);
            var projectMap = _mapper.Map<UpdateProjectDto, ProjectsDbEntity>(dto, project);
            _db.ProjectsDbEntities.Update(projectMap);
            _db.SaveChanges();
            return _mapper.Map<ProjectViewModel>(projectMap);
        }

        public string Delete(string UserId)
        {
            var project = _db.ProjectsDbEntities.Where(x => !x.IsDelete && x.UserId == UserId).ToList();
            foreach (var x in project)
            {
                x.IsDelete = true;
                _db.ProjectsDbEntities.Update(x);
                _db.SaveChanges();
            }
            return "Deleted successfully";
        }
    }
}
