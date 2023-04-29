using CVBuilder.Core.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CVBuilder.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BaseController : Controller
    {
      protected ApiResponseViewModel<T> GetResponse<T>(T data)
        => new ApiResponseViewModel<T>(true, "Done", data);
    }
}
