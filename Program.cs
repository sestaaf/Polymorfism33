using System;
using System.Collections.Generic;

namespace Polymorfism33
{
	class Program
	{
		static void Main(string[] args)
		{
			List<UserError> errors = new List<UserError>()
			{
				new TextInputError(),
				new NumericInputError()
			};

			foreach (UserError message in errors)
			{
				Console.WriteLine(message.UEMessage());
			}
		}

		// 3.4.11: Går att styra vad som ska gå att göra i ärvande klasser
		//         genom gemensamma gränssnitt i de översta arvsklasserna.
		//         Subklasser kan ha egna subklasser som ärver från dem.
		// 3.4.12: Blir mindre kod p g a att upprepningar kan undvikas,
		//         vilket också gör att det blir lättare att följa flödet.
		// 3.4.13: Metoder, egenskaper m m  som finns i ett interface måste 
		//         finnas också i de klasser som ärver därifrån. Det går att 
		//         ärva från flera Interface, medans abstrakta klasser bara
		//         kan ärvas i ett steg.
	}
}
