
namespace Pathfinding
{
	partial class SolveForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolveForm));
			this.DFS = new System.Windows.Forms.PictureBox();
			this.DIJKSTRA = new System.Windows.Forms.PictureBox();
			this.ASTAR = new System.Windows.Forms.PictureBox();
			this.BFS = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.DFS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DIJKSTRA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ASTAR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BFS)).BeginInit();
			this.SuspendLayout();
			// 
			// DFS
			// 
			this.DFS.Image = ((System.Drawing.Image)(resources.GetObject("DFS.Image")));
			this.DFS.Location = new System.Drawing.Point(300, 0);
			this.DFS.Name = "DFS";
			this.DFS.Size = new System.Drawing.Size(300, 200);
			this.DFS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DFS.TabIndex = 2;
			this.DFS.TabStop = false;
			this.DFS.Click += new System.EventHandler(this.PictureBoxClick);
			this.DFS.MouseEnter += new System.EventHandler(this.PictureBoxMouseOver);
			// 
			// DIJKSTRA
			// 
			this.DIJKSTRA.Image = ((System.Drawing.Image)(resources.GetObject("DIJKSTRA.Image")));
			this.DIJKSTRA.Location = new System.Drawing.Point(0, 200);
			this.DIJKSTRA.Name = "DIJKSTRA";
			this.DIJKSTRA.Size = new System.Drawing.Size(300, 200);
			this.DIJKSTRA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.DIJKSTRA.TabIndex = 3;
			this.DIJKSTRA.TabStop = false;
			this.DIJKSTRA.Click += new System.EventHandler(this.PictureBoxClick);
			this.DIJKSTRA.MouseEnter += new System.EventHandler(this.PictureBoxMouseOver);
			// 
			// ASTAR
			// 
			this.ASTAR.Image = ((System.Drawing.Image)(resources.GetObject("ASTAR.Image")));
			this.ASTAR.Location = new System.Drawing.Point(300, 200);
			this.ASTAR.Name = "ASTAR";
			this.ASTAR.Size = new System.Drawing.Size(300, 200);
			this.ASTAR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ASTAR.TabIndex = 5;
			this.ASTAR.TabStop = false;
			this.ASTAR.Click += new System.EventHandler(this.PictureBoxClick);
			this.ASTAR.MouseEnter += new System.EventHandler(this.PictureBoxMouseOver);
			// 
			// BFS
			// 
			this.BFS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BFS.Image = ((System.Drawing.Image)(resources.GetObject("BFS.Image")));
			this.BFS.Location = new System.Drawing.Point(0, 0);
			this.BFS.Name = "BFS";
			this.BFS.Size = new System.Drawing.Size(300, 200);
			this.BFS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BFS.TabIndex = 1;
			this.BFS.TabStop = false;
			this.BFS.Click += new System.EventHandler(this.PictureBoxClick);
			this.BFS.MouseEnter += new System.EventHandler(this.PictureBoxMouseOver);
			// 
			// SolveForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 400);
			this.Controls.Add(this.ASTAR);
			this.Controls.Add(this.DIJKSTRA);
			this.Controls.Add(this.BFS);
			this.Controls.Add(this.DFS);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SolveForm";
			this.Text = "SolveForm";
			this.Load += new System.EventHandler(this.SolveFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.DFS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DIJKSTRA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ASTAR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BFS)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox BFS;
		private System.Windows.Forms.PictureBox ASTAR;
		private System.Windows.Forms.PictureBox DIJKSTRA;
		private System.Windows.Forms.PictureBox DFS;
	}
}
