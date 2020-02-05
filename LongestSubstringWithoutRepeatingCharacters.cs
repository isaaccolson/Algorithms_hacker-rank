public class Solution {
    
    public int LengthOfLongestSubstring(string s) {
 
        var length = s.Length;
        
        if(length <= 1){
            return length;
        }
        
        var currentSubString = "";
        var largestCount = 0;
        
        for(var i = 0; i < length -1; i++){
            currentSubString = s[i].ToString();
            for(var j = i + 1; j < length;j++){
                if(currentSubString.Contains(s[j])){
                    if(currentSubString.Length > largestCount){
                        largestCount = currentSubString.Length;
                    }
                    break;
                }else{
                    currentSubString += s[j];
                    if(j == s.Length -1 && currentSubString.Length > largestCount){
                        return currentSubString.Length;
                    }
                }
            }
        }
       return largestCount;
    }
}//20 minutes 2nd try... needs to be refactored/optimized