# Development Environment #

This page details what is the recommended environment for you to work with this project's code.




---


## Operating System ##

Since this application has no place in Linux or Mono, the development is solely focused on Windows and .NET.

I'm using Windows XP, but any version after it should work too.

If something not works for you (such as a [commit hook](CommitHooks.md)), file it as an issue. Everything should work (even the program itself) in Windows XP+.

## Framework Version ##

Use .NET 4.0 or above.

Compile for .NET 4.0 Client Profile.

## IDE ##

Use any version of Visual Studio 2010+. I'm using Visual Studio Ultimate 2010, but it should not matter what you use. If something does not work for you because of using the free Visual C# Express, tell me, because this is meant to be usable with any version.

## FxCop ##

Stable code _**must not raise any FxCop warnings**_.

FxCop is integrated in some versions of Visual Studio (not the free ones) and named "Code Analysis".

It can also be downloaded freely from [here](http://www.microsoft.com/download/en/details.aspx?id=6544).

We use all rules; this means tiny mistakes will trigger a warning.

See [Using FxCop](UsingFxCop.md) for more info and exceptions.

## StyleCop ##

Stable code _**must not raise any StyleCop warnings either**_.

StyleCop is also a free tool and can be downloaded from [here](http://stylecop.codeplex.com/releases).

See [Using StyleCop](UsingStyleCop.md) for more info and exceptions.

## TortoiseSVN ##

Since we are on Windows, the best tool for working with SVN is TortoiseSVN.

It is free, download it from [here](http://tortoisesvn.net/downloads.html).

### <font size='2'>Commit Hooks</font> ###

Take a look at the [Commit Hooks](CommitHooks.md) page for info on whatever commit hooks currently in use, and what you need to do manually if you don't want to run them.