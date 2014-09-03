<!DOCTYPE html>
<html>
    <head>
        <title>Sum Of Digits</title>
        <link rel="stylesheet" type="text/css" href="tableStyle.css">
    </head>
    <body>
         <form method="post">
            <span>Input string:</span>
            <input type="text" name="str"/>
            <input type="submit" value="Submit" />
        </form>
        <?php
        if(isset($_POST['str'])&&!empty($_POST['str'])):
            $strList=$_POST['str'];
            $str=preg_split('/[ ,;]+/',$strList);
        ?>
        <table border="1">
            <?php
            foreach ($str as $var):
                if(!is_numeric($var)){?>
                <tr><td><?=$var?></td><td>I cannot sum that</td></tr>
            <?php 
                }
                else{
                    $sum=0;
                    $mask=$var;
                    while ($var!=0)
                    {
                    	$dig=$var%10;
                        $var/=10;
                        $sum+=$dig;  
                    }?>
                <tr><td><?=$mask?></td><td><?=$sum?></td></tr>    
            <?php } endforeach; ?>
        </table>
        <?php endif;?>
    </body>
</html>
