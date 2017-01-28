open System.IO;
// Open a .NET Framework namespace.

let writeToFile (filename:string) (textToWrite:string) : _ =
    File.WriteAllText(filename, textToWrite);
let ReadFromFile (filename:string):string =
    File.ReadAllText(filename);

let main() =
    writeToFile "FSharpTest.txt" "Hello, cruel world of I/O via F#!";
    //let msg = ReadFromFile "FSharpTest.txt";
    printfn "%s" (ReadFromFile "FSharpTest.txt");
main();