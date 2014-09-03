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
    $pattern="/[<]{1}[ ]href=[ ]{}/";
    $text="<p>Come and visit <a href=\"http://soft.uni.bg\">the Software University</a> 
    to master the art of programming. You can always check our <a href=\"www.softuni.bg/forum\">forum</a> 
    if you have any questions.</p>
    <p>Come and visit <a href=\"respor.php\">the Software University</a> 
    to master the art of programming. You can always check our <a href=\"www.softuni.bg/forum\">forum</a> 
    if you have any questions.</p>";
    $pattern='/[<]{1}[ ]*a[ ]*href[ ]*=[ ]*(")[ ]*(http|https)*[ ]*(:)*[ ]*(\/\/)*[ ]*(www.)*([$\-_+!*\'()\w]+(\.){1})+[\w]{2,4}((\/){1}[$\-_+!*\'()\w]+)*(")[ ]*(>)/';
    $count=preg_match_all($pattern,$text,$result,PREG_OFFSET_CAPTURE);
//preg_match($pattern, substr($subject,3), $matches, PREG_OFFSET_CAPTURE);
var_dump($result);
}
?>