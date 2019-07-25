using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pathfinding
{

	public partial class SettingsForm : Form
	{
		
		// színek
		
		private Point loc;
		public SettingsForm(Point _loc)
		{
		
			InitializeComponent();
			this.loc = _loc;
			this.sizeTrackBar.Value=MainForm.m;
			this.speedTrackBar.Value=MainForm.speed;
			this.sizeLabel.Text = String.Format((sizeTrackBar.Value+"pt")
                .PadRight(6)+Math.Pow((int)(600/sizeTrackBar.Value),2)+"tiles");
			this.speedLabel.Text = speedTrackBar.Value.ToString();
			
		}
		
		void SettingsFormLoad(object sender, EventArgs e)
		{
			this.ClientSize= new Size(600,600);
			this.SetDesktopLocation(this.loc.X,this.loc.Y);
			
		}
		
		void SaveButtonClick(object sender, EventArgs e)
		{
			
			if(this.sizeTrackBar.Value!=MainForm.m){
				DialogResult confirmResult =  MessageBox
					.Show("Your current map will be deleted.","Are you sure?",MessageBoxButtons.OKCancel);
				if (confirmResult == DialogResult.OK)
				{
				   MainForm.SetM(this.sizeTrackBar.Value);
					MainForm.speed = this.speedTrackBar.Value;		
					this.Close();
				}	
			}else{
				MainForm.speed = this.speedTrackBar.Value;		
				this.Close();
			}
			
		}
		
		void SizeTrackBarScroll(object sender, EventArgs e)
		{
			this.sizeLabel.Text = String.Format((sizeTrackBar.Value+"pt").PadRight(6)+Math.Pow((int)(600/sizeTrackBar.Value),2)+"tiles");
		}
		
		void SpeedTrackBarScroll(object sender, EventArgs e)
		{
			this.speedLabel.Text = speedTrackBar.Value.ToString();
		}
		
		void CancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ResetButtonClick(object sender, EventArgs e)
		{
			DialogResult confirmResult =  MessageBox
				.Show("Your settings and your map will be deleted.","Are you sure?",MessageBoxButtons.OKCancel);
			if (confirmResult == DialogResult.OK)
			{
			   	MainForm.SetM(10);
				MainForm.speed = 10;		
				this.Close();
			}
		}
	}
}

//{Width=606, Height=629}