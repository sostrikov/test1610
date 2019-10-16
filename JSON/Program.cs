using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON
{

	public class data
	{
		public int Id { get; set; }
		public int SSN { get; set; }
		public string Message { get; set; }

	}
	class Program
	{
		static void Main(string[] args)
		{

			List<data> _data = new List<data>();
			_data.Add(new data()
			{
				Id = 1,
				SSN = 2,
				Message = "A Message"
			});

			using (StreamWriter file = File.CreateText(@"D:\Git\15102019.json"))
			{
				JsonSerializer serializer = new JsonSerializer();

				//serialize object directly into file stream
				serializer.Serialize(file, _data);
			}

			
		}
	}
}
