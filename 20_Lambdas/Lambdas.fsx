let twice = fun x -> x * 2;
twice 42

// but we can even make it anonymous
(fun x -> x * 3) 14

// we also can make things a bit more complicated and use pipe operator & composition

(fun x -> x * 3) >> twice <| 5;
