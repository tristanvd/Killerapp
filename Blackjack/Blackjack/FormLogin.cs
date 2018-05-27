using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
	public partial class FormLogin : Form
	{
		Database database = new Database();

		public FormLogin()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUser.Text;
			string password = txtPassword.Text;
			if (database.Login(username, password) == true)
			{
				

				FormMain formMain = new FormMain(database.GetCurrentUser(username));
				formMain.Show();
				this.Hide();

			}
			else
			{
				MessageBox.Show("fail");
			}
		}

		private void lblRegister_Click(object sender, EventArgs e)
		{
			Register formRegister = new Register();
			formRegister.Show();
			this.Hide();
			
		}

		

		
	}
}
