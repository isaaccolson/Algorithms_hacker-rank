function smallestCommons(arr) {

var returnNum = -1;

  arr.sort((a,b) => (a-b));
  var high = arr[1];
  var low = arr[0];

var counter = 2;
var flag = true;

  while(flag){

    returnNum = high * counter;

    for(let i = low; i < high; i++){
      flag = false;
      if(returnNum % i !== 0){
        flag = true;
        break;
      }
    }
    counter++;
  }

  return returnNum;
}

smallestCommons([1,5]);
