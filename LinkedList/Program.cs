﻿using LinkedList.Model;
using System;

namespace LinkedList
{
	class Program
	{
		static void Main(string[] args)
		{
			var list = new LinkedList<int>();

			list.Add(1);
			list.Add(2);
			list.Add(3);
			list.Add(4);
			list.Add(5);
			list.Add(6);
			list.Add(7);

			foreach(var item in list)
			{
				Console.WriteLine(item);
			}

			Console.ReadLine();
		}
	}
}
