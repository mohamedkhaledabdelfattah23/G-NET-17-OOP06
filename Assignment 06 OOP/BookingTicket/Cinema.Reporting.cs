using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_OOP.BookingTicket
{
    public partial class Cinema
    {


        public void PrintTickets()
        {


            Console.WriteLine("--- All Tickets ---");

            int i = 1;

            foreach (var t in tickets)
            {

                Console.WriteLine(
                    $"[Ticket #{i}] {t.Movie} | {t.GetType().Name} | Price: {t.Price} | Final: {t.FinalPrice()} | Booked: {t.Status()}"
                );

                i++;


            }
        }
    }
}
