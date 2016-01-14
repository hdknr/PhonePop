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


		public void PresentMessage()
		{
			var id = "MessageViewController";
			var vc = (MessageViewController)
				Storyboard.InstantiateViewController(id);


			if( vc.ModalTransitionStyle == UIModalTransitionStyle.CoverVertical )
			{
				// CoverVertical is default.
				vc.ModalTransitionStyle = UIModalTransitionStyle.FlipHorizontal;
			}

			// Modal
			// http://furuya02.hatenablog.com/entry/2014/07/02/052557
			PresentViewController(vc, true, 
				() =>{
					// Here is action executed after View Controller show up
					(new UIAlertView("Hello", "Are you fine?", null, null, "OK"))
						.Show();
				}
			);
		}
		partial void PopupViewButton_TouchUpInside (UIButton sender)
		{
			// PresentMessage();

			var id = "NoticeViewController";
			var vc = (NoticeViewController)
				Storyboard.InstantiateViewController(id);
			PresentViewController(vc, true,null);
		}
	}
}

