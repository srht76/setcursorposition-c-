using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppDeneme1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("*");
                 
            }
            for (int i =0; i < 35; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(13+i, 1);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("*");
                Console.SetCursorPosition(55, i);
                

            }
            for (int i=0;i<10;i++)
            { 
                Console.WriteLine("*");
                Console.SetCursorPosition(5, 5 + i);
            }

            for (int i = 0; i < 10; i++)
            { 
                Console.Write("*");
                Console.SetCursorPosition(5+i, 15);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(20-i, 5 + i);
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(15+i , 10+i);
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(20 + i, 15 - i);
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(25 -i, 10 - i);
            }


            for (int i = 0; i < 11; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(30 + i, 5 + i);
            }
            for (int i = 0; i < 11; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(41 + i, 15 - i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(55, 5 + i);
            }
            for (int i = 0; i < 12; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(55+i, 5 );
            }
            for (int i = 1; i < 12; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(55 + i, 10);
            }

            for (int i = 0; i < 12; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(55 + i, 15);
            }
                 for (int i = 0; i < 6; i++)
             {
                 Console.Write("*");
                 Console.SetCursorPosition(20+i, 20+i);
             }
            for (int i = 0; i < 6; i++)
               {
                   Console.Write("*");
                   Console.SetCursorPosition(27 + i, 25- i);
               }
               for (int i = 0; i < 6; i++)
               {
                   Console.Write("*");
                   Console.SetCursorPosition(26, 25 + i);
               }



               ////ooooo
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(41 - i, 20 + i);
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(36 + i, 25 + i);
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(41 + i, 30 - i);
            }
            for (int i = 0; i < 6; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(46 - i, 25 - i);
            }

            ///UUUUUUUUUUUU

            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(56, 20 + i);
            }

            for (int i = 0; i < 15; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(56+i, 30  );
            }

            for (int i = 0; i < 12; i++)
            {
                Console.Write("*");
                Console.SetCursorPosition(70, 30-i);
            }
            Console.SetCursorPosition(15, 15);
            Console.ReadLine();
        }
    }
}
