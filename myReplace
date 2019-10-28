function myReplace(str, before, after) {

    let stringArr = str.split(" ");
    let indexOfBefore = stringArr.indexOf(before);

    let isUppercase = false;

    if (before[0] === before[0].toUpperCase()) {
        after = after.charAt(0).toUpperCase() + after.slice(1);
    } else {
        after = after.toLowerCase();
    }

    stringArr[indexOfBefore] = after;

    str = stringArr.join(" ");

    return str;
}

myReplace("A quick brown fox jumped over the lazy dog", "jumped", "leaped");
