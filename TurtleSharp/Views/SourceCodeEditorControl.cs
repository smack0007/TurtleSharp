using System;
using System.Drawing;
using System.Windows.Forms;

namespace TurtleSharp.Views
{
	public partial class SourceCodeEditorControl : UserControl
	{
		public ListView.ListViewItemCollection CompilerErrors
		{
			get { return this.compilerErrorsView.Items; }
		}

		public override string Text
		{
			get { return this.sourceCodeBox.Text; }
			set { this.sourceCodeBox.Text = value; }
		}

		public SourceCodeEditorControl()
			: base()
		{
			this.InitializeComponent();
		}
	}
}