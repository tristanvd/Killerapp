using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
	public class Game
	{

		public int inzet { get; set; } = 1;

		public bool GameOn { get; set; } = false;

		public Player player1 { get; set; }
		public Player player2 { get; set; }
		public Player player3 { get; set; }

		public Dealer dealer { get; set; }

		//public Game (Player player1, Player player2, Player player3)
		//{
		//	this.player1 = player1;
		//	this.player2 = player2;
		//	this.player3 = player3;
		//}


		public void SetGameStatus(bool status)
		{
			GameOn = status;
		}

		public int CheckWin(Player player, int inzet)
		{
			foreach (Card c in player.HandCards)
			{
				player.hand.Value += c.Value;
			}


			int bedrag = 0;
			if (player.Bust == false && player.hand.Value == dealer.hand.Value)
			{
				bedrag = inzet;
			}
			if (player.hand.Value > dealer.hand.Value)
			{
				bedrag = inzet * 2;
			}
			else
			{
				bedrag = 0;
			}
			return bedrag;
		}

		public void GameEnd(Database database, User currentUser)
		{
			SetGameStatus(false);

			player1.Balance += CheckWin(player1, player1.Inzet);
			player2.Balance += CheckWin(player2, player2.Inzet);
			player3.Balance += CheckWin(player3, player3.Inzet);

			database.UpdateBalance(player1.Balance, currentUser);
			database.UpdateBalance(player2.Balance, currentUser);
			database.UpdateBalance(player3.Balance, currentUser);

		}

	}

}
