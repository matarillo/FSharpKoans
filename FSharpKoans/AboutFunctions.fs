namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// 関数について
//
// let を使って名前と値をバインドする方法を見てきましたが、
// 次は let キーワードを使って関数を作る方法を学びます。
//---------------------------------------------------------------
[<Koan(Sort = 3)>]
module ``関数について`` =

    (* デフォルトでは、F#は空白に意味があります。
       関数の場合は、関数の最後の行が戻り値であり、
       関数の本文はインデントで示されることを意味します。 *)

    let add x y =
        x + y

    [<Koan>]
    let ``Letで関数を作成する``() =
        let result1 = add 2 2
        let result2 = add 5 2
        
        AssertEquality result1 __
        AssertEquality result2 __

    [<Koan>]
    let ``関数を入れ子にする``() =
        let quadruple x =    
            let double x =
                x * 2

            double(double(x))

        let result = quadruple 4
        AssertEquality result __

    [<Koan>]
    let ``型注釈を追加する``() =

        (* 時には、F# の型推論システムを
           明示的な型注釈で支援しなければならない場合があります。 *)
    
        let sayItLikeAnAuctioneer (text:string) =
            text.Replace(" ", "")

        let auctioneered = sayItLikeAnAuctioneer "going once going twice sold to the lady in red"
        AssertEquality auctioneered __

        // 実験: text の型注釈を削除するとどうなりますか？

    [<Koan>]
    let ``親スコープの変数にはアクセスできる``() =
        let suffix = "!!!"

        let caffeinate (text:string) =
            let exclaimed = text.Trim() + suffix
            let yelled = exclaimed.ToUpper()
            yelled

        let caffeinatedReply = caffeinate "hello there"

        AssertEquality caffeinatedReply __

        (* 注: 内側の caffeinate 関数の中から suffix 変数にアクセスすることは、
           クロージャとして知られています。
           
           クロージャについての詳細は
           https://ja.wikipedia.org/wiki/%E3%82%AF%E3%83%AD%E3%83%BC%E3%82%B8%E3%83%A3
           を参照してください。 *)
