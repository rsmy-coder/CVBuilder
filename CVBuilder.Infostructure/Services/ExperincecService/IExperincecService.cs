using CVBuilder.Core.Dto;
using CVBuilder.Core.ViewModel;

namespace CVBuilder.Infostructure.Services.ExperincecService
{
    public interface IExperincecService
    {
        List<ExperinsesViewModel> Get(string UserId);
        string Create(List<CreateExperinsesDto> dto, string UserId);
        string Delete(string UserId);
    }
}
