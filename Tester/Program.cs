using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using CSharp;
using MathNet.Numerics;

namespace Tester
{
	public class Program
	{
		public static string WriteLine(string message)
		{
			Debug.WriteLine(message);
			return message;
		}

		public static string Write(string message1, string message2, string message3)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append(message1);
			builder.Append(" ");
			builder.Append(message2);
			builder.Append(" ");
			builder.Append(message3);
			builder.AppendLine();

			Debug.Write(builder);

			return builder.ToString();
		}

		public static void Main(string[] args)
		{
			Debug.WriteLine("------------------ Initializing Test -------------------");
			Utilities.Mapcar(Write,
				new List<string>() { "Hello", "How", "My", "fugazi" },
				new List<string>() { "World", "Are", "Dear" },
				new List<string>() { "!", "You", "Friend" });
			Debug.WriteLine("------------------- Test Completed ---------------------");
		}
	}
}
