using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FR.Rolandl.Carousel
{
	public partial class Carousel
	{
		protected override Java.Lang.Object RawAdapter
		{
			get { return Adapter.JavaCast<Java.Lang.Object>(); }
			set { Adapter = value.JavaCast<global::Android.Widget.ISpinnerAdapter>(); }
		}
	}

	public partial class CarouselSpinner
	{
		protected override Java.Lang.Object RawAdapter
		{
			get { return Adapter.JavaCast<Java.Lang.Object>(); }
			set { Adapter = value.JavaCast<global::Android.Widget.ISpinnerAdapter>(); }
		}
	}

	public partial class CarouselSpinner
	{
	}

}