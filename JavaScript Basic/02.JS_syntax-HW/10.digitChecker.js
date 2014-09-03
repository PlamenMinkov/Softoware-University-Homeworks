var arr = [1235,25368,123456];

function checkDigit(value) {
    value /= 100;
    var dig = parseInt(value % 10);
    if (dig === 3) {
        return true;   
    }
    
    return false;
}
for (var i = 0; i < arr.length; i++) {
    console.log(checkDigit(arr[i]));
}