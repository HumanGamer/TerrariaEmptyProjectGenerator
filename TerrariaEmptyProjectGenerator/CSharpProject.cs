using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TerrariaEmptyProjectGenerator
{
	public class CSharpProject
	{
		public const string ProjectTypeGuid = "{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}";

		public string Name
		{
			get;
			protected set;
		}

		public string Directory { get; set; }

		public string Guid
		{
			get;
			protected set;
		}

		public string TMLServerPath
		{
			get;
			set;
		}

		public List<string> Files;

		public List<string> References;

		public CSharpProject(string name)
		{
			Name = name;
			Guid = "{" + System.Guid.NewGuid().ToString().ToUpper() + "}";
			Directory = "";
			TMLServerPath = "";
			Files = new List<string>();
			References = new List<string>();
			References.Add("System");
			References.Add("System.Core");
			References.Add("Microsoft.Xna.Framework");
			References.Add("Microsoft.Xna.Framework.Game");
			References.Add("Microsoft.Xna.Framework.Graphics");
			References.Add("Microsoft.Xna.Framework.Xact");
			References.Add("Terraria");
			References.Add("Microsoft.CSharp");
		}

		public void SaveProject(string dir, string referenceDirectory = null)
		{
			if (!System.IO.Directory.Exists(Path.Combine(dir, Directory)))
				System.IO.Directory.CreateDirectory(Path.Combine(dir, Directory));
			if (referenceDirectory == null)
				referenceDirectory = "";
			using (Stream s = File.Open(Path.Combine(dir, Directory, Name + ".csproj"), FileMode.Create))
			using (StreamWriter sw = new StreamWriter(s, Encoding.UTF8))
			{
				sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
				sw.WriteLine("<Project ToolsVersion=\"15.0\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
				sw.WriteLine("  <Import Project=\"$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props\" Condition=\"Exists('$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props')\" />");

				// General Configuration
				sw.WriteLine("  <PropertyGroup>");
				sw.WriteLine("    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>");
				sw.WriteLine("    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>");
				sw.WriteLine("    <ProjectGuid>" + Guid + "</ProjectGuid>");
				sw.WriteLine("    <OutputType>Library</OutputType>");
				sw.WriteLine("    <AppDesignerFolder>Properties</AppDesignerFolder>");
				sw.WriteLine("    <RootNamespace>" + Name + "</RootNamespace>");
				sw.WriteLine("    <AssemblyName>" + Name + "</AssemblyName>");
				sw.WriteLine("    <TargetFrameworkVersion>v4.7.2</TargetFrameworkVersion>");
				sw.WriteLine("    <FileAlignment>512</FileAlignment>");
				sw.WriteLine("  </PropertyGroup>");

				// Debug Configuration
				sw.WriteLine("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' \">");
				sw.WriteLine("    <DebugSymbols>true</DebugSymbols>");
				sw.WriteLine("    <DebugType>full</DebugType>");
				sw.WriteLine("    <Optimize>false</Optimize>");
				sw.WriteLine("    <OutputPath>bin\\Debug\\</OutputPath>");
				sw.WriteLine("    <DefineConstants>DEBUG;TRACE</DefineConstants>");
				sw.WriteLine("    <ErrorReport>prompt</ErrorReport>");
				sw.WriteLine("    <WarningLevel>4</WarningLevel>");
				sw.WriteLine("  </PropertyGroup>");

				// Release Configuration
				sw.WriteLine("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' \">");
				sw.WriteLine("    <DebugType>pdbonly</DebugType>");
				sw.WriteLine("    <Optimize>true</Optimize>");
				sw.WriteLine("    <OutputPath>bin\\Release\\</OutputPath>");
				sw.WriteLine("    <DefineConstants>TRACE</DefineConstants>");
				sw.WriteLine("    <ErrorReport>prompt</ErrorReport>");
				sw.WriteLine("    <WarningLevel>4</WarningLevel>");
				sw.WriteLine("  </PropertyGroup>");

				// References
				sw.WriteLine("  <ItemGroup>");
				References.Sort(StringComparer.CurrentCultureIgnoreCase);
				foreach (var reference in References)
				{
					string refPath1 = Path.GetFullPath(Path.Combine(referenceDirectory, reference + ".dll"));
					string refPath2 = Path.GetFullPath(Path.Combine(referenceDirectory, reference + ".exe"));
					if (!string.IsNullOrWhiteSpace(referenceDirectory) && File.Exists(refPath1))
					{
						sw.WriteLine("    <Reference Include=\"" + reference + "\">");
						sw.WriteLine("      <HintPath>" + refPath1 + "</HintPath>");
						sw.WriteLine("    </Reference>");
					}
					else if (!string.IsNullOrWhiteSpace(referenceDirectory) && File.Exists(refPath2))
					{
						sw.WriteLine("    <Reference Include=\"" + reference + "\">");
						sw.WriteLine("      <HintPath>" + refPath2 + "</HintPath>");
						sw.WriteLine("    </Reference>");
					}
					else
					{
						sw.WriteLine("    <Reference Include=\"" + reference + "\" />");
					}
				}

				sw.WriteLine("  </ItemGroup>");

				// Files
				sw.WriteLine("  <ItemGroup>");
				foreach (var file in Files)
				{
					if (file.EndsWith(".cs"))
						sw.WriteLine("    <Compile Include=\"" + file + "\" />");
					else
						sw.WriteLine("    <None Include=\"" + file + "\" />");
				}

				sw.WriteLine("  </ItemGroup>");

				sw.WriteLine("  <Import Project=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets\" />");

				sw.WriteLine("<PropertyGroup>");
				sw.WriteLine("<PostBuildEvent>\"" + TMLServerPath + "\" -build \"$(ProjectDir)\\\" -eac \"$(TargetPath)\"</PostBuildEvent>");
				sw.WriteLine("</PropertyGroup>");

				sw.WriteLine("</Project>");
			}
		}
	}
}
