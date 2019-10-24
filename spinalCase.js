function spinalCase(str) {//use regex string manipulation

    var newStr = "";
    for (let i = 0; i < str.length; i++) {
        let char = str[i];
        if (char == "-") {
            newStr += str[i];
        } else if (char === " " || char === "_") {
            newStr += "-";
        } else if (char === char.toUpperCase()) {
            if (str[i - 1] != null && (str[i - 1] != " " && str[i - 1] != "_" && str[i - 1] != "-")) {
                newStr += "-";
            }
            newStr += char.toLowerCase();
        } else {
            newStr += str[i];
        }
    }
    console.log(newStr);
    return newStr;
}

spinalCase('This Is Spinal Tap');
//40 min
