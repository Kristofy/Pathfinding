using System.Windows.Forms;

namespace Pathfinding
{
	partial class Dijkstra
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
			this.components = new System.ComponentModel.Container();
			this.tick_timer = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.checkedLabel = new System.Windows.Forms.Label();
			this.pathLabel = new System.Windows.Forms.Label();
			this.resetButton = new System.Windows.Forms.Button();
			this.speedLabel = new System.Windows.Forms.Label();
			this.speedTrackBar = new System.Windows.Forms.TrackBar();
			this.label5 = new System.Windows.Forms.Label();
			this.realTimeLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.allInSpeedLabel = new System.Windows.Forms.Label();
			this.time_record = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).BeginInit();
			this.SuspendLayout();
			// 
			// tick_timer
			// 
			this.tick_timer.Interval = 500;
			this.tick_timer.Tick += new System.EventHandler(this.Tick_timerTick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(628, 216);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Checked:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(628, 257);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 40);
			this.label3.TabIndex = 3;
			this.label3.Text = "Path:";
			// 
			// checkedLabel
			// 
			this.checkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.checkedLabel.ForeColor = System.Drawing.Color.Red;
			this.checkedLabel.Location = new System.Drawing.Point(711, 216);
			this.checkedLabel.Name = "checkedLabel";
			this.checkedLabel.Size = new System.Drawing.Size(100, 40);
			this.checkedLabel.TabIndex = 4;
			this.checkedLabel.Text = "0";
			// 
			// pathLabel
			// 
			this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.pathLabel.ForeColor = System.Drawing.Color.Blue;
			this.pathLabel.Location = new System.Drawing.Point(711, 256);
			this.pathLabel.Name = "pathLabel";
			this.pathLabel.Size = new System.Drawing.Size(100, 40);
			this.pathLabel.TabIndex = 5;
			this.pathLabel.Text = "0";
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(628, 19);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(150, 46);
			this.resetButton.TabIndex = 1;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButtonClick);
			// 
			// speedLabel
			// 
			this.speedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.speedLabel.Location = new System.Drawing.Point(722, 142);
			this.speedLabel.Name = "speedLabel";
			this.speedLabel.Size = new System.Drawing.Size(100, 23);
			this.speedLabel.TabIndex = 10;
			this.speedLabel.Text = "500";
			// 
			// speedTrackBar
			// 
			this.speedTrackBar.Location = new System.Drawing.Point(628, 168);
			this.speedTrackBar.Maximum = 1000;
			this.speedTrackBar.Minimum = 1;
			this.speedTrackBar.Name = "speedTrackBar";
			this.speedTrackBar.Size = new System.Drawing.Size(150, 45);
			this.speedTrackBar.TabIndex = 3;
			this.speedTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
			this.speedTrackBar.Value = 500;
			this.speedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBarScroll);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(628, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Speed:";
			// 
			// realTimeLabel
			// 
			this.realTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.realTimeLabel.ForeColor = System.Drawing.Color.Lime;
			this.realTimeLabel.Location = new System.Drawing.Point(711, 315);
			this.realTimeLabel.Name = "realTimeLabel";
			this.realTimeLabel.Size = new System.Drawing.Size(100, 40);
			this.realTimeLabel.TabIndex = 12;
			this.realTimeLabel.Text = "0 s";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(628, 355);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 40);
			this.label6.TabIndex = 11;
			this.label6.Text = "All in speed:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.ForeColor = System.Drawing.Color.Lime;
			this.label4.Location = new System.Drawing.Point(628, 296);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 40);
			this.label4.TabIndex = 11;
			this.label4.Text = "Real time speed:";
			// 
			// allInSpeedLabel
			// 
			this.allInSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.allInSpeedLabel.ForeColor = System.Drawing.Color.Black;
			this.allInSpeedLabel.Location = new System.Drawing.Point(711, 355);
			this.allInSpeedLabel.Name = "allInSpeedLabel";
			this.allInSpeedLabel.Size = new System.Drawing.Size(100, 40);
			this.allInSpeedLabel.TabIndex = 12;
			this.allInSpeedLabel.Text = "0";
			// 
			// time_record
			// 
			this.time_record.Interval = 10;
			this.time_record.Tick += new System.EventHandler(this.Time_recordTick);
			// 
			// Dijkstra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 590);
			this.Controls.Add(this.allInSpeedLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.realTimeLabel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.speedLabel);
			this.Controls.Add(this.speedTrackBar);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.pathLabel);
			this.Controls.Add(this.checkedLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.MaximizeBox = false;
			this.Name = "Dijkstra";
			this.Text = "Dijkstra";
			this.Load += new System.EventHandler(this.DijkstraLoad);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DijkstraKeyUp);
			((System.ComponentModel.ISupportInitialize)(this.speedTrackBar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Timer time_record;
		private System.Windows.Forms.Label allInSpeedLabel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label realTimeLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TrackBar speedTrackBar;
		private System.Windows.Forms.Label speedLabel;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Label pathLabel;
		private System.Windows.Forms.Label checkedLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer tick_timer;
	}
}
