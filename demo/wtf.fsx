let add a b = 
    a + b

let increment = add 1

increment 41


let msg = "Dima is awesome!"
printfn "%s" msg
if msg = "Dima is super awesome!" 
    then 
        printfn "%s" msg
    else 
        printfn "what?"

let mutable msg' = msg;
printfn "%s" msg'
msg' <- "Dima is superman!"
printfn "%s" msg'


[   "Dima is awesome"
    "Dima is super awesome!"
    ".NET is cool!"
] 
|> Seq.map (printfn "%s")




