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
			// 초대권이 있다면 초대권으로 티켓을 교환한다.
			if (audience.Bag.HasInvitation())
			{
				Ticket ticket = _ticketSeller.TicketOffice.GetTicket();
				audience.Bag.Ticket = ticket;
			}
			// 초대권이 없다면 돈으로 티켓을 구매한다.
			else
			{
				Ticket ticket = _ticketSeller.TicketOffice.GetTicket();
				audience.Bag.MinusAmount(ticket.Fee);
				_ticketSeller.TicketOffice.PlusAmount(ticket.Fee);
				audience.Bag.Ticket = ticket;
			}
		}
	}
}
