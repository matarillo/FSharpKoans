namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// 関数について、続き
//
// F#の関数についてすでに少し学んだと思いますが、
// F#は関数型言語なので、学ぶべきコツはまだまだありますよ！
//---------------------------------------------------------------
[<Koan(Sort = 13)>]
module ``more about functions`` =
    
    [<Koan>]
    let DefiningLambdas() =
        
        let colors = ["maize"; "blue"]

        let echo = 
            colors
            |> List.map (fun x -> x + " " + x)

        AssertEquality echo __

        (* fun キーワードを使用すると、関数に名前を付けずにインラインで関数を
           作成することができます。そのような関数は、匿名関数、ラムダ、または
           ラムダ関数として知られています。 *)

    [<Koan>]
    let FunctionsThatReturnFunctions() =
        (* 関数プログラミングの巧妙な技法の一つは、別の関数を返す関数を作成
           することです。これは、いくつかの興味深い動作をもたらします。 *)
        let add x =
            (fun y -> x + y)

        (* F#の軽量構文では、あたかも関数が1つしかないかのように両方の関数を
           呼び出すことができます。 *)
        let simpleResult = add 2 4
        AssertEquality simpleResult __

        (* ...ですが、一度に1つの引数だけを渡して残差関数を作成することも
           できます。この手法は部分適用と呼ばれています。 *)
        let addTen = add 10
        let fancyResult = addTen 14

        AssertEquality fancyResult __

        // 注：このスタイルで書かれた関数はカリー化されていると言われます。

    [<Koan>]
    let AutomaticCurrying() =
        (* 上記のテクニックは、F#が実際にデフォルトでサポートしているほど
           一般的なものです。言い換えれば、関数は自動的にカリー化されます。 *)
        let add x y = 
            x + y

        let addSeven = add 7
        let unluckyNumber = addSeven 6
        let luckyNumber = addSeven 0

        AssertEquality unluckyNumber __
        AssertEquality luckyNumber __

    [<Koan>]
    let NonCurriedFunctions() =
        (* ほとんどの場合、自動でカリー化される関数の構文にこだわるべきです。
           ですが、C#のようにカリー化があまり一般的ではない言語からでも
           使いやすいように、カリー化されていない形式で関数を書くこともできます。 *)

        let add(x, y) =
            x + y

        (* 注: "add 5" ではコンパイルできません。
               両方の引数を同時に渡さなければなりません。 *)

        let result = add(5, 40)

        AssertEquality result __

        (* 考察: 複数の戻り値を持つ関数は、実際はタプルを返すだけの関数である
                 ことを前に学びましたね。カリー化されていない形式で定義された
                 関数は、本当に一度に複数の引数を受け入れるのでしょうか？ *)
