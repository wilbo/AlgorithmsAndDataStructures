using Gtk;

namespace Recursion.HTree
{
	class Program
	{
		public static void Main(string[] args)
		{
			Application.Init();
			var window = new HTree(800, 600);
			window.Show();
			Application.Run();
		}
	}
}