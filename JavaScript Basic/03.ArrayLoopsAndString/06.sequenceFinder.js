var arr = [
    [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
    ['happy'],
    [2, 'qwe', 'qwe', 3, 3, '3']];
function findMaxSequence(arr) {
    var bool = false;
    var res = "";
    
    for (var i = 0; i <arr.length; i++) {
        
        if (parseInt(arr[i].length) == 1) {
            console.log(arr[i]);
        }
        else {
            var max = 0, maskMax = 0, maxObj = arr[i][0], maskMaxObj;
            
            for (var j = 1; j <= arr[i].length; j++) {
                
                if (arr[i][j] === arr[i][j - 1]) {
                    maskMax++;
                    maskMaxObj = arr[i][j];
                    if (maskMax >= max) {
                        
                        max = maskMax;
                        maxObj = maskMaxObj;
                    }
                }
                else maskMax = 0;
                
            }
            var fin = [];
            while (max >= 0) {
                fin.push(maxObj);
                max--;
            }
            console.log(fin);
        }
    }
    
};
findMaxSequence(arr);