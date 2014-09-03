var valArr = [333,425,2567564754];
function bitChecker(value) {
    var mask = 1<<3;
    mask = value & mask;
    mask >>= 3;
    if (mask == 1) {
        return true;   
    }
    
    return false;
}
for (var i = 0; i < 3; i++) {
    console.log(bitChecker(valArr[i]));
}