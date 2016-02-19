open System
open System.IO

let addLine (line:string) =     
  use wr = StreamWriter("StoreCreditFS.txt", true)
  wr.WriteLine(line)
File.Delete("StoreCreditFS.txt")
let linesr = File.ReadAllText(@"C-small-practice.in").Split[|'\n'|]
let N = Int32.Parse(linesr.[0])


for i in 0..N-1 do
 let credit = Int32.Parse(linesr.[3*i+1])
 let items = Int32.Parse(linesr.[3*i+2])
 let prices = linesr.[3*i+3].Split[|' '|]
 for j= 0 to (items-1) do
  for k = j+1 to (items-1) do
   if Int32.Parse(prices.[j])+Int32.Parse(prices.[k])=credit then addLine ("Case #" + string(i+1) + ": " + string(j+1) + " " + string(k+1))
  