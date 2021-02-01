using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism33
{
	abstract class UserError
	{
		public abstract string UEMessage { get; }

		public string Message { get; set; }

	}
}
