using System;
using System.Collections.Generic;

namespace Assignment_2___IRUD301
{
    public class AnalyticsTracker
    {
        private static AnalyticsTracker instance;
        private static readonly object this_lock = new object();
        private List<string> sales_log;
        private int Sales_total;
        private double Total_revenue;

        private AnalyticsTracker()
        {
            sales_log = new List<string>();
            Sales_total = 0;
            Total_revenue = 0.0;
        }

        public static AnalyticsTracker GetInstance()
        {
            if (instance == null)
            {
                lock (this_lock)
                {
                    if (instance == null)
                    {
                        instance = new AnalyticsTracker();
                    }
                }
            }
            return instance;
        }

        public void LogSale(string ticketDescription, double amount, int customerId)
        {
            string logEntry = $"Ticket details:  Customer: {customerId}, Ticket: {ticketDescription}, Amount: {amount:C2}";
            sales_log.Add(logEntry);
            Sales_total++;
            Total_revenue += amount;
            Console.WriteLine($"{logEntry}");
        }

        public void PrintAnalytics()
        {
          
            Console.WriteLine($"Total Sales: {Sales_total}");
            Console.WriteLine($"Total Revenue: {Total_revenue:C2}");
            Console.WriteLine($"Sales Records: {sales_log.Count}");
            Console.WriteLine("=========================================\n");
        }

    }
}
