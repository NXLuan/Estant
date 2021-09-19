using Estant.Material.Model;
using Estant.Material.Model.EnumModel;
using Estant.Material.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estant.API.Controllers
{
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
    }
}
