[<Measure>] type m               (*meter*)
[<Measure>] type s               (*second*)
[<Measure>] type ban             (*bananas*)

let distance = 100.0<m>
let time = 5.0<s>
let bananas = 10<ban>;
let speed (x : float<m>) (y : float<s>) = x / y // can remove type declaration

speed distance time

speed 420.0<m> 4.2<s>

//speed 33.3<m> 5<ban>
