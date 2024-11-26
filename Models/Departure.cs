using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANF.Models
{
	public class Departure
	{
		public int Id { get; set;}
		public string Description {get; set;}
		public string Date {get; set;}
		public string Time {get; set;}
		public List<Transaction>? Transactions {get; set;}
		public Departure() { }

		public Departure(string description, string date, string time)
		{
			Description = description;
			Date = date;
			Time = time;
		}
	}
}
