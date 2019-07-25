using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Pathfinding
{
	/// <summary>
	/// Description of EditForm.
	/// </summary>
	/// 
	public enum Tile {START, TARGET, UNDEFINED}
	
	public partial class EditForm : Form
	{
		Cell[,] grid;
		public static Tile editTO = Tile.UNDEFINED;
		Point start;
		Point target;
		Point begin;
		
		public EditForm(Cell[,] _grid)
		{
			InitializeComponent();
			this.grid=MainForm.gridCopy(_grid);

			this.ClientSize = new Size(800,600);
			this.DoubleBuffered=true;
			start = new Point(MainForm.start.X,MainForm.start.Y);
			target = new Point(MainForm.target.X,MainForm.target.Y);
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics g = e.Graphics;
			int w = MainForm.gridSize*MainForm.m;
			for(int i=0;i<MainForm.gridSize;i++){
				for(int k = 0;k<MainForm.gridSize;k++){
					grid[i,k].show(g);
				}
			}
			
			g.FillRectangle(Brushes.Cyan,start.X*MainForm.m,start.Y*MainForm.m,MainForm.m,MainForm.m);
			g.FillRectangle(Brushes.DarkOrange,target.X*MainForm.m,target.Y*MainForm.m,MainForm.m,MainForm.m);
			
			for(int i=0;i<MainForm.gridSize;i++){
				g.DrawLine(Pens.DarkGray,0,MainForm.m*i,w,i*MainForm.m);
				g.DrawLine(Pens.DarkGray,i*MainForm.m,0,i*MainForm.m,w);
			}
			
		}
		
		void EditFormMouseUp(object sender, MouseEventArgs e)
		{
			
			if(e.Y<600&&e.X<600&&e.X>=0&&e.Y>=0){
				Point to = new Point(e.X/MainForm.m,e.Y/MainForm.m);
				if(e.Button == MouseButtons.Left){
					if(begin.Y<to.Y){
						for (int i = begin.Y; i <= to.Y; i++) {
							if(begin.X<to.X){
								for (int k = begin.X; k <= to.X; k++) {
									grid[k,i].walkable = eraseCheckBox.Checked;
									
								}
							}else{
								for (int k = begin.X; k >= to.X; k--) {
									grid[k,i].walkable = eraseCheckBox.Checked;
									
								}
							}
							
						}
					}else{
						for (int i = begin.Y; i >= to.Y; i--) {
							if(begin.X<to.X){
								for (int k = begin.X; k <= to.X; k++) {
									grid[k,i].walkable = eraseCheckBox.Checked;
									
								}
							}else{
								for (int k = begin.X; k >= to.X; k--) {
									grid[k,i].walkable = eraseCheckBox.Checked;
									
								}
							}
						}
					}
				}else if(e.Button == MouseButtons.Right){
					ChooseForm choose = new ChooseForm(to,this.DesktopLocation);
					choose.ShowDialog();
					if(editTO == Tile.START){
						if(to == target){
							MessageBox.Show("The start and the target can not be on the same tile!");
						}else{
							this.start=new Point(to.X,to.Y);
						}
					}else if(editTO == Tile.TARGET){
						if(to == start){
							MessageBox.Show("The start and the target can not be on the same tile!");
						}else{
							this.target=new Point(to.X,to.Y);
						}
					}
					
					
					
				}
				
				this.Refresh();
			}
			
		}
		
		void ClearButtonClick(object sender, EventArgs e)
		{
			for(int i = 0; i < MainForm.gridSize; i++){
				for (int k = 0; k < MainForm.gridSize; k++) {
					grid[i,k] = new Cell(i,k,MainForm.m,true,new Vec2(99,99));
				}
			}
			this.Refresh();
		}
		
		void EditFormMouseDown(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left){
				begin.X=e.X/MainForm.m;
				begin.Y=e.Y/MainForm.m;
			}
		}
		
		void SaveButtonClick(object sender, EventArgs e)
		{
			for(int i = 0; i < MainForm.gridSize; i++){
				for (int k = 0; k < MainForm.gridSize; k++) {
					grid[i,k] = new Cell(i,k,MainForm.m,grid[i,k].walkable,new Vec2(target));
				}
			}
			grid[start.X,start.Y].walkable=true;
			grid[target.X,target.Y].walkable=true;
			MainForm.grid = grid;
			MainForm.target = target;
			MainForm.start = start;
			this.Close();
			this.Dispose();
		}
		
		void CancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
		}
		
		void ExpotButtonClick(object sender, EventArgs e)
		{
			grid[start.X,start.Y].walkable=true;
			grid[target.X,target.Y].walkable=true;
			if(exportSaveFileDialog.ShowDialog()==DialogResult.OK)
				if(exportSaveFileDialog.FileName!=""){
				StreamWriter sw = new StreamWriter(exportSaveFileDialog.FileName);
				sw.WriteLine(MainForm.m+","+start.X+","+start.Y+","+target.X+","+target.Y);
				for (int i = 0; i < MainForm.gridSize; i++) {
					for (int k = 0; k < MainForm.gridSize; k++) {
						sw.Write(grid[i,k].ToString());
					}
				}
				
				sw.Close();
				MessageBox.Show("Exported successfuly.");
			}
			
		}
		
		void ImportButtonClick(object sender, EventArgs e)
		{
			try {
				if(importOpenFileDialog.ShowDialog()== DialogResult.OK)
					if(importOpenFileDialog.FileName!=""){
					StreamReader sr = new StreamReader(importOpenFileDialog.OpenFile());
					var head = (sr.ReadLine()).Split(',');
					int m = Convert.ToInt32(head[0]);
					MainForm.SetM(m);
					int sx = Convert.ToInt32(head[1]);
					int sy = Convert.ToInt32(head[2]);
					int tx = Convert.ToInt32(head[3]);
					int ty = Convert.ToInt32(head[4]);
					MainForm.start = new Point(sx,sy);
					MainForm.target = new Point(tx,ty);
					start = new Point(sx,sy);
					target = new Point(tx,ty);
					grid = new Cell[MainForm.gridSize,MainForm.gridSize];
					for (int i = 0; i < MainForm.gridSize; i++) {
						for (int k = 0; k < MainForm.gridSize; k++) {
							grid[i,k] = new Cell(i,k,m,(sr.Read()==48)?false:true,new Vec2(MainForm.target));
						}
					}
					
					this.Refresh();
					
				}
			} catch (Exception) {
				MessageBox.Show("Error!\nWrong file format!");
			}
			
		}
	}
}
//{Width=806, Height=629}
