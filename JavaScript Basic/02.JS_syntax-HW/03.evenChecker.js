var valArr = [3,127,588];
function evenNumber(value) {
    if (parseInt(value) % 2 == 0) {
        return true;
    }
    else return false;
}
for (var i = 0; i < 3; i++) {
    console.log(evenNumber(valArr[i]));
 }