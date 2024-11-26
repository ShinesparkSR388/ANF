using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANF.Models;
using System.Reflection;
using System.Collections;

namespace ANF.Logic
{
	public class QuerySql
	{
		SqlConexion connector;
		MySqlCommand cmd;

		public QuerySql() { 
			connector = new SqlConexion();
			cmd = new MySqlCommand();
			cmd.Connection = connector.Open();
		}

		//Transactions #################################################################################

		public List<Transaction> getTransactions()
		{
			List<Transaction> list = new List<Transaction>();
			cmd.CommandText = "SELECT * FROM transactions";

			try
			{
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					// Leer cada fila del resultado
					while (reader.Read())
					{
						// Crear una instancia de la clase del modelo
						Transaction data = new Transaction();

						// Mapear los datos del lector de MySQL a las propiedades del modelo
						foreach (PropertyInfo prop in typeof(Transaction).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							// Verificar si el lector tiene la columna correspondiente a la propiedad del modelo
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								// Asignar el valor del lector a la propiedad del modelo
								prop.SetValue(data, reader[prop.Name]);
							}
						}

						// Agregar la instancia del modelo a la lista
						list.Add(data);
					}
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return list;
		}
		public List<Transaction> getTransactionsByDepartureId(int idDeparture)
		{
			List<Transaction> list = new List<Transaction>();

			try
			{
				cmd.CommandText = "SELECT * FROM transactions WHERE idDeparture = ?IdDeparture";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?IdDeparture", MySqlDbType.Int32).Value = idDeparture;

				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Transaction data = new Transaction();

						foreach (PropertyInfo prop in typeof(Transaction).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}

						list.Add(data);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos" + ex.Message, "Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return list;
		}
		public List<Transaction> getTransactionsByCodeId(int code)
		{
			List<Transaction> list = new List<Transaction>();

			try
			{
				cmd.CommandText = "SELECT * FROM transactions WHERE CAST(Code AS CHAR) LIKE ?Code%";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Code", MySqlDbType.Int32).Value = code;

				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Transaction data = new Transaction();

						foreach (PropertyInfo prop in typeof(Transaction).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}

						list.Add(data);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos" + ex.Message, "Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return list;
		}

		public Transaction getTransaction(int id)
		{

			try
			{
				cmd.CommandText = $"SELECT * FROM transactions WHERE id = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Id", MySqlDbType.String).Value = id;
				Transaction data = new Transaction();
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						foreach (PropertyInfo prop in typeof(Transaction).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}

					}
				}
				return data;
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return null;
		}
		public Transaction getTransactionbyAccount(int id)
		{

			try
			{
				cmd.CommandText = $"SELECT * FROM transactions WHERE idAccount = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Id", MySqlDbType.String).Value = id;
				Transaction data = new Transaction();
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						foreach (PropertyInfo prop in typeof(Transaction).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}

					}
				}
				return data;
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return null;
		}
		public bool deleteTransaction(int id)
		{

			try
			{
				cmd.CommandText = $"DELETE FROM transactions WHERE id = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Id", MySqlDbType.String).Value = id;

				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					return true;
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return false;
		}
		public bool insertTransaction(Transaction model)
		{
			try
			{
				cmd.CommandText = $"INSERT INTO transactions(type, amount, idDeparture, idAccount) VALUES(?Type, ?Amount, ?IdDeparture, ?IdAccount)";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Type", MySqlDbType.Double).Value = model.Type;
				cmd.Parameters.Add("?Amount", MySqlDbType.Double).Value = model.Amount;
				cmd.Parameters.Add("?IdDeparture", MySqlDbType.Int32).Value = model.IdDeparture;
				cmd.Parameters.Add("?IdAccount", MySqlDbType.Int32).Value = model.IdAccount;

				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					return true;
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error al guardar los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
			}
			return false;
		}
		public bool updateTransaction(Transaction model)
		{
			try
			{
				cmd.CommandText = $"UPDATE transactions SET type = ?Type, amount = ?Amount, idDeparture = ?IdDeparture, idAccount = ?IdAccount WHERE id = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Type", MySqlDbType.Double).Value = model.Type;
				cmd.Parameters.Add("?Amount", MySqlDbType.Double).Value = model.Amount;
				cmd.Parameters.Add("?IdDeparture", MySqlDbType.Double).Value = model.IdDeparture;
				cmd.Parameters.Add("?IdAccount", MySqlDbType.Double).Value = model.IdAccount;
				cmd.Parameters.Add("?Id", MySqlDbType.Double).Value = model.Id;

				int rows = cmd.ExecuteNonQuery();
				if (rows > 0) { 
					return true;
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error al guardar los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}

		//END Transactions #################################################################################

		//Accounts #################################################################################

		public List<Account> getAccounts()
		{
			List<Account> list = new List<Account>();
			cmd.CommandText = "SELECT * FROM accounts";

			try
			{
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Account data = new Account();
						foreach (PropertyInfo prop in typeof(Account).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}
						list.Add(data);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return list;
		}
		public List<Account> getUsableAccounts()
		{
			List<Account> list = new List<Account>();
			cmd.CommandText = "SELECT * FROM accounts";

			try
			{
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						if (reader["code"].ToString().Length == 5)
						{
							Account data = new Account();
							foreach (PropertyInfo prop in typeof(Account).GetProperties())
							{
								if (!reader.HasColumn(prop.Name))
								{
									continue;
								}
								if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
								{
									prop.SetValue(data, reader[prop.Name]);
								}
							}
							list.Add(data);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return list;
		}

		public Account getAccount(int id)
		{
			try
			{
				cmd.CommandText = $"SELECT * FROM accounts WHERE id = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Id", MySqlDbType.String).Value = id;
				Account data = new Account();

				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						foreach (PropertyInfo prop in typeof(Account).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}
					}
				}
				return data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return null;
		}
		public Account getAccountByCode(string code)
		{
			try
			{
				cmd.CommandText = $"SELECT * FROM accounts WHERE code = ?Code";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Code", MySqlDbType.String).Value = code;
				Account data = new Account();

				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						foreach (PropertyInfo prop in typeof(Account).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}
					}
				}
				return data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return null;
		}
		public Account getAccountFKTransactions(int id)
		{
			try
			{
				cmd.CommandText = $"SELECT * FROM accounts WHERE id = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Id", MySqlDbType.String).Value = id;
				Account data = new Account();

				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						foreach (PropertyInfo prop in typeof(Account).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}
					}
				}
				return data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return null;
		}

		public bool deleteAccount(int id)
		{
			try
			{
				cmd.CommandText = $"DELETE FROM accounts WHERE id = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Id", MySqlDbType.String).Value = id;

				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return false;
		}

		public bool insertAccount(Account model)
		{
			try
			{
				cmd.CommandText = $"INSERT INTO accounts(description, code) VALUES(?Description, ?Code)";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Description", MySqlDbType.String).Value = model.Description;
				cmd.Parameters.Add("?Code", MySqlDbType.Int32).Value = model.Code;

				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return false;
		}

		public bool updateAccount(Account model)
		{
			try
			{
				cmd.CommandText = $"UPDATE accounts SET description = ?Description, code = ?Code WHERE id = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Description", MySqlDbType.String).Value = model.Description;
				cmd.Parameters.Add("?Code", MySqlDbType.Int32).Value = model.Code;
				cmd.Parameters.Add("?Id", MySqlDbType.Int32).Value = model.Id;

				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return false;
		}

		//END Accounts #################################################################################
		//Departures #################################################################################

		public List<Departure> getDepartures()
		{
			List<Departure> list = new List<Departure>();

			try
			{
				cmd.CommandText = "SELECT * FROM departures";
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Departure data = new Departure();
						foreach (PropertyInfo prop in typeof(Departure).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}
						list.Add(data);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return list;
		}

		public Departure getDeparture(int id)
		{
			try
			{
				cmd.CommandText = $"SELECT * FROM departures WHERE id = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Id", MySqlDbType.String).Value = id;
				Departure data = new Departure();

				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						foreach (PropertyInfo prop in typeof(Departure).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}
					}
				}
				return data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return new Departure(ex.Message, "","");
			}

			return null;
		}
		public Departure getDepartureFKTransactions(int id)
		{
			try
			{
				cmd.CommandText = $"SELECT * FROM departures WHERE id = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Id", MySqlDbType.String).Value = id;
				Departure data = new Departure();

				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						foreach (PropertyInfo prop in typeof(Departure).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)) && !typeof(IList).IsAssignableFrom(prop.PropertyType))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}
					}
				}
				cmd.CommandText = $"SELECT * FROM transactions WHERE idDeparture = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Id", MySqlDbType.String).Value = id;

				List<Transaction> list = new List<Transaction>();
				using (MySqlDataReader _reader = cmd.ExecuteReader())
				{
					// Leer cada fila del resultado
					while (_reader.Read())
					{
						// Crear una instancia de la clase del modelo
						Transaction dataTransaction = new Transaction();

						// Mapear los datos del lector de MySQL a las propiedades del modelo
						foreach (PropertyInfo prop in typeof(Transaction).GetProperties())
						{
							if (!_reader.IsDBNull(_reader.GetOrdinal(prop.Name)))
							{
								if (!_reader.HasColumn(prop.Name))
								{
									continue;
								}
								prop.SetValue(dataTransaction, _reader[prop.Name]);
							}
						}

						// Agregar la instancia del modelo a la lista
						list.Add(dataTransaction);
					}
				}
				data.Transactions = list;
				return data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Console.WriteLine(ex.ToString());
			}

			return null;
		}
		public List<Departure> getDeparturesFKTransactions()
		{

			List<Departure> list_ = new List<Departure>();
			try
			{
				cmd.CommandText = "SELECT * FROM departures";
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Departure data = new Departure();
						foreach (PropertyInfo prop in typeof(Departure).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}
						list_.Add(data);
					}
				}

                foreach (Departure item in list_)
                {
					cmd.CommandText = $"SELECT * FROM transactions WHERE idDeparture = ?Id";
					cmd.Parameters.Clear();
					cmd.Parameters.Add("?Id", MySqlDbType.String).Value = item.Id;

					List<Transaction> list = new List<Transaction>();
					using (MySqlDataReader _reader = cmd.ExecuteReader())
					{
						// Leer cada fila del resultado
						while (_reader.Read())
						{
							// Crear una instancia de la clase del modelo
							Transaction dataTransaction = new Transaction();

							// Mapear los datos del lector de MySQL a las propiedades del modelo
							foreach (PropertyInfo prop in typeof(Transaction).GetProperties())
							{
								if (!_reader.HasColumn(prop.Name))
								{
									continue;
								}
								if (!_reader.IsDBNull(_reader.GetOrdinal(prop.Name)))
								{
									prop.SetValue(dataTransaction, _reader[prop.Name]);
								}
							}

							// Agregar la instancia del modelo a la lista
							list.Add(dataTransaction);
						}
					}
					item.Transactions = list;
                    
                }
				return list_;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
				MessageBox.Show(ex.ToString());
			}

			return null;
		}

		public bool deleteDeparture(int id)
		{
			try
			{
				cmd.CommandText = $"DELETE FROM departures WHERE id = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Id", MySqlDbType.String).Value = id;

				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al eliminar los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return false;
		}

		public bool insertDeparture(Departure model)
		{
			try
			{
				cmd.CommandText = $"INSERT INTO departures(description, date, time) VALUES(?Description, ?Date, ?Time); SELECT LAST_INSERT_ID();";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Description", MySqlDbType.String).Value = model.Description;
				cmd.Parameters.Add("?Date", MySqlDbType.String).Value = model.Date;
				cmd.Parameters.Add("?Time", MySqlDbType.String).Value = model.Time;

				int insertedId = Convert.ToInt32(cmd.ExecuteScalar());
				if (model.Transactions != null) {
					foreach (Transaction transaction in model.Transactions) {
						transaction.IdDeparture = insertedId;
						insertTransaction(transaction);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return false;
		}

		public bool updateDeparture(Departure model)
		{
			try
			{
				cmd.CommandText = $"UPDATE departures SET description = ?Description, date = ?Date, time = ?Time WHERE id = ?Id";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Description", MySqlDbType.String).Value = model.Description;
				cmd.Parameters.Add("?Date", MySqlDbType.String).Value = model.Date;
				cmd.Parameters.Add("?Time", MySqlDbType.String).Value = model.Time;
				cmd.Parameters.Add("?Id", MySqlDbType.Int32).Value = model.Id;

				int rows = cmd.ExecuteNonQuery();
				if (rows > 0)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al guardar los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return false;
		}

		//END Departures #################################################################################

		//OTHER QUERY #################################################################################


		public double getAccountAmount(int code)
		{

			try
			{
				Account account = this.getAccountByCode(code.ToString());
				cmd.CommandText = $"SELECT * FROM transactions WHERE idAccount = ?IdAccount";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?IdAccount", MySqlDbType.Int32).Value = account.Id;
				double result = 0;
				string sts = account.Code.ToString().Substring(0, 1);
				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						if(Convert.ToInt32(reader["type"]) == 0)
						{
							if (sts.Equals("2") || sts.Equals("3") || sts.Equals("7"))
							{
								result = result + Convert.ToDouble(reader["amount"].ToString());
							}
							else {
								result = result - Convert.ToDouble(reader["amount"].ToString());
							}
						}
						else
						{
							if (sts.Equals("2") || sts.Equals("3") || sts.Equals("7"))
							{
								result = result - Convert.ToDouble(reader["amount"].ToString());
							}
							else
							{
								result = result + Convert.ToDouble(reader["amount"].ToString());
							}
						}
					}
				}
				return result;
			}
			catch (Exception ex)
			{

				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return 0.0;
		}

		public List<Departure> getDeparturesBetween(string start, string end)
		{
			List<Departure> list = new List<Departure>();

			try
			{
				cmd.CommandText = "SELECT SQL_NO_CACHE * FROM departures WHERE STR_TO_DATE(date, '%d-%m-%Y') BETWEEN STR_TO_DATE(@Start, '%d-%m-%Y') AND STR_TO_DATE(@End, '%d-%m-%Y')";
				cmd.Parameters.Clear();
				cmd.Parameters.Add("?Start", MySqlDbType.VarChar).Value = start;
				cmd.Parameters.Add("?End", MySqlDbType.VarChar).Value = end;

				using (MySqlDataReader reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						Departure data = new Departure();
						foreach (PropertyInfo prop in typeof(Departure).GetProperties())
						{
							if (!reader.HasColumn(prop.Name))
							{
								continue;
							}
							if (!reader.IsDBNull(reader.GetOrdinal(prop.Name)))
							{
								prop.SetValue(data, reader[prop.Name]);
							}
						}
						list.Add(data);
					}
				}
				foreach (Departure data in list)
				{

					data.Transactions = getTransactionsByDepartureId(data.Id);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al obtener los datos",
					"Error de solicitud", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return list;
		}

	}
}
