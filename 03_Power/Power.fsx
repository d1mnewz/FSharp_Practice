open System;
let ReadString _ = Console.ReadLine();
let ReadInput convert = ReadString () |> convert; 

let main() = 

    // ** is exponentiation operator in f#, raises an operand to the power of another
    printfn "%f" (ReadInput float ** ReadInput float)

    
    // OR 
    //Console.WriteLine(Math.Pow(ReadInput float, ReadInput float))

    //OR
    //let a = ReadInput float // |> - what type of result we want from console.readline()
    //let b = ReadInput float // actually this is a explicit cast operator like (int)a
    //Console.WriteLine("{0}^{1} = {2}", a, b, Math.Pow(a, b).ToString())
main() // started wrtiting in vs code

// refactored so now it looks like functional programming
