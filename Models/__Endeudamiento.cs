using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANF.Models
{
	public class __Endeudamiento
	{
		public double PasivoTotal { get; set; }
		public double CapitalContable { get; set; }
		public double PasivoCortoPlazo { get; set; }
		public double PasivoLargoPlazo { get; set; }

		public double Activo{ get; set; }

		public __Endeudamiento() { }

		public double RatioDeEndeudamiento()
		{
			if (CapitalContable == 0) return 0;
			return PasivoTotal / CapitalContable;
		}

		public double EndeudamientoCortoPlazo()
		{
			if (CapitalContable == 0) return 0;
			return PasivoCortoPlazo / CapitalContable;
		}

		public double EndeudamientoLargoPlazo()
		{
			if (CapitalContable == 0) return 0;
			return PasivoLargoPlazo / CapitalContable;
		}

		public double RatioDePasivoSobreActivo()
		{
			if (Activo == 0) return 0;
			return PasivoTotal / Activo;
		}
	}

}
