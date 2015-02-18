# Memoize and FuncEx
.net / C# Memoize and Func extensions

## Usage of FuncEx

`FuncEx` can be used as a natural feeling (for a C# developer) way for creating anonymous methods in C#. 
This means instead of writing...

```
Func<bool, int, string> func2 = (b, x) =>
  String.Format("string = {0} and {1}", b, x);
```

...instead you can write in a more consise way like

```
var funcConcat = FuncEx.Create((int x, int y) => 
  String.Format("{0} of {1}", x, y));
```

### Usage of Memoize

For a better explaination of `Memoized` func I recommend you take a look at this sample file. Follow the steps documented in the
test.

Here's a peek at a Memoized function

```
static Func<int, int, string> funcConcat = FuncEx.Create((int x, int y) => 
    String.Format("{0} of {1}", x, y);
)
.Memoize(threadSafe: true);
```
