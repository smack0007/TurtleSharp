namespace TurtleSharp.Views
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sourceCodeEditorControl = new TurtleSharp.Views.SourceCodeEditorControl();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.turtleGraphicsControl = new TurtleSharp.Views.TurtleGraphicsControl();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.compileButton = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// codeEditorControl
			// 
			this.sourceCodeEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sourceCodeEditorControl.Location = new System.Drawing.Point(0, 0);
			this.sourceCodeEditorControl.Name = "codeEditorControl";
			this.sourceCodeEditorControl.Size = new System.Drawing.Size(410, 537);
			this.sourceCodeEditorControl.TabIndex = 1;
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 25);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.turtleGraphicsControl);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.sourceCodeEditorControl);
			this.splitContainer.Size = new System.Drawing.Size(784, 537);
			this.splitContainer.SplitterDistance = 370;
			this.splitContainer.TabIndex = 2;
			// 
			// turtleGraphicsControl
			// 
			this.turtleGraphicsControl.BackColor = System.Drawing.Color.CornflowerBlue;
			this.turtleGraphicsControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.turtleGraphicsControl.Location = new System.Drawing.Point(0, 0);
			this.turtleGraphicsControl.Name = "turtleGraphicsControl";
			this.turtleGraphicsControl.Size = new System.Drawing.Size(370, 537);
			this.turtleGraphicsControl.TabIndex = 0;
			this.turtleGraphicsControl.Text = "turtleGraphicsControl";
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(784, 25);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip";
			// 
			// compileButton
			// 
			this.compileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.compileButton.Image = global::TurtleSharp.Properties.Resources.CompileIcon;
			this.compileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.compileButton.Name = "compileButton";
			this.compileButton.Size = new System.Drawing.Size(23, 22);
			this.compileButton.Text = "Compile";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.toolStrip);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "MainForm";
			this.Text = "TurtleSharp";
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TurtleSharp.Views.TurtleGraphicsControl turtleGraphicsControl;
		private TurtleSharp.Views.SourceCodeEditorControl sourceCodeEditorControl;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton compileButton;

	}
}

