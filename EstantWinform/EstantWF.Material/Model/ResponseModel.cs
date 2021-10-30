using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material.Model
{
    public class ResponseModel<T>
    {
        /// <summary>
        /// 0 => Success
        /// </summary>
        public int code { get; set; }

        public T data { get; set; }

        public string message { get; set; }

        public bool IsSuccess()
        {
            return code == 0;
        }
    }
}
