let rec fib n =                     // simply like switch, but much more powerful
     match n with                     // this is pattern matching syntax
    | 0 -> 0                         // case 0:
    | 1 -> 1                         // case 1:
    | _ -> fib (n - 1) + fib (n - 2) // default result

let main()  =
    for i in [1..10] do
        printfn "Fibonacci #%d: %d" i (fib(i))

main();