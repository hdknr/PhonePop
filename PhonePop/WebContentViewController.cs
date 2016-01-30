using System;

using UIKit;

using Foundation;
using ObjCRuntime;

namespace PhonePop
{


	public partial class WebContentViewController : UIViewController
	{
		WebContentView HtmlView { get;set; }

		public WebContentViewController () : base ("WebContentViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			HtmlView = WebContentView.Factory();
			HtmlView.Frame = View.Frame;
			View.AddSubview (HtmlView);

			SetupHtml ();

		}

		public override void DidReceiveMemoryWarning ()
		{
//			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		void SetupHtml()
		{
			HtmlView.Html.Delegate = new MyContentView (this);

			string contentDirectoryPath =
				System.IO.Path.Combine (NSBundle.MainBundle.BundlePath, "");

			string htmml = @"<html><body><a href=""#close"">Close</a></body></html>";

			HtmlView.Html.LoadHtmlString(htmml,
				new NSUrl(contentDirectoryPath, true));
		}

		public  class MyContentView : UIWebViewDelegate
		{
			WebContentViewController Controller {get;set;}

			public MyContentView(WebContentViewController controller)
			{
				Controller = controller;
			}


			public override bool ShouldStartLoad (
					UIWebView webView, NSUrlRequest request, 
					UIWebViewNavigationType navigationType)
			{
				Console.WriteLine (">>>>> URL {0}", request.Url.ToString ());

				//				return OnNavigated(request.u
				if (request.Url.AbsoluteString.EndsWith ("#close")) {
					Controller.DismissViewController (true, () => {
					});
				}
				Console.WriteLine ("@@@@@@ {0}", request.Url.AbsoluteString);
				return true;
			}

		}
	}
}


