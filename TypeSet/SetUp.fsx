#r @"bin\Debug\TypeSet.dll"

open TypeSet.Provided

TPrint<"A %s string! %s %d">.show "hello" "world" 32
// val it : string = "A hello string! world 32"

TPrint<"Number one: %d! Number two: %d! A string: %s!">.show 1 2 "My string!"
// val it : string = "Number one: 1! Number two: 2! A string: My string!!"