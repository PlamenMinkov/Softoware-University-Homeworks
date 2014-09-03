<?php 
    function isPrime($num){
        if($num>=0&&$num<=3){
            return true;        
        }
        else{
            for ($i = 2; $i < $num; $i++)
            {
            	if($num%$i==0){
                    return false;
                }
            }
            return true;
        }
    }
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Primes In Range</title>
        <link rel="stylesheet" type="text/css" href="tableStyle.css">
    </head>
    <body>
         <form method="post">
            <span>Starting Index:</span>
            <input type="text" name="start"/>
             <span>End:</span>
            <input type="text" name="end"/>
            <input type="submit" value="Submit" />
        </form>
<?php
    if((isset($_POST['start'])&&!empty($_POST['start']))&&
        (isset($_POST['end'])&&!empty($_POST['end']))){
        for ($i = $_POST['start']; $i <= $_POST['end']; $i++)
        {
        	if(isPrime($i)){
                print  '<strong>' .$i. '</strong>'; 
            }
            else print  $i; 
            if($i!=$_POST['end']){
                print ', ';
            }
        }
        
    }
        
?>
    </body>
</html>