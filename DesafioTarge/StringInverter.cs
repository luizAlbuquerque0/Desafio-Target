using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTarget
{
    public class StringInverter
    {
        public void GetStringInderted()
        {
            Console.WriteLine("Escreva a palava que você quer inventer:");
            var input = Console.ReadLine();

            string invertedString = "";

           for(var i = input.Length - 1; i >= 0; i--)
            {
                invertedString += input[i];
            }

            Console.WriteLine($"Assim fica a palavra invertida {invertedString}");
        }
    }
}
