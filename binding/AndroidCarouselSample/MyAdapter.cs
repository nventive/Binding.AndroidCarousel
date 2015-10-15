using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace App._3dCarousel
{
	public class MyAdapter : Android.Widget.BaseAdapter
	{
		private readonly Context _ctx;
		private readonly int[] _toArray;
		private List<MyItem> _items;

		public MyAdapter(Context ctx, int[] toArray)
		{
			_ctx = ctx;
			_toArray = toArray;
			_items = new List<MyItem>();
			for (int i = 0; i < toArray.Length; i++)
			{
				var res = toArray[i];
				var item = new MyItem(_ctx, new LinearLayout(_ctx));
				var img = new ImageView(_ctx);
				img.SetImageResource(res);
				item.AddView(img);
				item.SetMinimumHeight(800);
				item.SetMinimumWidth(300);
				TextView txt = new TextView(_ctx);
				txt.SetTextColor(Color.White);
				txt.SetHighlightColor(Color.Black);
				txt.SetText("Item " + i, TextView.BufferType.Normal);
				item.AddView(txt);

				item.Index = i;
				_items.Add(item);
			}
		}

		public override Object GetItem(int position)
		{
			return null;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			if (convertView != null)
			{
				return convertView;
				;
			}
			if (position < 0)
			{
				return new TextView(Application.Context);
			}

			return _items[position];

		}

		public override int Count
		{
			get { return _toArray.Length; }
		}
	}
}