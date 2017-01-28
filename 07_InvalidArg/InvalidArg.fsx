let months = [ "January"; "February"; "March"; "April";
                "May"; "June"; "July"; "August"; "September";
                "October"; "November"; "December" ];

let lookupMonth (month) =
   if (month > 12 || month < 1)
     then invalidArg "month" (sprintf "invalid month number  %d." month);
   months.[month - 1];

let main() = 
    for i in 1 .. 13 do
        printfn "%s" (lookupMonth i)

main();