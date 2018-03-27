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

            {
                var uri = Uri.Parse("https://raw.githubusercontent.com/facebook/fresco/master/docs/static/logo.png");
                var draweeView = (SimpleDraweeView)FindViewById(Resource.Id.basic_image);
                draweeView.SetImageURI(uri);
            }

            {
                var uri = Uri.Parse("http://www.gstatic.com/webp/gallery/2.webp");
                var draweeView = (SimpleDraweeView)FindViewById(Resource.Id.webp_static);
                draweeView.SetImageURI(uri);
            }

            {
                var uri = Uri.Parse("https://www.gstatic.com/webp/gallery3/5_webp_ll.webp");
                var draweeView = (SimpleDraweeView)FindViewById(Resource.Id.webp_translucent);
                draweeView.SetImageURI(uri);
            }

            {
                var uri = Uri.Parse("https://www.gstatic.com/webp/animated/1.webp");
                var draweeView = (SimpleDraweeView)FindViewById(Resource.Id.webp_animated);
                var builder = Com.Facebook.Drawee.Backends.Pipeline.Fresco.NewDraweeControllerBuilder();
                builder.SetAutoPlayAnimations(true);
                builder.SetOldController(draweeView.Controller);
                builder.SetUri(uri);
                draweeView.Controller = builder.Build();
            }

            {
                var uri = Uri.Parse("http://frescolib.org/static/sample-images/fresco_logo_anim_full_frames_with_pause_s.gif");
                var draweeView = (SimpleDraweeView)FindViewById(Resource.Id.gif_animated);
                var builder = Com.Facebook.Drawee.Backends.Pipeline.Fresco.NewDraweeControllerBuilder();
                builder.SetAutoPlayAnimations(true);
                builder.SetOldController(draweeView.Controller);
                builder.SetUri(uri);
                draweeView.Controller = builder.Build();
            }
        }
    }
}

