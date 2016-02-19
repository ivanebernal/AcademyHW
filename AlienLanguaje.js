//Alien Languaje

var L, D, N, fs, lines;
var words = [];
var posibilities = [];
var output = "";

fs = require("fs");
fs.readFile("A-small-practice.in", "utf-8", function(err, data){
	if (err){
		return console.log(err);
	}
	lines = data.split("\n");
	parameters = lines[0].split(" ");
	L = +parameters[0];
	D = +parameters[1];
	N = +parameters[2];

	for(var i = 0; i < D; i++){
		words[i] = lines[i+1];
	}

	for(var j = 0; j < N; j++){
		posibilities[j] = lines[j+D+1].replace(/\(/g,"[").replace(/\)/g,"]");
	}

	for(var k = 0; k < N; k++){
		var count = 0;
		for(var l = 0; l < D; l++){
			if(words[l].match(posibilities[k]) != null){
				count += 1;
			}
		}
		console.log("Case #" + (k+1)+ ":\t" + count + "\n");
		output += "Case #" + (k+1)+ ":\t" + count + "\n";
	}
	fs.writeFile("Output.txt", output, function(err){
		if(err){
			return console.log(err);
		}
		console.log("File was saved!");
	});
});



  
  