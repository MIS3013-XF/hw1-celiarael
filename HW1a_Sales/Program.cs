// HW1a Sales Total

// Your Name:Celia Rael
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of items are you purchasing?");
            string ticket = Console.ReadLine();

            Console.WriteLine("How Many football tickets do you want to purchase?");
            int ticketquantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How Much are the tickets?");
            double ticketprice = Convert.ToDouble(Console.ReadLine());

            double salestax = 0.085;

            double totalPrice = ticketprice * ticketquantity + ((ticketprice * ticketquantity) * salestax);
            

            Console.WriteLine("Your total price for your tickets are " + totalPrice );



























































































































































            
        }
    }
}
