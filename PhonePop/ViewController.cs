using System;

using UIKit;

namespace PhonePop
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void PopupViewButton_TouchUpInside (UIButton sender)
		{
			var id = "MessageViewController";
			var vc = (MessageViewController)
					Storyboard.InstantiateViewController(id);
		
			// Modal
			// http://furuya02.hatenablog.com/entry/2014/07/02/052557
			PresentViewController(vc, true, null);
		}
	}
}

