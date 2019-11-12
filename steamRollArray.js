function steamrollArray(arr) {
  // I'm a steamroller, baby
  let newArr = [];
  for(let i = 0; i < arr.length; i++){
    if(Array.isArray(arr[i])){
      let flatArray = arr[i].flat(Infinity);
      for(let j = 0; j < flatArray.length; j++){
        newArr.push(flatArray[j]);
      }
    }else{
      newArr.push(arr[i]);
    }
  }

  console.log(newArr);
  return newArr;
}

steamrollArray([1, [2], [3, [[4]]]]);
//15 min
