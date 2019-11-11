function dropElements(arr, func) {
  // Drop them elements.
  let times = arr.length;//need to store arr.length because length will change
  for(let i = 0; i < times; i ++){
    if(!func(arr[0])){//does the first because keep shifting array over
      arr.shift();
    }else{
      break;
    }
  }
  return arr;
}

dropElements([1, 2, 3], function(n) {return n < 3; });
