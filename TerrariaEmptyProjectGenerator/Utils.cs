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
		public static bool IsValidPath(string path)
		{
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
			return true;
		}

		public static bool IsValidID(string id)
		{
			return true;
		}
	}
}
