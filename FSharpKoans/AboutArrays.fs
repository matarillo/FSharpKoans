namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// 配列について
//
// リストと同様に、配列もF#の基本的なコンテナ型です。
//---------------------------------------------------------------
[<Koan(Sort = 11)>]
module ``配列について`` =
    [<Koan>]
    let ``配列を作る``() =
        let fruits = [| "apple"; "pear"; "peach"|]

        AssertEquality fruits.[0] __
        AssertEquality fruits.[1] __
        AssertEquality fruits.[2] __

    [<Koan>]
    let ``配列は.NETの配列と同じである``() =
        let fruits = [| "apple"; "pear" |]

        let arrayType = fruits.GetType()
        let systemArray = System.Array.CreateInstance(typeof<string>, 0).GetType()

        (* F#の配列はリストとは異なり、他の.NET言語から来ている人にはおなじみの、
           標準的な.NETの配列です。 *)
        AssertEquality arrayType systemArray

    [<Koan>]
    let ``配列はミュータブルである``() =
        let fruits = [| "apple"; "pear" |]
        fruits.[1] <- "peach"

        AssertEquality fruits __

    [<Koan>]
    let ``内包表記で配列を作ることもできる``() =
        let numbers = 
            [| for i in 0..10 do 
                   if i % 2 = 0 then yield i |]

        AssertEquality numbers __

    [<Koan>]
    let ``配列に適用できる操作はほかにもある``() =
        let cube x =
            x * x * x

        let original = [| 0..5 |]
        let result = Array.map cube original

        AssertEquality original __
        AssertEquality result __
