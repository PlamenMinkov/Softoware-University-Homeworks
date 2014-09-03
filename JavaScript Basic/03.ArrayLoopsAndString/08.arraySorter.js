arr = [
    [5, 4, 3, 2, 1],
    [12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]
    ];

function compareChars(arr) {
    var first, temp;
    
    for (var i = arr.length - 1; i > 0; i--) {
        first = 0;              
        for (var j = 1; j <= i; j++)   
        {
            if (arr[j] > arr[first])
                first = j;
        }
        temp = arr[first]; 
        arr[first] = arr[i];
        arr[i] = temp;
    }
    console.log(arr.join(", "));
}
for (var i = 0; i < arr.length; i++) {
    compareChars(arr[i]);
}
