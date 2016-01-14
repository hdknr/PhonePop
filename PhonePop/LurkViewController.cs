using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

using System.Drawing;
using CoreGraphics;

namespace PhonePop
{
	partial class LurkViewController : UIViewController
	{
		public LurkViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewWillLayoutSubviews ()
		{
			this.View.BackgroundColor = UIColor.White.ColorWithAlpha (0.6f);

			this.ContentView.Layer.BorderWidth = 10.0f;
			this.ContentView.Layer.BorderColor = UIColor.Yellow.CGColor;
			this.ContentView.Layer.CornerRadius = 30.0f;
			this.ContentView.Layer.MasksToBounds = true;

			CloseButton ();

			base.ViewWillLayoutSubviews ();
		}

		UIButton  _close_button ;

		void CloseButton()
		{
			var icon = UIImage.FromFile ("close_button.png");
			_close_button = UIButton.FromType (UIButtonType.Custom);
			_close_button.SetImage (icon, UIControlState.Normal);
			_close_button.SetImage (icon, UIControlState.Highlighted);
			_close_button.SetImage (icon, UIControlState.Disabled);

			var size = ContentView.Frame.Size;
			_close_button.Frame = new CGRect (size.Width - 5 , 35, 50, 50);
			
			View.AddSubview (_close_button);	
			_close_button.TouchDown += (object sender, EventArgs e) => {

				this.ModalTransitionStyle = 
					UIModalTransitionStyle.CrossDissolve;
				DismissViewController(true, null);		
			};
		}

	}
}
