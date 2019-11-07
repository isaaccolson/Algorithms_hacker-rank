public class Solution {
  public int Reverse(int x) {

    char[] chars = x.ToString().ToCharArray();

    if(chars[0] == '-'){
      Array.Reverse(chars, 1,chars.Length - 1);
    }else{
      Array.Reverse(chars);
    }

    int returnString;
    bool res = int.TryParse(new string(chars), out returnString);
    //Could have used a try catch block: try{var num = int.Parse(str);} catch(Exception){Console.WriteLine("error!")}
    return returnString;
  }
}
