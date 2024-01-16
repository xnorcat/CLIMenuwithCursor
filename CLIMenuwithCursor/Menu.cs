/*
 * Created by SharpDevelop.
 * User: mrhitj
 * Date: 12/1/2023
 * Time: 3:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Menu
{
	/// <summary>
	/// Description of Class1
	/// </summary>
	public static class Menu
	{
		public static string Cursor = ">";
		public static string[] MenuList= {"Display Hello World", "Generate Random Number", "A * B", "Exit"};
		public static string[] CursorBox = {Cursor, " ", " ", " "};
		public static int CursorIndex = 0;
		
		public static void Display(){
			for(int i = 0; i < Menu.MenuList.Length; i++)
				{
					Console.WriteLine(Menu.CursorBox[i] + " " + Menu.MenuList[i]);
				}
			return;
		}
		
		public static void Move(ConsoleKeyInfo Key){
			switch(Key.Key)
			{
				case ConsoleKey.UpArrow:
					Menu.CursorBox[Menu.CursorIndex] = " ";
					Menu.CursorIndex--;
					Menu.CursorIndex = (Menu.CursorIndex == -1) ? Menu.CursorIndex + 1 : Menu.CursorIndex;
					Menu.CursorBox[Menu.CursorIndex] = Menu.Cursor;
					break;
				case ConsoleKey.DownArrow:
					Menu.CursorBox[Menu.CursorIndex] = " ";
					Menu.CursorIndex++;
					Menu.CursorIndex = (Menu.CursorIndex == Menu.CursorBox.Length) ? Menu.CursorIndex - 1 : Menu.CursorIndex;
					Menu.CursorBox[Menu.CursorIndex] = Menu.Cursor;
					break;
				default:
					break;
			}
		}
	}

}
