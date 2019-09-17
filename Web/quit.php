<?php
    session_destroy();
    setcookie("code", $_COOKIE['code'], time()-2629743);
    header("location:./login.php");
?>