public class Solution {
    public string DefangIPaddr(string address) {
        var newAddress = "";
        foreach(char letter in address){
            newAddress += (letter == '.') ? "[.]" : letter.ToString();
            //address.Replace(".","[.]"); Tom's way
        }
        return newAddress;
    }
}
//4.16
