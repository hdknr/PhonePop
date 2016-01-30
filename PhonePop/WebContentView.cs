using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using ObjCRuntime;


namespace PhonePop
{


	partial class WebContentView : UIView
	{
		const string NibName = "WebContentView";

		public UIWebView Html {get { return ContentHtml; }}

		public WebContentView (IntPtr handle) : base (handle)
		{
		}

		public static WebContentView Factory()
		{

			var arr = NSBundle.MainBundle.LoadNib (NibName, null, null);
			var v = Runtime.GetNSObject<WebContentView> (arr.ValueAt(0));

			return v;
		}
		public override void AwakeFromNib(){


		}
	}
}
