namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// letについて
//
// let キーワードは F# の最も基本的な部分の一つです。
// F# のコードのほとんどすべての行で使うことになるので、
// よく知っておきましょう。
//---------------------------------------------------------------
[<Koan(Sort = 2)>]
module ``Letについて`` =

    [<Koan>]
    let ``Letで名前を値にバインドする``() =
        let x = 50
        
        AssertEquality x __
    
    (* F#では、letで作成された値は、整数値の場合は "int"、
       テキスト値の場合は "string"、真偽値の場合は "bool" のような
       型を持っていると推論されます。 *)
    [<Koan>]
    let ``Letは値の型をできる限り推論する``() =
        let x = 50
        let typeOfX = x.GetType()
        AssertEquality typeOfX typeof<int>

        let y = "a string"
        let expectedType = y.GetType()
        AssertEquality expectedType typeof<FILL_ME_IN>

    [<Koan>]
    let ``明示的に型を指定してもよい``() =
        let (x:int) = 42
        let typeOfX = x.GetType()

        let y:string = "forty two"
        let typeOfY = y.GetType()

        AssertEquality typeOfX typeof<FILL_ME_IN>
        AssertEquality typeOfY typeof<FILL_ME_IN>

        (* 通常、ローカル変数には明示的な型注釈で
           型を指定する必要はありませんが、
           型注釈は、後述するように
           他の文脈でも便利に使うことができます。 *)
    
    [<Koan>]
    let ``浮動小数点数と整数``() =
        (* 予備知識にもよりますが、F#では整数と浮動小数点数は
           別の型であることを知って驚くかもしれません。
           言い換えれば、以下のアサーションは成功します。 *)
        let x = 20
        let typeOfX = x.GetType()

        let y = 20.0
        let typeOfY = y.GetType()

        // 以下を修正する必要はありません。
        AssertEquality typeOfX typeof<int>
        AssertEquality typeOfY typeof<float>

        // 他の.NET言語をご存じであれば、
        // floatはdouble型のことを表すF#のスラングです。

    [<Koan>]
    let ``変数の値を更新する``() =
        let mutable x = 100
        x <- 200

        AssertEquality x __

    [<Koan>]
    let ``Letでバインドされた値はミュータブルでなければ更新できない``() =
        let x = 50
        
        // 以下のコメントを外すとどうなりますか？
        //
        // x <- 100

        // 注意: イミュータブルな値を変更することはできませんが、
        // 「シャドウイング」を使用して名前を再利用することは可能です。
        let x = 100
         
        AssertEquality x __
