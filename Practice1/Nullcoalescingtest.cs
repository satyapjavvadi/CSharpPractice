using System;
class Nullcoalescingtest
 {
    public static void Test()
    {
        Console.WriteLine("How many tickets are on sale?");
        //int? TicketsOnSale = Convert.ToInt32(Console.ReadLine());

        /*  int? TicketsOnSale = null;
          int AvailableTickets;

          if (TicketsOnSale == null)
          {
              AvailableTickets = 0;
          }
          else
          {
              AvailableTickets = (int)TicketsOnSale;
          }
          Console.WriteLine($"Available Tickets : {AvailableTickets}"); */

        int? TicketsOnSale = 100;
       // int AvailableTickets = (int) TicketsOnSale ?? null;
       // Console.WriteLine($"Available Tickets : {AvailableTickets}");
    }
 }
