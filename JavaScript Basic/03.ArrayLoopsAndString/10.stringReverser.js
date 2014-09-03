var arr = ["sample","softuni","java script"];
function reverseString(arr) {
    for (var i = 0; i < arr.length; i++) {
        var txt ="";
        for (var j = arr[i].length - 1; j >= 0; j--) {
            txt += arr[i][j];
            }
        console.log(txt);
    }
};

    reverseString(arr);