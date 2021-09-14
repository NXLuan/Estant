using Estant.Material.Model.EnumModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Estant.Material.Utilities
{
    public static class EnumExtension
    {
        public static bool HasError(this ResponseError responseError)
        {
            return responseError != ResponseError.NoError;
        }

        public static string ToDescription(this Enum enumValue)
        {
            return enumValue.GetType()
                       .GetMember(enumValue.ToString())
                       .First()
                       .GetCustomAttribute<DescriptionAttribute>()?
                       .Description ?? string.Empty;
        }
    }
}
