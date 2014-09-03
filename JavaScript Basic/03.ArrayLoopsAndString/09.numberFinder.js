arr = [
    [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
    [2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1],
    [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]
    ];

function findMostFreqNum(arr) {
    var first=1, temp,count=1,maskCount;
    
    for (var i = arr.length - 1; i > 0; i--) {
        maskCount = 0;
        for (var j = 1; j <= i; j++) {
            if (arr[j] === arr[i])
                maskCount++;
        }
        if (maskCount > count) {
            count = maskCount;
            first = i;
        }
    }
    console.log(arr[i]+" ( "+count+"times )");
}
for (var i = 0; i < arr.length; i++) {
    findMostFreqNum(arr[i]);
}
