﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANF.Logic
{
	public static class MySqlDataReaderExtensions
	{
		public static bool HasColumn(this MySqlDataReader reader, string columnName)
		{
			for (int i = 0; i < reader.FieldCount; i++)
			{
				if (reader.GetName(i).Equals(columnName, StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
			return false;
		}
	}

}
