<?php
$d=cal_days_in_month(CAL_GREGORIAN,date('m'),date('y'));
for($i=1;$i<=$d;$i++){
    $isSunday = strtotime(date('Y')."-".date('m')."-".$i);
    if(date('l', $isSunday) == 'Sunday'){
        echo date("jS F, Y", $isSunday) . "\n";
    }
}

