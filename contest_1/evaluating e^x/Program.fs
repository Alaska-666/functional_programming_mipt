open System

let countNumbers = Console.ReadLine () |> int

let rec factorial n =
    if n <= 0 then 1
    else n * factorial (n - 1)

let rec power (x:float) n =
    if n <= 0 then 1.0
    else x * power x (n - 1)
    
let rec calculateExponentInPower (x:float) n =
    if n <= 0 then 1.0
    else power x n / float(factorial n) + calculateExponentInPower x (n - 1)
    
let exponent x = calculateExponentInPower x 9

let rec forLoop counter condition increment body =
    if condition counter then
        body ()
        forLoop (increment counter) condition increment body
        
forLoop 0 (( > ) countNumbers) (( + ) 1) (fun () -> Console.ReadLine () |> float |> exponent |> printfn "%A")
