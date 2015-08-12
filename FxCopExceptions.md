# FxCop Exceptions #

This page lists exceptions to FxCop rules, and justifications.

If you think you have a reason for another exception, feel free to add a comment here, or better yet, [send me an e-mail](http://about.me/camilomartin).

You may also want to check [StyleCop Exceptions](StyleCopExceptions.md).




---


## `CA1707:IdentifiersShouldNotContainUnderscores` ##

### <font size='2'>Where to suppress CA1707</font> ###

In constants named after Windows API constants.

You know, those horrible ones that have horrible names and that get used in native interop. [Example](http://code.google.com/p/msile/source/browse/trunk/solution/Constants.cs#30): `WS_EX_COMPOSITED`.

### <font size='2'>Why to suppress CA1707</font> ###

Because keeping the name the way it is helps finding the original documentation for the constant.

Check [this thread on StackOverflow](http://stackoverflow.com/questions/9917942/naming-windows-api-constants-in-c-sharp), there is consensus.

### <font size='2'>How to suppress CA1707</font> ###

Add a line to the `GlobalSuppressions.cs` file. Example:

```cs
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707:IdentifiersShouldNotContainUnderscores", Scope = "member", Target = "Msile.Constants.#WS_EX_COMPOSITED")]```

## `CA1709:IdentifiersShouldBeCasedCorrectly` ##

### <font size='2'>Where to suppress CA1709</font> ###

See [CA1707](#Where_to_suppress_CA1707.md).

### <font size='2'>Why to suppress CA1709</font> ###

See [CA1707](#Why_to_suppress_CA1707.md).

### <font size='2'>How to suppress CA1709</font> ###

See [CA1707](#How_to_suppress_CA1707.md).