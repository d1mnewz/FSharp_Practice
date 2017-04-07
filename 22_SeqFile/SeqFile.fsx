//used txt book from http://english-e-books.net/crime-and-punishment-fyodor-dostoyevsky/
#r "../packages/FSharp.Charting/lib/net40/FSharp.Charting.dll"

open FSharp.Charting
open System.IO
open System

let ReadLines fn =
  seq { use inp = File.OpenText fn in
        while not(inp.EndOfStream) do
            yield (inp.ReadLine())
      }


ReadLines @"Crime_and_Punishment-Fyodor_Dostoyevsky.txt"
 |> Seq.map (fun s->s.Split([|';';',';'!';'?';'-';'.';'\'';' '; '@'|]))
 |> Seq.concat
 |> Seq.filter (fun s->s.Length>0)
 //|> Seq.maxBy (fun x -> x.Length)
 |> Seq.groupBy (fun s->s.Length)
 |> Seq.map ( fun (n, s) -> (n, Seq.length s) )
 //|> Seq.sortBy (fun (n, s) -> n) 
 |> Seq.sortBy fst 
 |> Seq.toList
 //|> Seq.maxBy snd 
 //|> Seq.maxBy (fun (n, s) -> s)
 //|> Chart.Bar
 




