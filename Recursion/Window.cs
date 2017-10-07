using System;
using Gdk;
using Gtk;
using WindowType = Gtk.WindowType;

namespace Recursion
{
	public class Window : Gtk.Window
	{
		private Gdk.GC _context;
		
		public Window(int height, int width) : base(WindowType.Toplevel)
		{			
			SetDefaultSize(height, width);
			Title = "Recursion Drawing";

			DeleteEvent += delegate { Application.Quit(); };	
		}

		protected override bool OnExposeEvent(EventExpose evnt)
		{
			var ok = base.OnExposeEvent(evnt);

			// Define the drawing context
			_context = new Gdk.GC(GdkWindow) {RgbFgColor = new Color(255, 0, 0)};

			// Amount of 
			const int depth = 4;
			// Size of H at start
			var size = DefaultSize.Width / 3;
			
			// Start position
			var x = DefaultSize.Width / 2; // x center
			var y = DefaultSize.Height / 2; // y center
			
			// Start drawing
			Draw(depth, x, y, size);
			
			return ok;
		}

		private void Draw(int depth, double x, double y, double size)
		{
			if (depth == 0) return;

			// Draw a H
			DrawH(x, y, size);

			// Calculate new positions next for H's
			var x0 = x - size / 2;
			var x1 = x + size / 2;
			var y0 = y - size / 2;
			var y1 = y + size / 2;

			// Draw H's
			Draw(depth - 1, x0, y0, size / 2);
			Draw(depth - 1, x0, y1, size / 2);
			Draw(depth - 1, x1, y0, size / 2);
			Draw(depth - 1, x1, y1, size / 2);
		}
		
		private void DrawH(double x, double y, double size)
		{
			// Calculate positions for this H
			var x0 = x - size / 2;
			var x1 = x + size / 2;
			var y0 = y - size / 2;
			var y1 = y + size / 2;

			DrawLine(x0, y0, x0, y1); // Draw left line
			DrawLine(x1, y0, x1, y1); // Draw right line
			DrawLine(x0, y, x1,  y); // Draw connection line
		}
		
		private void DrawLine(double x1, double y1, double x2, double y2)
		{
			GdkWindow.DrawLine(_context, (int) Math.Round(x1), (int) Math.Round(y1), (int) Math.Round(x2), (int) Math.Round(y2));
		}
	}
}