function whatIsInAName(collection, source) {
  // What's in a name?
  var arr = [];
  // Only change code below this line
for(let collObj in collection){
  console.log(collection[collObj]);
}//can access this way

collection.forEach(collObj => {//or this way
  console.log(collObj);
  let flag = true;
  let sourceArray = Object.entries(source);

  sourceArray.forEach(keyValue =>{
    if(collObj[keyValue[0]] !== keyValue[1]){
      //keyValue[0]] gets the value based on the array keyValue[0] which is the name.
      //keyValue[1] is the second element gives the value of the key 
      flag = false;
    }
  })
  if(flag){
    arr.push(collObj);
  }
})

  // Only change code above this line
  return arr;
}

whatIsInAName([{ first: "Romeo", last: "Montague" }, { first: "Mercutio", last: null }, { first: "Tybalt", last: "Capulet" }], { last: "Capulet" });
//15 minutes
