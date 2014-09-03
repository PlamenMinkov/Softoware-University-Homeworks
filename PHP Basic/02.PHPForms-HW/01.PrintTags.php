<!DOCTYPE html>
<html>
    <head>
        <title></title>
    </head>
    <body>
        <form method="post">
            <p>Enter Tags:</p>
            <input type="text" name="words"/>
            <input type="submit" name="sub" value="Submit" />
            <?php
                if($_POST){
                    $text = $_POST['words'];
                    $arr= explode(", ",$text);
                    //preg_match($pattern, substr($text,3), $matches, PREG_OFFSET_CAPTURE);
                    echo "<br/>";
                    foreach($arr as $key=>$val){
                        echo $key.' :'.$val."<br/>";
                    }
                }
            ?>
        </form>
    </body>
</html>
