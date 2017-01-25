// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System;

let sign num = // public string sign(int num)
   if num > 0 then "positive";
   elif num < 0 then "negative";
   else "zero";

let main() = // the way of getting void function
      Console.WriteLine("sign of -21367: {0}", (sign -21367));

main();
// actually i feel more comfortable with semicolons