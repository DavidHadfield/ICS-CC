using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace painting_application
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("rooms.txt");

            //1st - num of rooms
            int numRooms = Int32.Parse(sr.ReadLine());

            //2nd - # of coats per room
            int numCoats = Convert.ToInt32(sr.ReadLine());

            //3rd cost of paint per square foot
            double costPerFt = Convert.ToDouble(sr.ReadLine());

            Console.WriteLine("PICASSO PAINTERS INVOICE");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("ROOM                          COST");
            Console.WriteLine("-----------------------------------");
            double subtotal = 0;
            for (int i = 0; i < numRooms; i++)
            {
                //4th house room dimensions
                string roomsLWH = sr.ReadLine();
                string[] rooms = roomsLWH.Split(',');
                //data of rooms
                string room = (rooms[0]);
                int length = Convert.ToInt32(rooms[1]);
                int width = Convert.ToInt32(rooms[2]);
                int height = Convert.ToInt32(rooms[3]);

                //calc sides length x height x 2
                double lengthHeight = 2 * (length * height);

                //calc sides width x height x 2
                double widthHeight = 2 * (width * height);
                double totalSA = widthHeight + lengthHeight;
                double finalCost = (totalSA * numCoats) * costPerFt;
                subtotal += finalCost;
                string sFinalCost = "$" + finalCost;
                Console.WriteLine("{0,-30}{1}", room, sFinalCost);
            }
            //bottom text
            double tax = subtotal * .13;
            double taxes = subtotal * 1.13;

            string sSubTotal = "$" + subtotal;
            string sTax = "$" + tax;
            string sTaxes = "$" + taxes;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("SUBTOTAL {0,25}", sSubTotal);
            Console.WriteLine("-----------------------------------"); 
            Console.WriteLine("HST (13.0%) {0,22}", sTax);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("TOTAL {0,28}", sTaxes);
            Console.ReadLine();
        }
    }
}
