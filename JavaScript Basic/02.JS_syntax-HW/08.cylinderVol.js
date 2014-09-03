var arr = [
    [2,4],
    [5,8],
    [12,3]
];

function calcCylinderVol(r,h) {
    var vol = Math.PI * r * r * h;
    
    return vol;
}
for (var i = 0; i < arr.length; i++) {
    console.log((calcCylinderVol(arr[i][0],arr[i][1])).toFixed(3));
}