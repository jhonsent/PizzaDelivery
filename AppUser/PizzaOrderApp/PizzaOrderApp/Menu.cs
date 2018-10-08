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
    [Activity(Label = "Menu")]
    public class Menu : Activity
    {
        ListView myList;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Menu);

            myList = FindViewById<ListView>(Resource.Id.listPizza);
            //myList.Adapter = new MyCustomListAdapter(UserData.Users);

            myList.Adapter = new MyProductListAdapter(ProductData.Products);

        }
        
    }
}