using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrariaEmptyProjectGenerator
{
	public class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MainForm mainForm = new MainForm();
			if (args.Length > 0)
			{
				mainForm.BaseDirectory = Path.GetFullPath(args[0]);
			}
			else
			{
				mainForm.BaseDirectory = Environment.CurrentDirectory;
			}

			Application.Run(mainForm);
		}
	}
}
