using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVBuilder.Infostructure.Services.AwardService
{
    public interface IAwardService
    {
        string Create(List<CreateSkillAwordDto> dto,string UserId);
        string Delete(string id);
        List<SkillAwordViewModel> Get(string UserId);
    }
}
