let mutable x = 10
let mutable y = 20

let add x y = x + y

printf "%A" (add x y) //expect 30

//The issue is with the scoping of mutable variables.
//In add2, x and y are modified, but the changes persist outside the function
//This is because the function is using the global mutable variables.

let add2 x y = 
    x <- x + 1
    y <- y + 1
    x + y

printf "%A" (add2 x y) //expect 32, now it's 32

//In add3, the inner mutable variables shadow the outer variables
//the outer variables are not modified
let add3 x y = 
    let mutable x = x + 1
    let mutable y = y + 1
    x + y

printf "%A" (add3 x y) // expect 32, and it's 32

//Better solution using immutability
let add4 x y = (x+1) + (y+1)
printf "%A" (add4 x y) //expect 32