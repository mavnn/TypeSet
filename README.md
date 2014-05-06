A type safe printf implemented via F# Type Providers.

```fsharp
TPrint<"Hello %s">.show "Bob"

TPrint<"%d green %s...">.show 10 "bottles"
```
