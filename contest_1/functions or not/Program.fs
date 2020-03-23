open System
open System.Text.RegularExpressions

let countTestCase = Console.ReadLine () |> int

let rec forLoop counter condition increment body =
    if condition counter then
        body ()
        forLoop (increment counter) condition increment body

let rec checkCase (map:Collections.Set<_>) countPairs answer =
    if countPairs <= 0 then answer
    else
    Regex.Split (Console.ReadLine (), " ") 
    |> fun (arr) ->
        if map.Contains(arr.[0] |> int) then checkCase (map.Add (arr.[0] |> int)) (countPairs - 1) "NO"
        else checkCase (map.Add (arr.[0] |> int)) (countPairs - 1) answer
        
forLoop 0 (( > ) countTestCase) (( + ) 1) (fun () -> Console.ReadLine () |> int |> (fun (x) -> (printfn "%s" (checkCase Set.empty x "YES"))))
