using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaBookingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Toby Nyland - Project 1
            //Varibles
            int tickets = 0;
            int age = 0;
            bool book = true;
            while (book == true)
            {
                //User interface - asks for a int that corresponds to a flim
                Console.WriteLine(">> Welcome to Aquinas Multiplex!");
                Console.WriteLine("1. Rush (15): "+tickets+" Tickets sold.");
                Console.WriteLine("2. How I Live Now (15)");
                Console.WriteLine("3. Thor: The Dark World (12)");
                Console.WriteLine("4. Filth (18)");
                Console.WriteLine("5. Planes (U)");
                Console.WriteLine("6. Exit Menu");
                Console.WriteLine("Please enter the option that you want: ");
                int flim = int.Parse(Console.ReadLine()); //Sets the string entered into a int (flim)
                //Enter your age
                Console.WriteLine("Please enter your age:");
                age = int.Parse(Console.ReadLine()); //Sets the string entered into a int (age)


                //

                switch (flim) //Switch statment to select the flim options.
                {

                    case 1:
                        Console.WriteLine("You have choosen Rush");
                        if (age >= 15) //Checks age
                        {
                            Console.WriteLine("Access Granted to book Rush");

                            Console.WriteLine("Enter your date you would like to book");//Enter a date
                            string BookingDateStr = Console.ReadLine(); //Date is stored
                            try // Coverts date to DateTime if vaild
                            {
                                DateTime TheTimeNow = DateTime.Now;
                                DateTime BookingDate = DateTime.Parse(BookingDateStr);
                                if (BookingDate < TheTimeNow.AddDays(7))
                                {
                                    Console.WriteLine("You have booked for " + BookingDateStr + "for the movie Rush. How many people would ou like to book for? ");
                                    
                                }
                            }
                            catch //If a not vaild date this is caught (Preventing a RunTime error)
                            {
                                Console.WriteLine("Invaild Booking Date entered");
                                //Console.ReadLine();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Access Declined to book Rush ");
                        }
                        break;

                    case 2:
                        Console.WriteLine("You have choosen How I Live Now");
                        if (age >= 15)
                        {
                            Console.WriteLine("Access Granted to book How I Live Now");
                        }
                        else
                        {
                            Console.WriteLine("Access Declined to book How I Live Now ");
                        }
                        break; ;

                    case 3:
                        Console.WriteLine("You have choosen Thor: The Dark World");
                        if (age >= 12)
                        {
                            Console.WriteLine("Access Granted to book Thor: The Dark World");
                        }
                        else
                        {
                            Console.WriteLine("Access Declined to book Thor: The Dark World ");
                        }
                        break;

                    case 4:
                        Console.WriteLine("You have choosen Filth");
                        if (age >= 18)
                        {
                            Console.WriteLine("Access Granted to book Filth");
                        }
                        else
                        {
                            Console.WriteLine("Access Declined to book Filth ");
                        }
                        break;

                    case 5:
                        Console.WriteLine("You have choosen Planes");
                        Console.WriteLine("Access Granted to book Planes");
                        break;

                    case 6: //Exit
                        Console.WriteLine("Exiting");
                        book = false; //Breaks the while loop
                        break;
                    default:
                        Console.WriteLine("Not an option.");
                        break;
                }
            }

        }
    }
}
