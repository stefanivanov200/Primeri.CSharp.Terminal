﻿using System;

namespace TableProject
{
	class MainClass
	{
		enum ti {ime=0, famil, godin};

		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			string[,] table = new string[2, 3];

			//Въвеждане на първи и втори ред
			table [0, (int) ti.ime]="Stefan"; table[0,(int) ti.famil]="Ivanov";   table[0,(int) ti.godin]="31";
			table [1, (int) ti.ime]="Ivan";   table[1,(int) ti.famil]="Stefanov"; table[1,(int) ti.godin]="41";

			Console.Write ("Кой ред искате да видите? ");
			int _index = Convert.ToInt32    (Console.ReadLine ())-1; 
			Console.WriteLine ((table[_index,(int) ti.ime])[0] + 
				". " + table[_index,(int) ti.famil] +
				", " + table[_index,(int) ti.godin] + " г.");
		
			Console.ReadKey ();



		}
	} 
}
//			string[] row = new string[3];
//			row [0] = "Ред 1";
//			row [1] = "Ред 2";
//			row [2] = "Ред 3";
//			Console.WriteLine ("Масив ROW:" + row[0] + ", "+row[1]+", "+row[2]+"\n");
//
//			String[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
//			Console.WriteLine ("броят на масива:\n" + "1,2,3,4,5,6,7,8,9\n\ne:" + parse.Length);
//
//			string list1 = string.Join (";", parse);
//			Console.WriteLine ("Новият стринг е: \n" + list1 +	"\n\n");