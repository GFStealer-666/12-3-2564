using System;

namespace homework_motherfucker
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            double x, y,p,p1,p2;

            Console.Write("Mode : ");
            mode = Console.ReadLine();

            Console.Write("X : ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Y : ");
            y = double.Parse(Console.ReadLine());

            
            if (x < 0)
            {
                Console.WriteLine("Invaild mouse position");
                return;
            }
            
            if (mode == "Time" || mode == "time")
            {
                p = Math.Pow((x - 1), 2);

                Console.WriteLine("{0} , {1}" , x,p );
            }

            else if (mode == "Price" || mode == "price")
            {
                p1 = x + 1;
                p2 = Math.Pow(p1 , 0.5);

                Console.WriteLine("{0:0.00} , {1}",p2,y );
            }

            else if (mode != "Time" || mode != "Price" || mode != "time" || mode!= "price") // ขี้เกียจเขียน else ครับเลยเขียนแบบนี้ชัดกว่า
            {
                Console.WriteLine("Invaild mode");
            }


            Console.ReadLine();
        }
    }
}
