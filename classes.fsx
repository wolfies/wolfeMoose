(*

Implementering af klasser

4 klasser 

*)

[<AbstractClass>]
type Animal =
   abstract member birthrate : int
   default this.birthrate = 1

type Prey = 
   inherit Animal
   override this.birthrate = base.birthrate * 4


type Predator = 
   override this.birthrate = base.birthrate * 3


type Habitat(a : Prey list, b : Predator list) = 
   let mutable time = 0 
   member x.tick = time <- time + 1
