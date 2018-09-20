# SimpleConvert

Clean Code oriented library. SimpleConvert adds many method extensions to System.Object so you can perform type conversions in the blink of an eye. Do not even think about the scenarios that you need to consider. Let SimpleConvert do it for you. 

## Getting Started

By just referencing this NuGet package in your project you are done. Now all of you objects will have methods with the signature AsXXX() where XXX is the type you want to transform to.

## Authors

* **Christian Guzman** - *Main Contributor*

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

# Examples

## General Idea

This library adds the methods with the signature AsXXX to all objects for you to convert to all primitive types and string. Examples of these are:

* AsInt()
* AsString()
* AsBoolean()
* AsLong()
* AsShort()
* AsUShort()
* And so on...

And we also have nullable versions

* AsIntNullable()
* AsBooleanNullable()
* AsLongNullable()
* And so on...

Only AsStringNullable has a special case which we will see in the examples.

## AsInt()

```C#

myObj.AsInt();

```

This is the same as doing

```C#

Convert.ToInt32(myObj);

```

## AsIntNullable()

```C#

myObj.AsIntNullable();

```

In this case, if myObj is null then we get null, otherwise we get the value as integer.

## AsString() and AsStringNullable()

For common scenarios you will just get the ToString() of the object.

```C#

myObj.AsString();

```

But let's look at this one...

```C#

string myStr = null;
myStr.AsString();
myStr.AsStringNullable();

```

On the first case we will actually get "" (String.Empty).
On the second case we will get null.

## Float and Single

Float and Single are the same type on C#. However, you have all four methods:

* AsFloat() is exactly the same as AsSingle()
* AsFloatNullable() is exactly the same as AsFloatNullable()

## The other types

There are really no additional complexities for the other types, but I will keep adding examples just for completion.

# Changelog

## 2018-09-19

* Started this project.