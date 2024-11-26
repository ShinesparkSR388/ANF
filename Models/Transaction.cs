using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANF.Models
{
	public class Transaction
	{
		public int Id { get; set; }
		public bool Type { get; set; }
		public double Amount { get; set; }
		public int IdDeparture { get; set; }
		public int IdAccount { get; set; }
		public Account Account_ { get; set; }
		public Departure Departure_ { get; set; }
		public Transaction() { }

		public Transaction(bool type, double amount, int idDeparture, int idAccount)
		{
			Type = type;
			Amount = amount;
			IdDeparture = idDeparture;
			IdAccount = idAccount;
		}
	}
}
