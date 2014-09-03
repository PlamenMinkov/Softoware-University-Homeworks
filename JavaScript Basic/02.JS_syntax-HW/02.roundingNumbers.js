var valArr = [22.7,12.3,58.7];
function roundNumber(value) {
    var arr = [];
    arr.push(Math.floor(value));
    arr.push  (Math.round(value));
    return arr;
}
for (i = 0; i < 3; i++) {
    console.log(roundNumber(valArr[i])[0]);
    console.log(roundNumber(valArr[i])[1]);
}