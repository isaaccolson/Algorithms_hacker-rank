public class Solution {
    public string DefangIPaddr(string address) {
        var newAddress = "";
        foreach(char letter in address){
            newAddress += (letter == '.') ? "[.]" : letter.ToString();
        }
        return newAddress;
    }
}
//4.16
