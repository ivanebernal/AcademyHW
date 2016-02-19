textr = File.read! "B-large-practice.in"
text = String.split(textr, "\n")
n = String.to_integer(Enum.fetch!(text,0))
sentences = Enum.slice(text,1,n) |> Enum.with_index
reverse = Enum.map(sentences, fn({x,i})  ->
	new = String.split(x, " ") |> Enum.reverse |> Enum.join(" ")
	"Case ##{i+1}: #{new}"
end
	)
content = Enum.join(reverse, "\n")
File.write("ReverseWordsEX.txt", content)