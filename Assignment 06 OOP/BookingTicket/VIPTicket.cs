using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.BookingTicket
{
    public class VIPTicket : Ticket
    {


        public bool Lounge { get; set; }
        public double Fee { get; set; }

        public VIPTicket(string movie, double price, bool lounge, double fee) : base(movie, price)
        {

            Lounge = lounge;
            Fee = fee;


        }

        public override double FinalPrice()
        {

            return Price + Fee;


        }
    }
}
