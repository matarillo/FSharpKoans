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
module ``unitについて`` =

    [<Koan>]
    let ``関数に戻り値がない時にunitが使われる``() =
        let sendData data =
            // ...サーバーにデータを送信するコード...
            ()

        let x = sendData "data"
        AssertEquality x __ (* 考えすぎないようにしましょう。
                               また、"()"の値が "null"と表示される場合があることにも注意してください。 *)

    [<Koan>]
    let ``引数を持たない関数は代わりにunitを受け取る``() =
        let sayHello() =
            "hello"

        let result = sayHello()
        AssertEquality result __
