
namespace Pathfinding
{
	partial class SettingsForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.sizeTrackBar = new System.Windows.Forms.TrackBar();
			this.speedTrackBar = new System.Windows.Forms.TrackBar();
			this.sizeLabel = new System.Windows.Forms.Label();
			this.speedLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(30, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tile size:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(30, 157);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Speed:";
			// 
			// sizeTrackBar
			// 
			this.sizeTrackBar.Location = new System.Drawing.Point(127, 102);
			this.sizeTrackBar.Maximum = 100;
			this.sizeTrackBar.Minimum = 5;
			this.sizeTrackBar.Name = "sizeTrackBar";
			this.sizeTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.sizeTrackBar.Size = new System.Drawing.Size(310, 45);
			this.sizeTrackBar.TabIndex = 1;
			this.sizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			this.sizeTrackBar.Value = 10;
			this.sizeTrackBar.Scroll += new System.EventHandler(this.SizeTrackBarScroll);
			// 
			// speedTrackBar
			// 
			this.speedTrackBar.Location = new System.Drawing.Point(127, 159);
			this.speedTrackBar.Maximum = 100;
			this.speedTrackBar.Minimum = 1;
			this.speedTrackBar.Name = "speedTrackBar";
			this.speedTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.speedTrackBar.Size = new System.Drawing.Size(310, 45);
			this.speedTrackBar.TabIndex = 2;
			this.speedTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			this.speedTrackBar.Value = 10;
			this.speedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBarScroll);
			// 
			// sizeLabel
			// 
			this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.sizeLabel.Location = new System.Drawing.Point(443, 99);
			this.sizeLabel.Name = "sizeLabel";
			this.sizeLabel.Size = new System.Drawing.Size(153, 33);
			this.sizeLabel.TabIndex = 2;
			this.sizeLabel.Text = "10pt  360tiles";
			// 
			// speedLabel
			// 
			this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.speedLabel.Location = new System.Drawing.Point(443, 159);
			this.speedLabel.Name = "speedLabel";
			this.speedLabel.Size = new System.Drawing.Size(110, 23);
			this.speedLabel.TabIndex = 3;
			this.speedLabel.Text = "10";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(145, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(313, 90);
			this.label3.TabIndex = 4;
			this.label3.Text = "Settings";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(21, 542);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(150, 46);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(223, 542);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(150, 46);
			this.cancelButton.TabIndex = 4;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(423, 542);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(150, 46);
			this.resetButton.TabIndex = 5;
			this.resetButton.Text = "Reset to Default";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButtonClick);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 600);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.speedLabel);
			this.Controls.Add(this.sizeLabel);
			this.Controls.Add(this.speedTrackBar);
			this.Controls.Add(this.sizeTrackBar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SettingsForm";
			this.Text = "SettingsForm";
			this.Load += new System.EventHandler(this.SettingsFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.sizeTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label speedLabel;
		private System.Windows.Forms.Label sizeLabel;
		private System.Windows.Forms.TrackBar speedTrackBar;
		private System.Windows.Forms.TrackBar sizeTrackBar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
