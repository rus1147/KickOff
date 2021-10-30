using System;
using System.Collections.Generic;
using System.Text;

namespace KickOffVariante1
{
	public class Formato
	{
		IFormat shortform = new ShortFormatPrinter();
		IFormat longform = new LongFormatPrinter();
		private string _parametroformato;
		private string[] _arg;
		public Formato(string linea, string[] arg)
		{
			_parametroformato = linea;
			_arg = arg;
		}
		public void Impiresosososra()
		{
			Registro r = new Registro(_parametroformato);
			if (_arg.Length == 1)
			{
				try
				{
					if (_arg[0] == "longformat")

						Console.WriteLine(longform.Format(r));

					else if (_arg[0] == "shortformat")
					{
						Console.WriteLine(
						shortform.Format(r));

					}
				}
				catch
				{
					Console.WriteLine(longform.Format(r));
				}
			}
		}
	}
}
