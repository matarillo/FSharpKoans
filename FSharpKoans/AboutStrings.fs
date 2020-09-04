namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// 文字列について
//
// ほとんどの言語には、文字列を操作するためのユーティリティが用意されています。
// F#も同様です。
//---------------------------------------------------------------
[<Koan(Sort = 7)>]
module ``文字列について`` =

    [<Koan>]
    let ``文字列値を使う``() =
        let message = "hello"

        AssertEquality message __

    [<Koan>]
    let ``文字列値を結合する``() =
        let message = "hello " + "world"

        AssertEquality message __

    [<Koan>]
    let ``文字列値をフォーマットする``() =
        let message = sprintf "F# turns it to %d!" 11

        AssertEquality message __

        // 注: printf を使用して標準出力に書き込むことができます。

        // 実験: 11を数字以外のものに変えるとどうなりますか？

    [<Koan>]
    let ``他の型をフォーマットする``() =
        let message = sprintf "hello %s" "world"

        AssertEquality message __

    [<Koan>]
    let ``なんでもフォーマットする``() =
        let message = sprintf "Formatting other types is as easy as: %A" (1, 2, 3)

        AssertEquality message __

    (* 注: 文字列の書式設定で使用できるすべての %書式指定子 については、以下を参照してください。
           https://docs.microsoft.com/ja-jp/dotnet/fsharp/language-reference/plaintext-formatting *)

    [<Koan>]
    let ``複数行を結合する``() =
        let message = "super\
                        cali\
                        fragilistic\
                        expiali\
                        docious"

        AssertEquality message __

    [<Koan>]
    let ``複数行をそのまま使う``() =
        let message = "This
                        is
                        on
                        five
                        lines"

        AssertEquality
              message __

    [<Koan>]
    let ``文字型の値を取り出す``() =
        let message = "hello world"

        let first = message.[0]
        let other = message.[4] 

 (* 単一の文字は、文字列に使用するような二重引用符ではなく、
    単一引用符を使用して表現します。（例: 'c'） *)
           
        AssertEquality first __
        AssertEquality other __

    [<Koan>]
    let ``学んだことを応用する``() =
        (* 今まで学んだことを応用する時が来ました。
           アサートが通るように下の関数を記述します。 *)
        let getFunFacts x =
            __

        let funFactsAboutThree = getFunFacts 3
        let funFactsAboutSix = getFunFacts 6

        AssertEquality "3 doubled is 6, and 3 tripled is 9!" funFactsAboutThree 
        AssertEquality "6 doubled is 12, and 6 tripled is 18!" funFactsAboutSix 
