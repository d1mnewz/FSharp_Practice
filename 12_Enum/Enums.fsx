open System;
type DayTime = 
    | Morning = 0
    | Afternoon = 1 
    | Evening = 2
    | Night = 3


let main () = 
    let mutable status:DayTime = DayTime.Morning;
    let hour:int = DateTime.Now.Hour;
    if(hour > 5 && hour < 12)
        then  status <-  DayTime.Morning;
    elif (hour > 12 && hour < 18)
        then status <- DayTime.Afternoon;
    elif (hour > 18 && hour < 20)
        then status <- DayTime.Evening;
    else status <- DayTime.Night;
    printfn "%A" status;
    
main();