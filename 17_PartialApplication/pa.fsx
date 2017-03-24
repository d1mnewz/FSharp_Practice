// partial application
let add a b =
    a + b;
let increment = add 1 

printfn "%d" (increment 41);


