using System;
using System.Collections.Generic;
using System.Text;


namespace KickOffVariante1
{
	public class LongFormatPrinter : IFormat
	{
		private List<string> listaderegistros = new List<string>();
		public string Format(Registro registro)
		{
			string HoraReg = registro.GetHora();
			string hora = HoraReg.Substring(0, 2);
			string min = HoraReg.Substring(3, 2);
			string seg = HoraReg.Substring(6, 2);
			string res = "Fecha del registro: " + registro.GetFecha() + "\n" +
					"Hora del registro: " + hora + "Hs " + min + "Min " + seg + "Seg" + "\n" +
					"Temperatura: " + registro.GetTemperatura() + '°' + "\n" +
					"Humedad: " + registro.GetHumedad() + '%' + "\n" +
					"Código: " + registro.GetCodigoSensor() + "\n" +
					"Estado: " + registro.GetEstado();
			return res;
		}

		public IList<string> Format(IList<Registro> registros)
		{
			foreach(Registro reg in registros)
			{
				string registro = this.Format(reg);
				listaderegistros.Add(registro);
			}
			return listaderegistros;
		}
	}
}
