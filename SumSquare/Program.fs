// 
// Try to learn F# using exercices from Stack Exchange Code Golf
// The code golf is : 
// https://codegolf.stackexchange.com/questions/171943/sum-textsquare2
// 
// CodeGolf //////////////////////////////////////////////////////////////////
// Let n=42
// (Input)
// Then divisors are : 1, 2, 3, 6, 7, 14, 21, 42
// Squaring each divisor : 1, 4, 9, 36, 49, 196, 441, 1764
// Taking sum (adding) : 2500
// Since 50×50=2500

// therefore we return a truthy value. If it is not a perfect square, 
// return a falsy value.
// Examples :
//   42  ---> true
//   1   ---> true
//   246 ---> true
//   10  ---> false
//   16  ---> false
// ///////////////////////////////////////////////////////////////////////////

open System

// Get the user entry en convert into a integer
let GetUserEntry =
    Console.Write("Please, enter a number: ")
    let entry = Console.ReadLine()

    Int32.Parse entry

[<EntryPoint>]
let main argv =
    let value = GetUserEntry
        
    let sumOfDividers = 
        [1..value]
        |>List.filter(fun(v:int)->(value%v)=0) 
        |> List.map (fun (i:int) -> i * i)
        |> Seq.sum 


    let squared = int (Math.Sqrt (float sumOfDividers))
    let isSquared =
        ((squared * squared) = sumOfDividers)

    printfn "The sum of dividers of %d is%s a perfect square" value (if isSquared then "" else " not")

    0 // return an integer exit code
