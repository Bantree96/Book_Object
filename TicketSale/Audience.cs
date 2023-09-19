using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale
{
	/// <summary>
	/// 관람객
	/// </summary>
	public class Audience
	{
		private Bag _bag;
		public Audience(Bag bag)
		{
			_bag = bag;
		}

		public long Buy(Ticket ticket)
		{
			// 초대권이 있다면 초대권으로 티켓을 교환한다.
			if (_bag.HasInvitation())
			{
				_bag.Ticket = ticket;
				return 0;
			}
			// 초대권이 없다면 돈으로 티켓을 구매한다.
			else
			{
				_bag.Ticket = ticket;
				_bag.MinusAmount(ticket.Fee);
				return ticket.Fee;
			}
		}

	}
}
