using System;

namespace Hello_World
{
	class MainClass
	{
		static bool isPrime (int n)
		{
			if (n == 1) return false;
			if (n == 2) return true;
			for (int i = 2; i < n - 1; i++) 
			{
				if (n % i == 0) return false;
			}
			return true; 
		}
		public static void Main(string[] args)
		{
			int a = args.Length;
			for (int k = 0; k < a; k++)
			{
				string s = args[k];
				int p = int.Parse(s);
				if (isPrime(p) == true)
				{
					Console.WriteLine(p); 
				}
			}

				
		}
	}
}
