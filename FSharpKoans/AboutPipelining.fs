namespace FSharpKoans
open FSharpKoans.Core

//----------------------------------------------------------------
// パイプラインについて
//
// 前方パイプ演算子は、F#プログラミングで最もよく使われる記号の一つです。
// リストや他のデータ構造に対する操作を読みやすく組み合わせるために使用できます。
//----------------------------------------------------------------
[<Koan(Sort = 10)>]
module ``パイプラインについて`` =

    let square x =
        x * x

    let isEven x =
        x % 2 = 0

    [<Koan>]
    let ``ステートメントを分けて偶数を二乗する``() =
        (* 操作を組み合わせる一つの方法は、別々のステートメントを使用することです。
           しかし、それぞれの結果に名前を付けなければならないので、不格好になります。*)

        let numbers = [0..5]

        let evens = List.filter isEven numbers
        let result = List.map square evens

        AssertEquality result __

    [<Koan>]
    let ``カッコを使って偶数を二乗する``() =
        (* この問題は、ある関数の結果を別の関数に渡すためにカッコを使用することで
           回避できます。ただ、これを読むには、最も内側にある関数から読み始めて、
           外側に移動していかなければならないので、読みにくいかもしれません。 *)

        let numbers = [0..5]

        let result = List.map square (List.filter isEven numbers)

        AssertEquality result __

    [<Koan>]
    let ``パイプライン演算子を使って偶数を二乗する``() =
        (* F#では、パイプライン演算子を使用することで、カッコ方式の利点と
           ステートメント方式の読みやすさを得ることができます。 *)

        let result =
            [0..5]
            |> List.filter isEven
            |> List.map square
        
        AssertEquality result __

    [<Koan>]
    let ``パイプ演算子の定義を知る``() =
        let (|>) x f =
            f x

        let result =
            [0..5]
            |> List.filter isEven
            |> List.map square

        AssertEquality result __
