
// records
type Organizator = {responsib:string}
// type Speaker = {speechTheme:string}
// type Developer = {stack:string}
// type Student = {studiesAt:string}

type Position = 
    | Organizator of Organizator
    // | Speaker of Speaker
    // | Developer of Developer
    // | Student of Student 

type Visitor(id:int, name:string, salary:int, pos:Position) =
    member this.Position 
        with get() = pos;



let printToView (pos : Position) = 
    match pos with
    | Organizator pos -> printfn "%s" pos.responsib
    // | Speaker pos -> printfn "%s" pos.speechTheme
    // | Developer pos -> printfn "%s" pos.stack
    // | Student pos -> printfn "%s" pos.studiesAt 



let v = Visitor(42, "hello",20000 , Position {responsib = "2helo"})
//let v:Visitor = Visitor(1, "Dmytro Zhluktenko", Position {responsib = "hello"})






// records
//type Robusta = {name:string}
type Arabika = {name:string; customer:string}

type CoffeeTaste = 
    //| Robusta of Robusta
    | Arabika of Arabika
    

type CoffeeMachine(id:int, name:string, price:int, coffee:CoffeeTaste) =
     member this.Coffee 
        with get() = coffee



let printToView (taste : CoffeeTaste) = 
    match taste with
    | Arabika taste -> printfn "%s %s" taste.name taste.customer
    //| Robusta taste -> printfn "%s" taste.name
    


let cm = CoffeeMachine(42, "COFFEEMAKER3000", 200, Arabika { name = "SomeName"; customer = "hello" })

printToView cm.Coffee



