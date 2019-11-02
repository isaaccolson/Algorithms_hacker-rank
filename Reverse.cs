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
    return returnString;
  }
}
