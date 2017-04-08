
// records
type Organizator = {responsib:string}
type Speaker = {speechTheme:string}
type Developer = {stack:string}
type Student = {studiesAt:string}

type Position =                     // sort of enum on steroids - dicrimminated union
    | Organizator of Organizator
    | Speaker of Speaker
    | Developer of Developer
    | Student of Student 

type Visitor(id:int, name:string, pos:Position) = // class
    member this.PositionField 
        with get() = pos;


let printToView (pos : Position) =  // function 
    match pos with
    | Organizator pos -> printfn "%s" pos.responsib
    | Speaker pos -> printfn "%s" pos.speechTheme
    | Developer pos -> printfn "%s" pos.stack
    | Student pos -> printfn "%s" pos.studiesAt 



let v = Visitor(42, "hello" , Speaker {speechTheme = "F# @ .NET"})

printToView v.PositionField
