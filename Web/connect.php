<?php
    error_reporting(0);
    
    $connect = mysql_connect("localhost", "root", "");
    
    mysql_select_db("eva_test", $connect);
    mysql_query("SET NAMES utf8");
    mysql_query("SET CHARACTER SET utf8");
    mysql_query("SET COLLATION_CONNECTION='utf8_general_ci'");
?>
