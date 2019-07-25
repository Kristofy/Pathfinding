/*
 * Created by SharpDevelop.
 * User: oszto
 * Date: 2019. 07. 22.
 * Time: 12:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Pathfinding
{
	partial class MainForm
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
			this.title = new System.Windows.Forms.Label();
			this.rondomizeButton = new System.Windows.Forms.Button();
			this.Placeholder = new System.Windows.Forms.Panel();
			this.solveButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.settingsButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.Dock = System.Windows.Forms.DockStyle.Fill;
			this.title.Font = new System.Drawing.Font("Garamond", 88F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
			this.title.Location = new System.Drawing.Point(0, 0);
			this.title.Margin = new System.Windows.Forms.Padding(0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(600, 600);
			this.title.TabIndex = 0;
			this.title.Text = "Pathfinding";
			// 
			// rondomizeButton
			// 
			this.rondomizeButton.Location = new System.Drawing.Point(433, 251);
			this.rondomizeButton.Name = "rondomizeButton";
			this.rondomizeButton.Size = new System.Drawing.Size(150, 46);
			this.rondomizeButton.TabIndex = 2;
			this.rondomizeButton.Text = "Randomize";
			this.rondomizeButton.UseVisualStyleBackColor = true;
			this.rondomizeButton.Click += new System.EventHandler(this.RandomizeButtonClick);
			// 
			// Placeholder
			// 
			this.Placeholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Placeholder.Location = new System.Drawing.Point(12, 188);
			this.Placeholder.Name = "Placeholder";
			this.Placeholder.Size = new System.Drawing.Size(400, 400);
			this.Placeholder.TabIndex = 5;
			this.Placeholder.Paint += new System.Windows.Forms.PaintEventHandler(this.PlaceholderPaint);
			// 
			// solveButton
			// 
			this.solveButton.Location = new System.Drawing.Point(433, 188);
			this.solveButton.Name = "solveButton";
			this.solveButton.Size = new System.Drawing.Size(150, 46);
			this.solveButton.TabIndex = 1;
			this.solveButton.Text = "Solve";
			this.solveButton.UseVisualStyleBackColor = true;
			this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(433, 316);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(150, 46);
			this.editButton.TabIndex = 3;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.EditButtonClick);
			// 
			// settingsButton
			// 
			this.settingsButton.Location = new System.Drawing.Point(433, 377);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(150, 46);
			this.settingsButton.TabIndex = 4;
			this.settingsButton.Text = "Settings";
			this.settingsButton.UseVisualStyleBackColor = true;
			this.settingsButton.Click += new System.EventHandler(this.SettingsButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 600);
			this.Controls.Add(this.Placeholder);
			this.Controls.Add(this.settingsButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.solveButton);
			this.Controls.Add(this.rondomizeButton);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Pathfinding";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button settingsButton;
		private System.Windows.Forms.Panel Placeholder;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.Button solveButton;
		private System.Windows.Forms.Button rondomizeButton;
		private System.Windows.Forms.Label title;
	}
}
