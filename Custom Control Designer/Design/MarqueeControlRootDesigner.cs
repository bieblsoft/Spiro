using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Custom_Control_Designer.Design
{
	[ToolboxItemFilter( "Custom_Control_Designer.MarqueeBorder", ToolboxItemFilterType.Require )]
	[ToolboxItemFilter( "Custom_Control_Designer.MarqueeText", ToolboxItemFilterType.Require )]
	[System.Security.Permissions.PermissionSet( System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust" )]
	public class MarqueeControlRootDesigner : DocumentDesigner
	{

		public MarqueeControlRootDesigner()
		{
			Trace.WriteLine( "MarqueeControlRootDesigner ctor" );
		}

		public override void Initialize( IComponent component )
		{
			base.Initialize( component );

			IComponentChangeService cs =
				GetService( typeof( IComponentChangeService ) )
				as IComponentChangeService;

			if ( cs != null )
			{
				cs.ComponentChanged +=
					new ComponentChangedEventHandler( OnComponentChanged );
			}

			this.Verbs.Add(
				new DesignerVerb( "Run Test",
				new EventHandler( OnVerbRunTest ) )
				);

			this.Verbs.Add(
				new DesignerVerb( "Stop Test",
				new EventHandler( OnVerbStopTest ) )
				);
		}

		private void OnComponentChanged(
			object sender,
			ComponentChangedEventArgs e )
		{
			if ( e.Component is IMarqueeWidget )
			{
				this.Control.Refresh();
			}
		}

		private void OnVerbRunTest( object sender, EventArgs e )
		{
			MarqueeControl c = this.Control as MarqueeControl;

			c.Start();
		}

		private void OnVerbStopTest( object sender, EventArgs e )
		{
			MarqueeControl c = this.Control as MarqueeControl;

			c.Stop();
		}
	}
}