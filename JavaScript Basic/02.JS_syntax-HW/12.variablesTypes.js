var arr = ['Pesho', 22, true, ['fries', 'banana', 'cake']];

function variablesTypes(arr) {
   console.log("My name:"+arr[0]+"//type is "+typeof(arr[0]));
   console.log("My age:" + arr[1] + "//type is " + typeof (arr[1]));
   console.log("I am male: " + arr[2] + "//type is " + typeof (arr[2]));
   console.log("My favorite froods are:"+arr[3][0]+", "+arr[3][1]+", "+arr[3][2]+"//type is "+typeof(arr[3]));
}
variablesTypes(arr);
