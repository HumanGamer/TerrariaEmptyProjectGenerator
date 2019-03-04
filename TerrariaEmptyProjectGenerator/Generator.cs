using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerrariaEmptyProjectGenerator
{
	public class Generator
	{
		public string Path
		{
			get;
		}

		public string Name
		{
			get;
			private set;
		}

		public string ID
		{
			get;
			private set;
		}

		public Generator(string path, string name, string id)
		{
			Path = path;
			Name = name;
			ID = id;
		}

		public void Generate()
		{
			GenerateProject();
			GenerateBuildTxt();
			GenerateDescription();
		}

		private void GenerateProject()
		{
			Solution solution = new Solution(ID);
			CSharpProject project = new CSharpProject(ID);
			project.Directory = ID;
			project.Files.Add("build.txt");
			project.Files.Add("description.txt");
			project.TMLServerPath = System.IO.Path.Combine(Config.TerrariaDirectory, "tModLoaderServer.exe").Replace("/", "\\");
			project.SaveProject(Path, Config.TerrariaDirectory);
			solution.Projects.Add(project);
			solution.SaveSolution(Path);
		}

		private void GenerateBuildTxt()
		{
			using (Stream s = File.Open(System.IO.Path.Combine(Path, ID, "build.txt"), FileMode.Create))
			using (StreamWriter sw = new StreamWriter(s))
			{
				sw.WriteLine("author = " + Config.Author);
				sw.WriteLine("version = 0.1");
				sw.WriteLine("displayName = " + Name);
			}
		}

		private void GenerateDescription()
		{
			using (Stream s = File.Open(System.IO.Path.Combine(Path, ID, "description.txt"), FileMode.Create))
			using (StreamWriter sw = new StreamWriter(s))
			{
				sw.WriteLine("Sample Description...");
			}
		}
	}
}
