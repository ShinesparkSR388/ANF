using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANF.Logic
{

	public class SqlConexion
	{
		private string connectionString = "Server=localhost;Port=3306;Database=anf;Uid=root;password=;";
		MySqlConnection conexion;
		public SqlConexion() { 
			conexion = new MySqlConnection(connectionString);
		}
		public MySqlConnection Open()
		{
			try
			{
				if (conexion.State == System.Data.ConnectionState.Closed)
				{
					conexion.Open();
				}
				return conexion;
			}
			catch (Exception ex)
			{
				
					MessageBox.Show("Error al conectar a la base de datos, por favor verifique la conexión del servidor",
						"Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
				return null;

			}
		}
		public void Close() {

			if (conexion.State == System.Data.ConnectionState.Open)
			{
				conexion.Close();
			}

		}

	}
}
