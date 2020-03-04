using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;

namespace Renamer
{
	class Res
	{
		static ResourceManager manager = new ResourceManager(typeof(Renamer.GlobalResource));

		public static String Get(String key) {
			return manager.GetString(key);
		}
	}
}
