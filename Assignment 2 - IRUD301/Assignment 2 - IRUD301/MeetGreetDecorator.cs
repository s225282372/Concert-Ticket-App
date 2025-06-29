using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2___IRUD301
{
    public class MeetGreetDecorator: TicketDecorator
    {
        private double meetAndGreetPrice;

        public MeetGreetDecorator(ITicket ticket, double meetGreetPrice = 200.0) : base(ticket)
        {
            meetAndGreetPrice = meetGreetPrice;
        }

        public override double GetPrice()
        {
            return base.GetPrice() + meetAndGreetPrice;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + Meet & Greet (Photo Opportunity, Autograph Session, Backstage Access)";
        }

    }
}
