using CourseException.Entities;
using CourseException.Entities.Execptions;
using System;

namespace CourseException
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soulução muito ruim!!!
            //Console.Write("Room number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            //DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            //DateTime checkOut = DateTime.Parse(Console.ReadLine());


            //if (checkOut <= checkIn)
            //{
            //    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            //}
            //else
            //{
            //    Reservation reservation = new Reservation(number, checkIn, checkOut);
            //    Console.WriteLine("Reservation: " + reservation);

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation:");
            //    Console.Write("Check-in date (dd/MM/yyyy):");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-out date (dd/MM/yyyy): ");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    DateTime now = DateTime.Now;
            //    if (checkIn < now || checkOut < now)
            //    {
            //        Console.WriteLine("Error in reservation: Reservation dates for update must be future dates!");
            //    }
            //    else if(checkOut <= checkIn){
            //        Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            //    }
            //    else
            //    {
            //        reservation.UpdateDates(checkIn, checkOut);
            //        Console.WriteLine("Reservation: " + reservation);
            //    }
            //}

            //Soulução ruim!!!
            //Console.Write("Room number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Check-in date (dd/MM/yyyy): ");
            //DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Check-out date (dd/MM/yyyy): ");
            //DateTime checkOut = DateTime.Parse(Console.ReadLine());


            //if (checkOut <= checkIn)
            //{
            //    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            //}
            //else
            //{
            //    Reservation reservation = new Reservation(number, checkIn, checkOut);
            //    Console.WriteLine("Reservation: " + reservation);

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation:");
            //    Console.Write("Check-in date (dd/MM/yyyy):");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-out date (dd/MM/yyyy): ");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    string error = reservation.UpdateDates(checkIn, checkOut);

            //    if(error != null)
            //    {
            //        Console.WriteLine("Error in reservation: " + error);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Reservation: " + reservation);
            //    }
            //}

            // Solução Boa!!!!

            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());



                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy):");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
          

             
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpect error: " + e.Message);
            }
        }
    }
}

