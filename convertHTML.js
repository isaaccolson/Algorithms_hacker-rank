var obj = {38: "&amp;", 60: "&lt;", 62: "&gt;", 34: "&quot;", 39: "&apos;"};

function convertHTML(str) {
  let newStr = [];
  for(let i = 0; i < str.length; i++){

  if(obj.hasOwnProperty(str.charCodeAt(i))){
    newStr.push(obj[str.charCodeAt(i)]);
  }else{
    newStr.push(str[i]);
  }
  }
  return newStr.join('');
}

convertHTML("Dolce & Gabbana");
//31.10
