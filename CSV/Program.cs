using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace CSV
{
	class Program
	{
		public class Foo
		{
			public int Id { get; set; }
			public string Name { get; set; }
		}

		static void Main(string[] args)
		{
			var records = new List<Foo>
			{
				new Foo { Id = 1, Name = "one" },
				new Foo { Id = 2, Name = "two" },
			};


			
			//Пишем в файл
			using (var writer = new StreamWriter("file.csv"))
			using (var csv = new CsvWriter(writer))
			{
				csv.WriteRecords(records);
			}
			//Читаем из файла
			using (var reader = new StreamReader("file.csv"))
			using (var csv = new CsvReader(reader))
			{
				var records1 = csv.GetRecords<Foo>();
			}
			Console.ReadKey();
		}
	}
}
