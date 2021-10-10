using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estant.Service.ApiService
{
    public class NewsApi
    {
        private string ApiKey = "695079f4004c411d80787a7e933c59da";
        private NewsApiClient newsApiClient;
        public NewsApi()
        {
            newsApiClient = new NewsApiClient(ApiKey);
        }

        public object GetEverything(DateTime fromDate)
        {
            object result = null;
            var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                Q = "Airline",
                Language = Languages.EN,
                From = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day)
            });

            if (articlesResponse.Status == Statuses.Ok)
            {
                result = articlesResponse.Articles;
            }

            return result;
        }

        public List<Article> GetTopHeadlines()
        {
            var result = new List<Article>();
            var articlesResponse = newsApiClient.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = Languages.EN,
            });

            if (articlesResponse.Status == Statuses.Ok)
            {
                result = articlesResponse.Articles;
            }

            return result;
        }
    }
}
