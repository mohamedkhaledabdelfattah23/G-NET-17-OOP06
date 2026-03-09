using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.BookingTicket
{
    public partial class Cinema
    {

        private List<Ticket> tickets = new List<Ticket>();

        public void AddTicket(Ticket t)
        {

            tickets.Add(t);

        }

        public List<Ticket> GetTickets()
        {

            return tickets;


        }
    }
}
