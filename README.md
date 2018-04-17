# Fresco Xamarin.Android Binding

Fresco is an exceedingly difficult binding for Xamarin.Android. This project is an ongoing effort to get all of Fresco's domain properly binded and working with Xamarin.

Currently, we have successfully binded WebPs & GIFs. We are currently working towards getting OkHttp libraries supported. 

To get started, follow the documentation over at:
https://github.com/facebook/fresco

Additionally, the code in Fresco.Test is an entry point to how the binding is integrated into a Xamarin.Android app.

## Contributing

Currently some of the projects completely skip any generation of C# code (e.g. see Fresco.ImagePipeline/Transforms/Metadata.xml). We should bind the Fresco reference as best as possible.

A Nuget package that Xamarin apps could consume will be fantastic.

## License

Fresco Xamarin.Android Binding is [MIT-licensed](https://github.com/facebook/fresco/blob/master/LICENSE).
