using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Material.Utilities
{
    public static class FileHelper
    {
        public static async Task<string> ReadFileAsync(string filePath)
        {
            string json = null;
            try
            {
                json = await File.ReadAllTextAsync(filePath);
            }
            catch
            {
                json = null;
            }
            return json;
        }

        //protected async Task<bool> WriteData(T data)
        //{
        //    try
        //    {
        //        var JsonData = JsonConvert.SerializeObject(data);
        //        await File.WriteAllTextAsync(_jsonDataPath, JsonData);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}
