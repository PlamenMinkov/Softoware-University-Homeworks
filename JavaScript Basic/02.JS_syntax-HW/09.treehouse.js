var arr = [[3,2],[3,3],[4,5]];

function treeHouseCompare(arr) {
    var h = ((1/2) * arr[0] *(arr[0]*(2/3)))+arr[0]*arr[0];
    var t = (arr[1] * (1 / 3) * arr[1]) + (Math.PI * (2 / 3) * arr[1]* (2 / 3) * arr[1]);
    
    if (h >= t) return "house/" + h.toFixed(2);
    else return "tree/" + t.toFixed(2);
}
for(var i=0;i<arr.length;i++)
console.log(treeHouseCompare(arr[i]));