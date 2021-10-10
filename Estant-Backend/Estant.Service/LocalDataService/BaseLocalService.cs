using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Service.LocalDataService
{
    public class BaseLocalService
    {
        private string _jsonDataPath;

        protected BaseLocalService(string JsonFileName)
        {
            string RootPath = @"../Estant.Service/LocalDataService/JsonData/";
            _jsonDataPath = RootPath + JsonFileName;
        }

        protected async Task<string> ReadData()
        {
            string json = null;
            try
            {
                json = await File.ReadAllTextAsync(_jsonDataPath);
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
