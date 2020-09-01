namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// クラスについて
//
// 本格的なオブジェクト指向言語として、F#ではデータやメソッドを含む
// 伝統的なクラスを作成することができます。
//---------------------------------------------------------------

type Zombie() =
    member this.FavoriteFood = "brains"

    member this.Eat food =
        match food with
        | "brains" -> "mmmmmmmmmmmmmmm"
        | _ -> "grrrrrrrr"

type Person(name:string) =
    member this.Speak() =
        "Hi my name is " + name

type Zombie2() =
    let favoriteFood = "brains"

    member this.Eat food =
        if food = favoriteFood then "mmmmmmmmmmmmmmm" else "grrrrrrrr"

type Person2(name:string) =
    let mutable internalName = name

    member this.Name
        with get() = internalName
        and set(value) = internalName <- value

    member this.Speak() =
        "Hi my name is " + this.Name

[<Koan(Sort = 21)>]
module ``about classes`` =

    [<Koan>]
    let ClassesCanHaveProperties() =
        let zombie = new Zombie()

        AssertEquality zombie.FavoriteFood __

    [<Koan>]
    let ClassesCanHaveMethods() =
        let zombie = new Zombie()

        let result = zombie.Eat "brains"
        AssertEquality result __
    
    [<Koan>]
    let ClassesCanHaveConstructors() =
    
        let person = new Person("Shaun")

        let result = person.Speak()
        AssertEquality result __

    [<Koan>]
    let ClassesCanHaveLetBindingsInsideThem() =
        let zombie = new Zombie2()

        let result = zombie.Eat "chicken"
        AssertEquality result __

        (* 実験: letでバインドされた値 Zombie2.favoriteFood に
                 クラス定義の外部からアクセスできますか？ *)

    [<Koan>]
    let ClassesCanHaveReadWriteProperties() =
        let person = new Person2("Shaun")

        let firstPhrase = person.Speak()
        AssertEquality firstPhrase __

        person.Name <- "Shaun of the Dead"
        let secondPhrase = person.Speak()
        AssertEquality secondPhrase __
