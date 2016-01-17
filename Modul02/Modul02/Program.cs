using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;


			// Събиране на числа
			a = 10;
			b = 5;
			sum = a + b;
			// Данни за програмата
			String program_name = "Модул 02 примери";
			String program_version = "1.0";

			Console.WriteLine (program_name);
			Console.WriteLine ("Версия: " + program_version + "\n\n");


			// Писане в конзола

			Console.WriteLine (a+"+" +b+ "=" +sum);	

			Console.Write ( a ); Console.Write (" + "); Console.Write ( b );
			Console.Write (" = "); 
			Console.WriteLine ( sum );   
			// дoпълнителни оператори
			Console.WriteLine ("\n ползване на оператор +=");
			a += b;                       //a=10+5, a=a+b, a=15
			Console.WriteLine (a);

			Console.WriteLine ("\n ползване на оператор -=");
			a -= b;                       //a=15-5 a=10
			Console.WriteLine (a);

			Console.WriteLine ("\n ползване на оператор +=");
			a *= b;                       //a=10.5, a=51
			Console.WriteLine (a);

			Console.WriteLine ("\n ползване на оператор ++");
			a++;                      		//a=a+1. a=51
			Console.WriteLine (a);

			Console.WriteLine ("делене на цели числа  " + ( 7 / 3 ).ToString ());   //целочислен резултат      
			Console.WriteLine ("целочислен остатък    " + ( 7 % 3 ).ToString ());   //целочислен остатък

		}
	}
}
