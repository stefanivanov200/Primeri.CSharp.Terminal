using System;

namespace Fact
{
	class MainClass
	{
		public static int Fact (int fa)    
		{
			if (fa >= 100)
			return 100;
			else
			Console.WriteLine (fa);
			//Console.WriteLine (Sop (5));
			return Fact (fa + 6);
			//	return fa * Sop (fa - 1); 
		}

		public static void Main (string[] args) 
		{
			Console.WriteLine (Fact (2));    
		}
	}
}
