# Memoize and FuncEx

.net / C# Memoize and Func extensions. 

So, what is memoization? Wikipedia has a straight forward explaination 

>...memoization is an optimization technique used primarily to speed up computer programs by storing the results of expensive function calls and returning the cached result when the same inputs occur again

Read in full here [http://en.wikipedia.org/wiki/Memoization].

## Nuget or source code

Either grab the source code from github or download via nuget `Install-Package MZMemoize` [https://www.nuget.org/packages/MZMemoize]

If you like using Visual Studio clicky-click the Menu > Tools > NuGet Package Manager > Manage Nuget Packages for Solution > Search for MZMemoize.

> Shut up and take my money
 
You're interested then? Awesome. Let's talk about how to _use_ `Memoize()`.

## Usage of Memoize

Here's a link of sample usage of a `Memoize` func I recommend you take a look at this sample file [/src/MZMemoize.Samples/Memoize.cs]. This guides you through a debugging session to demonstrate a concrete example of how memoization can help you and your application(s). 

Here's a peek at a memoized function

```
static Func<int, int, string> funcConcat = FuncEx.Create((int x, int y) => 
    String.Format("{0} of {1}", x, y);
)
.Memoize(threadSafe: true);
```

Whoa, what's with this `FuncEx.Create()` beast you're using? 

## Usage of FuncEx

`FuncEx` can be used as a natural feeling (atleast for a C# developer) way for creating anonymous methods in C#. To better taste test the code take a look at this sample [/src/MZMemoize.Samples/FuncEx.cs].

Using FuncEx means instead of writing...

```
Func<bool, int, string> func2 = (b, x) =>
  String.Format("string = {0} and {1}", b, x);
```

...you can write in a more readable way, and we get to use `var` nicely...

```
var funcConcat = FuncEx.Create((int x, int y) => 
  String.Format("{0} of {1}", x, y));
```

I find that I don't need to excerise as much memory recall on what it takes to create anonymous method in C#. The `Create` method looks a lot more like a standard C# function.

## Summary

Memoize makes for easy method caching.

FuncEx makes writing anonymous methods feel more natural.

Download the NuGet package and you'll forver wonder how you coded without.