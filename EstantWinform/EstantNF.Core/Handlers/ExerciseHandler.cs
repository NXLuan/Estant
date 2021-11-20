using EstantWF.Material.Model;
using EstantWF.Material.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstantNF.Core.Handlers
{
    public static class ExerciseHandler
    {
        public static async Task<List<Exercise>> GetExerciseByTopic(string topic)
        {
            var data = new List<Exercise>();
            string path = "Exercise/GetByTopic?topic=" + topic;
            var response = await API.GetRequestAsync<List<Exercise>>(path);

            if (response.IsSuccess())
            {
                data = response.data;
            }

            return data;
        }
    }
}
