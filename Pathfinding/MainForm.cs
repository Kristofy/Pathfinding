using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.ComponentModel;

namespace Pathfinding
{
	public enum Method{BFS, DFS, DIJKSTRA, BESTFS, ASTAR, CANCELED};
	public partial class MainForm : Form
	{
		
		public static Point target;
		public static Point start;		
		public static Method method;
		public static Cell[,] grid;
		public static int m=10;
		public static int gridSize=60;
		public static int speed=10;
		
		
		public MainForm()
		{
			InitializeComponent();
			this.ClientSize = new Size(600,600);
			grid = new Cell[100,100];
			
			
			for(int i = 0; i < 100; i++){
				for (int k = 0; k < 100; k++) {
					grid[i,k] = new Cell(i,k,10,true,new Vec2(99,99));
				}
			}
			
			start = new Point(0,0);
			target = new Point(gridSize-1,gridSize-1);
			
		}
		
		public static void SetM(int _m){
			MainForm.m=_m;
			MainForm.gridSize=600/MainForm.m;
			grid = new Cell[gridSize,gridSize];
			
			
			for(int i = 0; i < gridSize; i++){
				for (int k = 0; k < gridSize; k++) {
					grid[i,k] = new Cell(i,k,MainForm.m,true,new Vec2(99,99));
				}
			}
			start = new Point(0,0);
			target = new Point(gridSize-1,gridSize-1);
		}
			
		void MainFormLoad(object sender, EventArgs e)
		{

		}
		
		void PlaceholderPaint(object sender, PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			float m_small = m/1.5f ;
			Placeholder.Size = new Size(Convert.ToInt32(Math.Ceiling((double)(MainForm.gridSize*m_small))),Convert.ToInt32(Math.Ceiling((double)(MainForm.gridSize*m_small))));
			for (int i = 0; i < gridSize; i++) {
				for (int k = 0; k < gridSize; k++) {
					if(!grid[i,k].walkable){
						g.FillRectangle(Brushes.Black,i*m_small,k*m_small,m_small,m_small);	
					}
					
				}
			}
			g.FillRectangle(Brushes.Cyan,start.X*m_small,start.Y*m_small,m_small,m_small);
			g.FillRectangle(Brushes.DarkOrange,target.X*m_small,target.Y*m_small,m_small,m_small);
			
			
		}
		
		void RandomizeButtonClick(object sender, EventArgs e)
		{
			
			int chance = 35;
			string value = "chance";
			if (Prompt.InputBox("Randomize", "The chance of each tile being non walkable(default 35%):", ref value) == DialogResult.OK)
			{
				bool isNumeric = int.TryParse(value, out chance);
				if(isNumeric && chance >=0 && chance <=100){
				chance = Convert.ToInt32(chance);
				Random rnd = new Random();
				for(int i = 0; i < gridSize; i++){
					for (int k = 0; k < gridSize; k++) {
						grid[i,k] = new Cell(i,k,MainForm.m,(rnd.Next(1,101)>chance),new Vec2(target));
					}
				}
				grid[start.X,start.Y].walkable=true;
				grid[target.X,target.Y].walkable=true;
				Placeholder.Refresh();
				}else{
					MessageBox.Show("The chance must be a hole positive number betwen 0 and 100!");
				}
			}
			
		}
		
		void solveButton_Click(object sender, EventArgs e)
		{
			SolveForm f = new SolveForm(this.DesktopLocation);
			f.Show();
			this.Hide();
			f.FormClosed += new FormClosedEventHandler((s,args)=>{
               	this.Show();
               	if(method==Method.CANCELED){
               		return;
               	}
               	
				switch (method) {
					case Method.BFS:
               			BFS bfs = new BFS(gridCopy(grid));
               			bfs.Show();
						break;
					case Method.DFS:
						DFS dfs = new DFS(gridCopy(grid));
						dfs.Show();
						break;
					case Method.DIJKSTRA:
						Dijkstra dijkstra = new Dijkstra(gridCopy(grid));
						dijkstra.Show();
						break;
					case Method.ASTAR:
						AStarPathfinding astar = new AStarPathfinding(gridCopy(grid));
						astar.Show();
						break;
					
						
				}       
         	});
		}	
		
		void EditButtonClick(object sender, EventArgs e)
		{	
			EditForm f = new EditForm(grid);
			f.Show();
			this.Hide();
			f.SetDesktopLocation(this.DesktopLocation.X,this.DesktopLocation.Y);
			f.FormClosed += new FormClosedEventHandler((s,args)=>{
               	this.Show();
               	this.SetDesktopLocation(f.DesktopLocation.X,f.DesktopLocation.Y);
               	Placeholder.Refresh();
           	});
			
		}
		
		public static Cell[,] gridCopy(Cell[,] grid){
			Cell[,] copy = new Cell[MainForm.gridSize,MainForm.gridSize];
           	for (int i = 0; i < MainForm.gridSize; i++) {
           		for (int k = 0; k < MainForm.gridSize; k++) {
           			copy[i,k] = grid[i,k].Clone() as Cell;
           		}
           	}
			return copy;
		}
		
		void SettingsButtonClick(object sender, EventArgs e)
		{
			SettingsForm f = new SettingsForm(this.DesktopLocation);
			f.ShowDialog();
			Placeholder.Refresh();
		}
	}
}
