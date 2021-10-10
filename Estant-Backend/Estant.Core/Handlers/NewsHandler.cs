using Estant.Service.ApiService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Core.Handlers
{
    public class NewsHandler
    {
        private NewsApi newsApi;
        public NewsHandler()
        {
            newsApi = new NewsApi();
        }

        public object GetNewsToday()
        {
            var data = newsApi.GetEverything(DateTime.Today);
            return data;
        }
    }
}
