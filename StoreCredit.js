var lines;
var output = "";

fs = require("fs");
fs.readFile("C-large-practice.in", "utf-8", function(err, data){
	if (err){
		return console.log(err);
	}
	lines = data.split("\n");
	var D = +lines[0];
	for(var i = 0; i < D; i++){
		output += "Case #" + (i+1) + ": "
		var credit = +lines[(3*i)+1];
		var items = +lines[(3*i)+2];
		var pricesr = lines[(3*i)+3].split(" ");
		var prices = [];
		for(var a = 0; a < items; a++){
			prices[a]= +pricesr[a];
		}
		for(var j = 0; j < items; j++){
			for(var k  = j+1; k < items; k++){
				if(prices[j]+prices[k] === credit){
					output += (j+1) + " " + (k+1);
					break;
				}

			}
		}
		output += "\n";
	}		
	fs.writeFile("OutputC.txt", output, function(err){
		if(err){
			return console.log(err);
		}
		console.log("File was saved!");
	});
});
