using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Custom_Control_Designer
{
	[DesignTimeVisible(true)]
	public partial class Composite : UserControl
	{
		public Composite()
		{
			InitializeComponent();
		}

		private Color hintergrund;

		public Color Hintergrund
		{
			get
			{
				return hintergrund;
			}
			set
			{
				hintergrund = value;
				this.BackColor = hintergrund;
			}
		}

		//public Color Hintergrund { set, get } // VS 2008 only !

		private void checkBox1_CheckedChanged( object sender, EventArgs e )
		{
			if ( checkBox1.Checked )
			{
				pictureBox1.Hide();
			}
			else
			{
				pictureBox1.Show();
			}
		}
	}
}