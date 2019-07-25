
namespace Pathfinding
{
	partial class ChooseForm
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
			this.startButton = new System.Windows.Forms.Button();
			this.targetButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.Cyan;
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.startButton.ForeColor = System.Drawing.Color.White;
			this.startButton.Location = new System.Drawing.Point(6, 4);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// targetButton
			// 
			this.targetButton.BackColor = System.Drawing.Color.DarkOrange;
			this.targetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.targetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.targetButton.ForeColor = System.Drawing.Color.White;
			this.targetButton.Location = new System.Drawing.Point(87, 4);
			this.targetButton.Name = "targetButton";
			this.targetButton.Size = new System.Drawing.Size(75, 23);
			this.targetButton.TabIndex = 0;
			this.targetButton.Text = "Target";
			this.targetButton.UseVisualStyleBackColor = false;
			this.targetButton.Click += new System.EventHandler(this.TargetButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.cancelButton.Location = new System.Drawing.Point(168, 4);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 0;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// ChooseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(250, 32);
			this.ControlBox = false;
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.targetButton);
			this.Controls.Add(this.startButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChooseForm";
			this.ShowIcon = false;
			this.Text = "ChooseForm";
			this.Load += new System.EventHandler(this.ChooseFormLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button targetButton;
		private System.Windows.Forms.Button startButton;
	}
}
