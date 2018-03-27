using System;
using System.Collections.Generic;
using Android.Graphics.Drawables;
using Android.Runtime;
using Com.Facebook.Imagepipeline.Drawable;
using Com.Facebook.Imagepipeline.Image;

namespace Com.Facebook.Fresco.Animation.Factory
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.fresco.animation.factory']/class[@name='ExperimentalBitmapAnimationDrawableFactory']"
    [global::Android.Runtime.Register("com/facebook/fresco/animation/factory/ExperimentalBitmapAnimationDrawableFactory", DoNotGenerateAcw = true)]
    public partial class ExperimentalBitmapAnimationDrawableFactory : global::Java.Lang.Object, global::Com.Facebook.Imagepipeline.Drawable.IDrawableFactory
    {


        // Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.fresco.animation.factory']/class[@name='ExperimentalBitmapAnimationDrawableFactory']/field[@name='CACHING_STRATEGY_FRESCO_CACHE']"
        [Register("CACHING_STRATEGY_FRESCO_CACHE")]
        public const int CachingStrategyFrescoCache = (int)1;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.fresco.animation.factory']/class[@name='ExperimentalBitmapAnimationDrawableFactory']/field[@name='CACHING_STRATEGY_FRESCO_CACHE_NO_REUSING']"
        [Register("CACHING_STRATEGY_FRESCO_CACHE_NO_REUSING")]
        public const int CachingStrategyFrescoCacheNoReusing = (int)2;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.fresco.animation.factory']/class[@name='ExperimentalBitmapAnimationDrawableFactory']/field[@name='CACHING_STRATEGY_KEEP_LAST_CACHE']"
        [Register("CACHING_STRATEGY_KEEP_LAST_CACHE")]
        public const int CachingStrategyKeepLastCache = (int)3;

        // Metadata.xml XPath field reference: path="/api/package[@name='com.facebook.fresco.animation.factory']/class[@name='ExperimentalBitmapAnimationDrawableFactory']/field[@name='CACHING_STRATEGY_NO_CACHE']"
        [Register("CACHING_STRATEGY_NO_CACHE")]
        public const int CachingStrategyNoCache = (int)0;
        // Metadata.xml XPath class reference: path="/api/package[@name='com.facebook.fresco.animation.factory']/class[@name='ExperimentalBitmapAnimationDrawableFactory.AnimationFrameCacheKey']"
        [global::Android.Runtime.Register("com/facebook/fresco/animation/factory/ExperimentalBitmapAnimationDrawableFactory$AnimationFrameCacheKey", DoNotGenerateAcw = true)]
        public partial class AnimationFrameCacheKey : global::Java.Lang.Object, global::Com.Facebook.Cache.Common.ICacheKey
        {

            internal static new IntPtr java_class_handle;
            internal static new IntPtr class_ref
            {
                get
                {
                    return JNIEnv.FindClass("com/facebook/fresco/animation/factory/ExperimentalBitmapAnimationDrawableFactory$AnimationFrameCacheKey", ref java_class_handle);
                }
            }

            protected override IntPtr ThresholdClass
            {
                get { return class_ref; }
            }

            protected override global::System.Type ThresholdType
            {
                get { return typeof(AnimationFrameCacheKey); }
            }

            protected AnimationFrameCacheKey(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

            static IntPtr id_ctor_I;
            // Metadata.xml XPath constructor reference: path="/api/package[@name='com.facebook.fresco.animation.factory']/class[@name='ExperimentalBitmapAnimationDrawableFactory.AnimationFrameCacheKey']/constructor[@name='ExperimentalBitmapAnimationDrawableFactory.AnimationFrameCacheKey' and count(parameter)=1 and parameter[1][@type='int']]"
            [Register(".ctor", "(I)V", "")]
            public unsafe AnimationFrameCacheKey(int p0)
                : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
            {
                if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                    return;

                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(p0);
                    if (((object)this).GetType() != typeof(AnimationFrameCacheKey))
                    {
                        SetHandle(
                                global::Android.Runtime.JNIEnv.StartCreateInstance(((object)this).GetType(), "(I)V", __args),
                                JniHandleOwnership.TransferLocalRef);
                        global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "(I)V", __args);
                        return;
                    }

                    if (id_ctor_I == IntPtr.Zero)
                        id_ctor_I = JNIEnv.GetMethodID(class_ref, "<init>", "(I)V");
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor_I, __args),
                            JniHandleOwnership.TransferLocalRef);
                    JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor_I, __args);
                }
                finally
                {
                }
            }

            static Delegate cb_getUriString;
