﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism33
{
	class TextInputError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to use a text input in a numeric only field. This fired an error!";
		}
	}
}
