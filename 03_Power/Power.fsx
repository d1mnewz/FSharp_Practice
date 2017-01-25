open System;
let ReadString _ = Console.ReadLine();
let ReadInput convert = ReadString () |> convert; 

let main() = 
    //let a = ReadInput float // |> - what type of result we want from console.readline()
    //let b = ReadInput float // actually this is a explicit cast operator like (int)a
    Console.WriteLine(Math.Pow(ReadInput float, ReadInput float))
main() // started wrtiting in vs code

// refactored so now it looks like functional programming
