public class Solution {
    public int BalancedStringSplit(string s) {

        var currentNumR = 0;
        var currentNumL = 0;
        var currentBalancedSubs = 0;

        for(var i = 0; i < s.Length; i++){

            if(s[i] == 'L'){
                currentNumL++;
            }else{
                currentNumR++;
            }

            if(currentNumR == currentNumL){
                currentNumR = 0;
                currentNumL = 0;
                currentBalancedSubs++;
            }
        }

        return currentBalancedSubs;
    }
}
