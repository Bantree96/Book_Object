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
		public Bag Bag { get; private set; }
		public Audience(Bag bag)
		{
			Bag = bag;
		}

	}
}
