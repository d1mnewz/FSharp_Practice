open System;
let mutable x = 10; // by default all variables are immutable
// once variable is bound to value, it cant be changed. like read-only property.

let mutable y = x;
let main() = 
    Console.WriteLine(x);
    x <- 15;
    Console.WriteLine(x);
    y <- x + 8  // <- the way i should use to change mutable variable
    Console.WriteLine(y);
    if( (x <> y))
        then  Console.WriteLine("x != y"); // <> is != analogue
    if(true && not false)
        then Console.WriteLine("not false == true");

    

main();