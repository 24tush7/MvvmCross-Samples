using System;
using Foundation;
using MvvmCross.Binding.Mac.Views;

namespace FirstDemo.Mac
{
    public partial class FirstView : MvxView
	{
		#region Constructors
		// Called when created from unmanaged code
		public FirstView (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public FirstView (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		// Shared initialization code
		void Initialize ()
		{
		}
		#endregion
	}
}

