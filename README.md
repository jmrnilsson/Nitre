This is a reimagination of Pythons popular Itertools module for C#. Albeit LINQ provides syntactically simple
expressions there is still a few things that Itertools does really well and makes sense in C#. Most of those
things seem to evolve around the use of tuples or infinite collections. Features for enumerables are
already decently covered in the `System.Linq-namespace`.

This app requires [.NET Core ~1.0](https://www.microsoft.com/net/core) and [PowerShell](https://github.com/PowerShell/PowerShell)

List of features ported.

Type | Nr | Method | Implemented
------------ | ------------- | ------------- | -------------
unt | :white_check_m
INFINITE | 2 | cycle | -
INFINITE | 3 | repeat
SHORT TERMINATION | 9 | filterfalse | :hammer:
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

## Example draft

For example a cartesian product can be described as:

```csharp
    var libraries =
        from l in Libraries
        join m in Municipalities on l.MunicipalityId equals m.MunicipalityId
        from c in Countries
        where c.IsoCode equals m.IsoCode || "GP" == c.IsoCode
        select l;
```

Instead it's intended to make use of tuples for applying functions similar to parameter unpacking:

```csharp
    var libraries =
        Product(Libraries, Municipalities, Countries)
        .Filter((l, m, _) => l.MunicipalityId == m.MunicipalityId)
        .Filter((_, m, c) => m.IsoCode == c.IsoCode || "GP" == c.IsoCode)
        .Select(t => t.Item1);
```
