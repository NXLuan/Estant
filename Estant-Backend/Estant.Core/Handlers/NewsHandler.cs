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

        public object GetNewsTopToday()
        {
            var data = newsApi.GetTopHeadlines();
            return data;
        }

        public object GetNewsByKeyWord(string keyword)
        {
            object data = null;
            if (!string.IsNullOrEmpty(keyword))
            {
                data = newsApi.GetEverything(keyword);
            }
            return data;
        }
    }
}
