using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace KickOffVariante1.Properties
{
	public  class Impresora
	{
		IFormat shortform = new ShortFormatPrinter();
		IFormat longform = new LongFormatPrinter();
		
		private readonly int _length = 26;
		private StreamReader _arg { get; set; }
		public void Imprimir(string[] comandos)
		{
			
			String line;
			try
			{
				//StreamReader sr = new StreamReader(@"C:\Users\Ruslan\Programacion\txt\archivo.txt");
				StreamReader sr = new StreamReader(@"..\txt\archivo.txt");

				_arg = sr;
				line = sr.ReadLine();

				if (line.Length > _length || line.Length < _length)
				{
					while (line != null)
					{
						//Registro r = new Registro(line);

						Formato bbb = new Formato(line, comandos);
						bbb.Impiresosososra();
						Console.WriteLine("\n");

						line = sr.ReadLine();
					}

					sr.Close();

				}
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: " + e.Message);
			}
			finally
			{
				Console.WriteLine("Fin de la ejecucion");
			}
		}
	}
}
