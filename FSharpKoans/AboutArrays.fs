namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// 配列について
//
// リストと同様に、配列もF#の基本的なコンテナ型です。
//---------------------------------------------------------------
[<Koan(Sort = 11)>]
module ``about arrays`` =
    [<Koan>]
    let CreatingArrays() =
        let fruits = [| "apple"; "pear"; "peach"|]

        AssertEquality fruits.[0] __
        AssertEquality fruits.[1] __
        AssertEquality fruits.[2] __

    [<Koan>]
    let ArraysAreDotNetArrays() =
        let fruits = [| "apple"; "pear" |]

        let arrayType = fruits.GetType()
        let systemArray = System.Array.CreateInstance(typeof<string>, 0).GetType()

        (* F#の配列はリストとは異なり、他の.NET言語から来ている人にはおなじみの、
           標準的な.NETの配列です。 *)
        AssertEquality arrayType systemArray

    [<Koan>]
    let ArraysAreMutable() =
        let fruits = [| "apple"; "pear" |]
        fruits.[1] <- "peach"

        AssertEquality fruits __

    [<Koan>]
    let YouCanCreateArraysWithComprehensions() =
        let numbers = 
            [| for i in 0..10 do 
                   if i % 2 = 0 then yield i |]

        AssertEquality numbers __

    [<Koan>]
    let ThereAreAlsoSomeOperationsYouCanPerformOnArrays() =
        let cube x =
            x * x * x

        let original = [| 0..5 |]
        let result = Array.map cube original

        AssertEquality original __
        AssertEquality result __
