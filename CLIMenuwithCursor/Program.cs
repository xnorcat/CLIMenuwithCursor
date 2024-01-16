using System;
//using System.Globalization;

namespace Menu
{
	
	class Program
	{	
		static void ClearBuffer()
		{
			while(Console.In.Peek() != -1)
			{
				Console.In.Read();
			}
		}
		
		static double GetInput()
		{
			double result = 0;
			
			string Input = Console.ReadLine();
			bool success = double.TryParse(Input, out result);
			
			while(!success)
			{
				Console.WriteLine("Input must be numbers!");
				Input = Console.ReadLine();
				success = double.TryParse(Input, out result);
			}
			return result;
		}
		
		static void Main(string[] args)
		{
			ConsoleKeyInfo Key;
			bool MenuLoop = true;
			int RandomSeed = Convert.ToInt32(DateTime.Now.ToString("hmmss"));
			Random random = new Random(RandomSeed);
			
			while(MenuLoop)
			{
				Menu.Display();
				
				Key = Console.ReadKey(true);
				Menu.Move(Key);
				
				if(Key.Key == ConsoleKey.Enter)
				{
					ClearBuffer();
					
					switch(Menu.CursorIndex)
					{
						case 0:
							Console.WriteLine("Hello World!");
							Console.ReadKey();
							break;
						case 1:
							int number = 0;
							number = random.Next(1, 1000);
							Console.WriteLine("Generated Number : " + number);
							Console.ReadKey();
							break;
						case 2:
							double a = 0, b = 0; 
							Console.Clear();
							
							Console.WriteLine("Input A : ");
							a = GetInput();
							
							Console.WriteLine("Input B : ");
							b = GetInput();
							
							Console.WriteLine("A * B is " + a*b);
							Console.WriteLine("Press any key to continue...");
							Console.Read();
							break;
						case 3:
							MenuLoop = false;
							break;
						default:
							Console.WriteLine("Invalid Input!");
							break;
					}
				}
				Console.Clear();
			}
			
//			Console.Read();
		}
	}
}