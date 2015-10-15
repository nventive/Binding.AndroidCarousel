
package fr.rolandl.sample.carousel.adapter;

import android.content.Context;
import android.graphics.Color;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.ArrayList;
import java.util.List;

import fr.rolandl.carousel.CarouselAdapter;
import fr.rolandl.carousel.CarouselItem;
import fr.rolandl.sample.carousel.R;
import fr.rolandl.sample.carousel.bo.Photo;

public final class MyAdapter2
        extends BaseAdapter
{

  private final List<CarouselItem<Photo>> items = new ArrayList<>();

  public MyAdapter2(Context context, List<Photo> items)
  {
    for (int i = 0; i < items.size(); i++)
    {
      Photo currentItem = items.get(i);
      final CarouselItem<Photo> item = getCarouselItem(context);
      item.setIndex(i);
      item.update(currentItem);

      ImageView img = new ImageView(context);
      img.setImageResource(context.getResources().getIdentifier(currentItem.image, "drawable", context.getPackageName()));

      TextView txt = new TextView(context);
      txt.setTextColor(Color.WHITE);
      txt.setHighlightColor(Color.BLACK);
      txt.setText("Item " + i);

      item.addView(img);
      item.addView(txt);

      this.items.add(item);
    }
  }

  @Override
  public int getCount()
  {
    if (items == null)
    {
      return 0;
    }

    return items.size();
  }

  @Override
  public Object getItem(int position)
  {
    return position;
  }

  @Override
  public long getItemId(int position)
  {
    return position;
  }

  @Override
  public View getView(int position, View convertView, ViewGroup parent)
  {
    return items.get(position);
  }

  public CarouselItem<Photo> getCarouselItem(Context context)
  {
    CarouselItem<Photo>  c = new CarouselItem<Photo>(context, new android.widget.LinearLayout(context)) {
      Photo photo;
      @Override
      public void extractView(View view) {

      }

      @Override
      public void update(Photo arg0) {
        photo=arg0;
      }
    };
    return c;
  }


}
