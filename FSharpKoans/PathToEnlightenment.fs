open FSharpKoans
open FSharpKoans.Core

let runner = KoanRunner()
let result = runner.ExecuteKoans()

match result with
| Success message -> printf "%s" message
| Failure (message, ex) -> 
    printf "%s" message
    printfn ""
    printfn ""
    printfn ""
    printfn ""
    printfn "悟りを得ていないようじゃな..."
    printfn "%s" ex.Message
    printfn ""
    printfn "以下のコードに集中なされよ:"
    printfn "%s" ex.StackTrace
    
printfn ""
printfn ""
printfn ""
printfn ""
printf "何かキーを押すと続行します。"
System.Console.ReadKey() |> ignore
