namespace Controltest
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
			this.composite1 = new Custom_Control_Designer.Composite();
			this.myMarquee1 = new Custom_Control_Designer.MyMarquee();
			this.SuspendLayout();
			// 
			// composite1
			// 
			this.composite1.BackColor = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 255 ) ) ) ), ( (int) ( ( (byte) ( 192 ) ) ) ), ( (int) ( ( (byte) ( 192 ) ) ) ) );
			this.composite1.Hintergrund = System.Drawing.Color.FromArgb( ( (int) ( ( (byte) ( 255 ) ) ) ), ( (int) ( ( (byte) ( 192 ) ) ) ), ( (int) ( ( (byte) ( 192 ) ) ) ) );
			this.composite1.Location = new System.Drawing.Point( 45, 44 );
			this.composite1.Name = "composite1";
			this.composite1.Size = new System.Drawing.Size( 150, 150 );
			this.composite1.TabIndex = 0;
			// 
			// myMarquee1
			// 
			this.myMarquee1.Location = new System.Drawing.Point( 293, 56 );
			this.myMarquee1.Name = "myMarquee1";
			this.myMarquee1.Size = new System.Drawing.Size( 150, 150 );
			this.myMarquee1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 583, 400 );
			this.Controls.Add( this.myMarquee1 );
			this.Controls.Add( this.composite1 );
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout( false );

		}

		#endregion

		private Custom_Control_Designer.Composite composite1;
		private Custom_Control_Designer.MyMarquee myMarquee1;
	}
}

