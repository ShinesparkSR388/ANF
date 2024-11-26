using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANF.Models
{
	public class __Rotacion
	{
		public double VentaTotal { get; set; }
		public double ActivoTotal { get; set; }
		public double ActivoFijo { get; set; }
		public double CostoVenta { get; set; }
		public double Inventario { get; set; }

		public __Rotacion() { }

		public double RotacionActivosTotales()
		{
			if (ActivoTotal == 0) return 0;
			return VentaTotal / ActivoTotal;
		}

		public double RotacionActivosFijos()
		{
			if (ActivoFijo == 0) return 0;
			return VentaTotal / ActivoFijo;
		}

		public double RotacionInventarios()
		{
			if (Inventario == 0) return 0;
			return CostoVenta / Inventario;
		}
	}

}
