using CVBuilder.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CVBuilder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BaseController : Controller
    {
      protected async Task<ApiResponseViewModel> GetResponse(object data)
        {
            var response = new ApiResponseViewModel(true, "Done", data);
            return response;
        }
    }
}
