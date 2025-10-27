using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace myPass
{
	public class PasswordData
	{
		[JsonInclude]
		public string WebPageName { get; set; }

		[JsonInclude]
		public string UserName { get; set; }

		[JsonInclude]
		public string PassWord { get; set; }

		//public PasswordData() { }

		[JsonConstructor]
		public PasswordData(string webPageName, string userName, string passWord)
		{
			WebPageName = webPageName;
			UserName = userName;
			PassWord = passWord;
		}

		public string GetWebpageName()
		{
			if (string.IsNullOrEmpty(WebPageName))
				return WebPageName;
			return char.ToUpper(WebPageName[0]) + WebPageName.Substring(1);
		}

		public string GetUserName() => UserName;
		public string GetPassword() => PassWord;
	}
}
