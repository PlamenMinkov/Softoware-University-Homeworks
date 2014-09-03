var arr = [20,-5,13];
function printNumbers(n) {
    var bool = false;
    var res="";
    for (var i = 1; i <= n; i++) {
        if (i % 4 != 0 && i % 5 != 0) {
            if (!bool) {
                res +=i;
            }
            else res += ", " + i;
            bool = true;
        }
    }
    if (!bool) {
        res = "no";
    }
    return res;
};
for (var i = 0; i < arr.length; i++) {
    console.log(printNumbers(arr[i]));
}