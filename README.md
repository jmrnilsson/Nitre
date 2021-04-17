This is a reimagination of Pythons popular Itertools module for C#. Albeit LINQ provides syntactically simple
expressions there is still a few things that Itertools does really well whilst making sense in C#. Most of those
things seem to evolve around the use of tuples or infinite collections. Features for enumerables are
already decently covered in the `System.Linq-namespace`.

This app requires [.NET Core](https://www.microsoft.com/net/core). [PowerShell](https://github.com/PowerShell/PowerShell) is optional.

List of features ported.

Type | Nr | Method | Implemented | Comment
------------ | ------------- | ------------- | ------------- | -------------
Infinite | 1 | count | :white_check_mark:  | 
Infinite | 2 | cycle | - |
Infinite | 3 | repeat | - |
Short termination | 4 | chain | - |
Short termination | 5 | compress |  :white_check_mark: |
Short termination | 6 | dropwhile | :white_check_mark: |
Short termination | 7 | groupby | - |
Short termination | 8 | filter | :white_check_mark: | Also overloads index
Short termination | 9 | filterfalse | :white_check_mark:  | Also overloads index
Short termination | 10 | islice | :white_check_mark: |
Short termination | 11 | map | - |
Short termination | 12 | starmap | :white_check_mark: |
Short termination | 13 | tee | - | Due to language design return tuple is defined by generics rather than argument.
Short termination | 14 | takewhile | :white_check_mark: |
Combinatoric | 15 | product | :white_check_mark: |
Combinatoric | 16 | permutations | - |
Combinatoric | 17 | combinations | - |
Combinatoric | 18 | combinations_with_replacements | - |

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
        .Filter((item => item.Item1.MunicipalityId == item.Item2.MunicipalityId)
        .Filter(item => item.Item2.IsoCode == item.Item3.IsoCode || "GP" == item.Item3.IsoCode)
        .Select(t => t.Item1);
```
