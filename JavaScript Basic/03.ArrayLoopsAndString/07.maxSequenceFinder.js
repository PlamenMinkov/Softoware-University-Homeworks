var arr = [
    [3, 2, 3, 4, 2, 2, 4],
   [3, 5, 4, 6, 1, 2, 3, 6, 10, 32],
    [3, 2, 1]];
function findMaxSequence(arr) {
    var bool = false;
    var res = "";
    
    for (var i = 0; i < arr.length; i++) {
        
        if (parseInt(arr[i].length) == 1) {
            console.log(arr[i]);
        }
        else {
            var max = 1, maskMax = 1, maxObj = arr[i][0], maskMaxObj;
            
            for (var j = 1; j <= arr[i].length; j++) {
                
                if (parseInt(arr[i][j]) > parseInt(arr[i][j - 1])) {
                    maskMax++;
                    maskMaxObj = parseInt(arr[i][j]);
                    
                    if (maskMax >= max) {
                        var fin = [];
                        max = maskMax;
                        maxObj = maskMaxObj;
                        for (var k = j-max+1; k <= j; k++) {
                            fin.push(arr[i][k]);
                        }
                    }
                }
                else maskMax = 1;
                
            }
            if (max === 1) console.log("no");
            else  console.log(fin);
        }
    }
    
};
findMaxSequence(arr);