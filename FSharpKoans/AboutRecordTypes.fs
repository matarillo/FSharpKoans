namespace FSharpKoans
open FSharpKoans.Core

type Character = {
    Name: string
    Occupation: string
}

//---------------------------------------------------------------
// レコード型について
//
// レコード型は、新しい型を構築するための軽量な方法です。
// これらを使用して、タプルよりも構造化された方法でデータを
// グループ化することができます。
//---------------------------------------------------------------
[<Koan(Sort = 16)>]
module ``about record types`` =

    [<Koan>]
    let RecordsHaveProperties() =
        let mario = { Name = "Mario"; Occupation = "Plumber"; }

        AssertEquality mario.Name __
        AssertEquality mario.Occupation __

    [<Koan>]
    let CreatingFromAnExistingRecord() =
        let mario = { Name = "Mario"; Occupation = "Plumber"; }
        let luigi = { mario with Name = "Luigi"; }

        AssertEquality mario.Name __
        AssertEquality mario.Occupation __

        AssertEquality luigi.Name __
        AssertEquality luigi.Occupation __

    [<Koan>]
    let ComparingRecords() =
        let greenKoopa = { Name = "Koopa"; Occupation = "Soldier"; }
        let bowser = { Name = "Bowser"; Occupation = "Kidnapper"; }
        let redKoopa = { Name = "Koopa"; Occupation = "Soldier"; }

        let koopaComparison =
             if greenKoopa = redKoopa then
                 "all the koopas are pretty much the same"
             else
                 "maybe one can fly"

        let bowserComparison = 
            if bowser = greenKoopa then
                "the king is a pawn"
            else
                "he is still kind of a koopa"

        AssertEquality koopaComparison __
        AssertEquality bowserComparison __

    [<Koan>]
    let YouCanPatternMatchAgainstRecords() =
        let mario = { Name = "Mario"; Occupation = "Plumber"; }
        let luigi = { Name = "Luigi"; Occupation = "Plumber"; }
        let bowser = { Name = "Bowser"; Occupation = "Kidnapper"; }

        let determineSide character =
            match character with
            | { Occupation = "Plumber" } -> "good guy"
            | _ -> "bad guy"

        AssertEquality (determineSide mario) __
        AssertEquality (determineSide luigi) __
        AssertEquality (determineSide bowser) __
