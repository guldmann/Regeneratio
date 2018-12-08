using System.Collections.Generic;

namespace Chared.Settings
{
	public class MainSettings
	{
		public ApplicationSettings AppSettings { get; set;}
		public List<RegKeySetting> RegKeys { get; set;}

	}
}
