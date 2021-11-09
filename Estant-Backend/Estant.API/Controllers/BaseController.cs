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
        protected JsonResult ReturnData(object data, ResponseError responseError, string messageSuccess = "Thành công")
        {
            var model = new ResponseModel<object>();

            if (!responseError.HasError())
            {
                model.data = data;
                model.message = messageSuccess;
            }
            else model.SetResponseError(responseError);

            return Json(model);
        }

        protected JsonResult ReturnNoData(ResponseError responseError, string messageSuccess = "Thành công")
        {
           return ReturnData(null, responseError, messageSuccess);
        }

        protected string GetCurrentUID()
        {
            //var identity = HttpContext.User.Identity as ClaimsIdentity;
            //IList<Claim> claim = identity.Claims.ToList();
            return HttpContext.User.FindFirst(JwtRegisteredClaimNames.Jti)?.Value;
        }
    }
}
