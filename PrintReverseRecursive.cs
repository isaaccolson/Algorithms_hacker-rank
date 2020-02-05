public void reverseString(string str, index i){

  if(i < 0){
    return;
  }

  Console.WriteLine(str[i]);
  reverseString(str, i-1);

}
