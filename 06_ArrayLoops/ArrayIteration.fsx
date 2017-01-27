let nl = System.Environment.NewLine // useful snippet.


let PrintSeqOne = 
    let seq1 = seq { for i in 1 .. 10 -> (i, i*i) } // thats called tuple in f#
    for (a, asqr) in seq1 do
            printfn "%d squared is %d" a asqr
    printfn "%s" nl;

let PrintSeqTwo = 
    for i in 0 .. 3 .. 10 do // 3 is like step for one iteration 
        printf "%d " i;
    printfn "%s" nl 

let PrintSeqThree =        // as i got the point, you can`t make the thing from SeqTwo like for c in 'a' .. 'c' .. 'z' 
    for c in 'a' .. 'z' do // iterating through chars 
        printf "%c " c;
    printfn "%s"  nl
    
let PrintSeqFour =
    for i in 10 .. -2 .. 0 do // negative skip value in reverse iteration                       
        printf "%d " i        // so -2 is like step 
    printfn "%s" nl;
let main() = 
    PrintSeqOne;
    PrintSeqTwo;
    PrintSeqThree;
    PrintSeqFour;

main();