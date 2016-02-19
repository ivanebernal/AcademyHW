open System
open System.IO
open System.Text.RegularExpressions

let (|Regex|_|) pattern input =
    let m = Regex.Match(input, pattern)
    if m.Success then Some(List.tail [ for g in m.Groups -> g.Value ])
    else None

let countMatches (word :string) (dict :string[])=
    //number of matches
    let mutable matches = 0
    let ar :string[]=null;
    for d in dict do
        match d with
           | Regex word ar ->
                  //if matches it
                  matches <- matches + 1
                  // if not don't touch it
           | _ -> matches <- matches
    //return 
    matches

let addLine (line:string) =     
  use wr = StreamWriter("AlienLanguajeFS.txt", true)
  wr.WriteLine(line)
File.Delete("AlienLanguajeFS.txt")

let text = File.ReadAllText(@"A-large-practice.in").Replace("(","[").Replace(")","]")
let linesr = text.Split[|'\n'|]

let paramsr = linesr.[0].Split[|' '|]
let L = Int32.Parse(paramsr.[0])
let D = Int32.Parse(paramsr.[1])
let N = Int32.Parse(paramsr.[2])

let words = Array.sub linesr 1 D
let cases = Array.sub linesr (D+1) N


for i = 0 to N-1 do
 let n = countMatches cases.[i] words
 addLine ("Case #" + string (i+1) + ": " + string(n)) 
0



//printfn "%A" m
//for i in 0..paramsr.Length-1 do
//if Int32.TryParse(paramsr.[i], &result) then params[i] = result


