using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
	public partial class Form1 : Form
	{
		Deck deck = new Deck();
		Game game = new Game();
		


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			deck.NewDeck();
			foreach (Card c in deck.FullDeck)
			{
				listBox1.Items.Add(c);
			}
		}

		private void btnHit_Click(object sender, EventArgs e)
		{

			if (game.GameOn == true)
			{
				

				Button b = sender as Button;

				if (game.player1.Bust == false)
				{
					if (b.Name == "btnHit1")
					{
						int handvalue = 0;
						game.player1.HandCards.Add(game.player1.hand.GetCard(deck));
						deck.FullDeck.Remove(game.player1.hand.GetCard(deck));
						
						foreach (Card c in game.player1.HandCards)
						{
							handvalue += c.Value;
						}
						lblSpeler1Getal.Text = handvalue.ToString();
						if (handvalue > 21)
						{
							MessageBox.Show("DOOD");
							game.player1.Bust = true;
							NextPlayer();
						}
					}
				}
				if (game.player2.Bust == false) { 
					if (b.Name == "btnHit2")
					{
						int handvalue = 0;
						game.player2.HandCards.Add(game.player2.hand.GetCard(deck));
						deck.FullDeck.Remove(game.player2.hand.GetCard(deck));
						
						foreach (Card c in game.player2.HandCards)
						{
							handvalue += c.Value;
						}
						lblSpeler2Getal.Text = handvalue.ToString();
						if (handvalue > 21)
						{
							MessageBox.Show("DOOD");
							game.player2.Bust = true;
							NextPlayer();
						}
					}
				}
				if (game.player3.Bust == false) { 
					if (b.Name == "btnHit3")
					{
						int handvalue = 0;
						game.player3.HandCards.Add(game.player3.hand.GetCard(deck));
						deck.FullDeck.Remove(game.player3.hand.GetCard(deck));
						
						foreach (Card c in game.player3.HandCards)
						{
							handvalue += c.Value;
						}
						lblSpeler3Getal.Text = handvalue.ToString();
						if (handvalue > 21)
						{
							MessageBox.Show("DOOD");
							game.player3.Bust = true;
							NextPlayer();
						}
					}
				}

			}
			else { MessageBox.Show("Start eerst het spel."); }

			


			listBox1.Items.Clear();
			foreach (Card c in deck.FullDeck)
			{
				listBox1.Items.Add(c);
			}
		}

		
		private void btnStart_Click(object sender, EventArgs e)
		{
			if (game.GameOn == false)
			{
				

				Hand dealerhand = new Hand();
				Hand hand1 = new Hand();
				Hand hand2 = new Hand();
				Hand hand3 = new Hand();

				

				Dealer dealer = new Dealer(dealerhand);
				Player player1 = new Player(hand1);
				Player player2 = new Player(hand2);
				Player player3 = new Player(hand3);

				game.player1 = player1;
				game.player2 = player2;
				game.player3 = player3;

				game.dealer = dealer;










			}
			else { MessageBox.Show("Maak het spel eerst af."); }

			

		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			Button b = sender as Button;

			if (b.Name == "btnStop1")
			{
				game.player1.Bust = true;
				NextPlayer();
			}
			if (b.Name == "btnStop2")
			{
				game.player2.Bust = true;
				NextPlayer();
			}
			if (b.Name == "btnStop3")
			{
				game.player3.Bust = true;
				NextPlayer();
			}
		}

		public void NextPlayer()
		{
			
			if (game.player1.Bust == true && game.player2.Bust != true && game.player3.Bust != true)
			{
				btnHit1.Enabled = false;
				btnStop1.Enabled = false;
				btnHit2.Enabled = true;
				btnStop2.Enabled = true;
			}
			else if (game.player1.Bust == true && game.player2.Bust == true && game.player3.Bust != true)
			{

				btnHit2.Enabled = false;
				btnStop2.Enabled = false;
				btnHit3.Enabled = true;
				btnStop3.Enabled = true;
			}
			else if (game.player1.Bust == true && game.player2.Bust == true && game.player3.Bust == true)
			{
				btnHit1.Enabled = false;
				btnHit2.Enabled = false;
				btnHit3.Enabled = false;
				btnStop1.Enabled = false;
				btnStop2.Enabled = false;
				btnStop3.Enabled = false;

				game.GameEnd();

				game.player1.Balance += game.CheckWin(game.player1, game.player1.Inzet);
				game.player2.Balance += game.CheckWin(game.player2, game.player2.Inzet);
				game.player3.Balance += game.CheckWin(game.player3, game.player3.Inzet);
			}
		}

		

		

		

		private void lblInzet1Euro_Click(object sender, EventArgs e)
		{
			game.inzet = 1;
		}

		private void lblInzet5Euro_Click(object sender, EventArgs e)
		{
			game.inzet = 5;
		}

		private void lblInzet25Euro_Click(object sender, EventArgs e)
		{
			game.inzet = 25;
		}

		private void lblInzetSpeler1_Click(object sender, EventArgs e)
		{
			if (game.GameOn == false)
			{
				game.player1.Inzet += game.inzet;
				lblInzetSpeler1.Text = game.player1.Inzet.ToString();
			}
		}

		private void lblInzetSpeler2_Click(object sender, EventArgs e)
		{
			if (game.GameOn == false)
			{
				game.player2.Inzet += game.inzet;
				lblInzetSpeler2.Text = game.player2.Inzet.ToString();
			}
		}

		private void lblInzetSpeler3_Click(object sender, EventArgs e)
		{
			if (game.GameOn == false)
			{
				game.player3.Inzet += game.inzet;
				lblInzetSpeler3.Text = game.player3.Inzet.ToString();
			}
		}

		private void btnReady_Click(object sender, EventArgs e)
		{
			game.SetGameStatus(true);

			Card card1 = GetCard(deck);
			game.dealer.HandCards.Add(card1);

			Card card2 = GetCard(deck);
			game.player1.HandCards.Add(card2);

			Card card3 = GetCard(deck);
			game.player2.HandCards.Add(card3);

			Card card4 = GetCard(deck);
			game.player3.HandCards.Add(card4);

			int handvalue = 0;
			foreach (Card c in game.dealer.HandCards)
			{
				handvalue += c.Value;
				lblDealerGetal.Text = handvalue.ToString();
			}

			handvalue = 0;
			foreach (Card c in game.player1.HandCards)
			{
				handvalue += c.Value;
				lblSpeler1Getal.Text = handvalue.ToString();
			}

			handvalue = 0;
			foreach (Card c in game.player2.HandCards)
			{
				handvalue += c.Value;
				lblSpeler2Getal.Text = handvalue.ToString();
			}

			handvalue = 0;
			foreach (Card c in game.player3.HandCards)
			{
				handvalue += c.Value;
				lblSpeler3Getal.Text = handvalue.ToString();
			}

		}

		public Card GetCard(Deck deck)
		{

			Random rnd = new Random();
			int getal = rnd.Next(deck.FullDeck.Count);
			Card randomcard = deck.FullDeck[getal];

			return randomcard;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Register register = new Register();
			register.Show();
		}
	}
}
