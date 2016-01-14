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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton PopupViewButton { get; set; }

		[Action ("PopupViewButton_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void PopupViewButton_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (PopupViewButton != null) {
				PopupViewButton.Dispose ();
				PopupViewButton = null;
			}
		}
	}
}
