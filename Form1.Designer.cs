namespace Printing
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.F_Darstellung = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.F_tMax = new System.Windows.Forms.TextBox();
			this.F_ZPunkt = new System.Windows.Forms.TextBox();
			this.F_rKlein = new System.Windows.Forms.TextBox();
			this.F_RGross = new System.Windows.Forms.TextBox();
			this.Canvas = new System.Windows.Forms.Panel();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			( (System.ComponentModel.ISupportInitialize) ( this.trackBar2 ) ).BeginInit();
			( (System.ComponentModel.ISupportInitialize) ( this.trackBar1 ) ).BeginInit();
			this.SuspendLayout();
			// 
			// colorDialog1
			// 
			this.colorDialog1.Color = global::Printing.Properties.Settings.Default.ScreenColor;
			this.colorDialog1.FullOpen = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point( 0, 0 );
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.AutoScroll = true;
			this.splitContainer1.Panel1.Controls.Add( this.trackBar2 );
			this.splitContainer1.Panel1.Controls.Add( this.trackBar1 );
			this.splitContainer1.Panel1.Controls.Add( this.button5 );
			this.splitContainer1.Panel1.Controls.Add( this.button4 );
			this.splitContainer1.Panel1.Controls.Add( this.button3 );
			this.splitContainer1.Panel1.Controls.Add( this.button2 );
			this.splitContainer1.Panel1.Controls.Add( this.F_Darstellung );
			this.splitContainer1.Panel1.Controls.Add( this.button1 );
			this.splitContainer1.Panel1.Controls.Add( this.label4 );
			this.splitContainer1.Panel1.Controls.Add( this.label5 );
			this.splitContainer1.Panel1.Controls.Add( this.label3 );
			this.splitContainer1.Panel1.Controls.Add( this.label2 );
			this.splitContainer1.Panel1.Controls.Add( this.label1 );
			this.splitContainer1.Panel1.Controls.Add( this.F_tMax );
			this.splitContainer1.Panel1.Controls.Add( this.F_ZPunkt );
			this.splitContainer1.Panel1.Controls.Add( this.F_rKlein );
			this.splitContainer1.Panel1.Controls.Add( this.F_RGross );
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add( this.Canvas );
			this.splitContainer1.Size = new System.Drawing.Size( 551, 624 );
			this.splitContainer1.SplitterDistance = 183;
			this.splitContainer1.TabIndex = 1;
			// 
			// trackBar2
			// 
			this.trackBar2.LargeChange = 20;
			this.trackBar2.Location = new System.Drawing.Point( 198, 43 );
			this.trackBar2.Maximum = 250;
			this.trackBar2.Minimum = 1;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size( 153, 50 );
			this.trackBar2.TabIndex = 23;
			this.trackBar2.TickFrequency = 10;
			this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.trackBar2.Value = 1;
			this.trackBar2.Scroll += new System.EventHandler( this.trackBar2_Scroll );
			// 
			// trackBar1
			// 
			this.trackBar1.LargeChange = 20;
			this.trackBar1.Location = new System.Drawing.Point( 198, 8 );
			this.trackBar1.Maximum = 250;
			this.trackBar1.Minimum = 1;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size( 153, 50 );
			this.trackBar1.TabIndex = 23;
			this.trackBar1.TickFrequency = 10;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			this.trackBar1.Value = 1;
			this.trackBar1.Scroll += new System.EventHandler( this.trackBar1_Scroll );
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point( 355, 43 );
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size( 99, 23 );
			this.button5.TabIndex = 21;
			this.button5.Text = "Zeichenfarbe";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler( this.button5_Click );
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point( 355, 14 );
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size( 99, 23 );
			this.button4.TabIndex = 22;
			this.button4.Text = "Hintergrundfarbe";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler( this.button4_Click );
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point( 460, 72 );
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size( 92, 23 );
			this.button3.TabIndex = 20;
			this.button3.TabStop = false;
			this.button3.Text = "Druckvorschau";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler( this.button3_Click );
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point( 460, 43 );
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size( 91, 23 );
			this.button2.TabIndex = 18;
			this.button2.TabStop = false;
			this.button2.Text = "Drucken";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler( this.button2_Click );
			// 
			// F_Darstellung
			// 
			this.F_Darstellung.Items.AddRange( new object[] {
            "Hypozykloiden",
            "Epizykloiden"} );
			this.F_Darstellung.Location = new System.Drawing.Point( 198, 115 );
			this.F_Darstellung.Name = "F_Darstellung";
			this.F_Darstellung.Size = new System.Drawing.Size( 121, 21 );
			this.F_Darstellung.TabIndex = 19;
			this.F_Darstellung.SelectedIndexChanged += new System.EventHandler( this.F_Darstellung_SelectedIndexChanged );
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point( 460, 14 );
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size( 91, 23 );
			this.button1.TabIndex = 16;
			this.button1.TabStop = false;
			this.button1.Text = "Zeichnen";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler( this.button1_Click );
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point( 195, 93 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size( 132, 13 );
			this.label4.TabIndex = 14;
			this.label4.Text = "von Mittelpunkt Innenkreis";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point( 71, 119 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size( 52, 13 );
			this.label5.TabIndex = 10;
			this.label5.Text = "Vollkreise";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 8, 93 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 115, 13 );
			this.label3.TabIndex = 9;
			this.label3.Text = "Abstand Zeichenpunkt";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 19, 49 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 104, 13 );
			this.label2.TabIndex = 11;
			this.label2.Text = "Radius Innenenkreis";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 23, 11 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 100, 13 );
			this.label1.TabIndex = 13;
			this.label1.Text = "Radius Aussenkreis";
			// 
			// F_tMax
			// 
			this.F_tMax.Location = new System.Drawing.Point( 129, 116 );
			this.F_tMax.Name = "F_tMax";
			this.F_tMax.Size = new System.Drawing.Size( 60, 20 );
			this.F_tMax.TabIndex = 17;
			this.F_tMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.F_tMax.TextChanged += new System.EventHandler( this.TextChanged );
			// 
			// F_ZPunkt
			// 
			this.F_ZPunkt.Location = new System.Drawing.Point( 129, 90 );
			this.F_ZPunkt.Name = "F_ZPunkt";
			this.F_ZPunkt.Size = new System.Drawing.Size( 60, 20 );
			this.F_ZPunkt.TabIndex = 15;
			this.F_ZPunkt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.F_ZPunkt.TextChanged += new System.EventHandler( this.TextChanged );
			// 
			// F_rKlein
			// 
			this.F_rKlein.Location = new System.Drawing.Point( 129, 46 );
			this.F_rKlein.Name = "F_rKlein";
			this.F_rKlein.Size = new System.Drawing.Size( 60, 20 );
			this.F_rKlein.TabIndex = 12;
			this.F_rKlein.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// F_RGross
			// 
			this.F_RGross.Location = new System.Drawing.Point( 129, 8 );
			this.F_RGross.Name = "F_RGross";
			this.F_RGross.Size = new System.Drawing.Size( 60, 20 );
			this.F_RGross.TabIndex = 8;
			this.F_RGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.F_RGross.TextChanged += new System.EventHandler( this.TextChanged );
			// 
			// Canvas
			// 
			this.Canvas.AutoScroll = true;
			this.Canvas.BackColor = global::Printing.Properties.Settings.Default.ScreenColor;
			this.Canvas.DataBindings.Add( new System.Windows.Forms.Binding( "BackColor", global::Printing.Properties.Settings.Default, "ScreenColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged ) );
			this.Canvas.DataBindings.Add( new System.Windows.Forms.Binding( "ForeColor", global::Printing.Properties.Settings.Default, "PaintColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged ) );
			this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canvas.ForeColor = global::Printing.Properties.Settings.Default.PaintColor;
			this.Canvas.Location = new System.Drawing.Point( 0, 0 );
			this.Canvas.Name = "Canvas";
			this.Canvas.Size = new System.Drawing.Size( 551, 437 );
			this.Canvas.TabIndex = 1;
			this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler( this.Canvas_Paint );
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = global::Printing.Properties.Settings.Default.FormSize;
			this.Controls.Add( this.splitContainer1 );
			this.DataBindings.Add( new System.Windows.Forms.Binding( "Location", global::Printing.Properties.Settings.Default, "FormLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged ) );
			this.DataBindings.Add( new System.Windows.Forms.Binding( "ClientSize", global::Printing.Properties.Settings.Default, "FormSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged ) );
			this.Location = global::Printing.Properties.Settings.Default.FormLocation;
			this.Name = "Form1";
			this.Text = "Spirograph (Drucken)";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.Form1_FormClosing );
			this.splitContainer1.Panel1.ResumeLayout( false );
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout( false );
			this.splitContainer1.ResumeLayout( false );
			( (System.ComponentModel.ISupportInitialize) ( this.trackBar2 ) ).EndInit();
			( (System.ComponentModel.ISupportInitialize) ( this.trackBar1 ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox F_Darstellung;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox F_tMax;
		private System.Windows.Forms.TextBox F_ZPunkt;
		private System.Windows.Forms.TextBox F_rKlein;
		private System.Windows.Forms.TextBox F_RGross;
		private System.Windows.Forms.Panel Canvas;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TrackBar trackBar2;
	}
}

