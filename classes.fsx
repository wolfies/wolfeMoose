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
    let habitat = Array2D.create size size 0 //laver en tom todimensionel-liste uden dyr
    let gen = System.Random()
    let table = Hashtable()
    let placeAnimal(i) =
        let mutable x = gen.Next(size)
        let mutable y = gen.Next(size)
        if habitat.[x].[y] <> 0 then
            if x > size then x <- 0 ; y <- y + 1
                if y > size then
                    y <- 0
        else Array2D.set habitat x y i
        (x,y)
    for i in [1 .. numberOfPredator] do
        table.Add(i, 1)
        placeAnimal(i)
    for i in [-numberOfPrey .. -1] do
        table.Add(i, 2)
        placeAnimal(i)
    member x.tick =
        //stremline to save DOC
        time <- time + 1 //tick funktion