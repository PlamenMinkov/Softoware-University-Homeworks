<!DOCTYPE html>
<html>
    <head>
        <title>Word Mapper</title>
        <link rel="stylesheet" type="text/css" href="tableStyle.css">
    </head>
    <body>
         <form method="post">
            <input type="text" name="text"/>
            <input type="submit" value="Submit" />
        </form>
<?php
    if(isset($_POST['text'])&&!empty($_POST['text'])){
            $textList=$_POST['text'];
            $text=preg_split('/\W+/',$textList);
            ?>
        <table border="1">
        <?php
        for ($i = 0; $i < count($text); $i++)
        {
            if($text[$i]!='')
            {     
                $count=1;
                $text[$i]=strtolower($text[$i]);
                for ($j = $i; $j < count($text); $j++)
                {
                    $text[$j]=strtolower($text[$j]);
            	    if($text[$j]==$text[$i]&& $i!=$j){
                        $count++;
                        $text[$j]=''; 
                    }
                }
                
                ?>            
            <tr><td><?=$text[$i] ?></td><td><?=$count ?></td></tr>
        <?php
            }
        }?>
            
            <?php }
        
?></table>
        </body>
    </html>