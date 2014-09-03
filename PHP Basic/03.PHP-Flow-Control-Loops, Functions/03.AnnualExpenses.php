<?php
function getMonthName($number)
{
    return date("F", strtotime(date("d-$number-Y")));
}
?>
<!DOCTYPE html>
<html>
    <head>
        <title>Annual Expenses</title>
        <link rel="stylesheet" type="text/css" href="tableStyle.css">
    </head>
    <body>
         <form method="post">
            <span>Enter number of years:</span>
            <input type="text" name="num"/>
            <input type="submit" value="Submit" />
        </form>
        <?php
        if(isset($_POST['num'])&&!empty($_POST['num'])):
            $year=date('Y');
         ?>
        <table border="1">
            <tr>
                <th>Year</th>
                <?php 
                    for ($i=1; $i<=12; $i++):     
                        $month=getMonthName($i);
                ?>
                <th><?=$month?></th>
                <?php endfor; ?>
                <th>Total:</th>
             </tr>
            <tr>
            <?php for ($i = 0; $i < $_POST['num']; $i++):?>
            <td><?= $year+$i ?></td>
               <?php 
                $count=0;
                for ($j = 0; $j < 12; $j++):
                    $rand=rand(0,999);
                    $count+=$rand;
               ?>
                <td><?= $rand ?></td>
                <?php endfor; ?>
                <td><?=$count ?></td>
                </tr>
            <?php endfor; ?>
        </table>
        <?php endif; ?>
        </body>
    </html>