#pragma warning disable 0169
            static Delegate GetGetUriStringHandler()
            {
                if (cb_getUriString == null)
                    cb_getUriString = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_GetUriString);
                return cb_getUriString;
            }

            static IntPtr n_GetUriString(IntPtr jnienv, IntPtr native__this)
            {
                global::Com.Facebook.Fresco.Animation.Factory.ExperimentalBitmapAnimationDrawableFactory.AnimationFrameCacheKey __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Fresco.Animation.Factory.ExperimentalBitmapAnimationDrawableFactory.AnimationFrameCacheKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                return JNIEnv.NewString(__this.UriString);
            }
#pragma warning restore 0169

            static IntPtr id_getUriString;
            public virtual unsafe string UriString
            {
                // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.fresco.animation.factory']/class[@name='ExperimentalBitmapAnimationDrawableFactory.AnimationFrameCacheKey']/method[@name='getUriString' and count(parameter)=0]"
                [Register("getUriString", "()Ljava/lang/String;", "GetGetUriStringHandler")]
                get
                {
                    if (id_getUriString == IntPtr.Zero)
                        id_getUriString = JNIEnv.GetMethodID(class_ref, "getUriString", "()Ljava/lang/String;");
                    try
                    {

                        if (((object)this).GetType() == ThresholdType)
                            return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getUriString), JniHandleOwnership.TransferLocalRef);
                        else
                            return JNIEnv.GetString(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getUriString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
                    }
                    finally
                    {
                    }
                }
            }

            static Delegate cb_containsUri_Landroid_net_Uri_;
#pragma warning disable 0169
            static Delegate GetContainsUri_Landroid_net_Uri_Handler()
            {
                if (cb_containsUri_Landroid_net_Uri_ == null)
                    cb_containsUri_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, bool>)n_ContainsUri_Landroid_net_Uri_);
                return cb_containsUri_Landroid_net_Uri_;
            }

            static bool n_ContainsUri_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
            {
                global::Com.Facebook.Fresco.Animation.Factory.ExperimentalBitmapAnimationDrawableFactory.AnimationFrameCacheKey __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Fresco.Animation.Factory.ExperimentalBitmapAnimationDrawableFactory.AnimationFrameCacheKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
                global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri>(native_p0, JniHandleOwnership.DoNotTransfer);
                bool __ret = __this.ContainsUri(p0);
                return __ret;
            }
#pragma warning restore 0169

            static IntPtr id_containsUri_Landroid_net_Uri_;
            // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.fresco.animation.factory']/class[@name='ExperimentalBitmapAnimationDrawableFactory.AnimationFrameCacheKey']/method[@name='containsUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
            [Register("containsUri", "(Landroid/net/Uri;)Z", "GetContainsUri_Landroid_net_Uri_Handler")]
            public virtual unsafe bool ContainsUri(global::Android.Net.Uri p0)
            {
                if (id_containsUri_Landroid_net_Uri_ == IntPtr.Zero)
                    id_containsUri_Landroid_net_Uri_ = JNIEnv.GetMethodID(class_ref, "containsUri", "(Landroid/net/Uri;)Z");
                try
                {
                    JValue* __args = stackalloc JValue[1];
                    __args[0] = new JValue(p0);

                    bool __ret;
                    if (((object)this).GetType() == ThresholdType)
                        __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_containsUri_Landroid_net_Uri_, __args);
                    else
                        __ret = JNIEnv.CallNonvirtualBooleanMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "containsUri", "(Landroid/net/Uri;)Z"), __args);
                    return __ret;
                }
                finally
                {
                }
            }

        }

        internal static new IntPtr java_class_handle;
        internal static new IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/facebook/fresco/animation/factory/ExperimentalBitmapAnimationDrawableFactory", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(ExperimentalBitmapAnimationDrawableFactory); }
        }

        protected ExperimentalBitmapAnimationDrawableFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static Delegate cb_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_;
