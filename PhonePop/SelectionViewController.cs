using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PhonePop
{
	partial class SelectionViewController : UIViewController
	{
		public SelectionViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			MenuList.Hidden = true;
			MenuList.SeparatorStyle = UITableViewCellSeparatorStyle.None;

			MenuButton.TouchDown += (object sender, EventArgs e) => {
				MenuList.Hidden = !MenuList.Hidden;
			};
				
			string[] tableItems = new string[] {
				"Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers"
			};
			var menu = new MenuTable(tableItems);
			menu.OnSelected += (object sender, NSIndexPath path) => {
				Console.WriteLine("***** {0}", path.Row);
				// MenuList.DeselectRow(path, true);
				MenuList.Hidden = true;	
			};
			MenuList.Source = menu;

		}


	}
}
