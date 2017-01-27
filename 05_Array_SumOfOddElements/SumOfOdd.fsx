open System

let IsOdd digit:bool = 
    digit % 2 <> 0;

let SumOfOdd arr:int =
    let mutable sumOdd = 0;
    for item in arr do
        if(IsOdd item)
        then sumOdd <- sumOdd + item;
    sumOdd;

let ReadAndParse()=
    let mutable arr = [];
    let mutable counter = 0;
    let mutable buff = "";
    while (not (isNull buff) && (counter < 5)) do
            buff <- Console.ReadLine();                        
            arr <- (Int32.Parse(buff))::arr
            counter <- counter + 1;
    arr


let main () =    
    let arr = ReadAndParse();
   // Console.WriteLine(arr); // print array of odd elements we`ve got from ReadAndParse()
    for item in arr do
        Console.Write("{0} ", item); 
    Console.WriteLine();
    Console.WriteLine("Sum of all elements = {0}",  Seq.sum(arr)); // sum of all elements
    Console.WriteLine("Sum of all odd elements = {0}", SumOfOdd arr); // sum of all odd elements
    

main()