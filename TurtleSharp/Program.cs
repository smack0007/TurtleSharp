using System;
using System.Windows.Forms;
using TurtleSharp.Presenters;
using TurtleSharp.Views;

namespace TurtleSharp
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			MainForm view = new MainForm();
			MainPresenter presenter = new MainPresenter(view);

			Application.Run(view);
		}

		public static readonly string DefaultTurtleGraphicsProgram = @"using System;
using TurtleSharp;

public class MyTurtleGraphics : ITurtleGraphicsProgram
{
	public void Draw(ITurtleGraphics graphics)
	{
	}
}";
	}
}
