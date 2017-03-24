[<Measure>] type m               (*meter*)
[<Measure>] type s               (*second*)
[<Measure>] type mPerS = m / s   (*meters per second*)
[<Measure>] type ban             (*bananas*)

let distance = 100.0<m>
let time = 5.0<s>
let bananas = 10.0<ban>;
let speed:float<mPerS>  = distance / time

//let speed:float<mPerS> = distance / bananas;

printfn "%f" speed
