//A record is similar to a tuple, however it contains named fields

type Flower = {name: string; color:string}

let roses = {name = "Roses"; color = "Red"};
let violets = {name = "Violets"; color = "Purple"};


let main() = 
    printfn "%s are %s" roses.name roses.color;
    printfn "This part is %b." true ;
    printfn "But %s are %s" violets.name violets.color;
    printfn "Not fucking blue.";
main();