function sumFibs(num) {

  let sum = 1;
  let lastNum = 1;
  let currentNum = 1;

for(let i = 1; i <= num; i = lastNum + currentNum){
  if(i % 2 != 0){
    sum += i;
  }
  lastNum = currentNum;
  currentNum = i;
}
  return sum;
}

sumFibs(4);
//18.42
