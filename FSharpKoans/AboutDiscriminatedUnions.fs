namespace FSharpKoans
open FSharpKoans.Core

type Condiment =
    | Mustard
    | Ketchup
    | Relish
    | Vinegar

type Favorite =
    | Bourbon of string
    | Number of int

//---------------------------------------------------------------
// 判別共用体について
//
// 判別共用体は、決まった数の場合分けのいずれかになり得るデータを
// 表現するために使用されます。まずは、他の言語でいう列挙型のより
// 強力なバージョンのようなものと考えてもよいでしょう。
//---------------------------------------------------------------
[<Koan(Sort = 18)>]
module ``about discriminated unions`` =
    [<Koan>]
    let DiscriminatedUnionsCaptureASetOfOptions() =

        let toColor condiment = 
            match condiment with
            | Mustard -> "yellow"
            | Ketchup -> "red"
            | Relish -> "green"
            | Vinegar -> "brownish?"

        let choice = Mustard

        AssertEquality (toColor choice) __

        (* 実験: 上記のパターンマッチから場合分けのケースを削除すると
                 どうなりますか？ *)

    [<Koan>]
    let DiscriminatedUnionCasesCanHaveTypes() =

        let saySomethingAboutYourFavorite favorite =
            match favorite with
            | Number 7 -> "me too!"
            | Bourbon "Bookers" -> "me too!"
            | Bourbon b -> "I prefer Bookers to " + b
            | Number _ -> "I'm partial to 7"

        let bourbonResult = saySomethingAboutYourFavorite <| Bourbon "Maker's Mark"
        let numberResult = saySomethingAboutYourFavorite <| Number 7
        
        AssertEquality bourbonResult __
        AssertEquality numberResult __
