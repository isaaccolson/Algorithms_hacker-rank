function fearNotLetter(str) {
  let newStr;

  let charCounter = str.charCodeAt(0);
  for(let i = 0; i < str.length; i++){
    if(str.charCodeAt(i) !== charCounter){
      newStr = String.fromCharCode(charCounter);
      break;
    }else{
      charCounter++;
    }
  }
  return newStr;
}

fearNotLetter("abce");
//12.57
