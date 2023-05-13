using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Infostructure.Services.SkillesService
{
    public interface ISkillesService
    {
        List<SkillAwordViewModel> Get(string UserId);
        string Create(List<CreateSkillAwordDto> dto, string UserId);
        string Delete(string UserId);

    }
}
