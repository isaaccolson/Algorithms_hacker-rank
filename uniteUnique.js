function uniteUnique(arr) {
  let newArr;
  newArr = Array.prototype.slice.call(arguments);
  console.log(newArr);
  let returnArray = [newArr[0][0]];

  for(let i = 0; i < newArr.length; i++){
    for(let j = 0; j < newArr[i].length; j++){
      if(returnArray.indexOf(newArr[i][j]) === -1){
        returnArray.push(newArr[i][j]);
      }
    }
  }
  console.log(returnArray);
  return returnArray;
}

uniteUnique([1, 3, 2], [5, 2, 1, 4], [2, 1]);
//19.02
