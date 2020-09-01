namespace FSharpKoans
open FSharpKoans.Core

module MushroomKingdom =
    type Power =
        | Mushroom
        | Star
        | FireFlower
        
    type Character = {
        Name: string
        Occupation: string
        Power: Power option
    }

    let Mario = { Name = "Mario"; Occupation = "Plumber"; Power = None}

    let powerUp character =
        { character with Power = Some Mushroom }

//---------------------------------------------------------------
// モジュールについて
//
// モジュールは、関数や値や型をグループ化するために使用されます。
// モジュールは .NET の名前空間に似ていますが、以下に示すように、
// 若干セマンティクスが異なります。
//---------------------------------------------------------------
[<Koan(Sort = 19)>]
module ``about modules`` =

    [<Koan>]
    let ModulesCanContainValuesAndTypes() =

        AssertEquality MushroomKingdom.Mario.Name __
        AssertEquality MushroomKingdom.Mario.Occupation __
        
        let moduleType = MushroomKingdom.Mario.GetType()
        AssertEquality moduleType typeof<FILL_ME_IN>

    [<Koan>]
    let ModulesCanContainFunctions() =
        let superMario = MushroomKingdom.powerUp MushroomKingdom.Mario

        AssertEquality superMario.Power __

(* 注: 以前のセクションでは、List 型と Option 型を扱うのに便利な関数を含む
       List と Option のようなモジュールを見てきました。 *)

open MushroomKingdom

[<Koan(Sort = 20)>]
module ``about opened modules`` =
    [<Koan>]
    let OpenedModulesBringTheirContentsInScope() = 
        AssertEquality Mario.Name __
        AssertEquality Mario.Occupation __
        AssertEquality Mario.Power __