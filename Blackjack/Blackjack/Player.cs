using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
	public class Player
	{
		public string Name { get; set; }
		public decimal Balance { get; set; }
		public bool Bust { get; set; } = false;
		public List<Card> HandCards { get; set; }
		
		public Player (Hand hand)
		{
			HandCards = hand.Cards;
		}
	}
}
