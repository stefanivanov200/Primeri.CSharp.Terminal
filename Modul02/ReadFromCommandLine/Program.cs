using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{	//Дефиниране на променливи
			int a = 5, b = 0;

			Console.Write ("Моля въведете b = ");
			//Въвеждане от клавиатура
			b = Convert.ToInt32 (Console.ReadLine ());

			//Печат на резултат
			Console.WriteLine ("Резултат a + b = " +(a+b).ToString()+"\n\n");
		}
	}
}
