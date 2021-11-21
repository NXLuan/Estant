using EstantWF.Material.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantWF.Material
{
    public static class MockData
    {
        public static List<Topic> GetAllTopic()
        {
            return new List<Topic>(){
                new Topic()
                {
                    title = "Airline",
                    imageUrl = "https://tienganhmoingay.com/static/Vocabulary/images/topic_images/airlines.png"
                },
                new Topic()
                {
                    title = "Banking",
                    imageUrl = "https://tienganhmoingay.com/static/Vocabulary/images/topic_images/banking.png"
                },
                new Topic()
                {
                  title = "Computers",
                  imageUrl = "https://tienganhmoingay.com/static/Vocabulary/images/topic_images/computers.png"
                },
                new Topic()
                {
                  title = "Financial",
                  imageUrl = "https://tienganhmoingay.com/static/Vocabulary/images/topic_images/financial_statements.png"
                },
                new Topic()
                {
                  title = "Interview",
                  imageUrl = "https://tienganhmoingay.com/static/Vocabulary/images/topic_images/applying.png"
                },
                new Topic()
                {
                  title = "Marketing",
                  imageUrl = "https://tienganhmoingay.com/static/Vocabulary/images/topic_images/marketing.png"
                },
            };
        }

        public static List<News> GetNewsToday()
        {
            return new List<News>(){
                new News()
                {
                    title = "College football Week 12 winners and losers: Oklahoma, Clemson, Florida State orchestrate key wins - Yahoo Sports",
                    url = "https://www.ndtv.com/world-news/new-video-of-missing-chinese-tennis-star-peng-shuai-surfaces-amid-global-outcry-2618888",
                    urlToImage = "https://c.ndtvimg.com/2021-11/tdiupbhg_peng-shuaivideopictwitter_625x300_21_November_21.jpg",
                    publishedAt = DateTime.Today,
                    source = new News.Source(){name = "NDTV News"}
                },
                new News()
                {
                    title = "Lunar eclipse November 2021 updates – What time was the full Beaver Moon and where was it visible?... - The Sun",
                    url = "https://www.thesun.co.uk/news/16781117/lunar-eclipse-november-2021-updates-what-time/",
                    urlToImage = "https://www.thesun.co.uk/wp-content/uploads/2021/11/COMP_ES_LUNAR-ECLIPSE-LIVE.jpg?strip=all&quality=100&w=1200&h=800&crop=1",
                    publishedAt = DateTime.Today,
                    source = new News.Source(){name = "The Sun"}
                }
            };
        }
    }
}
