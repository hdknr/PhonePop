// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PhonePop
{
	[Register ("ButtonMenuViewController")]
	partial class ButtonMenuViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView HeaderView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton MenuButton { get; set; }

		[Action ("MenuButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void MenuButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (HeaderView != null) {
				HeaderView.Dispose ();
				HeaderView = null;
			}
			if (MenuButton != null) {
				MenuButton.Dispose ();
				MenuButton = null;
			}
		}
	}
}
