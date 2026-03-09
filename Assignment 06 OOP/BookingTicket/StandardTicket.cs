using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.BookingTicket
{
    public class StandardTicket : Ticket
    {


        public string Seat { get; set; }

        public StandardTicket(string movie, double price, string seat) : base(movie, price)
        {

            Seat = seat;


        }

        public override double FinalPrice()
        {


            return Price * 1.14;


        }
    }
}
