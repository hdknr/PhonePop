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
	[Register ("SelectionViewController")]
	partial class SelectionViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton MenuButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView MenuList { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (MenuButton != null) {
				MenuButton.Dispose ();
				MenuButton = null;
			}
			if (MenuList != null) {
				MenuList.Dispose ();
				MenuList = null;
			}
		}
	}
}
