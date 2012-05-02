using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using Snowball.WinForms;

namespace TurtleSharp.Views
{
	public interface IMainView
	{
		string SourceCode { get; set; }

		int SceneWidth { get; }

		int SceneHeight { get; }

		event EventHandler<GraphicsDeviceEventArgs> InitializeGraphics;

		event EventHandler<GraphicsDeviceEventArgs> DrawScene;

		event EventHandler CompileButtonClicked;

		void ClearCompilerErrors();

		void SetCompilerErrors(IList<CompilerError> errors);

		void RedrawScene();
	}
}
