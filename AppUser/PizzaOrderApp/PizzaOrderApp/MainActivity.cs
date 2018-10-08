using Android.App;
using Android.Widget;
using Android.OS;

namespace PizzaOrderApp
{
    [Activity(Label = "Pizza House", MainLauncher = true)]

    public class MainActivity : Activity
    {

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

   

            Button btnMenu = FindViewById<Button>(Resource.Id.btnMenu);
            
            btnMenu.Click += delegate 
            {
                //btnMenu.Text = string.Format("{0} clicks!", count++);
                StartActivity(typeof(Menu));
            };
        }
    }
}

