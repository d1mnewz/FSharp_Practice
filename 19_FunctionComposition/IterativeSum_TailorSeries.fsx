// let rec sum a b = 
//     if a > b then 0
//     else a + sum (a + 1) b

// but not every time recursion is readable, right? 
// i will make it even more unreadable, i will do it recursive + functional.

// here i've got something to explain or your brain will blow up
let rec iter a b f i = // loop from a to b, applying every time function f to result, and starting from index i
    if a > b then i;
    else f a (iter (a+1) b f i) 
    

let sum a b = iter a b (+) 0 // in our case function f is adding, and sum starts from 0
printfn "%d" (sum 1 3)


// OK, that's bullshit. let's make some real stuff. do you remember taylor series? 

// e^x = 1 + x + (x^2)/2 + ... (x^n)n! + ...


let fact n = iter 1 n (*) 1 // iteration from 1 to n that every time multiplyes accumulative digit starting from 1
                                             // in c# we would write
                                             // function for factorial (loop),
                                             // function for x^n (also loop),
// in our case we have already written iter, so we can use it to define factorial

let pow x n = iter 1 n (fun n acc -> acc * x) 1 // also we can use iter here, every time we multiply our accumulative digit with x
// fun n acc -> acc * x    that's lambda expression                                                    // (accumulatio - summarisation of previosly made points)
//printfn "%f" (float (fact 5))
let exp x =
         iter 0 x
            (fun n acc ->
                 acc + float (pow x n) / float (fact n)) 0.

printfn "%f" (exp 5)


