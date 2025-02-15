let mutable x = 10
let mutable y = 20

let add x y = x + y

printf "%A" (add x y) //expect 30

let add2 x y = 
    x <- x + 1
    y <- y + 1
    x + y

printf "%A" (add2 x y) //expect 30 + 2 = 32, but got 33

let add3 x y = 
    let mutable x = x + 1
    let mutable y = y + 1
    x + y

printf "%A" (add3 x y) // expect 32, but got 33