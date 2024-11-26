using ANF.Logic;
using ANF.Models;
using ANF.Views.InternalViews;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ANF.Views
{
	public partial class financialStatementForm : Form
	{
		QuerySql data = new QuerySql();
		List<Departure> departures = new List<Departure>();
		List<Account> accounts = new List<Account>();
		List<__resTotal> res = new List<__resTotal>();
		double activo, activoCirculante, activoNoCirculante, pasivo, pasivoCirculante, pasivoNoCirculante, capital;

		//Estado de resultados
		List<__resTotal> resResult = new List<__resTotal>();

		//Razones propuestas
		__Endeudamiento endeudamiento = new __Endeudamiento();
		__Rotacion rotacion = new __Rotacion();
		public financialStatementForm()
		{
			InitializeComponent();
			departures = data.getDeparturesBetween(date_desde.Value.ToString("dd-MM-yyyy"), date_hasta.Value.ToString("dd-MM-yyyy"));
			accounts = data.getAccounts();
			getBetween();
			fillTableActivo();
			fillTablePasivo();
			fillTableCapital();
			updateBalance();

			//Estado de resultados

			getBetweenResult();
			fillTableResult();

			//propuestos
			endeudamiento.PasivoTotal = pasivo;
			endeudamiento.PasivoLargoPlazo = pasivoNoCirculante;
			endeudamiento.PasivoCortoPlazo = pasivoCirculante;
			endeudamiento.CapitalContable = capital;
			endeudamiento.Activo = activo;

			rotacion.ActivoTotal = activo;
			rotacion.ActivoFijo = activoNoCirculante;

		}
		private void getBetween()
		{
			foreach (var departure in departures)
			{
				foreach (var item in departure.Transactions)
				{
					foreach (var item1 in accounts)
					{

						if (item1.Id == item.IdAccount)
						{

							bool flag = false;
							int count = 0;
							string sts = item1.Code.ToString().Substring(0, 1);
							foreach (__resTotal itRes in res)
							{
								if (itRes.Account.Id == item.IdAccount)
								{
									flag = true;
									if (!item.Type)
									{
										if (sts.Equals("2") || sts.Equals("3"))
										{
											itRes.Total += item.Amount;
										}
										else if (sts.Equals("1"))
										{
											itRes.Total -= item.Amount;
										}
									}
									else
									{
										if (sts.Equals("2") || sts.Equals("3"))
										{
											itRes.Total -= item.Amount;
										}
										else if (sts.Equals("1"))
										{
											itRes.Total += item.Amount;
										}
									}
								}
							}
							if (!flag && (sts.Equals("2") || sts.Equals("3") || sts.Equals("1")))
							{
								__resTotal rs = new __resTotal();
								rs.Account = item1;
								rs.Code = item1.Code;
								res.Add(rs);

								if (!item.Type)
								{
									if (sts.Equals("2") || sts.Equals("3"))
									{
										rs.Total = item.Amount;
									}
									else if (sts.Equals("1"))
									{
										rs.Total = -item.Amount;
									}
								}
								else
								{
									if (sts.Equals("2") || sts.Equals("3"))
									{
										rs.Total = -item.Amount;
									}
									else if (sts.Equals("1"))
									{
										rs.Total = item.Amount;
									}
								}
							}

						}
					}
				}
			}
		}

		private void fillTableActivo()
		{
			tbl_activo.Rows.Clear();
			tbl_activo.Columns.Clear();

			tbl_activo.Columns.Add("code", "Codigo");
			tbl_activo.Columns["code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tbl_activo.Columns["code"].Width = Convert.ToInt32(tbl_capital.ClientSize.Width * 0.2);

			tbl_activo.Columns.Add("descripcion", "Descripcion");
			tbl_activo.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tbl_activo.Columns["descripcion"].Width = Convert.ToInt32(tbl_capital.ClientSize.Width * 0.6);

			tbl_activo.Columns.Add("monto", "Monto");
			tbl_activo.Columns["monto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tbl_activo.Columns["monto"].Width = Convert.ToInt32(tbl_capital.ClientSize.Width * 0.2);

			Account ac1 = data.getAccountByCode("1");
			Account ac2 = data.getAccountByCode("110");
			Account ac3 = data.getAccountByCode("111");
			tbl_activo.Rows.Add("", "", "");
			int rowIndex = tbl_activo.Rows.Add(ac1.Code, ac1.Description);
			tbl_activo.Rows[rowIndex].DefaultCellStyle.Font = new System.Drawing.Font(tbl_activo.Font, FontStyle.Bold); // Establece negrita en toda la fila
			tbl_activo.Rows.Add();
			int wr2 = tbl_activo.Rows.Add(ac2.Code, "   " + ac2.Description);
			tbl_activo.Rows[wr2].DefaultCellStyle.Font = new System.Drawing.Font(tbl_activo.Font, FontStyle.Italic);
			foreach (__resTotal item in res)
			{
				if (item.Code.ToString().Substring(0, 3).Equals("110"))
				{
					tbl_activo.Rows.Add(item.Code, "      " + item.Account.Description, "$" + item.Total);
					activoCirculante = activoCirculante + item.Total;
				}
			}
			tbl_activo.Rows.Add("Total", ac2.Description + "......", "$" + activoCirculante);
			tbl_activo.Rows.Add("", "", "");
			int rw3 = tbl_activo.Rows.Add(ac3.Code, "   " + ac3.Description);

			tbl_activo.Rows[rw3].DefaultCellStyle.Font = new System.Drawing.Font(tbl_activo.Font, FontStyle.Italic);
			foreach (__resTotal item in res)
			{
				if (item.Code.ToString().Substring(0, 3).Equals("111"))
				{
					tbl_activo.Rows.Add(item.Code, "      " + item.Account.Description, "$" + item.Total);
					activoNoCirculante = activoNoCirculante + item.Total;
				}
			}
			tbl_activo.Rows.Add("Total", ac3.Description + "......", "$" + activoNoCirculante);
			tbl_activo.Rows.Add("", "", "");
			foreach (__resTotal item in res)
			{
				if (item.Code.ToString().Equals("11011"))
				{
					rotacion.Inventario = item.Total;
				}
			}

		}
		private void fillTablePasivo()
		{
			tbl_pasivo.Rows.Clear();
			tbl_pasivo.Columns.Clear();

			tbl_pasivo.Columns.Add("code", "Codigo");
			tbl_pasivo.Columns["code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tbl_pasivo.Columns["code"].Width = Convert.ToInt32(tbl_capital.ClientSize.Width * 0.2);

			tbl_pasivo.Columns.Add("descripcion", "Descripcion");
			tbl_pasivo.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tbl_pasivo.Columns["descripcion"].Width = Convert.ToInt32(tbl_capital.ClientSize.Width * 0.6);

			tbl_pasivo.Columns.Add("monto", "Monto");
			tbl_pasivo.Columns["monto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tbl_pasivo.Columns["monto"].Width = Convert.ToInt32(tbl_capital.ClientSize.Width * 0.2);

			Account ac1 = data.getAccountByCode("2");
			Account ac2 = data.getAccountByCode("220");
			Account ac3 = data.getAccountByCode("221");

			tbl_pasivo.Rows.Add("", "", "");
			int rowIndex = tbl_pasivo.Rows.Add(ac1.Code, ac1.Description);
			tbl_pasivo.Rows[rowIndex].DefaultCellStyle.Font = new System.Drawing.Font(tbl_pasivo.Font, FontStyle.Bold);

			tbl_pasivo.Rows.Add();
			int wr2 = tbl_pasivo.Rows.Add(ac2.Code, "   " + ac2.Description);
			tbl_pasivo.Rows[wr2].DefaultCellStyle.Font = new System.Drawing.Font(tbl_pasivo.Font, FontStyle.Italic);

			foreach (__resTotal item in res)
			{
				if (item.Code.ToString().Substring(0, 3).Equals("220"))
				{
					tbl_pasivo.Rows.Add(item.Code, "      " + item.Account.Description, "$" + item.Total);
					pasivoCirculante += item.Total;
				}
			}
			tbl_pasivo.Rows.Add("Total", ac2.Description + "......", "$" + pasivoCirculante);
			tbl_pasivo.Rows.Add("", "", "");

			int rw3 = tbl_pasivo.Rows.Add(ac3.Code, "   " + ac3.Description);
			tbl_pasivo.Rows[rw3].DefaultCellStyle.Font = new System.Drawing.Font(tbl_pasivo.Font, FontStyle.Italic);

			foreach (__resTotal item in res)
			{
				if (item.Code.ToString().Substring(0, 3).Equals("221"))
				{
					tbl_pasivo.Rows.Add(item.Code, "      " + item.Account.Description, "$" + item.Total);
					pasivoNoCirculante += item.Total;
				}
			}
			tbl_pasivo.Rows.Add("Total", ac3.Description + "......", "$" + pasivoNoCirculante);
			tbl_pasivo.Rows.Add("", "", "");
		}
		private void fillTableCapital()
		{
			tbl_capital.Rows.Clear();
			tbl_capital.Columns.Clear();

			tbl_capital.Columns.Add("code", "Codigo");
			tbl_capital.Columns["code"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tbl_capital.Columns["code"].Width = Convert.ToInt32(tbl_capital.ClientSize.Width * 0.2);

			tbl_capital.Columns.Add("descripcion", "Descripcion");
			tbl_capital.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tbl_capital.Columns["descripcion"].Width = Convert.ToInt32(tbl_capital.ClientSize.Width * 0.6);

			tbl_capital.Columns.Add("monto", "Monto");
			tbl_capital.Columns["monto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tbl_capital.Columns["monto"].Width = Convert.ToInt32(tbl_capital.ClientSize.Width * 0.2);
			Account ac1 = data.getAccountByCode("3");
			Account ac2 = data.getAccountByCode("330");
			tbl_capital.Rows.Add("", "", "");
			int rowIndex = tbl_capital.Rows.Add(ac1.Code, ac1.Description);
			tbl_capital.Rows[rowIndex].DefaultCellStyle.Font = new System.Drawing.Font(tbl_capital.Font, FontStyle.Bold); // Establece negrita en toda la fila
			tbl_capital.Rows.Add();
			int wr2 = tbl_capital.Rows.Add(ac2.Code, "   " + ac2.Description);
			tbl_capital.Rows[wr2].DefaultCellStyle.Font = new System.Drawing.Font(tbl_capital.Font, FontStyle.Italic);

			foreach (__resTotal item in res)
			{
				if (item.Code.ToString().Substring(0, 3).Equals("330"))
				{
					tbl_capital.Rows.Add(item.Code, "      " + item.Account.Description, "$" + item.Total);
					capital = capital + item.Total;
				}
			}
			tbl_capital.Rows.Add("Total", ac2.Description + "......", "$" + capital);
			tbl_capital.Rows.Add("", "", "");
		}

		void updateBalance()
		{
			activo = activoCirculante + activoNoCirculante;
			pasivo = pasivoCirculante + pasivoNoCirculante;
			txtBalance.Text = "(ACTIVO)$" + activo + " = (PASIVO)$" + pasivo + " + (CAPITAL)$" + capital;
		}

		// ESTADO DE RESULTADOS

		private void getBetweenResult()
		{
			foreach (var departure in departures)
			{
				foreach (var item in departure.Transactions)
				{
					foreach (var item1 in accounts)
					{

						if (item1.Id == item.IdAccount)
						{

							bool flag = false;
							int count = 0;
							string sts = item1.Code.ToString().Substring(0, 2);
							foreach (__resTotal itRes in resResult)
							{
								if (itRes.Code == item1.Code)
								{
									flag = true;
									if (!item.Type)
									{
										if (sts.Equals("66") || sts.Equals("77"))
										{
											itRes.Total = +item.Amount;
										}
										else if (sts.Equals("55"))
										{
											itRes.Total = -item.Amount;
										}
									}
									else
									{
										if (sts.Equals("66") || sts.Equals("77"))
										{
											itRes.Total = -item.Amount;
										}
										else if (sts.Equals("55"))
										{
											itRes.Total = +item.Amount;
										}
									}
								}
								count++;
							}
							if (!flag && (sts.Equals("55") || sts.Equals("66") || sts.Equals("77")))
							{
								__resTotal rs = new __resTotal();
								rs.Account = item1;
								rs.Code = item1.Code;
								resResult.Add(rs);

								if (!item.Type)
								{
									if (sts.Equals("66") || sts.Equals("77"))
									{
										rs.Total = item.Amount;
									}
									else if (sts.Equals("55"))
									{
										rs.Total = -item.Amount;
									}
								}
								else
								{
									if (sts.Equals("66") || sts.Equals("77"))
									{
										rs.Total = -item.Amount;
									}
									else if (sts.Equals("55"))
									{
										rs.Total = item.Amount;
									}
								}
							}


						}
					}
				}
			}
		}


		private void fillTableResult()
		{
			tbl_result.Rows.Clear();
			tbl_result.Columns.Clear();

			tbl_result.Columns.Add("descripcion", "Descripcion");
			tbl_result.Columns["descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tbl_result.Columns["descripcion"].Width = Convert.ToInt32(tbl_capital.ClientSize.Width * 0.6);

			tbl_result.Columns.Add("monto", "Monto");
			tbl_result.Columns["monto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			tbl_result.Columns["monto"].Width = Convert.ToInt32(tbl_capital.ClientSize.Width * 0.4);

			double ventas = 0.0;
			double costoVentas = 0.0;
			double gastosOperacion = 0.0;
			double ingresosFinancieros = 0.0;
			double gastosFinancieros = 0.0;

			foreach (__resTotal item in resResult)
			{
				int code = item.Code;

				// Ventas Netas
				if (code / 1000 == 66)
				{
					ventas += item.Total;
				}

				if (code == 55002)
				{
					costoVentas += item.Total;
				}

				// Gastos de Operación
				if (code == 55004 || code == 55005 || code == 55006 || code == 55007)
				{
					gastosOperacion += item.Total;
				}

				// Gastos Financieros
				if (code == 66001)
				{
					gastosFinancieros += item.Total;
				}

				// Ingresos Financieros
				if (code / 1000 == 77)
				{
					ingresosFinancieros += item.Total;
				}
			}

			// Cálculos adicionales
			double utilidadBruta = ventas - costoVentas;
			double utilidadOperativa = utilidadBruta - gastosOperacion;
			double utilidadAntesImpuestos = utilidadOperativa + ingresosFinancieros - gastosFinancieros;

			// Imprimir en la tabla
			int d1 = tbl_result.Rows.Add("   " + "Ventas netas", "    $" + ventas);
			tbl_result.Rows[d1].DefaultCellStyle.Font = new System.Drawing.Font(tbl_result.Font, FontStyle.Bold);
			foreach (__resTotal item in resResult)
			{
				int code = item.Code;
				// Ventas Netas
				if (code / 1000 == 66)
				{
					tbl_result.Rows.Add("        " + item.Account.Description, "$" + costoVentas);
				}
			}
			// Imprimir en la tabla
			int d2 = tbl_result.Rows.Add("   " + "Costo de Ventas", "    $" + costoVentas);
			tbl_result.Rows[d2].DefaultCellStyle.Font = new System.Drawing.Font(tbl_result.Font, FontStyle.Bold);
			foreach (__resTotal item in resResult)
			{
				int code = item.Code;
				if (code == 55002)
				{
					tbl_result.Rows.Add("        " + item.Account.Description, "$" + item.Total);
				}
			}
			// Imprimir en la tabla
			int d3 = tbl_result.Rows.Add("   " + "Gastos de Operación", "    $" + gastosOperacion);
			tbl_result.Rows[d3].DefaultCellStyle.Font = new System.Drawing.Font(tbl_result.Font, FontStyle.Bold);
			foreach (__resTotal item in resResult)
			{
				int code = item.Code;
				if (code == 55004 || code == 55005 || code == 55006 || code == 55007)
				{
					tbl_result.Rows.Add("        " + item.Account.Description, "$" + item.Total);
				}
			}
			// Imprimir en la tabla
			int d4 = tbl_result.Rows.Add("   " + "Ingresos Financieros", "    $" + ingresosFinancieros);
			tbl_result.Rows[d4].DefaultCellStyle.Font = new System.Drawing.Font(tbl_result.Font, FontStyle.Bold);
			foreach (__resTotal item in resResult)
			{
				int code = item.Code;
				if (code / 1000 == 77)
				{
					tbl_result.Rows.Add("        " + item.Account.Description, "$" + item.Total);
				}
			}
			// Imprimir en la tabla
			int d5 = tbl_result.Rows.Add("   " + "Gastos Financieros", "    $" + gastosFinancieros);
			tbl_result.Rows[d5].DefaultCellStyle.Font = new System.Drawing.Font(tbl_result.Font, FontStyle.Bold);
			foreach (__resTotal item in resResult)
			{
				int code = item.Code;
				if (code == 66001)
				{
					tbl_result.Rows.Add("        " + item.Account.Description, "$" + item.Total);
				}
			}
			tbl_result.Rows.Add("Utilidad antes de Impuestos", "$" + ((ventas - costoVentas - gastosOperacion) + ingresosFinancieros - gastosFinancieros));

			tbl_result.Rows.Add();

			double tasaImpuestos = 0.16; // 16% de impuestos
			double impuestos = utilidadAntesImpuestos * tasaImpuestos;
			double utilidadNeta = utilidadAntesImpuestos - impuestos;
			int d6 = tbl_result.Rows.Add("   " + "Utilidad Neta", "$" + utilidadNeta);
			tbl_result.Rows[d6].DefaultCellStyle.Font = new System.Drawing.Font(tbl_result.Font, FontStyle.Bold);
			label5.Text = "(ACTIVO NETO) = $" + utilidadNeta;
			rotacion.CostoVenta = costoVentas;
			rotacion.VentaTotal = ventas;

		}

		public void ExportDataGridViewsToPDF(List<DataGridView> dataGrids, List<string> titles, string filePath)
		{
			int count = 0;
			Document document = new Document();
			PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
			document.Open();

			foreach (DataGridView dgv in dataGrids)
			{
				PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);

				foreach (DataGridViewColumn column in dgv.Columns)
				{
					PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
					pdfTable.AddCell(cell);
				}

				foreach (DataGridViewRow row in dgv.Rows)
				{
					foreach (DataGridViewCell cell in row.Cells)
					{
						if (cell.Value != null)
							pdfTable.AddCell(cell.Value.ToString());
					}
				}

				document.Add(new Paragraph(titles[count]));
				document.Add(new Paragraph("\n"));
				document.Add(pdfTable);
				document.Add(new Paragraph("\n")); // Agrega espacio entre tablas
				count++;
			}

			document.Close();
		}

		private void date_desde_ValueChanged(object sender, EventArgs e)
		{
			activo = 0;
			activoCirculante = 0;
			activoNoCirculante = 0;
			pasivo = pasivoCirculante = 0;
			pasivoNoCirculante = capital = 0;
			res = new List<__resTotal>();
			resResult = new List<__resTotal>();
			departures = data.getDeparturesBetween(date_desde.Value.ToString("dd-MM-yyyy"), date_hasta.Value.ToString("dd-MM-yyyy"));
			getBetween();
			fillTableActivo();
			fillTablePasivo();
			fillTableCapital();
			updateBalance();

			//Estado de resultados

			getBetweenResult();
			fillTableResult();
			//propuestos
			endeudamiento.PasivoTotal = pasivo;
			endeudamiento.PasivoLargoPlazo = pasivoNoCirculante;
			endeudamiento.PasivoCortoPlazo = pasivoCirculante;
			endeudamiento.CapitalContable = capital;

			rotacion.ActivoTotal = activo;
			rotacion.ActivoFijo = activoNoCirculante;

		}

		private void date_hasta_ValueChanged(object sender, EventArgs e)
		{

			activo = 0;
			activoCirculante = 0;
			activoNoCirculante = 0;
			pasivo = pasivoCirculante = 0;
			pasivoNoCirculante = capital = 0;
			res = new List<__resTotal>();
			resResult = new List<__resTotal>();
			departures = data.getDeparturesBetween(date_desde.Value.ToString("dd-MM-yyyy"), date_hasta.Value.ToString("dd-MM-yyyy"));
			getBetween();
			fillTableActivo();
			fillTablePasivo();
			fillTableCapital();
			updateBalance();

			//Estado de resultados

			getBetweenResult();
			fillTableResult();
			//propuestos
			endeudamiento.PasivoTotal = pasivo;
			endeudamiento.PasivoLargoPlazo = pasivoNoCirculante;
			endeudamiento.PasivoCortoPlazo = pasivoCirculante;
			endeudamiento.CapitalContable = capital;

			rotacion.ActivoTotal = activo;
			rotacion.ActivoFijo = activoNoCirculante;
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			using (analysisForm searchForm = new analysisForm(endeudamiento, rotacion))
			{
				if (searchForm.ShowDialog() == DialogResult.OK)
				{
					int selectedValue = searchForm.Result;
					// Utiliza el valor seleccionado
					Account acount = data.getAccount(selectedValue);

				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SaveFileDialog guardarDialogo = new SaveFileDialog
			{
				Filter = "PDF Files|*.pdf",
				Title = "Guardar como PDF",
				FileName = "Informe_general.pdf"
			};

			if (guardarDialogo.ShowDialog() == DialogResult.OK)
			{
				ExportDataGridViewsToPDF(new List<DataGridView>([tbl_activo,tbl_pasivo,tbl_capital,tbl_result]),new List<string>(["Activo","Pasivo","Capital","Estado de resultados"]), guardarDialogo.FileName);
				MessageBox.Show("Archivo PDF generado con éxito.");
			}
		}
	}
}
