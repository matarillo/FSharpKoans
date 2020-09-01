namespace FSharpKoans
open FSharpKoans.Core
open Microsoft.FSharp.Reflection

//---------------------------------------------------------------
// unitについて
//
// unit型は、値の欠落を表す特殊な型です。
// 他の言語ではvoidに似ていますが、F#ではunitは実際の型と考えられています。
//---------------------------------------------------------------
[<Koan(Sort = 5)>]
module ``about unit`` =

    [<Koan>]
    let UnitIsUsedWhenThereIsNoReturnValueForAFunction() =
        let sendData data =
            // ...サーバーにデータを送信するコード...
            ()

        let x = sendData "data"
        AssertEquality x __ (* 考えすぎないようにしましょう。
                               また、"()"の値が "null"と表示される場合があることにも注意してください。 *)

    [<Koan>]
    let ParameterlessFunctionsTakeUnitAsTheirArgument() =
        let sayHello() =
            "hello"

        let result = sayHello()
        AssertEquality result __
