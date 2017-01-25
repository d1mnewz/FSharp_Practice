open System;
let pow digit power = Math.Pow(digit, power)

let main() = 
    let a = Console.ReadLine() |> float
    let b = Console.ReadLine() |> float
    Console.WriteLine(pow a b)
main()