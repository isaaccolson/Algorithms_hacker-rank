const vowels = ["a", "e", "i", "o", "u"];
function translatePigLatin(str) {

    let newString = "";

    //1. Check if first char is vowel
    if (vowels.indexOf(str[0]) != -1) {
        newString = str;
        newString += "way";
    }

    //2. Check how long cluster of consonants is
    //3. Store the cluster and add to end
    //4. Add "ay" to end of cluster
    else {

        let conCluster = str[0];
        let vowelFound = false;

        for (let i = 1; i < str.length; i++) {
            if (vowels.indexOf(str[i]) == -1 && !vowelFound) {
                conCluster += str[i];
            } else {
                vowelFound = true;
                newString += str[i];
            }
        }
        conCluster += "ay";
        newString += conCluster;

    }

    return newString;
}

translatePigLatin("consonant");
//38 min
