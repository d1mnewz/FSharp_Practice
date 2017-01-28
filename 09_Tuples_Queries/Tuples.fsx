open System;
//A tuple is a comma-separated collection of values.
let TupleOne = (3, "Three", 3.3333, true);

let TupleTwo = (2.0**4.0, 82-40); // simple expressions also available in tuples.
let strings = ["F#"; "C#"; "T#"; "P#"; "D#"];

  

// well here i went crazy and tryed out some linq analogue in f#
// seemsGood
let SortedFullString = String.concat ", " (query {
                for item in strings do
                    sortBy item  });
let TupleThree = ( String.concat ", " strings , SortedFullString);  // it gives like "F#, C#, T#, P#, D#" for fst
                                                                    // and "C#, D#, F#, P#, T#" for snd


let main() : _ = 
    Console.WriteLine(TupleOne); // simple way of printing tuple.
    Console.WriteLine(TupleTwo);
    Console.WriteLine(fst TupleThree); // like in haskell here we`ve got fst & snd built-in functions
                                        // that returns first and second element of tuple respectively
    Console.WriteLine(snd TupleThree); // there is no built-in function like third, but i can easily write it by myself
                                        //let third (_, _, thirdEl) = thirdEl

main();