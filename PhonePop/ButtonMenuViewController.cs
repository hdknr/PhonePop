using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

using System.Collections.Generic;
using System.Linq;
using CoreGraphics;

namespace PhonePop
{
	partial class ButtonMenuViewController : UIViewController
	{
		ButtonMenu _menu = null;
		public ButtonMenuViewController (IntPtr handle) : base (handle)
		{
			
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var items = new List<object> {
				"Vegetables","Fruits","Flower Buds",
				"Legumes","Bulbs","Tubers"
			};
			_menu = new ButtonMenu(this.View, items, 
				new CGRect (230, HeaderView.Frame.Height + 30, 150, 30));
			_menu.OnSelected += (object sender, object selected) => {
				Console.WriteLine("object {0}", selected.ToString());
				_menu.Toggle();
			};
				
		}

		partial void MenuButton_TouchUpInside (UIButton sender)
		{
			_menu.Toggle();
		}


	}
}
