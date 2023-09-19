using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale
{
	public class TicketSeller
	{
		private TicketOffice _ticketOffice;

		public TicketSeller(TicketOffice ticketOffice)
		{
			_ticketOffice = ticketOffice;
		}

		public void SellTo(Audience audience)
		{
			_ticketOffice.PlusAmount(audience.Buy(_ticketOffice.GetTicket()));
		}
	}
}
