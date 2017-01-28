let rec fib n =                     // simply like switch
    match n with                     // this is pattern matching syntax
    | 0 -> 0                         // case 0:
    | 1 -> 1                         // case 1:
    | _ -> fib (n - 1) + fib (n - 2) // default result

let main() =
    for i = 1 to 10 do
        printfn "Fibonacci #%d: %d" i ( fib(i) )

main();