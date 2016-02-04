using System;

namespace BoolExplore2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int [] { 4, 3, 2 };
			int _ui = 0;
			string _input = "0";
			Console.Write ("Моля въведете индекс ");
			_input = Console.ReadLine ();
			bool _check01 = int.TryParse (_input, out _ui);

			try {
				Console.Write ("Елемент " + _ui.ToString () + " от масива е: ");
				Console.WriteLine (_i [_ui - 1]);
			} catch { 
				Console.WriteLine ("Недефиниран елемент");
			}

//			switch (_ui) {
//			case 1:
//				{Console.Write ("1-ви  елемент от масива: ");
//					Console.WriteLine (_i [_ui-1]);
//					break;
//				}
//			case 2:
//				{Console.Write ("2-ри  елемент от масива: ");
//					Console.WriteLine (_i [_ui-1]);
//					break;
//				}
//			case 3:
//				{Console.Write ("3-ти  елемент от масива: ");
//					Console.WriteLine (_i [_ui-1]);
//					break;
//				}
//			default:
//				{Console.Write ("Няма стойност с този индекс. Опитайте с индекс 1-3 !\n");
//					break;
//				}
//			}

		}
	} 
}
