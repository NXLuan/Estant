using Estant.Material.Model;
using Estant.Material.Model.EnumModel;
using Estant.Material.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Estant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {
        protected JsonResult ReturnData<T>(T data, ResponseError responseError)
        {
            var model = new ResponseModel<T>();

            if (!responseError.HasError())
                model.data = data;
            else model.SetResponseError(responseError);

            return Json(model);
        }

        protected JsonResult ReturnNoData(ResponseError responseError)
        {
           return ReturnData<object>(null, responseError);
        }

        protected string GetCurrentUID()
        {
            //var identity = HttpContext.User.Identity as ClaimsIdentity;
            //IList<Claim> claim = identity.Claims.ToList();

            return HttpContext.User.FindFirst(JwtRegisteredClaimNames.Jti)?.Value;
        }
    }
}
