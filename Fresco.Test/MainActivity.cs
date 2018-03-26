using Android.App;
using Android.Widget;
using Android.OS;
using Android.Net;
using Com.Facebook.Drawee.View;

namespace Fresco.Test
{
    [Activity(Label = "Fresco.Test", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Com.Facebook.Drawee.Backends.Pipeline.Fresco.Initialize(this);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Uri uri = Uri.Parse("https://raw.githubusercontent.com/facebook/fresco/master/docs/static/logo.png");
            SimpleDraweeView draweeView = (SimpleDraweeView)FindViewById(Resource.Id.my_image_view);
            draweeView.SetImageURI(uri);
        }
    }
}

