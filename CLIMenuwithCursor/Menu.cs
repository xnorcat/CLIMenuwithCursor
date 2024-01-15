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
	}
	
	
}
