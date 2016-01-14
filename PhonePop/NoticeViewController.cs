using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

using System.Drawing;
using CoreGraphics;

namespace PhonePop
{
	partial class NoticeViewController : UIViewController
	{
		public NoticeViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewWillLayoutSubviews ()
		{
			//base.ViewWillLayoutSubviews ();
			//this.View.Superview.Bounds = new RectangleF (0, 0, 300, 300);
			Console.WriteLine ("Superview = {0}", 
				this.View.Superview.GetType ().FullName);
			
			this.View.Center = this.View.Window.Center;
			this.View.Frame = new RectangleF (10, 10, 300, 300);
		}

		partial void CloseButton_TouchUpInside (UIButton sender)
		{
			this.ModalTransitionStyle = 
				UIModalTransitionStyle.CrossDissolve;
			DismissViewController(true, null);
		}
	}
}
