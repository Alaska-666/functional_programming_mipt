open System
open System.Text.RegularExpressions


type Point = { x: float; y: float }

let countPoints = Console.ReadLine () |> int

let readPoints n = 
    let rec readList (curList:List<Point>) n =
        if n <= 0 then curList
        else readList ((Regex.Split(Console.ReadLine(), " ") |> (fun (arr) -> {x=arr.[0] |> float ; y= arr.[1] |> float})) :: curList) (n - 1)
    
    readList List.empty n

let calculateArea (list:List<Point>) = 
    let rec area (list:List<Point>) a =
        if (List.length list) <= 1 then abs (0.5 * a)
        else area (list.Tail) (a + (list.[0].x * list.[1].y - list.[0].y * list.[1].x))
        
    area (list @ [list.Head]) 0.0
    
readPoints countPoints |> (fun (x) -> printfn "%A" (calculateArea x))
