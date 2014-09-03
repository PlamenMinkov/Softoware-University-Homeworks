<?php
mb_internal_encoding('UTF-8');
?>
<!Document html>
<html>
    <header>
        <meta charset="ISO-8859-1">
    </header>
    <body>
        <form action="" method="post">
            <input type="text" name="name" id="name" /><br/>
            <input type="text" name="age"/><br/>
            <input type="radio" name="gender" value="male">Male<br/>            
            <input type="radio" name="gender" value="female">Female<br/>
            <input type="submit" name="submit" value="Send" />
        </form>
    </body>
</html>
<?php
if($_POST)
	{
    $gender;
    if($_POST['gender']=="female")$gender='female';
    else if($_POST['gender']=="male")$gender='male';
   echo 'My name is '. $_POST['name'] .'. I am '. $_POST['age'] .' years old. I am '.$gender.'.';
   echo $gender;
        }
?>
