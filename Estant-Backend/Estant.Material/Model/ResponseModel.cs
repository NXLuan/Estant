using Estant.Material.Model.EnumModel;
using System;
using System.Collections.Generic;
using System.Text;
using Estant.Material.Utilities;

namespace Estant.Material.Model
{
    public class ResponseModel<T>
    {
        /// <summary>
        /// 0 => Success
        /// </summary>
        public int code { get; set; }

        public T data { get; set; }

        public string message { get; set; }

        public void SetResponseError(ResponseError responseError)
        {
            if (this != null)
            {
                if (responseError.HasError())
                {
                    this.code = (int)responseError;
                    this.message = responseError.ToDescription();
                }
            }
        }
    }
}
