# SimpleConvert

Object Method Extensions to perform super simple data conversions without being forced to consider all the scenarios. Let the library do it for you.

## Getting Started

By just referencing this NuGet package in your project you are done. Now all of you objects will have methods with the signature AsXXX() where XXX is the type you want to transform to.

## Authors

* **Christian Guzman** - *Main Contributor*

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

# Examples

## Really, it's too simple

Let's try the easiest example. We will play around a string value that can be transformed to anything.

```
var test = "1000";
int testAsInt = test.AsInt();
```

# Changelog

## 2018-09-19

* Started this project.