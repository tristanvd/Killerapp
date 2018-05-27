using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
	public class Dealer
	{
		public string Name { get; set; }
		public bool Bust { get; set; } = false;
		public Hand hand { get; set; }
		public List<Card> HandCards = new List<Card>();


		public Dealer(Hand Hand)
		{
			hand = Hand;
			HandCards = Hand.Cards;
		}
	}
}
