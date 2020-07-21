namespace CustomFormShape
{
	partial class CustomShapeForm
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
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.Color.Salmon;
			this.CloseButton.Location = new System.Drawing.Point( 255, 29 );
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size( 25, 23 );
			this.CloseButton.TabIndex = 0;
			this.CloseButton.Text = "X";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler( this.CloseButton_Click );
			// 
			// CustomShapeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size( 292, 262 );
			this.Controls.Add( this.CloseButton );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CustomShapeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CustomFormShape";
			this.TransparencyKey = System.Drawing.Color.Transparent;
			this.Load += new System.EventHandler( this.CustomShapeForm_Load );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.Button CloseButton;

	}
}

