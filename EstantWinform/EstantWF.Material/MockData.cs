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
    }
}
