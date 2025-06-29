using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_2___IRUD301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONCERT TICKET APP DEMONSTRATION\n");

            CommandInvoker invoker = new CommandInvoker();

         
            Console.WriteLine("1. SINGLETON PATTERN - Analytics Tracker");
            Console.WriteLine("=========================================");

            AnalyticsTracker analytics1 = AnalyticsTracker.GetInstance();
            AnalyticsTracker analytics2 = AnalyticsTracker.GetInstance();

            Console.WriteLine($"Same instance? {object.ReferenceEquals(analytics1, analytics2)}");
            Console.WriteLine("Analytics system initialized and ready to track events.\n");

            
            Console.WriteLine("2. DECORATOR PATTERN - Ticket Upgrades");
            Console.WriteLine("=========================================");

            
            ITicket standardTicket = new StandardTicket(75.0, "Rock Concert", "Madison Square Garden");
            ITicket standardTicket2 = new StandardTicket(90.0, "Pop Festival", "Central Park");

            Console.WriteLine($"Base Ticket 1: {standardTicket.GetDescription()}");
            Console.WriteLine($"Price: {standardTicket.GetPrice():C2}\n");

        
            ITicket vipTicket = new VIPDecorator(standardTicket);
            Console.WriteLine($"VIP Upgrade: {vipTicket.GetDescription()}");
            Console.WriteLine($"Price: {vipTicket.GetPrice():C2}\n");

        
            ITicket premiumTicket = new MeetGreetDecorator(new VIPDecorator(standardTicket2));
            Console.WriteLine($"Premium Package: {premiumTicket.GetDescription()}");
            Console.WriteLine($"Price: {premiumTicket.GetPrice():C2}\n");

            Console.WriteLine("3. COMMAND PATTERN - Purchase Flow");
            Console.WriteLine("=========================================");

     
            BuyTicketCommand purchase = new BuyTicketCommand(standardTicket, 12345);
            BuyTicketCommand purchase2 = new BuyTicketCommand(vipTicket, 67890);
            BuyTicketCommand purchase3 = new BuyTicketCommand(premiumTicket, 11111);

            invoker.ExecuteCommand(purchase);
            invoker.ExecuteCommand(purchase2);
            invoker.ExecuteCommand(purchase3);


            invoker.ShowCommandHistory();


            Console.WriteLine("\n4. COMMAND UNDO DEMONSTRATION");
            Console.WriteLine("=========================================");
            Console.WriteLine("Undoing last command...");
            invoker.UndoLastCommand();

            Console.WriteLine("Undoing another command...");
            invoker.UndoLastCommand();


            Console.WriteLine("\n5.ANALYTICS REPORT (SINGLETON)");
            Console.WriteLine("=========================================");
            AnalyticsTracker.GetInstance().PrintAnalytics();


            Console.WriteLine("6. PATTERN INDEPENDENCE DEMONSTRATION");
            Console.WriteLine("=========================================");
            Console.WriteLine("Creating decorated ticket without purchasing:");
            ITicket decoratedOnly = new VIPDecorator(new StandardTicket(50.0, "Jazz Night", "Blue Note"));
            Console.WriteLine($"Ticket: {decoratedOnly.GetDescription()}");
            Console.WriteLine($"Price: {decoratedOnly.GetPrice():C2}");
            Console.WriteLine("(No analytics logged, no commands executed)\n");

            Console.WriteLine("Executing command without decoration:");
            BuyTicketCommand simpleCommand = new BuyTicketCommand(
                new StandardTicket(60.0, "Classical Concert", "Symphony Hall"),
                99999
            );
            invoker.ExecuteCommand(simpleCommand);
            Console.WriteLine("(Analytics logged independently, no decorations involved)\n");


            Console.WriteLine("FINAL ANALYTICS REPORT:");
            Console.WriteLine("=========================================");
            AnalyticsTracker.GetInstance().PrintAnalytics();

            Console.ReadLine();
        }
    }
}
