using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TerrariaEmptyProjectGenerator
{
	public static class Utils
	{
		public static bool DoPathsEqual(string path1, string path2)
		{
			if (path1 == null && path2 == null)
				return true;

			if (path1 == null)
				return false;

			if (path2 == null)
				return false;

			path1 = Path.GetFullPath(path1.Trim()).Replace("\\", "/");
			path2 = Path.GetFullPath(path2.Trim()).Replace("\\", "/");

			if (path1.EndsWith("/"))
				path1 = path1.Substring(0, path1.Length - 1);
			
			if (path2.EndsWith("/"))
				path2 = path2.Substring(0, path2.Length - 1);

			return path1.Equals(path2, StringComparison.OrdinalIgnoreCase);
		}

		public static bool IsRunningInAppDirectory()
		{
			return DoPathsEqual(Environment.CurrentDirectory, AppDomain.CurrentDomain.BaseDirectory);
		}

		public static bool IsValidPath(string path)
		{
			path = path.Trim();
			if (path.Length == 0)
				return false;

			Regex driveCheck = new Regex(@"^[a-zA-Z]:\\$");
			if (!driveCheck.IsMatch(path.Substring(0, 3))) return false;
			string strTheseAreInvalidFileNameChars = new string(Path.GetInvalidPathChars());
			strTheseAreInvalidFileNameChars += @":/?*" + "\"";
			Regex containsABadCharacter = new Regex("[" + Regex.Escape(strTheseAreInvalidFileNameChars) + "]");
			if (containsABadCharacter.IsMatch(path.Substring(3, path.Length - 3)))
				return false;

			return true;
		}

		public static bool IsValidDirectoryPath(string path)
		{
			if (!IsValidPath(path))
				return false;

			try
			{
				if (File.Exists(path) && !File.GetAttributes(path).HasFlag(FileAttributes.Directory))
					return false;
			}
			catch
			{
				return false;
			}

			return true;
		}

		public static bool IsValidName(string name)
		{
			name = name.Trim();
			if (name.Length == 0)
				return false;
			return true;
		}

		public static bool IsValidID(string id)
		{
			id = id.Trim();
			if (id.Length == 0)
				return false;
			if (id[0] != '_' && !Char.IsLetter(id[0]))
				return false;

			foreach (var c in id)
			{
				if (c != '_' && !Char.IsLetterOrDigit(c))
					return false;
			}

			return true;
		}
	}
}
