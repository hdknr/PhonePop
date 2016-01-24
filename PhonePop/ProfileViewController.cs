using System;

using UIKit;

namespace PhonePop
{
	public partial class ProfileViewController : UIViewController
	{
		public ProfileViewController () : base ("ProfileViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			var v = ProfileView.Factory();
			v.Frame = View.Frame;
			View.AddSubview (v);

			v.CloseButton.TouchUpInside += (object sender, EventArgs e) => {
				DismissViewController(true, ()=>{});
			};
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


