open System

let countHelloWord = Console.ReadLine () |> int

let rec forLoop counter condition increment body =
    if condition counter then
        body ()
        forLoop (increment counter) condition increment body

forLoop 0 (( > ) countHelloWord) (( + ) 1) (fun () ->  printfn "Hello World")
