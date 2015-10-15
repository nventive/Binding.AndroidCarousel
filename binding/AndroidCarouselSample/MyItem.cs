using Android.Content;
using Android.Runtime;
using Android.Views;
using FR.Rolandl.Carousel;
using Java.Lang;

namespace App._3dCarousel
{
	public class MyItem : CarouselItem
	{
		public MyItem(Context p0, int p1) : base(p0, p1)
		{
			
		}

		public override void ExtractView(View p0)
		{
			
		}

		public override void Update(Object p0)
		{
			
		}

		public override int CompareTo(Object another)
		{
			var item = another.JavaCast<CarouselItem>();
			return (int)(item.ItemZ - this.ItemZ);
		}
	}
}