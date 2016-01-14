using System;
using UIKit;
using Foundation;

namespace PhonePop
{
	public class MenuTable : UITableViewSource
	{
		public delegate void OnSelectedEvent(object sender, NSIndexPath path);
		public event OnSelectedEvent OnSelected;


		string[] TableItems;
		string CellIdentifier = "TableCell";

		public MenuTable (string[] items)
		{
			TableItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return TableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (CellIdentifier);
			string item = TableItems[indexPath.Row];

			//---- if there are no cells to reuse, create a new one
			if (cell == null)
			{ cell = new UITableViewCell (UITableViewCellStyle.Default, CellIdentifier); }

			cell.TextLabel.Text = item;

			return cell;
		}

		public override void RowSelected (
				UITableView tableView, NSIndexPath indexPath)
		{
			OnSelected (this, indexPath);
		}
	}
}

