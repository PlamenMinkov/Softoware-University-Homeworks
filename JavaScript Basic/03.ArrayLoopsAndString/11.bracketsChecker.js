var arr = [
    "( ( a + b ) / 5 – d )",
    ") ( a + b ) )",
    "( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )"
    ];
function checkBrackets(arr) {
    for (var i = 0; i < arr.length; i++) {
        var count = 0,bool=true;
        for (var j =0; j < arr[i].length; j++) {
            if (arr[i][j] === '(') count++;
            else if (arr[i][j] === ')') count--;
            if (count < 0) {
                console.log("incorrect");
                bool = false; break;
            }
        }
        if (count === 0&&bool) console.log("correct");
        else if(bool) console.log("incorrect");
    }
};

checkBrackets(arr);