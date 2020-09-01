namespace FSharpKoans
open FSharpKoans.Core
open System.Collections.Generic

//---------------------------------------------------------------
// リストについて
//
// リストはF#プログラミングで頻繁に使用される重要な構成要素です。
// リストは、値を多数並べたものをグループ化するために使用されます。
// リストに値をいくつか格納し、リスト内の各値に対して操作を行うことが
// たいへんよくあります。
//---------------------------------------------------------------
[<Koan(Sort = 9)>]
module ``about lists`` =

    [<Koan>]
    let CreatingLists() =
        let list = ["apple"; "pear"; "grape"; "peach"]
        
        (* 注: F#のリストデータ型は単一方向連結リストなので、
               インデックスによる要素アクセスはO(n)です。 *)
        
        AssertEquality list.Head __
        AssertEquality list.Tail __
        AssertEquality list.Length __

        (* 他の言語から来た .NET 開発者は、F# のリスト型が基本クラスライブラリの
           List<T> と同じではないことに驚くかもしれません。言い換えれば、
           以下のアサーションは成功します。 *)

        let dotNetList = new List<string>()
        // 以下を修正する必要はありません。
        AssertInequality (list.GetType()) (dotNetList.GetType())

    [<Koan>]
    let BuildingNewLists() =
        let first = ["grape"; "peach"]
        let second = "pear" :: first
        let third = "apple" :: second

        // 注: "::" は "cons" とも呼ばれます。
        
        AssertEquality ["apple"; "pear"; "grape"; "peach"] third
        AssertEquality second __
        AssertEquality first __

        // 以下のコメントを外すとどうなりますか？

        //first.Head <- "apple"
        //first.Tail <- ["peach"; "pear"]

        // 考察: 一度作成したリストの内容を変更することはできますか？


    [<Koan>]
    let ConcatenatingLists() =
        let first = ["apple"; "pear"; "grape"]
        let second = first @ ["peach"]

        AssertEquality first __
        AssertEquality second __

    (* 考察: 一般的に、リストを構築するのに :: と @ ではどちらがより良い
             パフォーマンスを発揮するでしょうか？ そしてその理由は？
       
       ヒント：上の例では "first" はイミュータブルで、変更することはできません。
               それを念頭に置いて、"first" に ["peach"] を追加して
               "second" を作成するために、@ 関数は何をしなければならないでしょうか？ *)
        
    [<Koan>]
    let CreatingListsWithARange() =
        let list = [0..4]
        
        AssertEquality list.Head __
        AssertEquality list.Tail __
        
    [<Koan>]
    let CreatingListsWithComprehensions() =
        let list = [for i in 0..4 do yield i ]
                            
        AssertEquality list __
    
    [<Koan>]
    let ComprehensionsWithConditions() =
        let list = [for i in 0..10 do 
                        if i % 2 = 0 then yield i ]
                            
        AssertEquality list __

    [<Koan>]
    let TransformingListsWithMap() =
        let square x =
            x * x

        let original = [0..5]
        let result = List.map square original

        AssertEquality original __
        AssertEquality result __

    [<Koan>]
    let FilteringListsWithFilter() =
        let isEven x =
            x % 2 = 0

        let original = [0..5]
        let result = List.filter isEven original

        AssertEquality original __
        AssertEquality result __

    [<Koan>]
    let DividingListsWithPartition() =
        let isOdd x =
            x % 2 <> 0

        let original = [0..5]
        let result1, result2 = List.partition isOdd original
        
        AssertEquality result1 __
        AssertEquality result2 __

    (* 注: Listモジュールには他にも便利なメソッドがたくさんあります。
           Visual Studio の Intellisense で List の後に '.' を入力して
           確認してください。または、オンラインドキュメントを参照してください。
           https://fsharp.github.io/fsharp-core-docs/reference/fsharp-collections-listmodule.html *)
