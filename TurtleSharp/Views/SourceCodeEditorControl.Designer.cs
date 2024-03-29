﻿namespace TurtleSharp.Views
{
	partial class SourceCodeEditorControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.compilerErrorsView = new System.Windows.Forms.ListView();
			this.descriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lineHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.sourceCodeBox = new ScintillaNET.Scintilla();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sourceCodeBox)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.sourceCodeBox);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.compilerErrorsView);
			this.splitContainer.Size = new System.Drawing.Size(460, 379);
			this.splitContainer.SplitterDistance = 244;
			this.splitContainer.TabIndex = 0;
			// 
			// compilerErrorsView
			// 
			this.compilerErrorsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.descriptionHeader,
            this.lineHeader});
			this.compilerErrorsView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.compilerErrorsView.Location = new System.Drawing.Point(0, 0);
			this.compilerErrorsView.Name = "compilerErrorsView";
			this.compilerErrorsView.Size = new System.Drawing.Size(460, 131);
			this.compilerErrorsView.TabIndex = 0;
			this.compilerErrorsView.UseCompatibleStateImageBehavior = false;
			this.compilerErrorsView.View = System.Windows.Forms.View.Details;
			// 
			// descriptionHeader
			// 
			this.descriptionHeader.Text = "Description";
			this.descriptionHeader.Width = 379;
			// 
			// lineHeader
			// 
			this.lineHeader.Text = "Line";
			// 
			// sourceCodeBox
			// 
			this.sourceCodeBox.ConfigurationManager.Language = "cs";
			this.sourceCodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sourceCodeBox.Location = new System.Drawing.Point(0, 0);
			this.sourceCodeBox.Name = "sourceCodeBox";
			this.sourceCodeBox.Size = new System.Drawing.Size(460, 244);
			this.sourceCodeBox.TabIndex = 0;
			// 
			// SourceCodeEditorControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer);
			this.Name = "SourceCodeEditorControl";
			this.Size = new System.Drawing.Size(460, 379);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sourceCodeBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ListView compilerErrorsView;
		private System.Windows.Forms.ColumnHeader descriptionHeader;
		private System.Windows.Forms.ColumnHeader lineHeader;
		private ScintillaNET.Scintilla sourceCodeBox;
	}
}
