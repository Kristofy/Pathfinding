using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pathfinding
{
	/// <summary>
	/// Description of SolveForm.
	/// </summary>
	public partial class SolveForm : Form
	{
		
		private Point loc;
		
		public SolveForm(Point _loc)
		{
			InitializeComponent();
			this.loc = _loc;	
		}
		
		void SolveFormLoad(object sender, EventArgs e)
		{
			MainForm.method=Method.CANCELED;
			this.ClientSize= new Size(600,400);
			this.SetDesktopLocation(this.loc.X,this.loc.Y);

		}
		
		
		void PictureBoxClick(object sender, EventArgs e)
		{
			MainForm.method = (Method)Enum.Parse(typeof(Method) ,((PictureBox)sender).Name);
			this.Close();
			this.Dispose();
		}
		
			private void PictureBoxMouseOver(object sender, EventArgs e)
		{
			unselectBox(this);
		
		try{
			PictureBox picBox = (PictureBox)(sender);
		
			picBox.BorderStyle = BorderStyle.Fixed3D;
		}catch{
			return;
		}
			
		}
		
		private void unselectBox(Control Form)
		{
			foreach (Control cControl in Form.Controls)
			{
				if (cControl is PictureBox)
				{
					((PictureBox)cControl).BorderStyle = BorderStyle.None;
				}
			}
		}
	}
}
//616 439 