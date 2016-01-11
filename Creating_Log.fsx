type Habitat() = class
    

    member h.AddToLog (s: string) =
        let name = "log.txt"
        if not <| System.IO.File.Exists(name) then
            let f = System.IO.File.Create(name)
            f.Close()
        //let file = System.IO.File.OpenText(name)
        let stream = System.IO.File.AppendText(name)
        let write (outStream: System.IO.StreamWriter) =
            outStream.WriteLine s
            outStream.Close()
        write stream
end


let test = new Habitat()

test.AddToLog ("tick[1] prey[5] predator[2]")
test.AddToLog ("tick[2] prey[8] predator[3]")
test.AddToLog ("tick[3] prey[12] predator[4]")
