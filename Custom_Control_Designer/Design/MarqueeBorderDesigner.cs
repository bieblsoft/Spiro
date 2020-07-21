using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Custom_Control_Designer.Design
{
	[System.Security.Permissions.PermissionSet( System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust" )]
	public class MarqueeBorderDesigner : ParentControlDesigner
	{

		public MarqueeBorderDesigner()
		{
			Trace.WriteLine( "MarqueeBorderDesigner" );
		}

		public bool Visible
		{
			get
			{
				return (bool) ShadowProperties["Visible"];
			}
			set
			{
				this.ShadowProperties["Visible"] = value;
			}
		}

		public bool Enabled
		{
			get
			{
				return (bool) ShadowProperties["Enabled"];
			}
			set
			{
				this.ShadowProperties["Enabled"] = value;
			}
		}

		protected override void PreFilterProperties( IDictionary properties )
		{
			base.PreFilterProperties( properties );

			if ( properties.Contains( "Padding" ) )
			{
				properties.Remove( "Padding" );
			}

			properties["Visible"] = TypeDescriptor.CreateProperty(
				typeof( MarqueeBorderDesigner ),
				(PropertyDescriptor) properties["Visible"],
				new Attribute[0] );

			properties["Enabled"] = TypeDescriptor.CreateProperty(
				typeof( MarqueeBorderDesigner ),
				(PropertyDescriptor) properties["Enabled"],
				new Attribute[0] );
		}

		private void OnVerbRunTest( object sender, EventArgs e )
		{
			IMarqueeWidget widget = this.Control as IMarqueeWidget;

			widget.StartMarquee();
		}

		private void OnVerbStopTest( object sender, EventArgs e )
		{
			IMarqueeWidget widget = this.Control as IMarqueeWidget;

			widget.StopMarquee();
		}
	}
}