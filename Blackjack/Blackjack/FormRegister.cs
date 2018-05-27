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
	public partial class Register : Form
	{
		Database database = new Database();

		public Register()
		{
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			
				string username = txtUsername.Text;
				string password = txtPassword.Text;
				string name = txtFirstName.Text + " " + txtInfix.Text + " " + txtLastName.Text;
				string birthdate = txtAge.Text;
				string streetname = txtStreetName.Text;
				int housenumber = Convert.ToInt32(txtHouseNumber.Text);
				string city = txtCityName.Text;
				string zip = txtPostalCode.Text;
				string country = txtCountry.Text;
				int phonenumber = Convert.ToInt32(txtPhoneNumber.Text);
				string email = txtEmail.Text;

				database.Register(name, email, phonenumber, birthdate, streetname, housenumber, city, country, zip, username, password);
				MessageBox.Show("ja");

				FormLogin formLogin = new FormLogin();
				formLogin.Show();
				this.Hide();
			
		}
	}
}
