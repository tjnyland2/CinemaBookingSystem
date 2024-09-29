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


            //I started the seating with the nested for loops but wasn't sure what to do after that and it felt like cheating to google it or use AI so this is all my own ability and I want to be marked off that.
            //We have a total tickets insead of individual tickets per movie just so the code is less of mess really
            //I can't wait to learn subroutine/ methods/ functions or whatever you call it as it will make this code much more compact.
            // All tickets are £5, even if your a kid, you are still taking up the same seat watching the same movie.
            // I probably could of done better on this one but, I am happy with what I get.

            //CONSTANTS
           // const int TICKETLIMIT = 50; //stores the limit of tickets that can be bought, decided to scrap this cause I got lazy, It has been an extremely busy week for me.

            //Varibles
            int tickets = 0; //Stores Total tickets, I was going to do indervidual varibles for each movie for the tickets but I decided I am just going to go for total tickets.
            int buyTickets = 0; //Temp Stores tickets
            int age = 0; //Stores User's age
            bool book = true; //If the while loop is broken or not
            while (book == true)
            {
                //User interface - asks for a int that corresponds to a flim
                Console.WriteLine("");
                Console.WriteLine(">> Welcome to Nyland's Multiplex!");
                Console.WriteLine("Total Tickets sold this week: " +tickets);
                Console.WriteLine("1. Rush (15)");
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

                switch (flim) //Switch statment to select the flim options.
                {

                    case 1: //if input 1
                        Console.WriteLine("You have choosen Rush"); //outputs movie
                        if (age >= 15) //Checks age
                        {
                            Console.WriteLine("Access Granted to book Rush");

                            Console.WriteLine("Enter your date you would like to book");//Enter a date
                            string BookingDateStr = Console.ReadLine(); //Date is stored
                            try // Coverts date to DateTime if vaild
                            {
                                DateTime TheTimeNow = DateTime.Now; //Time now
                                DateTime BookingDate = DateTime.Parse(BookingDateStr); //changes inputted str time to DateTime
                                if (BookingDate < TheTimeNow.AddDays(7)) //If the booking date is today or within a week of today(to the future)
                                {
                                    Console.WriteLine("You have booked for " + BookingDateStr + " for the movie Rush. How many people would you like to book for? "); //Booked date, input tickets
                                    buyTickets = int.Parse(Console.ReadLine()); //stores how many tickets user wants to buy
                                    int price = buyTickets * 5; //Tickets are £5, calcs price
                                    
                                    Console.WriteLine("You want to buy " + buyTickets + " tickets for £" + price +" (y/n)"); //Asks user if price is good
                                    string ans = Console.ReadLine(); //stores that answer
                                    if (ans == "y") //yes to price
                                    {
                                        Console.WriteLine("Booked " + buyTickets + " tickets for the movie Rush for £" + price); //confirmation
                                        tickets = tickets + buyTickets; //confirms the booking by adding it to the tickets
                                        buyTickets = 0; //sets temporary ticket store to 0 (cause why not have a temp store)

                                        //Visual Ticket//
                                        Console.WriteLine("-----------------");
                                        Console.WriteLine("Nyland's Multiplex");
                                        Console.WriteLine("Flim: Rush");
                                        Console.WriteLine("Date: "+BookingDateStr );
                                        Console.WriteLine("-----------------");
                                        //End of visual ticket
                                        //break;//Breaks// That break broke the seating grid thing.
                                    }
                                    else if (ans == "n") // answer is no to price
                                    {
                                        Console.WriteLine("Booking Cancelled"); //Booking cancelled 
                                        break; //Loop broken

                                    }
                                    else //Not vaild input
                                    {
                                        Console.WriteLine("Not vaild input"); //outputs invaid input
                                    }

                                    //Seating (or what I was able to do of the seating
                                    for (int i = 0; i < 5; i++)  // Rows (First For Loop) 5 rows
                                    {
                                        Console.Write((i + 1) + " "); // Display row number
                                        Console.Write("\n"); //Creates a new line for the next row
                                        for (int j = 0; j < 9; j++)  // Seats in each row (9 seats)
                                        {
                                            Console.Write("O");  //The seats
                                        }
                                    }

                                }
                            }
                            catch //If a not vaild date this is caught (Preventing a RunTime error)
                            {
                                Console.WriteLine("Invaild Booking Date entered");//Outputs to user that it is invaild
                                //Console.ReadLine();
                                break;//Breaks
                            }
                        }
                        else //Not old enough for the movie
                        {
                            Console.WriteLine("Access Declined to book Rush ");//Outputs that to user
                        }
                        break; //breaks

                    case 2:
                        Console.WriteLine("You have choosen How I Live Now");
                        if (age >= 15) //checks age
                        {
                            Console.WriteLine("Access Granted to book How I Live Now");//Outputs access granted

                            Console.WriteLine("Enter your date you would like to book");//Enter a date
                            string BookingDateStr = Console.ReadLine(); //Date is stored
                            try // Coverts date to DateTime if vaild
                            {
                                DateTime TheTimeNow = DateTime.Now; //Time now
                                DateTime BookingDate = DateTime.Parse(BookingDateStr); //changes inputted str time to DateTime
                                if (BookingDate < TheTimeNow.AddDays(7)) //If the booking date is today or within a week of today(to the future)
                                {
                                    Console.WriteLine("You have booked for " + BookingDateStr + " for the movie How I Live Now. How many people would you like to book for? "); //Booked date, input tickets
                                    buyTickets = int.Parse(Console.ReadLine()); //stores how many tickets user wants to buy
                                    int price = buyTickets * 5; //Tickets are £5, calcs price

                                    Console.WriteLine("You want to buy " + buyTickets + " tickets for £" + price + " (y/n)"); //Asks user if price is good
                                    string ans = Console.ReadLine(); //stores that answer
                                    if (ans == "y") //yes to price
                                    {
                                        Console.WriteLine("Booked " + buyTickets + " tickets for the movie How I live Now for £" + price); //confirmation
                                        tickets = tickets + buyTickets; //confirms the booking by adding it to the tickets
                                        buyTickets = 0; //sets temporary ticket store to 0 (cause why not have a temp store)

                                        //Visual Ticket//
                                        Console.WriteLine("-----------------");
                                        Console.WriteLine("Nyland's Multiplex");
                                        Console.WriteLine("Flim: How I live now");
                                        Console.WriteLine("Date: " + BookingDateStr);
                                        Console.WriteLine("-----------------");
                                        //End of visual ticket
                                    }
                                    else if (ans == "n") // answer is no to price
                                    {
                                        Console.WriteLine("Booking Cancelled"); //Booking cancelled 
                                        break; //Loop broken

                                    }
                                    else //Not vaild input
                                    {
                                        Console.WriteLine("Not vaild input"); //outputs invaid input
                                    }
                                    for (int i = 0; i < 5; i++)  // Rows (First For Loop) 5 rows
                                    {
                                        Console.Write((i + 1) + " "); // Display row number
                                        Console.Write("\n"); //Creates a new line for the next row
                                        for (int j = 0; j < 9; j++)  // Seats in each row (9 seats)
                                        {
                                            Console.Write("O");  //The seats
                                        }
                                    }
                                }
                            }
                            catch //If a not vaild date this is caught (Preventing a RunTime error)
                            {
                                Console.WriteLine("Invaild Booking Date entered");//Outputs to user that it is invaild
                                //Console.ReadLine();
                                break;//Breaks
                            }

                        }
                        else
                        {
                            Console.WriteLine("Access Declined to book How I Live Now ");//Output access declines (yikes) 
                        }
                        break; ;

                    case 3:
                        Console.WriteLine("You have choosen Thor: The Dark World");
                        if (age >= 12) //age checking
                        {
                            Console.WriteLine("Access Granted to book Thor: The Dark World");

                            Console.WriteLine("Enter your date you would like to book");//Enter a date
                            string BookingDateStr = Console.ReadLine(); //Date is stored
                            try // Coverts date to DateTime if vaild
                            {
                                DateTime TheTimeNow = DateTime.Now; //Time now
                                DateTime BookingDate = DateTime.Parse(BookingDateStr); //changes inputted str time to DateTime
                                if (BookingDate < TheTimeNow.AddDays(7)) //If the booking date is today or within a week of today(to the future)
                                {
                                    Console.WriteLine("You have booked for " + BookingDateStr + " for the movie Thor: The Dark World. How many people would you like to book for? "); //Booked date, input tickets
                                    buyTickets = int.Parse(Console.ReadLine()); //stores how many tickets user wants to buy
                                    int price = buyTickets * 5; //Tickets are £5, calcs price

                                    Console.WriteLine("You want to buy " + buyTickets + " tickets for £" + price + " (y/n)"); //Asks user if price is good
                                    string ans = Console.ReadLine(); //stores that answer
                                    if (ans == "y") //yes to price
                                    {
                                        Console.WriteLine("Booked " + buyTickets + " tickets for the movie Thor: The Dark World for £" + price); //confirmation
                                        tickets = tickets + buyTickets; //confirms the booking by adding it to the tickets
                                        buyTickets = 0; //sets temporary ticket store to 0 (cause why not have a temp store)

                                        //Visual Ticket//
                                        Console.WriteLine("-----------------");
                                        Console.WriteLine("Nyland's Multiplex");
                                        Console.WriteLine("Flim: Thor: The Dark World");
                                        Console.WriteLine("Date: " + BookingDateStr);
                                        Console.WriteLine("-----------------");
                                        //End of visual ticket
                                    }
                                    else if (ans == "n") // answer is no to price
                                    {
                                        Console.WriteLine("Booking Cancelled"); //Booking cancelled 
                                        break; //Loop broken

                                    }
                                    else //Not vaild input
                                    {
                                        Console.WriteLine("Not vaild input"); //outputs invaid input
                                    }
                                    for (int i = 0; i < 5; i++)  // Rows (First For Loop) 5 rows
                                    {
                                        Console.Write((i + 1) + " "); // Display row number
                                        Console.Write("\n"); //Creates a new line for the next row
                                        for (int j = 0; j < 9; j++)  // Seats in each row (9 seats)
                                        {
                                            Console.Write("O");  //The seats
                                        }
                                    }
                                }
                            }
                            catch //If a not vaild date this is caught (Preventing a RunTime error)
                            {
                                Console.WriteLine("Invaild Booking Date entered");//Outputs to user that it is invaild
                                //Console.ReadLine();
                                break;//Breaks
                            }
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
                            Console.WriteLine("Enter your date you would like to book");//Enter a date
                            string BookingDateStr = Console.ReadLine(); //Date is stored
                            try // Coverts date to DateTime if vaild
                            {
                                DateTime TheTimeNow = DateTime.Now; //Time now
                                DateTime BookingDate = DateTime.Parse(BookingDateStr); //changes inputted str time to DateTime
                                if (BookingDate < TheTimeNow.AddDays(7)) //If the booking date is today or within a week of today(to the future)
                                {
                                    Console.WriteLine("You have booked for " + BookingDateStr + " for the movie Filth. How many people would you like to book for? "); //Booked date, input tickets
                                    buyTickets = int.Parse(Console.ReadLine()); //stores how many tickets user wants to buy
                                    int price = buyTickets * 5; //Tickets are £5, calcs price

                                    Console.WriteLine("You want to buy " + buyTickets + " tickets for £" + price + " (y/n)"); //Asks user if price is good
                                    string ans = Console.ReadLine(); //stores that answer
                                    if (ans == "y") //yes to price
                                    {
                                        Console.WriteLine("Booked " + buyTickets + " tickets for the movie Filth for £" + price); //confirmation
                                        tickets = tickets + buyTickets; //confirms the booking by adding it to the tickets
                                        buyTickets = 0; //sets temporary ticket store to 0 (cause why not have a temp store)

                                        //Visual Ticket//
                                        Console.WriteLine("-----------------");
                                        Console.WriteLine("Nyland's Multiplex");
                                        Console.WriteLine("Flim: Thor: Filth");
                                        Console.WriteLine("Date: " + BookingDateStr);
                                        Console.WriteLine("-----------------");
                                        //End of visual ticket
                                    }
                                    else if (ans == "n") // answer is no to price
                                    {
                                        Console.WriteLine("Booking Cancelled"); //Booking cancelled 
                                        break; //Loop broken

                                    }
                                    else //Not vaild input
                                    {
                                        Console.WriteLine("Not vaild input"); //outputs invaid input
                                    }
                                    for (int i = 0; i < 5; i++)  // Rows (First For Loop) 5 rows
                                    {
                                        Console.Write((i + 1) + " "); // Display row number
                                        Console.Write("\n"); //Creates a new line for the next row
                                        for (int j = 0; j < 9; j++)  // Seats in each row (9 seats)
                                        {
                                            Console.Write("O");  //The seats
                                        }
                                    }
                                }
                            }
                            catch //If a not vaild date this is caught (Preventing a RunTime error)
                            {
                                Console.WriteLine("Invaild Booking Date entered");//Outputs to user that it is invaild
                                //Console.ReadLine();
                                break;//Breaks
                            }

                        }
                        else
                        {
                            Console.WriteLine("Access Declined to book Filth ");
                        }
                        break;

                    case 5:
                        Console.WriteLine("You have choosen Planes");
                        Console.WriteLine("Access Granted to book Planes");
                        Console.WriteLine("Enter your date you would like to book");//Enter a date
                        string BookingDateStr2 = Console.ReadLine(); //Date is stored, Stored as BookingDateStr2 due to some errors, which are now fixed.
                        try // Coverts date to DateTime if vaild
                        {
                            DateTime TheTimeNow = DateTime.Now; //Time now
                            DateTime BookingDate = DateTime.Parse(BookingDateStr2); //changes inputted str time to DateTime
                            if (BookingDate < TheTimeNow.AddDays(7)) //If the booking date is today or within a week of today(to the future)
                            {
                                Console.WriteLine("You have booked for " + BookingDateStr2 + " for the movie Filth. How many people would you like to book for? "); //Booked date, input tickets
                                buyTickets = int.Parse(Console.ReadLine()); //stores how many tickets user wants to buy
                                int price = buyTickets * 5; //Tickets are £5, calcs price

                                Console.WriteLine("You want to buy " + buyTickets + " tickets for £" + price + " (y/n)"); //Asks user if price is good
                                string ans = Console.ReadLine(); //stores that answer
                                if (ans == "y") //yes to price
                                {
                                    Console.WriteLine("Booked " + buyTickets + " tickets for the movie Filth for £" + price); //confirmation
                                    tickets = tickets + buyTickets; //confirms the booking by adding it to the tickets
                                    buyTickets = 0; //sets temporary ticket store to 0 (cause why not have a temp store)

                                    //Visual Ticket//
                                    Console.WriteLine("-----------------");
                                    Console.WriteLine("Nyland's Multiplex");
                                    Console.WriteLine("Flim: Thor: Filth");
                                    Console.WriteLine("Date: " + BookingDateStr2);
                                    Console.WriteLine("-----------------");
                                    //End of visual ticket
                                }
                                else if (ans == "n") // answer is no to price
                                {
                                    Console.WriteLine("Booking Cancelled"); //Booking cancelled 
                                    break; //Loop broken

                                }
                                else //Not vaild input
                                {
                                    Console.WriteLine("Not vaild input"); //outputs invaid input
                                }
                                for (int i = 0; i < 5; i++)  // Rows (First For Loop) 5 rows
                                {
                                    Console.Write((i + 1) + " "); // Display row number
                                    Console.Write("\n"); //Creates a new line for the next row
                                    for (int j = 0; j < 9; j++)  // Seats in each row (9 seats)
                                    {
                                        Console.Write("O");  //The seats
                                        }
                                    }
                                }
                            }
                            catch //If a not vaild date this is caught (Preventing a RunTime error)
                            {
                                Console.WriteLine("Invaild Booking Date entered");//Outputs to user that it is invaild
                                                                                  //Console.ReadLine();
                                break;//Breaks
                            }
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