using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicTasks
{
    class MinimalInteger
    {
        private readonly int[] array = new int[] {9, 8, 7, 6, 5, 4, 3, 2};

        public int MinimalNumber(int N)
        {
            var list = new List<int>();

            if (N < 10)
            {
                return N;
            }

            while (N>=10)
            {
                var temp = array.Where(x => N % x == 0).FirstOrDefault();
                if (temp != 0)
                {
                    list.Add(temp);
                    N /= temp;
                }
                else
                {
                    return -1;
                }
            }
            list.Add(N);
            list.Reverse();
            return listToInteger(list); ;
        }

        private int listToInteger(List<int> list)
        {
            var number = 0;
            for (int i = 0; i < list.Count; i++)
            {
                number += (int) (list[i] * Math.Pow(10, list.Count - 1 - i));
            }

            return number;
        }
      
    }
}
