namespace Com.Facebook.Drawee.Backends.Pipeline
{
    partial class PipelineDraweeControllerBuilderSupplier
    {
        Java.Lang.Object Com.Facebook.Common.Internal.ISupplier.Get()
        {
            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(Get());
        }
    }

    partial class PipelineDraweeControllerBuilder
    {
        public override unsafe Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri(string p0)
        {
            return SetUri2(p0);
        }

        public override unsafe Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri(Android.Net.Uri p0)
        {
            return SetUri2(p0);
        }

/*        protected override global::Com.Facebook.Datasource.IDataSource GetDataSourceForRequest(global::Com.Facebook.Drawee.Interfaces.IDraweeController p0, string p1, global::Java.Lang.Object p2, global::Java.Lang.Object p3, global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel p4)
        {
            return GetDataSourceForRequest(
                p0,
                p1,
                Android.Runtime.Extensions.JavaCast<Com.Facebook.Imagepipeline.Request.ImageRequest>(p2),
                p3,
                p4
            );
        }*/

        protected override Com.Facebook.Drawee.Controller.AbstractDraweeController ObtainController() => ObtainController2();

    }

    partial class PipelineDraweeController
    {
        protected override unsafe global::Android.Graphics.Drawables.Drawable CreateDrawable(Java.Lang.Object image)
        {
            return CreateDrawable(Android.Runtime.Extensions.JavaCast<Com.Facebook.Common.References.CloseableReference>(image));
        }

        protected override unsafe Java.Lang.Object GetImageInfo(Java.Lang.Object image)
        {
            var info = GetImageInfo(Android.Runtime.Extensions.JavaCast<Com.Facebook.Common.References.CloseableReference>(image));

            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(info);
        }

        protected override unsafe void ReleaseImage(Java.Lang.Object image)
        {
            ReleaseImage(Android.Runtime.Extensions.JavaCast<Com.Facebook.Common.References.CloseableReference>(image));
        }

/*        public override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ObtainExtrasFromImage(Java.Lang.Object info) {
            return ObtainExtrasFromImage(Android.Runtime.Extensions.JavaCast<global::Com.Facebook.Imagepipeline.Image.IImageInfo>(info));
        }*/
    }
}