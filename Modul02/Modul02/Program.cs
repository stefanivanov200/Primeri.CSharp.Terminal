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

			// Писане в конзола
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

			Console.WriteLine ("делене на цели числа" + ( 7 / 3 ).ToString ());   //целочислен резултат      
			Console.WriteLine ("целочислен остатък" + ( 7 % 3 ).ToString ());   //целочислен остатък

		}
	}
}
