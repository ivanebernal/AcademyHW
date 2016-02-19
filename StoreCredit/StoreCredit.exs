textr = File.read! "C-small-practice.in"
text = String.split(textr, "\n")
cases = String.to_integer(Enum.fetch!(text,0))

File.rm("StoreCreditEX.txt")

credit = Enum.concat([0,0],text) |> Enum.take_every(3) |> Enum.drop(1)
items = Enum.concat([0],text) |> Enum.take_every(3) |> Enum.drop(1) |> Enum.map(fn x -> String.to_integer(x) end)
pricesr = Enum.take_every(text,3) |> Enum.drop(1)

prices = Enum.map(pricesr, fn x -> String.split(x," ") |> Enum.map(fn x -> String.to_integer(x) end)end)
answer = []

for i <- 0..cases-1 do
	for j <- 0..Enum.fetch!(items, i)-2 do
		for k <- j+1..Enum.fetch!(items, i)-2 do
			price1 = Enum.fetch!(prices, i) |> Enum.fetch!(j)
			price2 = Enum.fetch!(prices, i) |> Enum.fetch!(k)
			if (price1+price2) === (String.to_integer(Enum.fetch!(credit,i))) do
				answer = Enum.concat(answer,["Case ##{i+1}: #{j+1} #{k+1}\n"])
				File.write("StoreCreditEX.txt", answer,[:append])
			end

		end
	end
end