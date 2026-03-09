using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.BookingTicket
{
    public abstract class Ticket
    {
        public string Movie { get; set; }
        public double Price { get; set; }
        public bool IsBooked { get; private set; }

        protected Ticket(string movie, double price)
        {

            Movie = movie;

            Price = price;



        }

        public void Book()
        {

            IsBooked = true;


        }

        public void Cancel()
        {


            IsBooked = false;


        }

        public virtual string Status()
        {


            return IsBooked ? "Booked" : "Available";


        }

        public abstract double FinalPrice();
    }
}
