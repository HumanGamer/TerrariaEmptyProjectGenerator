using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TerrariaEmptyProjectGenerator
{
    public class Solution
    {
	    public string Name
	    {
		    get;
		    protected set;
		}

	    public string Guid
	    {
		    get;
		    protected set;
		}

	    public string ProjectsDirectory { get; set; }

	    public List<CSharpProject> Projects;

	    public Solution(string name)
	    {
		    Name = name;
			Guid = "{" + System.Guid.NewGuid().ToString().ToUpper() + "}";
			ProjectsDirectory = "";
			Projects = new List<CSharpProject>();
	    }

	    public void SaveSolution(string dir)
	    {
			using (Stream s = File.Open(Path.Combine(dir, Name + ".sln"), FileMode.Create))
			using (StreamWriter sw = new StreamWriter(s, Encoding.UTF8))
			{
				sw.WriteLine();
				sw.WriteLine("Microsoft Visual Studio Solution File, Format Version 12.00");
				sw.WriteLine("# Visual Studio 15");
				sw.WriteLine("VisualStudioVersion = 15.0.27130.2027");
				sw.WriteLine("MinimumVisualStudioVersion = 10.0.40219.1");

				foreach (var project in Projects)
				{
					sw.WriteLine("Project(\"" + CSharpProject.ProjectTypeGuid + "\") = \"" + project.Name + "\", \"" + Path.Combine(project.Directory, project.Name + ".csproj") + "\", \"" + project.Guid + "\"");
					sw.WriteLine("EndProject");
				}

				sw.WriteLine("Global");
				sw.WriteLine("\tGlobalSection(SolutionConfigurationPlatforms) = preSolution");
				sw.WriteLine("\t\tDebug|Any CPU = Debug|Any CPU");
				sw.WriteLine("\t\tRelease|Any CPU = Release|Any CPU");
				sw.WriteLine("\tEndGlobalSection");

				sw.WriteLine("\tGlobalSection(ProjectConfigurationPlatforms) = postSolution");

				foreach (var project in Projects)
				{
					sw.WriteLine("\t\t" + project.Guid + ".Debug|Any CPU.ActiveCfg = Debug|Any CPU");
					sw.WriteLine("\t\t" + project.Guid + ".Debug|Any CPU.Build.0 = Debug|Any CPU");
					sw.WriteLine("\t\t" + project.Guid + ".Release|Any CPU.ActiveCfg = Release|Any CPU");
					sw.WriteLine("\t\t" + project.Guid + ".Release|Any CPU.Build.0 = Release|Any CPU");
				}
				
				sw.WriteLine("\tEndGlobalSection");

				sw.WriteLine("\tGlobalSection(SolutionProperties) = postSolution");
				sw.WriteLine("\t\tHideSolutionNode = FALSE");
				sw.WriteLine("\tEndGlobalSection");

				sw.WriteLine("\tGlobalSection(ExtensibilityGlobals) = postSolution");
				sw.WriteLine("\t\tSolutionGuid = " + Guid);
				sw.WriteLine("\tEndGlobalSection");

				sw.WriteLine("EndGlobal");
			}
	    }
    }
}
