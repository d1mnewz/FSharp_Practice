// thats very bad code down here!
let  msg = "Dima is awesome!";
printfn "%s" msg;
let mSg = "Dima is super awesome!";
printfn "%s" mSg;

// well, this one seem to be better, but it's still so imperitive!

// let mutable msg = "Dima is awesome!";
// printfn "%s" msg;
// msg <- "Dima is super awesome!";
// printfn "%s" msg;

// that's how you do this like a real fella!


[   "Dima is awesome"
    "Dima is super awesome!"
    "Alex is cool!"
] |> Seq.iter (printfn "%s")
