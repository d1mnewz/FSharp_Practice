#r "../packages/FSharp.Data/lib/net40/FSharp.Data.dll"

open FSharp.Data

// http://www.omdbapi.com/?t=title

let apiUrl = "http://www.omdbapi.com/?t=titanic";
type FilmP = JsonProvider<"http://www.omdbapi.com/?t=titanic">
let film = FilmP.Load(apiUrl);
film.Country




// let apiUrl = "http://www.omdbapi.com/?t=hello+world"


// type filmParser = JsonProvider<"http://www.omdbapi.com/?t=what">

// let film = filmParser.Load(apiUrl);

// printfn "%s" film.Genre
