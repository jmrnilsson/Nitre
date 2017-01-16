This is a reimagination of Pythons popular Itertools module for C#. Albeit LINQ provides syntactically beautiful expressions, there is still a few things that Itertools does really well and makes sense in C#. Some these features already exists in the System.Linq-namespace and consequently such implementations will simply be accessible as an alias in Itertools.

This app requires [.NET core ^1.0](https://www.microsoft.com/net/core).

List of features ported is listed bold.

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

**Restore dependencies:**

    $ dotnet restore
    log  : Restore completed in 101ms.


**Running tests:**

    $ dotnet test


**Start the application:**

    $ dotnet run
