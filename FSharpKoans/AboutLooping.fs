namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// ループについて
//
// F#ではSeq, List, Arrayモジュールを使用してループ処理を行うことが
// 一般的ですが、従来の命令型ループ処理のテクニックを使用することも
// できます。そちらの方がなじみ深いかもしれません。
//---------------------------------------------------------------
[<Koan(Sort = 12)>]
module ``about looping`` =
    [<Koan>]
    let LoopingOverAList() =
        let values = [0..10]

        let mutable sum = 0
        for value in values do
            sum <- sum + value

        AssertEquality sum __
       
    [<Koan>]
    let LoopingWithExpressions() =
        let mutable sum = 0

        for i = 1 to 5 do
            sum <- sum + i

        AssertEquality sum __

    [<Koan>]
    let LoopingWithWhile() =
        let mutable sum = 1

        while sum < 10 do
            sum <- sum + sum

        AssertEquality sum __

    (* 注: これらのループ構造が便利な場合もありますが、リストモジュールで
           学んだ関数のように、より関数的なアプローチを使用してループした
           方が良いこともよくあります。 *)
