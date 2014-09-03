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
    $text=preg_split('/[a-zA-Z0-9 ,:;-][.?!]/',$textList);
    echo $text[0];
}
            ?>