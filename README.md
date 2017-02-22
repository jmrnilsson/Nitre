This is a reimagination of Pythons popular Itertools module for C#. Albeit LINQ provides syntactically simple
expressions there is still a few things that Itertools does really well and makes sense in C#. Most of those
things seem to evolve around the use of tuples or infinite collections. Features for enumerables are
already decently covered in the `System.Linq-namespace`.

This app requires [.NET Core ~1.0](https://www.microsoft.com/net/core) and [PowerShell](https://github.com/PowerShell/PowerShell)

List of features ported.

Type | Nr | Method | Implemented
------------ | ------------- | ------------- | -------------
INFINITE | 1 | count | :white_check_mark:
INFINITE | 2 | cycle | -
INFINITE | 3 | repeat | -
SHORT TERMINATION | 4 | chain | -
SHORT TERMINATION | 5 | compress | -
SHORT TERMINATION | 6 | dropwhile | -
SHORT TERMINATION | 7 | groupby | -
SHORT TERMINATION | 8 | filter | -
SHORT TERMINATION | 9 | filterfalse | -
SHORT TERMINATION | 10 | slice | -
SHORT TERMINATION | 11 | map | -
SHORT TERMINATION | 12 | starmap | :white_check_mark:
SHORT TERMINATION | 13 | tee | -
SHORT TERMINATION | 14 | takewhile | :white_check_mark:
COMBINATORIC | 15 | product | :white_check_mark:
COMBINATORIC | 16 | permutations | -
COMBINATORIC | 17 | combinations | -
COMBINATORIC | 18 | combinations_with_replacements | -

## Planned changes
This library will probably include a few basic operations in addition to those listed above because
of their implied use. However currying, partials and bind will not be included since the have
great support through lambdas already.

Bind is already possible so no changes in relation to this:

    (i, j) => valueFactory(i, "value0", j);

Currying is achieved with:

    i => j => k => valueFactory(i, j, k);

## Building, testing and running

    PS> ./make.ps1
    PS> ./make.ps1 test
    PS> ./make.ps1 run
