using System;
using System.Collections.Generic;
using System.Text;

namespace KickOffVariante1
{
	public  class Registro
	{
		private string _fechaRegistro { get; set; }
		private string _horaRegistro { get; set; }

		private string _temperatura { get; set; }
		private string _humedad { get; set; }
		private string _codigoSensor { get; set; }
		private string _estado { get; set; }

		private string _input;

		internal Registro(string input)
		{
			_input = input;
		}
		private void FormatoFecha()
		{
			string fecha = _input.Substring(0, 8);
			string año = fecha.Substring(0, 4);
			string mes = fecha.Substring(4, 2);
			string dia = fecha.Substring(6, 2);
			string fechacompleta = año + "/" + mes + "/" + dia;
			_fechaRegistro = fechacompleta;
		}
		public string GetFecha()
		{
			FormatoFecha();
			return _fechaRegistro;
		}
		private void FormatoHoraRegistro()
		{
			string horaRegistro = _input.Substring(8, 6);
			string hora = horaRegistro.Substring(0, 2);
			string min = horaRegistro.Substring(2, 2);
			string seg = horaRegistro.Substring(4, 2);
			string format = hora + ":" + min + ":" + seg;
			_horaRegistro = format;
		}
		public string GetHora()
		{
			FormatoHoraRegistro();
			return _horaRegistro;
		}
		private void FormatoTemperatura()
		{
			string temperatura = _input.Substring(14, 3);
			temperatura = temperatura.Insert(2, ",");
			_temperatura = temperatura;
		}
		public string GetTemperatura()
		{
			FormatoTemperatura();
			return _temperatura;
		}
		private void FormatoHumedad()
		{
			string humedad = _input.Substring(17, 3);
			humedad = humedad.Insert(2, ",");
			_humedad = humedad;
		}
		public string GetHumedad()
		{
			FormatoHumedad();
			return _humedad;
		}
		private void CodigoSensor()
		{
			string codigoSensor = _input.Substring(20, 4);
			_codigoSensor = codigoSensor;
		}
		public string GetCodigoSensor()
		{
			CodigoSensor();
			return _codigoSensor;
		}
		private void Estado()
		{
			string estado = _input.Substring(24);
			switch (estado)
			{
				case "0":
					_estado = "NO";
					break;
				case "1":
					_estado = "SI";
					break;
				default:
					throw new ArgumentException("Error");
			}
		}
		public string GetEstado()
		{
			Estado();
			return _estado;
		}
	}
}
// input entrada 20211121231110123456AC1C1
// input entrada 2021 11 21 -- 23 11 10 --12,3 -- 45,6-- AC1C --1 
// input entrada 0123 45 67 -- 89 1011 1213 -- 1415,16-- 1718,19-- 20212223--25 

