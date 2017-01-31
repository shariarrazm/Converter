using System;

using UIKit;

namespace Converter.iOS
{
	public partial class ViewController : UIViewController
	{
		

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			// Perform any additional setup after loading the view, typically from a nib.
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate
			{
				var convert = new CurrencyConverter(amountTextField.Text);
				var result = convert.ConvertCurrency();
				resultLabel.Text = result;
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}
	}
}
