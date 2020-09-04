namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// 評価の順番について
//
// 時には、関数が評価される順番を明示する必要があるでしょう。
// F#には、これを実現するためのメカニズムがいくつかあります。
//---------------------------------------------------------------
[<Koan(Sort = 4)>]
module ``評価の順番について`` =

    [<Koan>]
    let ``時にはカッコでグループ化する必要がある``() =
        let add x y =
            x + y

        let result = add (add 5 8) (add 1 1)

        AssertEquality result __

        (* 実験: カッコを外すとどうなりますか？*)

    [<Koan>]
    let ``後方パイプ演算子でグループ化できる場合もある``() =
        let add x y =
            x + y

        let double x =
            x * 2

        let result = double <| add 5 8

        AssertEquality result __
