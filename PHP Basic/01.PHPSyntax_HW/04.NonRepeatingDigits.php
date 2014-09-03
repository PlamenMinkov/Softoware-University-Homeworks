<?php
function isTr($num){
    $units=$num%10;
    $num/=10;
    $tens=$num%10;
    $num/=10;
    $hundreds=$num%10;
    $num/=10;
    if($units!=$tens&&$units!=$hundreds&&$tens!=$hundreds)return true;
    else return false;
}
$var=345;
if($var<101){
    echo 'no';
}else{
    if($var<1000){
        $count=0;
        for($i=101;$i<=$var;$i++){
            if(isTr($i)==true) {
                if($count==0)
                echo $i;
                else echo ", $i";
                $count++;
            }
        }
    }
    else {
        $count=0;
        for($i=101;$i<=999;$i++){
            if(isTr($i)==true) {
                if($count==0)
                echo $i;
                else echo ", $i";
                $count++;
            }
        }
    }
}