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
			//b = Convert.ToInt32 (Console.ReadLine ());

			//Печат на резултат
			//Console.WriteLine ("Резултат a + b = " +(a+b).ToString()+"\n\n");

			string test = " 1";
			test += ", 2";
			test += ", 3";
			test += ", 4";
			test += ", 5";
			Console.WriteLine ("Събиране с += :" + test + "\n");
			test = test.Replace (", ", ";");
			Console.WriteLine ("работа с Replace:" + test + "\n");
			Console.WriteLine ("3-ти знак: " + test.Split (';') [2]);


		}
	}
}
