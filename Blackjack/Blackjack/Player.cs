using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
	public class Player
	{
		public int UserID { get; set; }
		public string Name { get; set; }
		public decimal Balance { get; set; }
		public bool Bust { get; set; } = false;
		public Hand hand { get; set; }
		public List<Card> HandCards = new List<Card>();
		public int Inzet { get; set; } = 0;

		
		public Player(Hand Hand, User user)
		{
			UserID = user.Id;
			Name = user.Name;
			Balance = user.Balance;
			hand = Hand;
			HandCards = Hand.Cards;

		}

		
	}
}
