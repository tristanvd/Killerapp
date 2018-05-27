using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
	public class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string UserName { get; set; }
		public decimal Balance { get; set; }

		public User (int id, string name, string username, decimal balance)
		{
			Id = id;
			Name = name;
			UserName = username;
			Balance = balance;
		}
	}
}
