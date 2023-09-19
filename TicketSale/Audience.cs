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
			return _bag.Hold(ticket);
		}

	}
}
