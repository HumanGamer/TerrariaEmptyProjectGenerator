using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaEmptyProjectGenerator
{
	public static class Config
	{
		public static string TerrariaDirectory => Config.GetVariable("TerrariaDir");

		public static string Author => Config.GetVariable("Author");

		public static string GetVariable(string name, string def = "")
		{
			using (Stream s = File.OpenRead(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt")))
			using (StreamReader sr = new StreamReader(s, Encoding.ASCII))
			{
				string contents = sr.ReadToEnd();

				string[] lines = contents.Split(new string[] {"\r\n", "\n"}, StringSplitOptions.RemoveEmptyEntries);

				foreach (var line in lines)
				{
					string[] parts = line.Split(new string[] {"="}, StringSplitOptions.RemoveEmptyEntries);

					if (parts.Length != 2)
						continue;

					string var = parts[0].Trim();
					string val = parts[1].Trim();

					if (!var.Equals(name, StringComparison.OrdinalIgnoreCase))
						continue;

					return val;
				}
			}

			return def;
		}
	}
}