#pragma warning disable 0169
        static Delegate GetCreateDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_Handler()
        {
            if (cb_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_ == null)
                cb_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_CreateDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_);
            return cb_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_;
        }

        static IntPtr n_CreateDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Facebook.Fresco.Animation.Factory.ExperimentalBitmapAnimationDrawableFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Fresco.Animation.Factory.ExperimentalBitmapAnimationDrawableFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Facebook.Imagepipeline.Image.CloseableImage p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.CloseableImage>(native_p0, JniHandleOwnership.DoNotTransfer);
            IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.CreateDrawable(p0));
            return __ret;
        }
#pragma warning restore 0169

        static IntPtr id_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.fresco.animation.factory']/class[@name='ExperimentalBitmapAnimationDrawableFactory']/method[@name='createDrawable' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.image.CloseableImage']]"
        [Register("createDrawable", "(Lcom/facebook/imagepipeline/image/CloseableImage;)Lcom/facebook/fresco/animation/drawable/AnimatedDrawable2;", "GetCreateDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_Handler")]
        public virtual unsafe global::Com.Facebook.Fresco.Animation.Drawable.AnimatedDrawable2 CreateDrawable(global::Com.Facebook.Imagepipeline.Image.CloseableImage p0)
        {
            if (id_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_ == IntPtr.Zero)
                id_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_ = JNIEnv.GetMethodID(class_ref, "createDrawable", "(Lcom/facebook/imagepipeline/image/CloseableImage;)Lcom/facebook/fresco/animation/drawable/AnimatedDrawable2;");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                global::Com.Facebook.Fresco.Animation.Drawable.AnimatedDrawable2 __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Fresco.Animation.Drawable.AnimatedDrawable2>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_createDrawable_Lcom_facebook_imagepipeline_image_CloseableImage_, __args), JniHandleOwnership.TransferLocalRef);
                else
                    __ret = global::Java.Lang.Object.GetObject<global::Com.Facebook.Fresco.Animation.Drawable.AnimatedDrawable2>(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "createDrawable", "(Lcom/facebook/imagepipeline/image/CloseableImage;)Lcom/facebook/fresco/animation/drawable/AnimatedDrawable2;"), __args), JniHandleOwnership.TransferLocalRef);
                return __ret;
            }
            finally
            {
            }
        }

        Android.Graphics.Drawables.Drawable IDrawableFactory.CreateDrawable(CloseableImage p0)
        {
            throw new NotImplementedException();
        }

        static Delegate cb_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_;
#pragma warning disable 0169
        static Delegate GetSupportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_Handler()
        {
            if (cb_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_ == null)
                cb_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, bool>)n_SupportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_);
            return cb_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_;
        }

        static bool n_SupportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
        {
            global::Com.Facebook.Fresco.Animation.Factory.ExperimentalBitmapAnimationDrawableFactory __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Fresco.Animation.Factory.ExperimentalBitmapAnimationDrawableFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
            global::Com.Facebook.Imagepipeline.Image.CloseableImage p0 = global::Java.Lang.Object.GetObject<global::Com.Facebook.Imagepipeline.Image.CloseableImage>(native_p0, JniHandleOwnership.DoNotTransfer);
            bool __ret = __this.SupportsImageType(p0);
            return __ret;
        }
#pragma warning restore 0169

        static IntPtr id_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_;
        // Metadata.xml XPath method reference: path="/api/package[@name='com.facebook.fresco.animation.factory']/class[@name='ExperimentalBitmapAnimationDrawableFactory']/method[@name='supportsImageType' and count(parameter)=1 and parameter[1][@type='com.facebook.imagepipeline.image.CloseableImage']]"
        [Register("supportsImageType", "(Lcom/facebook/imagepipeline/image/CloseableImage;)Z", "GetSupportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_Handler")]
        public virtual unsafe bool SupportsImageType(global::Com.Facebook.Imagepipeline.Image.CloseableImage p0)
        {
            if (id_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_ == IntPtr.Zero)
                id_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_ = JNIEnv.GetMethodID(class_ref, "supportsImageType", "(Lcom/facebook/imagepipeline/image/CloseableImage;)Z");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                bool __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_supportsImageType_Lcom_facebook_imagepipeline_image_CloseableImage_, __args);
                else
                    __ret = JNIEnv.CallNonvirtualBooleanMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "supportsImageType", "(Lcom/facebook/imagepipeline/image/CloseableImage;)Z"), __args);
                return __ret;
            }
            finally
            {
            }
        }
    }
}
