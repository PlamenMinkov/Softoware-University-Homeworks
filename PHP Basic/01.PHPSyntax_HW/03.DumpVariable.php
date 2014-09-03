<?php
$var=array(1,2,3);
if(gettype($var)=="int"||gettype($var)=="double"){
    echo gettype($var)."($var)";
}else    echo gettype($var);