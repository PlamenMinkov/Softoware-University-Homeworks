<style>
    table{
        border-collapse: collapse;
    }
    td{
        padding-left: 5px;
        padding-right: 5px;
    }
    .first{
        background-color: orange;
    }
</style>
<?php
$name='Ivan';
$num='0888855505';
$age=24;
$addres='Stefan Karadja 35';
echo '<table border="1"><tr><td class="first">Name:</td><td>'."$name".'</td></tr>'
        . '<tr><td class="first">Phone number:</td><td>'."$num".'</td></tr>'
        . '<tr><td class="first">Age:</td><td>'."$age".'</td></tr>'
        . '<tr><td class="first">Adress:</td><td>'."$addres".'</td></tr></table>';

