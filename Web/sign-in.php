<?php
    require_once 'connect.php';

    if ($_POST['login']) {
        $kad = $_POST['mail'];
        $pass = $_POST['password'];

        if ($kad == "") {
            header("location:./login?error=emptyusername");
        } else {
            if ($pass == "") {
                header("location:./login?error=emptypassword");    
            } else {
                $control = mysql_fetch_object(mysql_query("SELECT * FROM eva_team WHERE mail='$kad'"));

                if ($pass == $control->password) {
                    setcookie("code", $control->code, time()+3600*24*365*10);
                    header("location:./");
                } else {
                    header("location:./login?error=wronganything");
                }
            }
        }
    } else {
        header("location:./");
    }
?>