<?php
    require_once 'connect.php';

    $c = $_COOKIE['code'];
    $c = mysql_query("SELECT * FROM eva_team WHERE code='$c'");

    if (mysql_num_rows($c) == 0) {
        header("location:./login");
    } else {
        //
    }

    $code = $_GET['code'];

    if ($code == "") {
        header("location:./");
    } else {
        $user = mysql_fetch_object($c);
        
        if ($user->admin == "1") {
            $update = mysql_query("UPDATE eva_team SET active='1' WHERE code='$code'");
            $text = "Kişiye erişim izni verildi.";
        } else {
            $text = "Sen admin değilsin kaarşim hayırdır??¿";
        }
    }
?>
<html>
    <head>
        <title>Dashboard</title>
        <meta name="viewport" content="width=device-width, initial-scale=0.5">
    </head>

    <style>
        body {
            font-family: Helvetica;
            background-color: #1c2025;
            color: white;
        }
        a {
            color: white;
            text-decoration: none;
        }
        #content {
            width: 1000px;
            position: relative;
            margin: 100px auto;
        }

        @media (max-width: 500px) {
            #content {
                width: 300px;
                position: relative;
                margin: 100px auto;
            }
        }
        .input {
            padding: 13px 20px;
            width: 300px;
            outline: none;
            border-radius: 50px;
            border: none;
            background-color: #5a5e65;
            color: white;
        }
        .input::placeholder {
            color: white;
        }
    </style>

    <body>
        <div id="content" style="text-align: center;">
            <img src="logo.png" style="height: 90px;">
            <br><br><br><br>    
            <a style="font-size: 24px; color: white; font-weight: bold;"><?= $text ?></a>
        </div>
    </body>
</html>