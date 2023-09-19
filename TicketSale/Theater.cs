using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale
{
	public class Theater
	{
		private TicketSeller _ticketSeller;

		public Theater(TicketSeller ticketSeller)
		{
			_ticketSeller = ticketSeller;
		}

		public void Enter(Audience audience)
		{
			_ticketSeller.SellTo(audience);
		}
	}
}
