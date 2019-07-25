using System;
using System.Drawing;

namespace Pathfinding
{

	public class Vec2{
		public int x;
		public int y;
	    public Vec2(int _x, int _y){
	        this.x=_x;
	        this.y=_y;
	    }
		public Vec2(Point pos){
	        this.x=pos.X;
	        this.y=pos.Y;
	    }
		public override string ToString()
		{
			return string.Format("{0},{1}", x, y);
		}

	}
	
	public class Cell : IComparable,ICloneable{
	
		public State Open;
		public bool walkable;
		public int i;
		public int k;
		private Vec2 pos;
		private int w;
		public float gScore;
		public Cell parent;
		public float hScore;
		public float fScore;
		private Vec2 target;
	
	    public Cell(int i, int k, int w, bool walkable, Vec2 _target){
			this.target = _target;
	        this.Open=State.UNDEFINED;
	        this.walkable=walkable;
	        this.i=i;
	        this.k=k;
	        this.pos= new Vec2(i*w,k*w);
	        this.w=w;
	        this.gScore=100000000;
	        this.parent=null;
	        this.hScore=heuristic();
	        
	        
	        this.fScore=100000000;
	    }
		
		private float heuristic(){	
			return (float)Math.Sqrt(Math.Pow((this.k-target.y),2)+Math.Pow((this.i-target.x),2))*10;
		}
	
	    public void show(Graphics g){
			if(!walkable){
				g.FillRectangle(Brushes.Black,this.pos.x,this.pos.y,this.w,this.w);
				return;
			}
			
			switch (Open) {
				case State.UNDEFINED:
					g.FillRectangle(Brushes.White,this.pos.x,this.pos.y,this.w,this.w);
					break;
				case State.OPENED:
					g.FillRectangle(Brushes.Green,this.pos.x,this.pos.y,this.w,this.w);
					break;
				case State.CLOSED:
					g.FillRectangle(Brushes.Red,this.pos.x,this.pos.y,this.w,this.w);
					break;
				case State.PATH:
					g.FillRectangle(Brushes.Blue,this.pos.x,this.pos.y,this.w,this.w);
					break;
				default:
					throw new Exception("Invalid value for State");
			}
			//g.DrawString(Convert.ToString(fScore), new Font("Times New Roman",12),Brushes.Black,pos.x+3,pos.y+w/2);
			
	    }
	
	    public static float d(Cell a, Cell b){
	        int i=Math.Abs(a.i-b.i);
	        int k=Math.Abs(a.k-b.k);
	        if(k+i==1){
	            return 10;
	        }
	        else{
	            return 14.1421356237f;
	        }
	    }
		
		public virtual int CompareTo(object obj)
		{
			if(fScore==100000000){
				int res = this.gScore.CompareTo(((Cell)obj).gScore);
				if(res == 0){
					return 1;
				}else{
					return res;
				}
			}
			int result = this.fScore.CompareTo(((Cell)obj).fScore);
			if(result==0){
				int res = this.hScore.CompareTo(((Cell)obj).hScore);
				if(res == 0){
					return 1;	
				}else {
				return res;
				}
			}else{
				return result;
			}
		}
		
		public override string ToString()
		{
			return string.Format("{0}",walkable?"1":"0");
		}

		
		public object Clone()
		{
			return new Cell(i,k,w,walkable,target);
		}
	}
	
	
}
