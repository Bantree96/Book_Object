using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale
{
	public class TicketOffice
	{
		private long _amount;
		private List<Ticket> _ticket = new List<Ticket>();

		public TicketOffice(long amount, List<Ticket> tickets)
		{
			_amount = amount;
			_ticket = tickets;
		}

		public void SellTicketTo(Audience audience)
		{
			PlusAmount(audience.Buy(GetTicket()));
		}

		private Ticket GetTicket()
		{
			Ticket firstTicket = _ticket.First();
			_ticket.RemoveAt(0);
			return firstTicket;
		}

		public void MinusAmount(long amount)
		{
			_amount -= amount;
		}

		private void PlusAmount(long amount)
		{
			_amount += amount;
		}
	}
}
