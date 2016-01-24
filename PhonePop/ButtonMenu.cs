using System;
using System.Collections.Generic;
using System.Linq;

using UIKit;
using CoreGraphics;

namespace PhonePop
{
	public class ButtonMenu
	{
		public delegate void OnSelectedEvent(object sender, object selected);
		public event OnSelectedEvent OnSelected;

		protected bool _show = false;
		protected List<object> _menu;
		protected UIView _parent = null;	
		protected List<UIButton> _buttons = new List<UIButton>();
		protected CGRect _first_rect;

		public ButtonMenu (UIView parent, List<object> menu, CGRect first_rect )
		{			
			_first_rect = first_rect;
			_parent = parent;
			_menu = menu;

			var icon = UIImage.FromFile ("sports.png");

			nfloat y = _first_rect.Y;
			foreach (var obj in menu) {
				
				var button = UIButton.FromType (UIButtonType.Custom);

				button.HorizontalAlignment = UIControlContentHorizontalAlignment.Left;

				/*
				button.ImageEdgeInsets = new UIEdgeInsets (6, 6, 6,120);
				button.TitleEdgeInsets	 = new UIEdgeInsets (6,-30, 6,6);
				*/
				button.ImageEdgeInsets = new UIEdgeInsets(6,120, 6, 10);
				button.TitleEdgeInsets	 = new UIEdgeInsets (6 ,-70, 6, -10);


				button.SetImage (icon, UIControlState.Normal);

				button.SetTitle (obj.ToString(), UIControlState.Normal);
				button.Frame = new CGRect (
					_first_rect.X, y, _first_rect.Width, _first_rect.Height);
				_buttons.Add (button);

				button.TouchUpInside += (object sender, EventArgs e) => {
					button.BackgroundColor = UIColor.Gray;
					OnSelected(this, obj);
				};

				y += _first_rect.Height;
			}
		}

		public void Toggle()
		{
			if (_parent == null || _buttons == null)
				return;
			
			if (_show) {
				foreach (var button in _buttons) {
					button.RemoveFromSuperview ();
					button.BackgroundColor = null;
					button.Hidden = true;
				}

			} else {
				foreach (var button in _buttons) {
					button.Hidden	= false;
					_parent.Add (button);
				}
			}
			_show = !_show;
		}
	}
}

