<!DOCTYPE html>
<html>
    <head>
        <title>Square Root Sum</title>
        <link rel="stylesheet" type="text/css" href="tableStyle.css">
    </head>
    <body>
        <table border="1">
            <tr><th>Number</th><th>Square</th></tr>
<?php
$sum=0; 
$count=0;
for($i=0;$i<=100;$i+=2){
    $sqrt=sqrt($i);
    $sum+=number_format(sqrt($i), 2, '.', '');
    if($i<=8||($i>=94&&$i<=100)){
        echo '<tr><td>'.$i.'</td><td>'.number_format(sqrt($i), 2, '.', '').'</td></tr>';
    }
    else if($count==0){
        echo '<tr><td>...</td><td>...</td></tr>';
        $count++;
    }
}
echo '<tr><td class="bold">Total</td><td>'.number_format($sum, 2, '.', '').'</td></tr></table>';
?>
   </body>
</html>