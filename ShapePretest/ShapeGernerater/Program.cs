using System;
using ShapePretest;

namespace ShapeGernerater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press [Q] to gernerate Quadrilateral");
            Console.WriteLine("Press [T] to gernerate Triangle");
            Console.WriteLine("Press [C] to gernerate Cricle");

            string inputtype = Console.ReadLine().ToUpper();


            if (inputtype == "Q")
            {
                Console.WriteLine("You Selected Quadrilateral, Press [S] to gernerate Square, [R] to gernerate Rectangle");

                string inputshapeq = Console.ReadLine().ToUpper();

                if(inputshapeq== "S")
                {
                    Console.WriteLine("You selected Square");
                    Console.WriteLine("");
                }

                if(inputshapeq == "R")
                {

                }
            }

            else if (inputtype == "T")
            {

            }

            else if (inputtype == "C")
            {

            }


        }
    }
}
