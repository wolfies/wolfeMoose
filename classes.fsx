open System.Collections
(*
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

*)

[<Sealed>]
type Habitat(size, numberOfPrey, numberOfPredator) = 
    let mutable time = 0 //starter tid
    member x.habitat = Array2D.create size size 0 //laver en tom todimensionel-liste uden dyr
    member x.gen = System.Random()
    member x.table = Hashtable()
    member x.placeAnimal(i) =
        let mutable x = x.gen.Next(size)
        let mutable y = x.gen.Next(size)
        while x.habitat.[x,y] <> 0 do
            x <- x + 1
            if x > size then x <- 0 ; y <- y + 1
                if y > size then
                    y <- 0
        Array2D.set x.habitat x y i
    for i = 1 to numberOfPredator] do
        x.table.Add(i, 1)
        x.placeAnimal(i)
    for i = -1 downto -numberOfPrey do
        x.table.Add(i, 2)
        x.placeAnimal(i)
    member x.tick =
        //stremline to save DOC
        x.time <- x.time + 1 //tick funktion