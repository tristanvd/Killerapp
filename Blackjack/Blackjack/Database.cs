using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Blackjack
{
	public class Database
	{
		public User GetCurrentUser(string username)
		{



			string query = "SELECT * FROM AspNetUsers WHERE UserName = '" + username + "'";
			SqlDataAdapter sda = new SqlDataAdapter(query, connectionString);
			DataTable dt = new DataTable();
			sda.Fill(dt);


			int id = Convert.ToInt32(dt.Rows[0][0]);


			string name = dt.Rows[0][12].ToString();

			string userName = dt.Rows[0][11].ToString();
			decimal balance = Convert.ToDecimal(dt.Rows[0][22]);


			User currentUser = new User(id, name, userName, balance);



			return currentUser;



		}


		SqlConnection connectionString = new SqlConnection("Data Source=desktop-38t55sn;Initial Catalog=database;Integrated Security=False;User ID=sa;Password=784512tyghvB;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

		public void UpdateBalance(decimal balance, User user)
		{
			connectionString.Open();
			SqlCommand cmd = new SqlCommand(" UPDATE dbo.AspNetUsers SET Balance = '" + balance + "' Where Id = '" + user.Id + "'", connectionString);
			cmd.ExecuteNonQuery(); 
			connectionString.Close();
		}

		public void Register(string Name, string Email, int PhoneNumber, string BirthDate, string Street, int HouseNumber, string City, string Country, string Zip, string UserName, string Password)
		{

			string idnumber = "Select count(*) from AspNetUsers";
			connectionString.Open();
			SqlDataAdapter sda = new SqlDataAdapter(idnumber, connectionString);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			int nr = Convert.ToInt32(dt.Rows[0][0]) + 1;
			connectionString.Close();

			using (connectionString)
			{
				string query = "insert into AspNetUsers (Id, Name, Email, PhoneNumber, BirthDate, StreetName, HouseNumber, City, Country, Zip, UserName, PasswordHash) values(@Id, @Name, @Email, @PhoneNumber, @BirthDate, @Street, @HouseNumber, @City, @Country, @Zip, @UserName, @Password)";
				connectionString.Open();
				using (SqlCommand cmd = new SqlCommand(query, connectionString))
				{
					cmd.Parameters.AddWithValue("@Id", nr);
					cmd.Parameters.AddWithValue("@Name", Name);
					
					cmd.Parameters.AddWithValue("@Email", Email);
					cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
					cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
					cmd.Parameters.AddWithValue("@Street", Street);
					cmd.Parameters.AddWithValue("@HouseNumber", HouseNumber);
					cmd.Parameters.AddWithValue("@City", City);
					cmd.Parameters.AddWithValue("@Country", Country);
					cmd.Parameters.AddWithValue("@Zip", Zip);
					cmd.Parameters.AddWithValue("@UserName", UserName);
					cmd.Parameters.AddWithValue("@Password", Password);


					cmd.ExecuteNonQuery();

					connectionString.Close();
				}
			}

		}

		public bool Login(string userName, string password)
		{
			bool correctLogin = false;
			string query = "SELECT COUNT(*) FROM AspNetUsers WHERE UserName='" + userName + "' AND PasswordHash='" + password + "'";
			SqlDataAdapter sda = new SqlDataAdapter(query, connectionString);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			if (dt.Rows[0][0].ToString() == "1")
			{
				correctLogin = true;
			}
			else correctLogin = false;

			return correctLogin;

		}
	}
}
