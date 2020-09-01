namespace FSharpKoans
open FSharpKoans.Core

//---------------------------------------------------------------
// 条件分岐について
//
// 条件分岐は、プログラムに条件付きで操作を行うように指示するために使用されます。
// これもF#の基本的な部分です。
//---------------------------------------------------------------
[<Koan(Sort = 8)>]
module ``about branching`` =
    
    [<Koan>]
    let BasicBranching() =
        let isEven x =
            if x % 2 = 0 then
                "it's even!"
            else
                "it's odd!"
                
        let result = isEven 2                
        AssertEquality result __
    
    [<Koan>]
    let IfStatementsReturnValues() =
    
        (* C# のような言語では、if 文は結果を返さず、副作用を引き起こすだけです。
           F# の if 文は、F# のルーツが関数型プログラミングにあるため、値を返します。 *)
           
        let result = 
            if 2 = 3 then
                "something is REALLY wrong"
            else
                "no problem here"

        AssertEquality result __

    [<Koan>]
    let BranchingWithAPatternMatch() =
        let isApple x =
            match x with
            | "apple" -> true
            | _ -> false
        
        let result1 = isApple "apple"
        let result2 = isApple ""
        
        AssertEquality result1 __
        AssertEquality result2 __
    
    [<Koan>]
    let UsingTuplesWithIfStatementsQuicklyBecomesClumsy() =
        
        let getDinner x = 
            let name, foodChoice = x
            
            if foodChoice = "veggies" || foodChoice ="fish" || 
               foodChoice = "chicken" then
                sprintf "%s doesn't want red meat" name
            else
                sprintf "%s wants 'em some %s" name foodChoice
         
        let person1 = ("Chris", "steak")
        let person2 = ("Dave", "veggies")
        
        AssertEquality (getDinner person1) __
        AssertEquality (getDinner person2) __
        
    [<Koan>]
    let PatternMatchingIsNicer() =
    
        let getDinner x =
            match x with
            | (name, "veggies")
            | (name, "fish")
            | (name, "chicken") -> sprintf "%s doesn't want red meat" name
            | (name, foodChoice) -> sprintf "%s wants 'em some %s" name foodChoice 
            
        let person1 = ("Bob", "fish")
        let person2 = ("Sally", "Burger")
        
        AssertEquality (getDinner person1) __
        AssertEquality (getDinner person2) __
