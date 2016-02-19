var lines;
var output = "";

var fs = require("fs");
fs.readFile("B-small-practice.in", "utf-8", function(err, data){
	if (err){
		return console.log(err);
	}
	lines = data.split("\n");
	var D = +lines[0];
	for(var i = 0; i < D; i++){
		words = lines[i+1].split(" ");
		output += "Case #" + (i+1) + ": ";
		for(var j = words.length-1; j >= 0; j--){
			output += words[j] + " ";
		}
		output += "\n";
		
	}
	console.log(output);
	fs.writeFile("OutputB.txt", output, function(err){
		if(err){
			return console.log(err);
		}
		console.log("File was saved!");
	});
});
