using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTarget
{
    public class DesafioTarget
    {

        public List<int> FibonacciSequence(int target)
        {
            if (target < 0)
            {
                Console.WriteLine("This number does not belong to fibonacci sequence");
                return new List<int>();
            }


            var actualNumber = 0;
            List<int> res = new List<int> { 0, 1 };

            while(actualNumber <= target)
            {
                var actualIndex = res.Count();
                actualNumber += res[actualIndex - 1];
                res.Add(actualNumber);
            }

            if(res.Last() == target)
            {
                Console.WriteLine("This number belongs to fibonacci sequence");
                return res;
            }

            Console.WriteLine("This number does not belong to fibonacci sequence");
            return new List<int>();
        }
    }
}
