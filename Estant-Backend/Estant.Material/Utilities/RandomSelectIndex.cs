using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estant.Material.Utilities
{
    public class RandomSelectIndex
    {
        private List<int> indexs;
        private Random r;
        public RandomSelectIndex(int n)
        {
            indexs = Enumerable.Range(0, n - 1).ToList();
            r = new Random();
        }

        public int GetIndexRandom()
        {
            int result = 0;
            int rInt = r.Next(0, indexs.Count);
            result = indexs[rInt];

            // remove index is selected
            indexs.RemoveAt(rInt);
            return result;
        }

        public void RemoveIndex(int index)
        {
            indexs.Remove(index);
        }
    }
}
