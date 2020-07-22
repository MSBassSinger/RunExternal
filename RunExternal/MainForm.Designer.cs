namespace RunExternal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.GetCSDialog = new System.Windows.Forms.OpenFileDialog();
			this.ButtonPanel = new System.Windows.Forms.Panel();
			this.CompileButton = new System.Windows.Forms.Button();
			this.LeftSepPanel2 = new System.Windows.Forms.Panel();
			this.MiddleSeparatorPanel = new System.Windows.Forms.Panel();
			this.CompileAndExecuteButton = new System.Windows.Forms.Button();
			this.RightSeparatorPanel = new System.Windows.Forms.Panel();
			this.SelectFileButton = new System.Windows.Forms.Button();
			this.LeftSeparatorPanel = new System.Windows.Forms.Panel();
			this.RowColStatus = new System.Windows.Forms.StatusStrip();
			this.RowNum = new System.Windows.Forms.ToolStripStatusLabel();
			this.ColNum = new System.Windows.Forms.ToolStripStatusLabel();
			this.TextBoxContainer = new System.Windows.Forms.SplitContainer();
			this.CSTextBox = new System.Windows.Forms.TextBox();
			this.ResultsTextBox = new System.Windows.Forms.TextBox();
			this.ButtonPanel.SuspendLayout();
			this.RowColStatus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TextBoxContainer)).BeginInit();
			this.TextBoxContainer.Panel1.SuspendLayout();
			this.TextBoxContainer.Panel2.SuspendLayout();
			this.TextBoxContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// GetCSDialog
			// 
			this.GetCSDialog.FileName = "*.cs";
			this.GetCSDialog.Filter = "C# Files|*.cs|All files|*.*";
			this.GetCSDialog.Title = "Select C# File to execute.";
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.Controls.Add(this.CompileButton);
			this.ButtonPanel.Controls.Add(this.LeftSepPanel2);
			this.ButtonPanel.Controls.Add(this.MiddleSeparatorPanel);
			this.ButtonPanel.Controls.Add(this.CompileAndExecuteButton);
			this.ButtonPanel.Controls.Add(this.RightSeparatorPanel);
			this.ButtonPanel.Controls.Add(this.SelectFileButton);
			this.ButtonPanel.Controls.Add(this.LeftSeparatorPanel);
			this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(1024, 63);
			this.ButtonPanel.TabIndex = 3;
			// 
			// CompileButton
			// 
			this.CompileButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.CompileButton.Image = global::RunExternal.Properties.Resources.Check_32x32_72;
			this.CompileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.CompileButton.Location = new System.Drawing.Point(739, 0);
			this.CompileButton.Name = "CompileButton";
			this.CompileButton.Size = new System.Drawing.Size(111, 63);
			this.CompileButton.TabIndex = 11;
			this.CompileButton.Text = "Compile Only";
			this.CompileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CompileButton.UseVisualStyleBackColor = true;
			this.CompileButton.Click += new System.EventHandler(this.CompileButton_Click);
			// 
			// LeftSepPanel2
			// 
			this.LeftSepPanel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.LeftSepPanel2.Location = new System.Drawing.Point(132, 0);
			this.LeftSepPanel2.Name = "LeftSepPanel2";
			this.LeftSepPanel2.Size = new System.Drawing.Size(16, 63);
			this.LeftSepPanel2.TabIndex = 10;
			// 
			// MiddleSeparatorPanel
			// 
			this.MiddleSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.MiddleSeparatorPanel.Location = new System.Drawing.Point(850, 0);
			this.MiddleSeparatorPanel.Name = "MiddleSeparatorPanel";
			this.MiddleSeparatorPanel.Size = new System.Drawing.Size(16, 63);
			this.MiddleSeparatorPanel.TabIndex = 8;
			// 
			// CompileAndExecuteButton
			// 
			this.CompileAndExecuteButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.CompileAndExecuteButton.Image = global::RunExternal.Properties.Resources.RightArrow_Green_32x32_72;
			this.CompileAndExecuteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.CompileAndExecuteButton.Location = new System.Drawing.Point(866, 0);
			this.CompileAndExecuteButton.Name = "CompileAndExecuteButton";
			this.CompileAndExecuteButton.Size = new System.Drawing.Size(142, 63);
			this.CompileAndExecuteButton.TabIndex = 7;
			this.CompileAndExecuteButton.Text = "Compile && Execute";
			this.CompileAndExecuteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CompileAndExecuteButton.UseVisualStyleBackColor = true;
			this.CompileAndExecuteButton.Click += new System.EventHandler(this.CompileAndExecuteButton_Click);
			// 
			// RightSeparatorPanel
			// 
			this.RightSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.RightSeparatorPanel.Location = new System.Drawing.Point(1008, 0);
			this.RightSeparatorPanel.Name = "RightSeparatorPanel";
			this.RightSeparatorPanel.Size = new System.Drawing.Size(16, 63);
			this.RightSeparatorPanel.TabIndex = 6;
			// 
			// SelectFileButton
			// 
			this.SelectFileButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.SelectFileButton.Image = global::RunExternal.Properties.Resources.Folder_Open;
			this.SelectFileButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SelectFileButton.Location = new System.Drawing.Point(16, 0);
			this.SelectFileButton.Name = "SelectFileButton";
			this.SelectFileButton.Size = new System.Drawing.Size(116, 63);
			this.SelectFileButton.TabIndex = 5;
			this.SelectFileButton.Text = "Select C# File";
			this.SelectFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.SelectFileButton.UseVisualStyleBackColor = true;
			this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
			// 
			// LeftSeparatorPanel
			// 
			this.LeftSeparatorPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.LeftSeparatorPanel.Location = new System.Drawing.Point(0, 0);
			this.LeftSeparatorPanel.Name = "LeftSeparatorPanel";
			this.LeftSeparatorPanel.Size = new System.Drawing.Size(16, 63);
			this.LeftSeparatorPanel.TabIndex = 4;
			// 
			// RowColStatus
			// 
			this.RowColStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RowNum,
            this.ColNum});
			this.RowColStatus.Location = new System.Drawing.Point(0, 634);
			this.RowColStatus.Name = "RowColStatus";
			this.RowColStatus.Size = new System.Drawing.Size(1024, 22);
			this.RowColStatus.TabIndex = 9;
			this.RowColStatus.Text = "statusStrip1";
			// 
			// RowNum
			// 
			this.RowNum.Name = "RowNum";
			this.RowNum.Size = new System.Drawing.Size(39, 17);
			this.RowNum.Text = "Row 0";
			// 
			// ColNum
			// 
			this.ColNum.Name = "ColNum";
			this.ColNum.Size = new System.Drawing.Size(34, 17);
			this.ColNum.Text = "Col 0";
			// 
			// TextBoxContainer
			// 
			this.TextBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxContainer.Location = new System.Drawing.Point(0, 63);
			this.TextBoxContainer.Name = "TextBoxContainer";
			// 
			// TextBoxContainer.Panel1
			// 
			this.TextBoxContainer.Panel1.Controls.Add(this.CSTextBox);
			// 
			// TextBoxContainer.Panel2
			// 
			this.TextBoxContainer.Panel2.Controls.Add(this.ResultsTextBox);
			this.TextBoxContainer.Size = new System.Drawing.Size(1024, 571);
			this.TextBoxContainer.SplitterDistance = 543;
			this.TextBoxContainer.TabIndex = 10;
			// 
			// CSTextBox
			// 
			this.CSTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CSTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CSTextBox.Location = new System.Drawing.Point(0, 0);
			this.CSTextBox.Multiline = true;
			this.CSTextBox.Name = "CSTextBox";
			this.CSTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.CSTextBox.Size = new System.Drawing.Size(543, 571);
			this.CSTextBox.TabIndex = 7;
			this.CSTextBox.WordWrap = false;
			this.CSTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CSTextBox_KeyUp);
			this.CSTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CSTextBox_MouseUp);
			// 
			// ResultsTextBox
			// 
			this.ResultsTextBox.BackColor = System.Drawing.Color.Snow;
			this.ResultsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ResultsTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResultsTextBox.Location = new System.Drawing.Point(0, 0);
			this.ResultsTextBox.Multiline = true;
			this.ResultsTextBox.Name = "ResultsTextBox";
			this.ResultsTextBox.ReadOnly = true;
			this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.ResultsTextBox.Size = new System.Drawing.Size(477, 571);
			this.ResultsTextBox.TabIndex = 8;
			this.ResultsTextBox.WordWrap = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 656);
			this.Controls.Add(this.TextBoxContainer);
			this.Controls.Add(this.RowColStatus);
			this.Controls.Add(this.ButtonPanel);
			this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Run External";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.ButtonPanel.ResumeLayout(false);
			this.RowColStatus.ResumeLayout(false);
			this.RowColStatus.PerformLayout();
			this.TextBoxContainer.Panel1.ResumeLayout(false);
			this.TextBoxContainer.Panel1.PerformLayout();
			this.TextBoxContainer.Panel2.ResumeLayout(false);
			this.TextBoxContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TextBoxContainer)).EndInit();
			this.TextBoxContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog GetCSDialog;
		private System.Windows.Forms.Panel ButtonPanel;
		private System.Windows.Forms.Button CompileAndExecuteButton;
		private System.Windows.Forms.Panel RightSeparatorPanel;
		private System.Windows.Forms.Button SelectFileButton;
		private System.Windows.Forms.Panel LeftSeparatorPanel;
		private System.Windows.Forms.Panel MiddleSeparatorPanel;
		private System.Windows.Forms.Button CompileButton;
		private System.Windows.Forms.Panel LeftSepPanel2;
		private System.Windows.Forms.StatusStrip RowColStatus;
		private System.Windows.Forms.ToolStripStatusLabel RowNum;
		private System.Windows.Forms.ToolStripStatusLabel ColNum;
		private System.Windows.Forms.SplitContainer TextBoxContainer;
		private System.Windows.Forms.TextBox CSTextBox;
		private System.Windows.Forms.TextBox ResultsTextBox;
	}
}

