function truthCheck(collection, pre) {
  // Is everyone being true?
  let isTruthy = true;

   for (let collObj in collection) {

  // if(!collection[collObj].hasOwnProperty(pre)){//checks to see if the key exists. But don't need this.
    //  isTruthy = false;
  // }else{
     if (!collection[collObj][pre]) {
        isTruthy = false;
    }

 //  }

    }

  return isTruthy;
}

truthCheck([{"user": "Tinky-Winky", "sex": "male"}, {"user": "Dipsy", "sex": "male"}, {"user": "Laa-Laa", "sex": "female"}, {"user": "Po", "sex": "female"}], "sex");
