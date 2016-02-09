using System;
using System.Collections.Generic;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string _userinput = "";
			List<int> _list = new List<int> ();
			_list.Add (5);
			_list.Add (3);
			_list.Add (9);

			//Потребителски вход
			do {
				Console.Write ("  ?  ");
				_userinput = Console.ReadLine ();
	//Разделя входния стринг и стойността след интервала превръща в int
	//Добавя стойност в списъка
				if (_userinput.ToLower().Contains ("add"))
				{
					try 
					{int _add = 0;
						if (int.TryParse (_userinput.Split (' ')[1], out _add))
						{_list.Add (_add);}
						Console.WriteLine();
						}catch{}}

			//Преглед на листа
				if (_userinput.Contains ("show"))

				{  Console.Write ("списък: ");	
					foreach (int value in _list)
					{Console.Write(value.ToString() + ", ");}}


			//Размер на листа
				if (_userinput.ToLower().Contains ("size"))
				{  Console.Write ("брой елементи: " + _list.Count.ToString() + "\n");	
				}
				} while (_userinput != "exit");	
		}  
	} 
	}
