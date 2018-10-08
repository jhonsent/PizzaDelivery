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
    public class productRow : Activity
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.productRow);

            Button addToCart = FindViewById<Button>(Resource.Id.addToCart);

            addToCart.Click += delegate
            {
                AlertDialog.Builder alertDiag = new AlertDialog.Builder(this);
                alertDiag.SetTitle("Add to cart?");
                alertDiag.SetMessage("Add this Pizza to Cart?");
                alertDiag.SetPositiveButton("Add", (senderAlert, args) => {
                    Toast.MakeText(this, "Added to Cart Successfully", ToastLength.Short).Show();
                });
                alertDiag.SetNegativeButton("Cancel", (senderAlert, args) => {
                    alertDiag.Dispose();
                });
                Dialog diag = alertDiag.Create();
                diag.Show();
            };
        }
    }
}