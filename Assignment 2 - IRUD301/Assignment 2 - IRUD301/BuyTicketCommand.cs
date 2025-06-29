using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2___IRUD301
{
    public class BuyTicketCommand: ICommand
    {
        private ITicket ticket;
        private int customer_id;
        private bool executed;
        private int transaction_id;
        private static int nextTransaction_id = 100;

        public BuyTicketCommand(ITicket ticket, int customerId)
        {
            this.ticket = ticket;
            customer_id = customerId;
            executed = false;
            transaction_id = nextTransaction_id++;
        }

        public void Execute()
        {
            if (!executed)
            {
                Console.WriteLine($"\nProcessing ticket purchase...");
                Console.WriteLine($"Transaction ID: {transaction_id}");
                Console.WriteLine($"Customer ID: {customer_id}");
                Console.WriteLine($"Ticket: {ticket.GetDescription()}");
                Console.WriteLine($"Total Price: {ticket.GetPrice():C2}");
                Console.WriteLine("Payment processed successfully!");

                executed = true;

                
                AnalyticsTracker.GetInstance().LogSale(ticket.GetDescription(), ticket.GetPrice(), customer_id);
            }
            else
            {
                Console.WriteLine("Purchase already executed!");
            }
        }

        public void Undo()
        {
            if (executed)
            {
                Console.WriteLine($"\nUndoing ticket purchase...");
                Console.WriteLine($"Transaction ID: {transaction_id}");
                Console.WriteLine($"Reversing purchase for customer {customer_id}");
                Console.WriteLine("Purchase successfully reversed!");

                executed = false;
            }
            else
            {
                Console.WriteLine("No purchase to undo!");
            }
        }

        public int GetTransactionId()
        {
            return transaction_id;
        }

    }
}
