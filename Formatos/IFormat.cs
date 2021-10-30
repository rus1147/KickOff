using System;
using System.Collections.Generic;
using System.Text;

namespace KickOffVariante1
{
	public interface IFormat
	{
		string Format(Registro registro);

		IList<string> Format(IList<Registro> registros);
	}
}
