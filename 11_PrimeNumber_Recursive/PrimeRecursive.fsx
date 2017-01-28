let isprime (n:int) =
    let rec check (i:int)=   // rec is keyword for recursive functions
        i > n/2 || (n % i <> 0 && check (i + 1))
    check 2

let primeIn50 = seq { for n in 1..100 do
                         if isprime n 
                            then yield n }
for x in primeIn50 do
    printf "%d " x