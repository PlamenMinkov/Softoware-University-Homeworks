var valArr = [7,254,587];
function isPrime(value) {
    if (value < 3) {
        return true;   
    }
    for (var i = 2; i <value; i++) {
        if (value % i == 0) { 
            return false;
        }
    }
    return true;
}
for (var i = 0; i <3; i++) {
    console.log(isPrime(valArr[i]));
}