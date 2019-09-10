<?php
    require_once 'connect.php';

    $c = $_COOKIE['code'];
    $c = mysql_query("SELECT * FROM eva_team WHERE code='$c'");

    if (mysql_num_rows($c) == 0) {
        //
    } else {
        header("location:./");
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
            <form action="sign-up.php" method="post">
                <a style="font-size: 24px; color: white; font-weight: bold;">Hesap oluşturma isteğide bulun.</a>
                <br><br><br>
                <input type="text" name="username" autocomplete="off" placeholder="Kullanıcı adı" class="input">
                <br><br>
                <input type="mail" name="mail" autocomplete="off" placeholder="E-Posta" class="input">
                <br><br>
                <select name="team" class="input">
                    <option value="1">Otonom - Telemetri</option>
                    <option value="2">Mekanik</option>
                    <option value="3">Elektrik</option>
                    <option value="4">İdari tanıtım</option>
                    <option value="5">Proje takip optimizasyon</option>
                </select>
                <br><br>
                <input class="input" type="password" name="password" placeholder="Şifre">
                <br><br>
                <input type="submit" name="register" value="Kayıt isteğinde bulun" style="cursor: pointer;" class="input">
                <br><br><br>
                <a href="login" style="color: grey; font-size: 15px; cursor: pointer;">Zaten hesabın var mı?</a> <a href="login" style="color: lightgrey; cursor: pointer; font-size: 15px; text-decoration: underline;">Giriş yap.</a>
            </form>
        </div>
    </body>
</html>