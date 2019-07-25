
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pathfinding
{
	public partial class ChooseForm : Form
	{
		Point pos;
		Point relativeTo;
		
		public ChooseForm(Point _pos,Point _relativeTo)
		{
			InitializeComponent();
			pos=_pos;
			relativeTo=_relativeTo;
		}
		
		void ChooseFormLoad(object sender, EventArgs e)
		{
			this.AutoSize=false;	
			this.SetDesktopLocation(relativeTo.X+(pos.X+1)*MainForm.m,relativeTo.Y+(pos.Y+1)*MainForm.m+26);
		}
		
		void CancelButtonClick(object sender, EventArgs e)
		{
			EditForm.editTO = Tile.UNDEFINED;
			this.Close();
		}
		
		void StartButtonClick(object sender, EventArgs e)
		{
			EditForm.editTO = Tile.START;
			this.Close();
		}
		
		void TargetButtonClick(object sender, EventArgs e)
		{
			EditForm.editTO = Tile.TARGET;
			this.Close();
		}
	}
}
