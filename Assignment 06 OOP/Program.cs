using Assignment_06_OOP.BookingTicket;
using System;
using System.ComponentModel;
using System.IO;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_06_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region PART 01
            //PART 01

            //    Question  01:

            //    Abstraction is the concept of hiding complex implementation details and showing only the essential features of an object.

            //    It focuses on what the object does, not how it does it.

            //    Encapsulation is the concept of wrapping data and methods inside a class and controlling access to them using 
            //    access modifiers like private, public, and protected.





            //   Real World Example

            //Consider a coffee machine.

            //The user presses a button to make coffee → this is abstraction because the user does not know the internal process.

            //The internal components like heating system and pressure control are hidden → this is encapsulation.




            //Question  02:

            //    Abstract class :
            //            Can contain fields and constructor, Can have implemented methods,
            //            A class can inherit only one abstract class , Can contain access modifiers.




            //   Interface :

            //             Cannot contain constructors , Methods are usually abstract ,  A class can implement multiple interfaces
            //             Members are public by default   






            //  When to use each

            //Use abstract class when classes share common implementation.

            //Use interface when different classes need to follow the same contract but are not related by inheritance.



            //Question  03: 


            //         a) No, you cannot create object from abstract class cannot be instantiated directly.
            //            They must be inherited by another class.



            //         b) 

            //            abstract : Must be implemented by child classes


            //            virtual  : Has a default implementation but can be overridden

            //            concrete : Fully implemented and cannot be overridden




            //        c) StandBy

            //            because the Toaster class does not override the Status method, so the base implementation is used.


            //Question  04: 


            //         a) 

            //            A partial class allows a class definition to be split into multiple files.

            //            This helps organize large classes and allows multiple developers to work on the same class.


            //         b) 

            //          A partial method is a method declared in one part of a partial class and optionally implemented in another part.

            //          If the implementation is removed, the compiler removes the method call automatically, so the program still compiles.


            //         c)

            //          An extension method allows adding new methods to an existing class without modifying the original class.

            //            Rules for extension methods

            //            Must be inside a static class

            //            The method must be static

            //            The first parameter must use the keyword this







            //         d)  
            //                Log: result = 20 
            //                $20.00 
            #endregion



            Console.WriteLine("=== Cinema Opened ===");

            

            StandardTicket t1 = new StandardTicket("Inception", 80, "A5");
            VIPTicket t2 = new VIPTicket("Avengers", 200, true, 50);
            IMAXTicket t3 = new IMAXTicket("Dune", 130, true);

            t1.Book();
            t2.Book();
            t3.Book();

            Cinema cinema = new Cinema();

            cinema.AddTicket(t1);
            cinema.AddTicket(t2);
            cinema.AddTicket(t3);

            cinema.PrintTickets();

            Console.WriteLine("\n--- Polymorphism ---");

            Ticket[] tickets = { t1, t2, t3 };

            foreach (var t in tickets)
            {

                Console.WriteLine($"{t.GetType().Name} => Final Price: {t.FinalPrice()}");

            }


            Console.WriteLine("\n--- Receipt ---");
            Console.WriteLine(t2.Receipt());


            Console.WriteLine("\n--- Total Revenue ---");
            Console.WriteLine(tickets.TotalRevenue());

            Console.WriteLine("=== Cinema Closed ===");
        }





    }


    public static class TicketExtensions
    {
            public static string Receipt(this Ticket ticket)
            {
                return 
                $@"========== RECEIPT ==========
                  Movie   : {ticket.Movie}
                  Type    : {ticket.GetType().Name}
                  Price   : {ticket.Price}
                  Final   : {ticket.FinalPrice()}
                  Status  : {ticket.Status()}
                  =============================";
            }

            public static double TotalRevenue(this Ticket[] tickets)
            {

                double total = 0;

                foreach (var t in tickets)
                {


                    total += t.FinalPrice();


                }

                return total;

            }
    }




    


}

