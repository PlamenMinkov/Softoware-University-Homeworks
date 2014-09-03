var arr = {
    1:[
     ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'],
     ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']
    ],
    2: [
        ['3', '5', 'g', 'd'], 
        ['5', '3', 'g', 'd']
       ],
    3:[
        ['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'],
        ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']

      ]
};

function compareChars(arr) {
    var res = [];
    
    for (var index in arr) {
        if (parseInt(arr[index][0].length) !== parseInt(arr[index][1].length)) {
            console.log("Not Equal");
        }
        else {
            var bool = true;
            for (var i = 0; i < arr[index][0].length; i++) {
                if (arr[index][0][i] !== arr[index][1][i]) { 
                    bool = false; break;
                }
            }
            if (bool) {
                res.push("Equal");
                console.log("Equal");
            }
            else {
                console.log("Net Equal");
                res.push("Net Equal");
            }
        }
    }
}

compareChars(arr);