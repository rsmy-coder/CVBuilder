using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Infostructure.Services.ProjectService
{
    public interface IProjectService
    {
        List<ProjectViewModel> Get(string UserId);
        string Create(List<CreateProjectDto> dto, string UserId);
        string Delete(string UserId);


    }
}
