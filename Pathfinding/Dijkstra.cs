using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using SelfBalancedTree;


namespace Pathfinding
{

	public partial class Dijkstra : Form
	{
		
		private SolveState solveState;
		private int w;
		private Cell[,] grid;
		private Cell target;
		private Cell trace;
		private int speed;
		private int checkedTiles = 0;
		private int pathTiles = 0;
		private Point targetPos;
		private Point startPos;
		private DateTime start;
		private AVLTree<Cell> queue;
		
		public Dijkstra(Cell[,] _grid)
		{
			//SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			InitializeComponent();
			w = MainForm.gridSize*MainForm.m;
			DoubleBuffered=true;
			solveState = SolveState.FIND;
			this.queue = new AVLTree<Cell>();
			this.grid=_grid;
			this.ClientSize = new Size(800,w);
			this.targetPos = new Point(MainForm.target.X,MainForm.target.Y);
			this.startPos = new Point(MainForm.start.X,MainForm.start.Y);
			
			this.target=grid[targetPos.X,targetPos.Y];
			speed = (int)Math.Ceiling(MainForm.speed/10f);
			
			
			tick_timer.Start();
			start = DateTime.Now;
			time_record.Start();
			
			grid[startPos.X,startPos.Y].Open = State.CLOSED;
			grid[startPos.X,startPos.Y].gScore = 0;
			queue.Add(grid[startPos.X,startPos.Y]);
		}
		
		void Tick_timerTick(object sender, EventArgs e)
		{
			for(int i=0;i<this.speed;i++){
				if(solveState== SolveState.FIND){
					Cell current;
					if(!queue.GetMin(out current)){
						this.time_record.Stop();
						this.tick_timer.Stop();
						this.Refresh();
						return;
					}
					current.Open = State.CLOSED;
					queue.DeleteMin();
					
					getNeighbours(current.i,current.k).ForEach((n)=>{
                       	checkedTiles++;
                       	float newG = current.gScore + Cell.d(current,n);
                       	if(newG<n.gScore){
                       		n.parent=current;
                       		n.gScore=newG;
                       	}
                       	
                       	if(n==target){
                       		solveState= SolveState.TRACE;
                       		trace=n;
                       		pathTiles++;
                       		trace.Open=State.PATH;
                       		return;
                       	}
                       	if(n.Open==State.UNDEFINED){
	                       	n.Open = State.OPENED;
	                       	queue.Add(n);
                       	}
                       	
                   });
				}else{
					if(trace.parent!=null){
						pathTiles++;
						trace=trace.parent;
						trace.Open= State.PATH;
					}else{
						time_record.Stop();
						tick_timer.Stop();
						this.Refresh();
						this.checkedLabel.Text = checkedTiles.ToString();
						this.pathLabel.Text = pathTiles.ToString();
						return;
					}
					
				}
				
			}
			
			this.checkedLabel.Text = checkedTiles.ToString();
			this.pathLabel.Text = pathTiles.ToString();
			this.Refresh();

		}
		
		private List<Cell> getNeighbours(int _i, int _k){
			List<Cell> neighbours = new List<Cell>();
			for(int i = -1; i <= 1; i++){
				for(int k = -1; k <= 1;k++){
					if(i!=0 || k!=0){
						int x = i+_i;
						int y = k+_k;
						if(x>=0&&x<MainForm.gridSize&&y>=0&&y<MainForm.gridSize){
							
							if(grid[x,y].walkable&&grid[x,y].Open!=State.CLOSED){
								neighbours.Add(grid[x,y]);
							}
						}
					}
				}
			}
			return neighbours;
		}
		
		protected override void OnPaint( PaintEventArgs e )
		{
			
			Graphics g = e.Graphics;
			int w = MainForm.gridSize*MainForm.m;
			
			g.FillRectangle(Brushes.Gray,0,ClientSize.Width,0,ClientSize.Height);
			
			for(int i=0;i<MainForm.gridSize;i++){
				for(int k = 0;k<MainForm.gridSize;k++){
					grid[i,k].show(g);
				}
			}
			
			g.FillRectangle(Brushes.Cyan,startPos.X*MainForm.m,startPos.Y*MainForm.m,MainForm.m,MainForm.m);
			g.FillRectangle(Brushes.DarkOrange,targetPos.X*MainForm.m,targetPos.Y*MainForm.m,MainForm.m,MainForm.m);
			
			for(int i=0;i<MainForm.gridSize;i++){
				g.DrawLine(Pens.DarkGray,0,i*MainForm.m,w,i*MainForm.m);
				g.DrawLine(Pens.DarkGray,i*MainForm.m,0,i*MainForm.m,w);
			}
			

		}
		
		void reset(){
			tick_timer.Stop();
			//SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			solveState = SolveState.FIND;
			Vec2 t = new Vec2(target.i,target.k);
			for(int i=0;i<MainForm.gridSize;i++){
				for(int k = 0;k<MainForm.gridSize;k++){
					grid[i,k] = new Cell(i,k,MainForm.m,grid[i,k].walkable,t);
				}
			}
			
			this.queue = new AVLTree<Cell>();
			this.target=grid[targetPos.X,targetPos.Y];
			speed = (int)Math.Ceiling(MainForm.speed/10f);
			
			grid[startPos.X,startPos.Y].Open = State.CLOSED;
			grid[startPos.X,startPos.Y].gScore = 0;
			queue.Add(grid[startPos.X,startPos.Y]);
			
			this.pathTiles=0;
			this.pathLabel.Text="0";
			this.checkedTiles=0;
			this.checkedLabel.Text="0";

			this.tick_timer.Interval = 1001 - this.speedTrackBar.Value;
			
			tick_timer.Start();
			start=DateTime.Now;
			time_record.Start();
		}
		
		void ResetButtonClick(object sender, EventArgs e)
		{
			this.reset();
		}
		
		void DijkstraKeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
				this.reset();
			}
		}
		
		void SpeedTrackBarScroll(object sender, EventArgs e)
		{
			this.speedLabel.Text = this.speedTrackBar.Value.ToString();
			this.allInSpeedLabel.Text = (this.speed*(this.speedTrackBar.Value*0.1)).ToString();
		}
		
		void DijkstraLoad(object sender, EventArgs e)
		{
			this.allInSpeedLabel.Text = (this.speed*(this.speedTrackBar.Value*0.1)).ToString();
		}
		
		void Time_recordTick(object sender, EventArgs e)
		{
			TimeSpan diffSpan = ( DateTime.Now - start );
			realTimeLabel.Text = String.Format("{0:N2}",diffSpan.TotalSeconds)+" s";
		}
	}
	
	
}
