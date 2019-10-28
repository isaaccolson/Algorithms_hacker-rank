function pairElement(str) {
  var newStr = [];

  for(let i = 0; i < str.length; i++){
    if(str[i] === "A"){
      newStr.push(["A","T"]);
    }else if(str[i] === "T"){
      newStr.push(["T","A"]);
    }else if(str[i] === "C"){
      newStr.push(["C","G"]);
    }else if(str[i] === "G"){
      newStr.push(["G","C"]);
    }
  }
console.log("original: " + str);
console.log(newStr);
  return newStr;
}

pairElement("GCG");
//12.42 sec
