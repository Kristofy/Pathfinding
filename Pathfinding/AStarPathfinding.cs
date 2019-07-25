using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using SelfBalancedTree;

namespace Pathfinding
{

	public enum State {UNDEFINED, OPENED, CLOSED,PATH};
	public enum SolveState{FIND,TRACE}
	public partial class AStarPathfinding : Form
	{
		
		private float heuristic = 1f;
		private SolveState solveState;
		private int w;
		private Cell[,] grid;
		private Cell target;
		private AVLTree<Cell> OpenSet;
		private Cell trace;
		private int speed;
		private int checkedTiles = 0;
		private int pathTiles = 0;
		private DateTime start;
		private Point targetPos;
		private Point startPos;
		
		public AStarPathfinding(Cell[,] _grid)
		{
			//SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			w = MainForm.gridSize*MainForm.m;
			InitializeComponent();
			DoubleBuffered=true;
			OpenSet = new AVLTree<Cell>();
			solveState = SolveState.FIND;	
			
			this.ClientSize = new Size(800,w);

			this.targetPos = new Point(MainForm.target.X,MainForm.target.Y);
			this.startPos = new Point(MainForm.start.X,MainForm.start.Y);
			
			grid = _grid;
			speed = (int)Math.Ceiling(MainForm.speed/10f);
			target=grid[targetPos.X,targetPos.Y];
			
		    grid[startPos.X,startPos.Y].gScore=0;
		    grid[startPos.X,startPos.Y].Open=State.OPENED;
		    grid[startPos.X,startPos.Y].fScore=grid[startPos.X,startPos.Y].hScore*heuristic+grid[startPos.X,startPos.Y].gScore;

		    OpenSet.Add(grid[startPos.X,startPos.Y]);
		    
			tick_timer.Start();
			start = DateTime.Now;
			time_record.Start();
			
		}
			
		void Tick_timerTick(object sender, EventArgs e)
		{
			for(int i=0;i<this.speed;i++)
			if (solveState == SolveState.FIND) {
				Cell current;
				if(!OpenSet.GetMin(out current)){
					time_record.Stop();
					tick_timer.Stop();
					this.Refresh();
					return;
				}
			    current.Open=State.CLOSED;
			    OpenSet.DeleteMin();
			    
				List<Cell> neighbours = getNeighbours(current.i, current.k);
				neighbours.ForEach(n => {
		            float newGScore = current.gScore + Cell.d(current,n);
		            if(newGScore<n.gScore){
		            	
			            n.gScore=newGScore;
			            n.fScore=n.hScore*heuristic+n.gScore;
			            n.parent=current;
			           
			            this.checkedTiles++;
			            if(n.Open==State.UNDEFINED){
			                n.Open=State.OPENED;
			                OpenSet.Add(n);
			            }
			        }
	          	});
				
				if(current==target){
			        solveState=SolveState.TRACE;
			        trace=target;
			        pathTiles++;
			        trace.Open=State.PATH;
			    }
			}else{
				if(trace.parent!=null){
					pathTiles++;
					trace.parent.Open=State.PATH;
					trace = trace.parent;
				}else{
					tick_timer.Stop();
					time_record.Stop();
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
							
							if(grid[x,y].walkable == true&&grid[x,y].Open!= State.CLOSED){
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
			OpenSet = new AVLTree<Cell>();
			solveState = SolveState.FIND;
			Vec2 t = new Vec2(target.i,target.k);
			for(int i=0;i<MainForm.gridSize;i++){
        		for(int k = 0;k<MainForm.gridSize;k++){
					grid[i,k] = new Cell(i,k,MainForm.m,grid[i,k].walkable,t);
        		}
    		}
			
			target=grid[targetPos.X,targetPos.Y];
		    grid[startPos.X,startPos.Y].gScore=0;
		    grid[startPos.X,startPos.Y].Open=State.OPENED;
		    grid[startPos.X,startPos.Y].fScore=grid[startPos.X,startPos.Y].hScore*heuristic+grid[startPos.X,startPos.Y].gScore;

		    OpenSet.Add(grid[startPos.X,startPos.Y]);
		    
		    
		    this.pathTiles=0;
		    this.pathLabel.Text="0";
		    this.checkedTiles=0;
		    this.checkedLabel.Text="0";
		    this.heuristic=heuristicTrackBar.Value/100;
		    this.tick_timer.Interval = 1001 - this.speedTrackBar.Value;
		    
			tick_timer.Start();
			start=DateTime.Now;
			time_record.Start();
		}
		
		void HeuristicsTrackBar(object sender, EventArgs e)
		{
			this.heuristicLabel.Text = Convert.ToString(this.heuristicTrackBar.Value/100f);
		}
		
		void ResetButtonClick(object sender, EventArgs e)
		{
			this.reset();
		}
			
		void AStarPathfindingKeyUp(object sender, KeyEventArgs e)
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
		
		void AStarPathfindingLoad(object sender, EventArgs e)
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
