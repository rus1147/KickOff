using System;
using System.Collections.Generic;
using System.Text;

namespace KickOffVariante1
{
	public class ShortFormatPrinter : IFormat
	{
		private List<string> listaderegistros = new List<string>();

		public string Format(Registro registro)
		{
			string HoraReg = registro.GetHora();
			string hora = HoraReg.Substring(0, 2);
			string min = HoraReg.Substring(3, 2);
			string seg = HoraReg.Substring(6, 2);
			string res= "Fecha/Hora registro: " + registro.GetFecha() + " " + hora + ":" + min + ":" + seg + "\n" +
					"Temperatura: " + registro.GetTemperatura() + '°' + "\n" +
					"Humedad: " + registro.GetHumedad() + '%' + "\n" +
					"Código: " + registro.GetCodigoSensor() + "\n" +
					"Activo: " + registro.GetEstado();
			return res;
		}

		public IList<string> Format(IList<Registro> registros)
		{
			foreach (Registro reg in registros)
			{
				string registro = this.Format(reg);
				listaderegistros.Add(registro);
			}
			return listaderegistros;
		}
	}

}

//faltaria ver como hacer con datetime y parsear a string
