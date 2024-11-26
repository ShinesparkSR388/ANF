using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANF.Models
{
	public class Account
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public int Code { get; set; }
		
		public Account() { }

		public Account(string description, int code)
		{
			Description = description;
			Code = code;
		}
	}
}
