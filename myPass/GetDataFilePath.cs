using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myPass
{
	internal class GetDataFilePath
	{
		public static string GetData()
		{
			string folder = Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
				"myPass");
			Directory.CreateDirectory(folder);
			return Path.Combine(folder, "passwordData.json");
		}

	}
}
