using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTarget
{
    public class FibonacciSequence
    {
        public void GetFibonacciSequence()
        {
            Console.WriteLine("Informe um numero:");
            var target = int.Parse(Console.ReadLine());

            if (!InputValidation(target))
            {
                Console.WriteLine("O numero não pode ser negativo");
            }

            var res = CalculateFibonacciSequence(target);
            bool IsTargetInRes = res.Contains(target);

            if (!IsTargetInRes)
            {
                Console.WriteLine($"{target} não pertence a sequencia de fibonacci");
            }else
            {
                Console.WriteLine($"{target} pertence a sequencia de fonanacci");
                Console.WriteLine($"Sequência de Fibonacci até {target}: {string.Join(", ", res)}");
            }

        }

        public List<int> CalculateFibonacciSequence(int target)
        {

            var actualNumber = 1;
            List<int> res = new List<int> { 0, 1 };

            while (res[res.Count() - 1] < target)
            {
                int nextNumber = res[^1] + res[^2];
                res.Add(nextNumber);
            }

            return res;
        }

        private bool InputValidation(int input)
        {
            return input >= 0;
        }
    }
}
