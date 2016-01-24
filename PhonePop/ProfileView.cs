using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using ObjCRuntime;


namespace PhonePop
{
	partial class ProfileView : UIView
	{
		public ProfileView (IntPtr handle) : base (handle)
		{
		}

		public static ProfileView Factory()
		{

			var arr = NSBundle.MainBundle.LoadNib ("ProfileView", null, null);
			var v = Runtime.GetNSObject<ProfileView> (arr.ValueAt(0));

			return v;
		}
		public override void AwakeFromNib(){

			TitleLabel.Text = System.DateTime.Now.ToLongTimeString ();
		}
	}
}
