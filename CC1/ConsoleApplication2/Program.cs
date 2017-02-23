using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadratictEquations
{
    class Program
    {
        static void Main(string[] args)
        {
            // input text files
            StreamReader sr = new StreamReader("input.txt");

            // convert int to string
            int numQuad = Int32.Parse(sr.ReadLine());

            // loop for amnt in input
            for (int i = 0; i < numQuad; i++)
            {
                //split into array
                string values = sr.ReadLine();

                string[] splitted = values.Split(',');
                int a = Int32.Parse(splitted[0]);
                int b = Int32.Parse(splitted[1]);
                int c = Int32.Parse(splitted[2]);

                //equation
                double numerator = -b + Math.Sqrt(b * b - 4 * a * c);
                double numeratorneg = -b - Math.Sqrt(b * b - 4 * a * c);
                double denominator = (2 * a);
                double sqr = numerator / denominator;
                double sqrn = numeratorneg / denominator;

                //decides if NaN or != NaN + output
                if (Double.IsNaN(sqr) == true)
                {
                    Console.WriteLine("The quadratic equation with coefficients A = {0}, B = {1}, C = {2} has no real roots", a, b, c);
                    Console.ReadLine();

                }

                else if (Double.IsNaN(sqr) == false)
                {
                    Console.WriteLine("The quadratic equation with coefficients A = {0}, B = {1}, C = {2} has roots of  x = {3} and x = {4}", a, b, c, sqr, sqrn);
                    Console.ReadLine();
                }
            }
        }
    }
}
