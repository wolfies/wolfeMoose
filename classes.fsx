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

//diller

[<Sealed>]
type Habitat(size, numberOfPrey, numberOfPredator) = 
    let mutable time = 0 //starter tid
    let habitat = Array2D.create size size 0 //laver en tom todimensionel-liste uden dyr
    let gen = System.Random()
    let table = Hashtable()
    let placeAnimal(i) =
        let mutable x = gen.Next(size)
        let mutable y = gen.Next(size)
        while habitat.[x,y] <> 0 do
            x <- x + 1
            if x > size then
                x <- 0
                y <- y + 1
                if y > size then
                    y <- 0
        Array2D.set habitat x y i
    do 
        for i = 1 to numberOfPredator do
            table.Add(i, 1)
            placeAnimal(i)
        for i = -1 downto -numberOfPrey do
            table.Add(i, 2)
            placeAnimal(i)
    member x.tick =
        //stremline to save DOC
        time <- time + 1 //tick funktion
    member x.printAnimal() = printfn "%A, %A" table.Values table.Keys
    member x.printHabitat() = printfn "%A" habitat

let hab = Habitat(10,2,2)
hab.printAnimal()
hab.printHabitat()