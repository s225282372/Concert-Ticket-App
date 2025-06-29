using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2___IRUD301
{
    public abstract class TicketDecorator : ITicket
    {
        protected ITicket ticket;

        public TicketDecorator(ITicket ticket)
        {
            this.ticket = ticket;
        }

        public virtual double GetPrice()
        {
            return ticket.GetPrice();
        }

        public virtual string GetDescription()
        {
            return ticket.GetDescription();
        }

    }
}
