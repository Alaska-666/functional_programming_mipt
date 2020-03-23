open System
open System.Text.RegularExpressions


type Point = { x: float; y: float }

let distance firstPoint secondPoint = sqrt ((firstPoint.x - secondPoint.x) ** 2.0 + (firstPoint.y - secondPoint.y) ** 2.0)
                                                                                      
let countPoints = Console.ReadLine () |> int

let rec forLoop counter condition increment body =
    if condition counter then
        body ()
        forLoop (increment counter) condition increment body

let readPoints n = 
    let rec readList (curList:List<Point>) n =
        if n <= 0 then curList
        else readList ((Regex.Split(Console.ReadLine(), " ") |> (fun (arr) -> {x=arr.[0] |> float ; y= arr.[1] |> float})) :: curList) (n - 1)
    
    readList List.empty n

let perimeter (list:List<Point>) = 
    let rec per (list:List<Point>) p =
        if (List.length list) <= 1 then p
        else per (list.Tail) (p + (distance list.[0] list.[1]))
        
    per (list @ [list.Head]) 0.0
    
readPoints countPoints |> (fun (x) -> printfn "%A" (perimeter x))
