﻿namespace FSharpKoans
open FSharpKoans.Core

type Game = {
    Name: string
    Platform: string
    Score: int option
}

//---------------------------------------------------------------
// オプション型について
//
// オプション型は、値を返す可能性のある、または返さない可能性のある
// 計算を表すために使用されます。他の言語ではnullを使うことに慣れて
// いたかもしれません。しかし、null の代わりにオプション型を使用する
// ことで、微妙ではありますが大きな広がりのあるメリットがあります。
//---------------------------------------------------------------
[<Koan(Sort = 17)>]
module ``オプション型について`` =

    [<Koan>]
    let ``オプション型は値を持つかもしれない``() =
        let someValue = Some 10
        
        AssertEquality someValue.IsSome __
        AssertEquality someValue.IsNone __
        AssertEquality someValue.Value __

    [<Koan>]
    let ``値を持たないかもしれない``() =
        let noValue = None

        AssertEquality noValue.IsSome __
        AssertEquality noValue.IsNone __
        AssertThrows<FILL_IN_THE_EXCEPTION> (fun () -> noValue.Value)

    [<Koan>]
    let ``パターンマッチでオプション型を使う``() =
        let chronoTrigger = { Name = "Chrono Trigger"; Platform = "SNES"; Score = Some 5 }
        let halo = { Name = "Halo"; Platform = "Xbox"; Score = None }

        let translate score =
            match score with
            | 5 -> "Great"
            | 4 -> "Good"
            | 3 -> "Decent"
            | 2 -> "Bad"
            | 1 -> "Awful"
            | _ -> "Unknown"

        let getScore game =
            match game.Score with
            | Some score -> translate score
            | None -> "Unknown"

        AssertEquality (getScore chronoTrigger) __
        AssertEquality (getScore halo) __

    [<Koan>]
    let ``オプション型の値を射影する``() =
        let chronoTrigger = { Name = "Chrono Trigger"; Platform = "SNES"; Score = Some 5 }
        let halo = { Name = "Halo"; Platform = "Xbox"; Score = None }

        let decideOn game =

            game.Score
            |> Option.map (fun score -> if score > 3 then "play it" else "don't play")

        //ヒント: decideOn関数の戻り値の型を見てください。
        AssertEquality (decideOn chronoTrigger) __
        AssertEquality (decideOn halo) __
