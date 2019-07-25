
namespace Pathfinding
{
	partial class EditForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.importButton = new System.Windows.Forms.Button();
			this.expotButton = new System.Windows.Forms.Button();
			this.eraseCheckBox = new System.Windows.Forms.CheckBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.exportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.importOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(638, 113);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(150, 46);
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(638, 165);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(150, 46);
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// importButton
			// 
			this.importButton.Location = new System.Drawing.Point(638, 470);
			this.importButton.Name = "importButton";
			this.importButton.Size = new System.Drawing.Size(150, 46);
			this.importButton.TabIndex = 2;
			this.importButton.Text = "Import";
			this.importButton.UseVisualStyleBackColor = true;
			this.importButton.Click += new System.EventHandler(this.ImportButtonClick);
			// 
			// expotButton
			// 
			this.expotButton.Location = new System.Drawing.Point(638, 542);
			this.expotButton.Name = "expotButton";
			this.expotButton.Size = new System.Drawing.Size(150, 46);
			this.expotButton.TabIndex = 2;
			this.expotButton.Text = "Export";
			this.expotButton.UseVisualStyleBackColor = true;
			this.expotButton.Click += new System.EventHandler(this.ExpotButtonClick);
			// 
			// eraseCheckBox
			// 
			this.eraseCheckBox.Location = new System.Drawing.Point(648, 277);
			this.eraseCheckBox.Name = "eraseCheckBox";
			this.eraseCheckBox.Size = new System.Drawing.Size(104, 24);
			this.eraseCheckBox.TabIndex = 3;
			this.eraseCheckBox.Text = "Eraser";
			this.eraseCheckBox.UseVisualStyleBackColor = true;
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(638, 307);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(150, 46);
			this.clearButton.TabIndex = 5;
			this.clearButton.Text = "Clear";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// exportSaveFileDialog
			// 
			this.exportSaveFileDialog.Filter = "tile maps|*.txt";
			this.exportSaveFileDialog.Title = "Save the tile map";
			// 
			// importOpenFileDialog
			// 
			this.importOpenFileDialog.Filter = "tile map|*.txt";
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 600);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.eraseCheckBox);
			this.Controls.Add(this.expotButton);
			this.Controls.Add(this.importButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "EditForm";
			this.Text = "EditForm";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditFormMouseDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EditFormMouseUp);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.OpenFileDialog importOpenFileDialog;
		private System.Windows.Forms.SaveFileDialog exportSaveFileDialog;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.CheckBox eraseCheckBox;
		private System.Windows.Forms.Button expotButton;
		private System.Windows.Forms.Button importButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button saveButton;
	}
}
