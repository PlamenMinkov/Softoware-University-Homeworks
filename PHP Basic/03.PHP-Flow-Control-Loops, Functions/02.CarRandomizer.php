<!DOCTYPE html>
<html>
    <head>
        <title>Car Randomizer</title>
        <link rel="stylesheet" type="text/css" href="tableStyle.css">
    </head>
    <body>
         <form method="post">
            <p>Enter Tags:</p>
            <input type="text" name="cars"/>
            <input type="submit" value="Submit" />
        </form>
        <?php
        if(isset($_POST['cars'])&&!empty($_POST['cars'])):
            $carsList=$_POST['cars'];
            $cars=preg_split('/[ ,;]+/',$carsList);
        ?>
        <table border="1">
            <tr>
                <th>Car</th>
                <th>Coler</th>
                <th>Count</th>
            </tr>
            <?php
            $colors=array("yewoll",'blue','white','green','darkgreen');
            foreach ($cars as $carName):
                $count=rand(1,5);
                $color=array_rand($colors);
            ?>
            <tr>
                <td><?= $carName; ?></td>
                <td><?=$colors[$color];?></td>
                <td><?= $count;?></td>
            </tr>
            <?php endforeach; ?>
        </table>
        <?php endif;?>
    </body>
</html>
