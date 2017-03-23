
// also take a look at fibonacci demo

for i in [0 .. 10] do 
    match (i%3, i%5) with
    | 0, 0 -> printfn "FooBar"; // if (!i%3 && !i%5)
    | 0, _ -> printfn "Bar";
    | _, 0 -> printfn "Foo"
    | _ -> printfn "%d" i 
