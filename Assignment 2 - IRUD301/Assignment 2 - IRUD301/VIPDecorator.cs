using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2___IRUD301
{
    public class VIPDecorator: TicketDecorator
    {
        private double VIP_price;

        public VIPDecorator(ITicket ticket, double vipUpgradePrice = 150.0) : base(ticket)
        {
            VIP_price = vipUpgradePrice;
        }

        public override double GetPrice()
        {
            return base.GetPrice() + VIP_price;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + VIP Access (Premium Seating, Express Entry, Complimentary Drinks)";
        }

    }
}
