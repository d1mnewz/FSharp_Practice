let add a b =
    a + b;

// explicitly curried version
let add' a =  
    let sub b =
        a + b
    sub // return the sub function that takes int 

// using it step by step:
let x = 42
let y = 69
let intermidFun = add' x;
let result = intermidFun y;

// partial application
let incDima = add 42

printfn "%d" (incDima 13);


//printfn "%d" (increment 41);


