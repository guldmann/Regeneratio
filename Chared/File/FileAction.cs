using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chared.Settings;
using Action = Chared.Settings.Action;

namespace Chared.File
{
	public class FileAction
	{
		public string File { get; set; }

		public When When { get; set; }

		public Action Action { get; set; }

		public string Args { get; set; } //<- List ? 
		public string WorkingDirectory { get; set; }

	}
}
