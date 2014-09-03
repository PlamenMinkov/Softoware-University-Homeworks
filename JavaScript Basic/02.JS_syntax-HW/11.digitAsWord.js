var arr = [8,3,5];

function convertDigitToWord(value) {
    var name;
    switch(value) {
        case 1: return "one"; break;
        case 2: return "two"; break;
        case 3: return "three"; break;
        case 4: return "four"; break;
        case 5: return "five"; break;
        case 6: return "six"; break;
        case 7: return "seven"; break;
        case 8: return "eight"; break;
        case 9: return "nine"; break;
        default: return false; break;
    }
}

for (var i = 0; i < arr.length; i++) {
    console.log(convertDigitToWord(arr[i]));
}