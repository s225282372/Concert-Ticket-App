using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2___IRUD301
{
    public class StandardTicket: ITicket
    {
        private double best_Price;
        private string event_Name;
        private string venue;

        public StandardTicket(double best_Price, string event_Name, string venue)
        {
            this.best_Price = best_Price;
            this.event_Name = event_Name;
            this.venue = venue;
        }

        public double GetPrice()
        {
            return best_Price;
        }

        public string GetDescription()
        {
            return $"Standard Ticket - {event_Name} at {venue}";
        }

    }
}
