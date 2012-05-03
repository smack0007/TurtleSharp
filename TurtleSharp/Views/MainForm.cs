using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using Snowball.Graphics;
using Snowball.WinForms;

namespace TurtleSharp.Views
{
	public partial class MainForm : Form, IMainView
	{
		public string SourceCode
		{
			get { return this.sourceCodeEditorControl.Text; }
			set { this.sourceCodeEditorControl.Text = value; }
		}

		public int SceneWidth
		{
			get { return this.turtleGraphicsControl.Width; }
		}

		public int SceneHeight
		{
			get { return this.turtleGraphicsControl.Height; }
		}

		public event EventHandler<GraphicsDeviceEventArgs> InitializeGraphics;

		public event EventHandler<GraphicsDeviceEventArgs> DrawScene;

		public event EventHandler CompileButtonClicked;

		public MainForm()
		{
			this.InitializeComponent();

			this.turtleGraphicsControl.Initialize += this.TurtleGraphicsControl_Initialize;
			this.turtleGraphicsControl.Draw += this.TurtleGraphicsControl_Draw;

			this.compileButton.Click += this.CompileButton_Click;
		}

		private void TurtleGraphicsControl_Initialize(object sender, GraphicsDeviceEventArgs e)
		{
			if (this.InitializeGraphics != null)
				this.InitializeGraphics(this, e);
		}

		private void TurtleGraphicsControl_Draw(object sender, GraphicsDeviceEventArgs e)
		{
			if (this.DrawScene != null)
				this.DrawScene(this, e);
		}

		private void TriggerCompileButtonClicked()
		{
			if (this.CompileButtonClicked != null)
				this.CompileButtonClicked(this, EventArgs.Empty);
		}

		private void CompileButton_Click(object sender, EventArgs e)
		{
			this.TriggerCompileButtonClicked();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if ((keyData & Keys.F5) == Keys.F5)
				this.TriggerCompileButtonClicked();

			return base.ProcessCmdKey(ref msg, keyData);
		}

		public void ClearCompilerErrors()
		{
			this.sourceCodeEditorControl.CompilerErrors.Clear();
		}

		public void SetCompilerErrors(IList<CompilerError> errors)
		{
			this.ClearCompilerErrors();

			foreach (CompilerError error in errors)
			{
				ListViewItem item = new ListViewItem(error.ErrorText);
				item.SubItems.Add(error.Line.ToString());
				this.sourceCodeEditorControl.CompilerErrors.Add(item);
			}
		}

		public void RedrawScene()
		{
			this.turtleGraphicsControl.Refresh();
		}
	}
}
