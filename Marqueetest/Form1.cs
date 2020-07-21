using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Marqueetest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			myMarquee1.Start();
		}

		private void button2_Click( object sender, EventArgs e )
		{
			myMarquee1.Stop();
		}
	}
}