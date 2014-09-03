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
    $text=$_POST['text'];
    $text=str_replace(" ",'',$text);
    for ($i = 0; $i < strlen($text); $i++)
    {
        if(ord($text[$i])%2==0){
        echo "<font color='red'>{$text[$i]} </font>";
        }
        else{
            echo "<font color='blue'>{$text[$i]} </font>"; 
        }
    }
    
}
?>