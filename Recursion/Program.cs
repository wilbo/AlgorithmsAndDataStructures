using System;
using Gdk;
using Gtk;

namespace Recursion
{
	class Program
	{
		public static void Main(string[] args)
		{
			Application.Init();
			var window = new Window(800, 600);
			window.Show();
			Application.Run();
		}
	}
}