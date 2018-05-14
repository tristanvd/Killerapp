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
		Hand hand1 = new Hand();
		Hand hand2 = new Hand();
		Hand hand3 = new Hand();
		Player player1 = new Player(hand3 = new Hand());
		Player player2 = new Player();
		Player player3 = new Player();
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
			

			int getal = 0;

			if (player1.Bust == false)
			{
				Card newcard = hand.GetCard(hand, deck);

				hand.Cards.Add(newcard);
				deck.FullDeck.Remove(newcard);
			}



			foreach (Card c in hand.Cards)
			{
				getal += c.Value;
			}

			

			lblSpeler1Getal.Text = getal.ToString();

			if (getal > 21)
			{
				player1.Bust = true;
				MessageBox.Show("Dood");
				game.NextPlayer();			
			}
			if (game.GameFinished == true)
			{

			}

			listBox1.Items.Clear();
			foreach (Card c in deck.FullDeck)
			{
				listBox1.Items.Add(c);
			}
		}

		private void btnHit2_Click(object sender, EventArgs e)
		{
			int getal = 0;

			if (player1.Bust == false)
			{
				Card newcard = hand.GetCard(hand, deck);

				hand.Cards.Add(newcard);
				deck.FullDeck.Remove(newcard);
			}



			foreach (Card c in hand.Cards)
			{
				getal += c.Value;
			}



			lblSpeler1Getal.Text = getal.ToString();

			if (getal > 21)
			{
				player1.Bust = true;
				MessageBox.Show("Dood");
				game.NextPlayer();
			}
			if (game.GameFinished == true)
			{

			}

			listBox1.Items.Clear();
			foreach (Card c in deck.FullDeck)
			{
				listBox1.Items.Add(c);
			}
		}

		private void btnHit3_Click(object sender, EventArgs e)
		{
			int getal = 0;

			if (player1.Bust == false)
			{
				Card newcard = hand.GetCard(hand, deck);

				hand.Cards.Add(newcard);
				deck.FullDeck.Remove(newcard);
			}



			foreach (Card c in hand.Cards)
			{
				getal += c.Value;
			}



			lblSpeler1Getal.Text = getal.ToString();

			if (getal > 21)
			{
				player1.Bust = true;
				MessageBox.Show("Dood");
				game.NextPlayer();
			}
			if (game.GameFinished == true)
			{

			}

			listBox1.Items.Clear();
			foreach (Card c in deck.FullDeck)
			{
				listBox1.Items.Add(c);
			}
		}
	}
}
