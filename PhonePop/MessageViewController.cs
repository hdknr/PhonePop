using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PhonePop
{
	partial class MessageViewController : UIViewController
	{
		public MessageViewController (IntPtr handle) : base (handle)
		{
		}

		partial void CloseButton_TouchUpInside (UIButton sender)
		{
			// Close Modal
			// http://furuya02.hatenablog.com/entry/2014/07/02/052557
			DismissViewController(true, null);
		}
	}
}
