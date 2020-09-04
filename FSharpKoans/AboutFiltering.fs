namespace FSharpKoans
open FSharpKoans.Core

module NumberFilterer =

    let someIfEven x =
        if x % 2 = 0 then Some x
        else None

//---------------------------------------------------------------
// リストのフィルタリングを始める
//
// F# のリストはいくつかの方法でフィルタリングすることができます。
// このKoanでは以下のものが見られます。
//  - filter
//  - find / tryFind
//  - choose
//  - pick
//---------------------------------------------------------------

[<Koan(Sort = 22)>]
module ``フィルタリングについて`` =
    open NumberFilterer

    [<Koan>]
    let ``リストをフィルタリングする``() =
        let names = [ "Alice"; "Bob"; "Eve"; ]
                
        // 匿名関数を使って "A" で始まる名前をすべて検索します。
        let actual_names = 
            names
            |> List.filter (fun name -> name.StartsWith( "A" ))
     
        AssertEquality actual_names [ __ ]

        // もしくは、フィルタする関数を渡します。
        let startsWithTheLetterB (s: string) =
            s.StartsWith("B")

        let namesBeginningWithB =
            names
            |> List.filter startsWithTheLetterB

        AssertEquality namesBeginningWithB [ __ ]

    [<Koan>]
    let ``唯一の要素を見つける``() =
        let names = [ "Alice"; "Bob"; "Eve"; ]
        let expected_name = "Bob"
                
        // findは1つの項目だけを返すか、例外をスローします。

        let actual_name = 
            names
            |> List.find (fun name -> name = __ )
            
        // ??? リストにボブが2人いるとどうなりますか？

        AssertEquality expected_name actual_name

    [<Koan>]
    let ``唯一の要素を見つけるか何も見つからないかのどちらか``() =
        let names = [ "Alice"; "Bob"; "Eve"; ]
                
        // tryFindはオプション型を返すので、0行が返されても処理できます。
        let eve = 
            names
            |> List.tryFind (fun name -> name = "Eve" )
        let zelda = 
            names
            |> List.tryFind (fun name -> name = "Zelda" )
            
        AssertEquality eve.IsSome __
        AssertEquality zelda.IsSome __

    [<Koan>]
    let ``リストの要素で値を持たないものを捨てる``() =
        let numbers = [ 1; 2; 3; ]
        
        // choose は、入力をオプション型に変換する関数を取り、
        // 結果が None のものを除外します。
        let evenNumbers =
            numbers
            |> List.choose someIfEven

        AssertEquality evenNumbers  [ __ ]

        // また、'a option list 型に対して "id" 関数を使用することも
        // できます。"id" は "Some" のものだけを返します。
        let optionNames = [ None; Some "Alice"; None; ]

        let namesWithValue = 
            optionNames
            |> List.choose id

        // namesWithValue の型が '文字列のリスト' であるのに対し、
        // optionNames は '文字列のオプションリスト' であることに注意してください。
        AssertEquality namesWithValue [ __ ]

    [<Koan>]
    let ``リストの要素で値を持つものを見つける``() =
        let numbers = [ 5..10 ]
       
        // pick は choose に似ていますが、"Some" である最初の要素を返すか、
        // または、そのような項目がない場合に例外をスローします (find と少し似ています)。
        let firstEven =
            numbers
            |> List.pick someIfEven

        AssertEquality firstEven __

        // chooseと同様に、オプションリストの型に "id"関数を使用して
        // "Some"であるものだけを返すこともできます。
        let optionNames = [ None; Some "Alice"; None; Some "Bob"; ]

        let firstNameWithValue = 
            optionNames
            |> List.pick id

        AssertEquality firstNameWithValue  __

        // また、tryFind のように動作する tryPick もあり、例外を投げる代わりに "None" を返します。
