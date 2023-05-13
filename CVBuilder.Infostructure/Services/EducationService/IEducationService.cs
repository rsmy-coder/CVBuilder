using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Infostructure.Services.EducationService
{
    public interface IEducationService
    {
        List<EducationViewModel> Get(string UserId);
        string Create(List<CreateEducationDto> dto, string UserId);
        string Delete(string UserId);

    }
}
