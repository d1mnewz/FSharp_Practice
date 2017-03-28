let solve a b c = 
    let d = b*b - 4. * a * c
    if d < 0. then None
    else Some ((-b - sqrt(d))/ (2. *a), (-b + sqrt(d))/ (2.*a))



let print res = 
    match res with
    | None -> printfn "No such roots";
    | Some(x1, x2) -> printfn "%f %f" x1 x2

solve 5. 2. -3. |> print