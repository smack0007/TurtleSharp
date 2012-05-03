using System;
using System.CodeDom.Compiler;
using System.Linq;
using TurtleSharp.Views;
using System.Collections.Generic;
using System.Reflection;
using Snowball.Graphics;
using Snowball.WinForms;
using Snowball;

namespace TurtleSharp.Presenters
{
	public class MainPresenter
	{
		IMainView view;
		TurtleGraphicsRenderer renderer;		
		ITurtleGraphicsProgram program;
				

		public MainPresenter(IMainView view)
		{
			if (view == null)
			{
				throw new ArgumentNullException("view");
			}

			this.view = view;
			this.view.InitializeGraphics += this.View_InitializeGraphics;
			this.view.DrawScene += this.View_DrawScene;
			this.view.CompileButtonClicked += this.View_CompileButtonClicked;
			this.view.SourceCode = Program.DefaultTurtleGraphicsProgram;
		}

		private void View_InitializeGraphics(object sender, GraphicsDeviceEventArgs e)
		{
			this.renderer = new TurtleGraphicsRenderer(e.GraphicsDevice);
		}

		private void View_DrawScene(object sender, GraphicsDeviceEventArgs e)
		{
			if (this.program != null)
			{
				this.renderer.Begin(new Vector2(this.view.SceneWidth / 2, this.view.SceneHeight / 2));

				this.program.Draw(this.renderer);

				this.renderer.End();
			}
		}

		private void View_CompileButtonClicked(object sender, EventArgs e)
		{
			using(CodeDomProvider provider = new Microsoft.CSharp.CSharpCodeProvider())
			{
				CompilerParameters parameters = new CompilerParameters();
				parameters.GenerateExecutable = false;
				parameters.GenerateInMemory = true;
				parameters.ReferencedAssemblies.Add("System.dll");
				parameters.ReferencedAssemblies.Add(Assembly.GetEntryAssembly().Location);

				CompilerResults results = provider.CompileAssemblyFromSource(parameters, this.view.SourceCode);

				if (results.Errors.Count == 0)
				{
					this.view.ClearCompilerErrors();

					this.program = null;

					foreach (Type type in results.CompiledAssembly.GetTypes())
					{
						if (type.GetInterface(typeof(ITurtleGraphicsProgram).ToString(), true) != null)
							this.program = (ITurtleGraphicsProgram)results.CompiledAssembly.CreateInstance(type.FullName);
					}

					if (this.program != null)
					{
						this.view.RedrawScene();
					}
					else
					{
						// TODO: Show error message here if no type implements ITurtleGraphicsProgram.
					}
				}
				else
				{
					List<CompilerError> errors = new List<CompilerError>();
					foreach (CompilerError error in results.Errors)
						errors.Add(error);

					this.view.SetCompilerErrors(errors);
				}
			}
		}
	}
}
