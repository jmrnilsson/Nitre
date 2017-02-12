This is a reimagination of Pythons popular Itertools module for C#. Albeit LINQ provides syntactically simple
expressions there is still a few things that Itertools does really well and makes sense in C#. Most of those
things seem to evolve around the use of tuples or infinite collections. Features for enumerables are
already decently covered in the `System.Linq-namespace`.

This app requires [.NET core ^1.0](https://www.microsoft.com/net/core).

List of features ported is listed.

Nr | Method | Implemented 
------------ | ------------- | -------------
1 | count | :white_check_mark:
2 | cycle | -
3 | repeat | -
4 | chain | -
5 | compress | -
6 | dropwhile | -
7 | groupby | -
8 | filter | -
9 | filterfalse | -
10 | slice | -
11 | map | -
12 | starmap | :white_check_mark:
13 | tee | -
14 | takewhile | -
15 | product | :white_check_mark:
16 | permutations | -
17 | combinations | -
18 | combinations_with_replacements | -

**Planned changes**
This library will probably include a few basic operations in addition to those listed above because
of their implied use. However currying, partials and bind will not be included since the have
great support through lambdas already. Bind is possible with `(i, j) => valueFactory(i, "value0", j);`
and currying can be achieved with `i => j => k => valueFactory(i, j, k);`.

Perhaps Zip, ZipLongest, Call, Apply may be considered in the future, along with up to 16 tuples
per function.

Apply will be included soon as method groups assumes a single argument. Hence tuples
needs to be declared as the argument even though arguments basically are tuples. Hence a method group
is only usable as such:


        Func<Tuple<int, string>, string> func2 = a => $"{a.Item1}{a.Item2}";
        var value = iterable0.Select(func2);


**Restore dependencies:**

    $ dotnet restore
    log  : Restore completed in 101ms.


**Running tests:**

    $ dotnet test


**Start the application:**

    $ dotnet run
