using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Configuration;

namespace Printing
{
	public partial class Form1 : Form
	{
		private float BigRadius = 100.0F;
		private float SmallRadius = 30.0F;
		private float PunktVector = 20.0F;
		private float Kreisbogen_Max = 360.0F;
		private float Kreisbogen = 0.0F;
		private int tMax = 1;
		private enum Darstellungsarten
		{
			Hypozykloiden,
			Epizykloiden
		};
		private Darstellungsarten Darstellung = Darstellungsarten.Hypozykloiden;
		private Thread Worker = null;
		private PointF[] Points;
		private PrintDocument PDoc;
		private PrintDialog pDia;
		private PrintPreviewDialog pView;

		public Form1()
		{
			InitializeComponent();

			trackBar1.Value = (int) BigRadius;
			trackBar2.Value = (int) SmallRadius;
			F_RGross.Text = BigRadius.ToString();
			F_rKlein.Text = SmallRadius.ToString();
			F_ZPunkt.Text = PunktVector.ToString();
			F_tMax.Text = tMax.ToString();
		}
		  
		private void Canvas_Paint( object sender, PaintEventArgs e )
		{
			if ( Points != null )
			{
				Graphics Screen = e.Graphics;
				Screen.SmoothingMode = SmoothingMode.HighQuality;
				Screen.Clear( Canvas.BackColor );
				Pen PaintPen = new Pen( Canvas.ForeColor );
				Screen.DrawLines( PaintPen, Points );
			}
		}

		private void button1_Click( object sender, EventArgs e )
		{
			BigRadius = float.Parse( F_RGross.Text );
			SmallRadius = float.Parse( F_rKlein.Text );
			PunktVector = float.Parse( F_ZPunkt.Text );
			Kreisbogen_Max = (float) ( float.Parse( F_tMax.Text ) * 100 * Math.PI );
			tMax = (int) ( Kreisbogen_Max * 10.0F ) / 10;

			Points = new PointF[tMax*10+2];
			Worker = new Thread( new ThreadStart( this.Run ) );
			Worker.Start();
		}

		private void Run()
		{
			float xPos = 0.0F;
			float yPos = 0.0F;
			int index = 0;

			while ( true )
			{
				try
				{
					for ( float Pos = Kreisbogen; Pos < Kreisbogen_Max; Pos += 0.1F )
					{
						try
						{
							if ( Darstellung == Darstellungsarten.Hypozykloiden )
							{
								xPos = ( BigRadius - SmallRadius ) *
										(float) Math.Cos( (double) ( SmallRadius / BigRadius ) * Pos ) +
										PunktVector * (float) Math.Cos( (double) ( 1 - ( SmallRadius / BigRadius ) ) * Pos );
								yPos = ( BigRadius - SmallRadius ) *
										(float) Math.Sin( (double) ( SmallRadius / BigRadius ) * Pos ) -
										PunktVector * (float) Math.Sin( (double) ( 1 - ( SmallRadius / BigRadius ) ) * Pos );
							}
							else if ( Darstellung == Darstellungsarten.Epizykloiden )
							{
								xPos = ( BigRadius + SmallRadius ) *
										(float) Math.Cos( (double) ( SmallRadius / BigRadius ) * Pos ) -
										PunktVector * (float) Math.Cos( (double) ( 1 + ( SmallRadius / BigRadius ) ) * Pos );
								yPos = ( BigRadius + SmallRadius ) *
										(float) Math.Sin( (double) ( SmallRadius / BigRadius ) * Pos ) -
										PunktVector * (float) Math.Sin( (double) ( 1 + ( SmallRadius / BigRadius ) ) * Pos );
							}
							Points[index++] = new PointF( xPos + Canvas.Width / 2, yPos + Canvas.Height / 2 );
						}
						catch ( IndexOutOfRangeException )
						{
						}
					}

					Canvas.Invalidate(); // calls Paint method, refreshing the Canvas
					Worker.Abort();
				}
				catch ( ThreadAbortException abo )
				{
					Worker = null;
				}
			}
		}

		private void F_Darstellung_SelectedIndexChanged( object sender, EventArgs e )
		{
			Darstellung = (Darstellungsarten) F_Darstellung.SelectedIndex;
			while ( Worker != null )
			{
			};

			button1.PerformClick();
		}

		private void button2_Click( object sender, EventArgs e )
		{
			pDia = new PrintDialog();
			DialogResult result = pDia.ShowDialog();

			if ( result == DialogResult.OK )
			{
				PDoc = new PrintDocument();
				PDoc.PrinterSettings = pDia.PrinterSettings;

				PDoc.PrintPage += new PrintPageEventHandler( PDoc_PrintPage );
				PDoc.Print();
			}
		}

		void PDoc_PrintPage( object sender, PrintPageEventArgs e )
		{
			if ( Points != null )
			{
				Graphics Screen = e.Graphics;
				Screen.Clear( Canvas.BackColor );
				Pen PaintPen = new Pen( Canvas.ForeColor );
				Screen.DrawLines( PaintPen, Points );
			}
		}

		private void button3_Click( object sender, EventArgs e )
		{
			PDoc = new PrintDocument();
			PDoc.DocumentName = "Spirograph";
			PDoc.PrintPage += new PrintPageEventHandler( PDoc_PrintPage );
			pView = new PrintPreviewDialog();
			pView.Document = PDoc;
			pView.UseAntiAlias = true;
			pView.Show();
		}

		private void button4_Click( object sender, EventArgs e )
		{
			DialogResult res = this.colorDialog1.ShowDialog();
			if ( res == DialogResult.OK )
			{
				this.Canvas.BackColor = colorDialog1.Color;
			}
		}

		private void Form1_FormClosing( object sender, FormClosingEventArgs e )
		{
			global::Printing.Properties.Settings.Default.ScreenColor = this.Canvas.BackColor;
			global::Printing.Properties.Settings.Default.PaintColor = this.Canvas.ForeColor;
			global::Printing.Properties.Settings.Default.Save();
		}

		private void button5_Click( object sender, EventArgs e )
		{
			DialogResult res = this.colorDialog1.ShowDialog();
			if ( res == DialogResult.OK )
			{
				this.Canvas.ForeColor = colorDialog1.Color;
			}

		}

		private void trackBar1_Scroll( object sender, EventArgs e )
		{
			BigRadius = trackBar1.Value;
			F_RGross.Text = BigRadius.ToString();
			while ( Worker != null ) {};

			button1.PerformClick();
		}

		private void trackBar2_Scroll( object sender, EventArgs e )
		{
			SmallRadius = trackBar2.Value;
			F_rKlein.Text = SmallRadius.ToString();
			while ( Worker != null ) {};

			button1.PerformClick();
		}

		private void TextChanged( object sender, EventArgs e )
		{
			while ( Worker != null ) {};

			button1.PerformClick();

		}

	}
}