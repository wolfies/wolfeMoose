(*

Implementering af klasser

3 klasser 

*)

type prey = 
   let birthrate = 4


type predator = 
   let birthrate = 3

type environment(a : prey list, b : predator lyst) = 
   let mutable time = 0 
   member x.tick = time <- time + 1
