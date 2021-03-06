﻿using System;

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
//			PresentNotice();
//			PresentLurk();
//			PresentAlert();
//			PushSelection();
//			PresentButonMenu();
//			ProfileView();
			WebContentView();

		}

		public void WebContentView()
		{
			PresentViewController (new WebContentViewController (), true, null);

		}

		public void ProfileView()
		{
			// XIB 
			PresentViewController (new ProfileViewController (), true, null);
		}
		public void PresentButonMenu()
		{
			var vc = Storyboard.InstantiateViewController("ButtonMenuViewController");
			PresentViewController(vc, true,null);
		}
		public void PushSelection(){
			var vc = Storyboard.InstantiateViewController("SelectionViewController");
			if (NavigationController != null)
				NavigationController.PushViewController (vc, true);
			else {
				PresentViewController (vc, true, null);
			}
		}


		public void PresentAlert()
		{
			UIAlertView alert = new UIAlertView () { 
				Title = "alert title", Message = "this is a simple alert"
			};
			alert.AddButton("OK");
			alert.Show ();
		}
		public void PresentLurk()
		{
			var id = "LurkViewController";
			var vc = (LurkViewController)
				Storyboard.InstantiateViewController(id);

			// http://marunouchi-tech.i-studio.co.jp/506/
			vc.ModalPresentationStyle = 
				UIModalPresentationStyle.OverCurrentContext;

			PresentViewController(vc, true,null);
		}
		public void PresentNotice()
		{
			var id = "NoticeViewController";
			var vc = (NoticeViewController)
				Storyboard.InstantiateViewController(id);

			//vc.ModalTransitionStyle = UIModalTransitionStyle.CrossDissolve;

			// http://marunouchi-tech.i-studio.co.jp/506/
			vc.ModalPresentationStyle = 
					UIModalPresentationStyle.OverCurrentContext;

			PresentViewController(vc, true,null);
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

	}
}

