using System;
using System.Linq;
using Android.App;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Widget;
using Android.OS;
using Android.Util;
using FR.Rolandl.Carousel;
using Org.Apache.Http.Conn;

namespace App._3dCarousel
{
	[Activity(Label = "Android Carousel (Xamarin)", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		private Carousel carousel;


		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			carousel = new Carousel(ApplicationContext);
			SetContentView(carousel);

			var items = new[]
			{
				Resource.Drawable.cat,//0
				Resource.Drawable.panda,//1
				Resource.Drawable.mouse,//2
				Resource.Drawable.rabbit,//3
				Resource.Drawable.hippo,//4
				Resource.Drawable.monkey,//5
				Resource.Drawable.cat,//6
				Resource.Drawable.panda,//7
				Resource.Drawable.mouse,//8
				Resource.Drawable.rabbit,//9
				Resource.Drawable.hippo,//10
				Resource.Drawable.monkey,//11
			};
			
			var adapter = new MyAdapter(this, items);
			carousel.Adapter = adapter;
			adapter.NotifyDataSetChanged();

			carousel.ItemClick += (sender, args) =>
			{
				Toast.MakeText(this, "Item clicked" + args.P2.ToString(), ToastLength.Short).Show();
				carousel.ScrollToChild(args.P2);
				Console.WriteLine("Click" + args.P2);
			};
			carousel.ItemSelected += (sender, args) =>
			{
				Toast.MakeText(this, "Item Selected" + args.P2.ToString(), ToastLength.Short).Show();
			};
		}
	}
}

