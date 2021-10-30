using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using KickOffVariante1.Properties;
namespace KickOffVariante1
{
	public class Program
	{
		static void Main(string[] args)
		{
			Impresora b = new Impresora();
			b.Imprimir(args);
		}
	}
}
// input entrada 20211121231110123456AC1C1
// input entrada 2021 11 21 -- 23 11 10 --12,3 -- 45,6-- AC1C --1 
// input entrada 0123 45 67 -- 89 1011 1213 -- 1415,16-- 1718,19-- 20212223--25 
// 01:23:45
// 01234567

