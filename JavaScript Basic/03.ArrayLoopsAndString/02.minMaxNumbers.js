var arr = [
    [1, 2, 1, 15, 20, 5, 7, 31],
    [2, 2, 2, 2, 2],
    [500, 1, -23, 0, -300, 28, 35, 12]];
function findMinAndMax(val) {
    var min;
    var max;
    
    var resArr=[];
    for (var i = 0; i < val.length; i++) {
        min = val[i][0];
        max = val[i][0];
        for (var j = 0; j < val[i].length; j++) {
            if(val[i][j]>max) max=val[i][j];
            if(val[i][j]<min) min=val[i][j];
        }
        resArr[i] = [min, max];
    }
   
    return resArr;
};
var res = findMinAndMax(arr);

for (var i = 0; i < res.length; i++) {
    console.log("min-> " + res[i][0]);
    console.log("max-> " + res[i][1]);
}