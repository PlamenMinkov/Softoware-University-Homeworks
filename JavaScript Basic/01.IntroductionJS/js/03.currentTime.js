var d = new Date();
var minutes = d.getMinutes();
var hours = d.getHours();
console.log(hours + ":" + (minutes < 10 ? "0" + minutes : minutes));