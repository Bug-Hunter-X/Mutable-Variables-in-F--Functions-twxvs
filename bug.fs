let mutable x = 10
let mutable y = 20

let add x y = x + y

printf "%A" (add x y)

x <- 30
y <- 40

printf "%A" (add x y)