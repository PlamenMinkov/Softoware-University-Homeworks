var arr = [
    [38,118,0.5],
    [20,87,2],
    [16,102,1.1]
];
var foods = ["apples","chocolate","tomatoes"];
function calcSupply(y1,y2,kg) {
    var fin = (y2 - y1) * 365 * kg;
       
    return fin;
}
for (var i=0;i<arr.length;i++) {
    console.log(calcSupply(arr[i][0], arr[i][1], arr[i][2]) + "kg of " + foods[i] +
        " would be enough until I am " + arr[i][1] + " years old.");
}
    