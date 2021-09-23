using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estant.Material.Utilities
{
    public class MultiRequestHelper<T>
    {
        private List<Task<T>> requests;

        public MultiRequestHelper()
        {
            requests = new List<Task<T>>();
        }

        public void AddRequest(Task<T> task)
        {
            requests.Add(task);
        }

        public async Task<IEnumerable<T>> Execute()
        {
            //Wait for all the requests to finish
            await Task.WhenAll(requests);

            var responses = requests.Select
            (
                task => task.Result
            );

            return responses;
        }
    }
}
