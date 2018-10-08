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

namespace PizzaOrderApp
{
    public class MyProductListAdapter : BaseAdapter<Product>
    {
        List<Product> Products;

        public MyProductListAdapter(List<Product> Products)
        {
            this.Products = Products;
        }

        public override Product this[int position]
        {
            get
            {
                return Products[position];
            }
        }

        public override int Count
        {
            get
            {
                return Products.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }



        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            
            var view = convertView;
            
            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.productRow, parent, false);

                var photo = view.FindViewById<ImageView>(Resource.Id.photoImageView);
                var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
                var price = view.FindViewById<TextView>(Resource.Id.priceTextView);


                

                view.Tag = new ViewHolder() { Photo = photo, Name = name, Price = price };
            }

            var holder = (ViewHolder)view.Tag;

            holder.Photo.SetImageDrawable(ImageManager.Get(parent.Context, Products[position].ImageUrl));
            holder.Name.Text = Products[position].Name;
            holder.Price.Text = Products[position].Price;


            return view;
            

        }

 
    }

    class MyProductListAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}