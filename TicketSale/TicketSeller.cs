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

		public TicketOffice TicketOffice { get; }
		public TicketSeller(TicketOffice ticketOffice)
		{
			_ticketOffice = ticketOffice;
		}
	}
}
