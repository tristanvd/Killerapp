using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
	public class Game
	{
		public bool Player1 { get; set; } = false;
		public bool Player2 { get; set; } = false;
		public bool Player3 { get; set; } = false;

		public bool GameFinished { get; set; } = false;


		public void NextPlayer()
		{
			if (Player1 == true)
			{
				Player1 = false;
				Player2 = true;
			}
			if (Player2 == true)
			{
				Player2 = false;
				Player3 = true;
			}
			if (Player3 == true)
			{
				Player3 = false;
				GameFinished = true;
			}

		}
	}
}
