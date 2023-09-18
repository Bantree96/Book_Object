using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSale
{
	public class Bag
	{
		// 현금
		private long _amount;
		// 초대장
		private Invitation _invitation;
		// 티켓
		public Ticket Ticket { get; set; }
		/// <summary>
		/// 초대장 없이 현금만 있는 가방
		/// </summary>
		/// <param name="amount"></param>
		public Bag(long amount)
		{
			_amount = amount;
		}

		/// <summary>
		/// 초대장과 현금이 있는 가방
		/// </summary>
		/// <param name="invitation"></param>
		/// <param name="amount"></param>
		public Bag(Invitation invitation, long amount)
		{
			_invitation = invitation;
			_amount = amount;
		}
		public bool HasInvitation()
		{
			return _invitation != null;
		}

		public bool HasTicket()
		{
			return Ticket != null;
		}

		public void MinusAmount(long amount)
		{
			_amount -= amount;
		}

		public void PlusAmount(long amount)
		{
			_amount += amount;
		}

	}
}
