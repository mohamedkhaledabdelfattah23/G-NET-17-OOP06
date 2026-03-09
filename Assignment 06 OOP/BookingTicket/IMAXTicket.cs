using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.BookingTicket
{
    public class IMAXTicket : Ticket

    {


        public bool Is3D { get; set; }

        public IMAXTicket(string movie, double price, bool is3D) : base(movie, price)
        {

            Is3D = is3D;


        }

        public override double FinalPrice()
        {

            return Price * 1.14;


        }
    }
}
