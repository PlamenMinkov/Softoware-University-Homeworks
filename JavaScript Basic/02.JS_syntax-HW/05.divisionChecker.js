var valArr = [12,188,591];
function divisionBy3(value) {
    if (value < 10) {
        return true;
    }
    var arr = [],count=0;
    while (value != 0) {
        arr[count] = parseInt(value) % 10;
        value =parseInt(value)/10;
        count++;
    }
    var sum = 0;
    for (var i = 0; i < count; i++) {
        var num = parseInt(arr[i]);
        sum += num;
    }
        
    if (sum % 3 == 0) {
        return console.log("the number is divided by 3 without remainder");   
    }
    return console.log("the number is not divided by 3 without remainder");
}
for (var i = 0; i < 3; i++) {
    divisionBy3(valArr[i]);
}