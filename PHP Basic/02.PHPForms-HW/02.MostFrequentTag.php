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
                    echo "<br/><br/>";
                    $count=1; $maskCount=1;
                    $maskObj; $obj;
                    for($j=0;$j<count($arr);$j++){
                        
                        if($arr[$j]!='*'){
                          
                            $maskCount=1;
                            $maskObj=$arr[$j];
                            for($i=$j+1;$i<count($arr);$i++){
                                if($arr[$j]==$arr[$i]){
                                    $maskCount++;
                                    $arr[$i]='*';
                                }
                                if($maskCount>$count){
                                    $count=$maskCount;
                                    $obj=$maskObj;
                                }
                            }
                            echo $maskObj.' : '.$maskCount.' times<br/>';
                        }                      

                    }
                }
            ?>
        </form>
    </body>
</html>