// Funksjonen square regner ut kvadratet av et tall
let square x = x * x


// Funksjonen  mult ganger x med n
// Kan du skrive funksjonen uten x, sånn at man heller kan gi inn x senere?
let mult n x = n * x

// areaOfDoubled finner arelet av et kvadrat som har sidelengde 2 * x 
// bruke pipe ( |> ) for å kjede sammen funksjonene
let areaOfDoubled x = x |> mult 2 |> square

// areaOfTripled finner arealet av kvadat med sidelengde 3 * x
// Skriv funksjonen uten parameter (point free) og med funksjonskomposision >>
let areaOfTripled = mult 3 >> square

printfn "Doubled area: 4 * %d = %d" (square 2) (areaOfDoubled 2)
printfn "Tripled ared: 9 * %d = %d" (square 2) (areaOfTripled 2)

// Og så litt streng-moro! Vi skal lage en leetifyer som erstatter vokaler med tall som ligner
// https://no.wikipedia.org/wiki/Leet

// Først trenger vi en funksjon som erstatter char med int i den gitte strenger
// Du kan få bruk får System.Char.ToUpper, og fsharpfunksjonene string og char for å caste
// og string sin .Replace
let replace (x : char) (y : int) ( str : string) =
    let xUpper = System.Char.ToUpper x
    let yChar =  y |> string |> char
    (str.Replace (x, yChar)).Replace(xUpper, yChar)
    
// Nå som replace er i boks er det lett å leetifye en streng ved å erstatte følgende
// a -> 4
// e -> 3
// i -> 1
// o -> 0
// funksjonen kan igjen skrives uten inputparameter
// hadde det samme vært mulig om string ikke hadde vært siste parameter i replace?
let leetify = replace 'a' 4 >> replace 'e' 3 >> replace 'i' 1 >> replace 'o' 0

let printLeetify str = 
    printfn "%s %s" str <| leetify str

printLeetify "To be, or not to be: that is the question"
printLeetify "Romeo, Romeo! wherefore art thou Romeo?"
printLeetify "What’s in a name? A rose by any name would smell as sweet"
