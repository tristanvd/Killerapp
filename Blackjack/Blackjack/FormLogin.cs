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
				Form1 form1 = new Form1();
				form1.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("fail");
			}
		}

		private void lblRegister_Click(object sender, EventArgs e)
		{
			FormMain formMain = new FormMain();
			formMain.Show();
			this.Hide();
			
		}
	}
}
