namespace Marqueetest
{
	partial class MyMarquee
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.marqueeBorder1 = new Custom_Control_Designer.MarqueeBorder();
			this.marqueeText3 = new Custom_Control_Designer.MarqueeText();
			this.marqueeText2 = new Custom_Control_Designer.MarqueeText();
			this.marqueeText1 = new Custom_Control_Designer.MarqueeText();
			this.marqueeBorder1.SuspendLayout();
			this.SuspendLayout();
			// 
			// marqueeBorder1
			// 
			this.marqueeBorder1.Controls.Add( this.marqueeText3 );
			this.marqueeBorder1.Controls.Add( this.marqueeText2 );
			this.marqueeBorder1.Controls.Add( this.marqueeText1 );
			this.marqueeBorder1.DarkColor = System.Drawing.SystemColors.Control;
			this.marqueeBorder1.Enabled = true;
			this.marqueeBorder1.LightColor = System.Drawing.Color.Yellow;
			this.marqueeBorder1.LightPeriod = 3;
			this.marqueeBorder1.LightShape = Custom_Control_Designer.MarqueeLightShape.Circle;
			this.marqueeBorder1.LightSize = 10;
			this.marqueeBorder1.LightSpacing = 1;
			this.marqueeBorder1.Location = new System.Drawing.Point( 22, 24 );
			this.marqueeBorder1.Name = "marqueeBorder1";
			this.marqueeBorder1.Size = new System.Drawing.Size( 200, 100 );
			this.marqueeBorder1.SpinDirection = Custom_Control_Designer.MarqueeSpinDirection.CW;
			this.marqueeBorder1.TabIndex = 0;
			this.marqueeBorder1.UpdatePeriod = 50;
			this.marqueeBorder1.Visible = true;
			// 
			// marqueeText3
			// 
			this.marqueeText3.DarkColor = System.Drawing.SystemColors.Control;
			this.marqueeText3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
			this.marqueeText3.ForeColor = System.Drawing.Color.Tomato;
			this.marqueeText3.LightColor = System.Drawing.Color.Tomato;
			this.marqueeText3.Location = new System.Drawing.Point( 21, 31 );
			this.marqueeText3.Name = "marqueeText3";
			this.marqueeText3.Size = new System.Drawing.Size( 166, 36 );
			this.marqueeText3.TabIndex = 0;
			this.marqueeText3.Text = "Sonderaktion";
			this.marqueeText3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.marqueeText3.UpdatePeriod = 50;
			// 
			// marqueeText2
			// 
			this.marqueeText2.AutoSize = true;
			this.marqueeText2.DarkColor = System.Drawing.SystemColors.Control;
			this.marqueeText2.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.marqueeText2.LightColor = System.Drawing.Color.DarkSlateBlue;
			this.marqueeText2.Location = new System.Drawing.Point( 102, 67 );
			this.marqueeText2.Name = "marqueeText2";
			this.marqueeText2.Size = new System.Drawing.Size( 52, 13 );
			this.marqueeText2.TabIndex = 0;
			this.marqueeText2.Text = "Einmalig !";
			this.marqueeText2.UpdatePeriod = 50;
			// 
			// marqueeText1
			// 
			this.marqueeText1.AutoSize = true;
			this.marqueeText1.DarkColor = System.Drawing.SystemColors.Control;
			this.marqueeText1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.marqueeText1.LightColor = System.Drawing.Color.DarkSlateBlue;
			this.marqueeText1.Location = new System.Drawing.Point( 23, 20 );
			this.marqueeText1.Name = "marqueeText1";
			this.marqueeText1.Size = new System.Drawing.Size( 62, 13 );
			this.marqueeText1.TabIndex = 0;
			this.marqueeText1.Text = "Nur Heute !";
			this.marqueeText1.UpdatePeriod = 50;
			// 
			// MyMarquee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add( this.marqueeBorder1 );
			this.Name = "MyMarquee";
			this.Size = new System.Drawing.Size( 236, 150 );
			this.marqueeBorder1.ResumeLayout( false );
			this.marqueeBorder1.PerformLayout();
			this.ResumeLayout( false );

		}

		#endregion

		private Custom_Control_Designer.MarqueeBorder marqueeBorder1;
		private Custom_Control_Designer.MarqueeText marqueeText1;
		private Custom_Control_Designer.MarqueeText marqueeText2;
		private Custom_Control_Designer.MarqueeText marqueeText3;
	}
}
