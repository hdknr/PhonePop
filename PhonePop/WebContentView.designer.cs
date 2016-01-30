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
	[Register ("WebContentView")]
	partial class WebContentView
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIWebView ContentHtml { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ContentHtml != null) {
				ContentHtml.Dispose ();
				ContentHtml = null;
			}
		}
	}
}
