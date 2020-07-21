using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CustomFormShape
{
	public partial class CustomShapeForm : Form
	{
		private int SizeFactor = 20;

		PointF[] Corpus = new PointF[] {	new PointF(  0,  0 ),
											new PointF( 17,  0 ),
											new PointF( 17, 10 ),
											new PointF(  0, 10 ),
											new PointF(  0,  6 ),
											new PointF(  1,  6 ),
											new PointF(  1,  4 ),
											new PointF(  0,  4 ),
											new PointF(  0,  0 ) }; 

		PointF[] Latch = new PointF[] {		new PointF(  0,  0 ),
											new PointF(  1,  0 ),
											new PointF(  1,  1 ),
											new PointF(  0,  1 ),
											new PointF(  0,  0 ) }; 

		public CustomShapeForm()
		{
			InitializeComponent();
		}

		void CloseButton_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void CustomShapeForm_Load( object sender, EventArgs e )
		{
			GraphicsPath FormPath = new GraphicsPath( FillMode.Winding );

			// resize Point arrays
			for ( int i=0; i<Corpus.Length; i++ )
			{
				Corpus[i].X *= SizeFactor;
				Corpus[i].Y = Corpus[i].Y * SizeFactor + SizeFactor;
			}

			for ( int i=0; i<Latch.Length; i++ )
			{
				Latch[i].X *= SizeFactor;
				Latch[i].Y *= SizeFactor;
			}

			FormPath.AddPolygon( Corpus );

			// Position 2 rows of latches around the corpus
			PointF[] Reserve = new PointF[Latch.Length];
			Array.Copy( Latch, Reserve, Latch.Length );

			for ( int i = 0; i < 8; i++ )
			{
				for ( int j = 0; j < Latch.Length; j++ )
				{
					Latch[j].X += i * SizeFactor * 2 + SizeFactor;
				}

				FormPath.AddPolygon( Latch );

				for ( int j = 0; j < Latch.Length; j++ )
				{
					Latch[j].Y += Corpus[2].Y;
				}

				FormPath.AddPolygon( Latch );

				Array.Copy( Reserve, Latch, Latch.Length );
			}

			Region myRegion = new Region( FormPath );
			this.Region = myRegion;


		}

	}
}