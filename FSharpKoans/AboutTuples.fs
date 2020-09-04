﻿namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// タプルについて
//
// F#のタプルは値を簡単にグループ化するために使われます。
// タプルはF#言語の基本的な構成要素の一つです。
//---------------------------------------------------------------
[<Koan(Sort = 6)>]
module ``タプルについて`` =
    
    [<Koan>]
    let ``タプルを作成する``() =
        let items = ("apple", "dog")
        
        AssertEquality items ("apple", __)
        
    [<Koan>]
    let ``タプルの要素にアクセスする``() =
        let items = ("apple", "dog")
        
        let fruit = fst items
        let animal = snd items
        
        AssertEquality fruit __
        AssertEquality animal __

    [<Koan>]
    let ``タプルの要素にパターンマッチングでアクセスする``() =

        (* fstとsndは状況によっては便利ですが、2つの要素を含むタプルでしか
           動作しません。通常は、タプルの値にアクセスするには
           パターンマッチングと呼ばれるテクニックを使う方が良いでしょう。
           
           パターンマッチングは任意の要素数のタプルで動作し、
           各値に名前を割り当てながら同時にタプルを分割することができます。
           例を挙げてみます。 *)
        
        let items = ("apple", "dog", "Mustang")
        
        let fruit, animal, car = items
        
        AssertEquality fruit __
        AssertEquality animal __
        AssertEquality car __
        
    [<Koan>]
    let ``パターンマッチで値を無視する``() =
        let items = ("apple", "dog", "Mustang")
        
        let _, animal, _ = items
        
        AssertEquality animal __
    
    (* 注意: パターンマッチは、F# の多くの場所で見られます。
             これについては後でまた考察します。 *)
        
    [<Koan>]
    let ``関数から多値を返す``() =
        let squareAndCube x =
            (x ** 2.0, x ** 3.0)
        
        let squared, cubed = squareAndCube 3.0
        
        
        AssertEquality squared __
        AssertEquality cubed __
    
    (* 考察: 返り値は1つだけではないのでしょうか？
             squareAndCube関数の戻り値の型は？ *)
    
    [<Koan>]
    let ``多値返り値の真実を知る``() =
        let squareAndCube x =
            (x ** 2.0, x ** 3.0)
            
        let result = squareAndCube 3.0
       
        AssertEquality result __
