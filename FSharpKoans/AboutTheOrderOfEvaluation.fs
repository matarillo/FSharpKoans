namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// 評価の順番について
//
// 時には、関数が評価される順番を明示する必要があるでしょう。
// F#には、これを実現するためのメカニズムがいくつかあります。
//---------------------------------------------------------------
[<Koan(Sort = 4)>]
module ``about the order of evaluation`` =

    [<Koan>]
    let SometimesYouNeedParenthesisToGroupThings() =
        let add x y =
            x + y

        let result = add (add 5 8) (add 1 1)

        AssertEquality result __

        (* 実験: カッコを外すとどうなりますか？*)

    [<Koan>]
    let TheBackwardPipeOperatorCanAlsoHelpWithGrouping() =
        let add x y =
            x + y

        let double x =
            x * 2

        let result = double <| add 5 8

        AssertEquality result __
