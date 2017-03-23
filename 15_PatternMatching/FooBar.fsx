
for i in [0 .. 100] do 
    match i%3, i%5 with
    | 0, 0 -> printfn "FooBar";
    | 0, _ -> printfn "Bar";
    | _, 0 -> printfn "Foo"
    | _ -> printfn "%d" i 
