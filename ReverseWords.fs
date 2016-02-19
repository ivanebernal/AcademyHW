open System
open System.IO

let addLine (line:string) =     
  use wr = StreamWriter("ReverseWordsFS.txt", true)
  wr.WriteLine(line)
File.Delete("ReverseWordsFS.txt")
let linesr = File.ReadAllText(@"B-small-practice.in").Split[|'\n'|]
let N = Int32.Parse(linesr.[0])

for i in 0..N-1 do
 let sentence = linesr.[i+1].Split[|' '|]
 let rsentence = String.Join(" ", Array.rev(sentence))
 addLine ("Case #" + string (i+1) + ": " + rsentence) 
 
