(*

Implementering af klasser

4 klasser 

*)

[<AbstractClass>]
type Animal =
    abstract member birthrate : int
    abstract member choice() : unit
    abstract member die() : unit
    member move() =

[<Sealed>]
type Prey = 
    inherit Animal
    override this.birthrate = 4
    override die() =

[<Sealed>]
type Predator = 
	inherit Animal
	override this.birthrate = 3
	override die() =
	member starveTime = 10
	member eat(prey) = 

[<Sealed>]
type Habitat(size, numberOfPrey, numberOfPredator) = 
	let mutable time = 0 //starter tid
	let mutable habitat = Array2D.create size size 0 //laver en tom todimensionel-liste
	member x.tick = time <- time + 1 //tick funktion
