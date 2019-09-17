<?php
    use PHPMailer\PHPMailer\PHPMailer;
    use PHPMailer\PHPMailer\Exception;

    function send_mail($who, $subject, $body) {
        require 'PHPMailer/src/Exception.php';
        require 'PHPMailer/src/PHPMailer.php';
        require 'PHPMailer/src/SMTP.php';

        $mail = new PHPMailer(true);
        $mail->setLanguage('tr');
        $mail->CharSet = "utf-8";
        $mail->isSMTP();
        $mail->SMTPDebug = 1; 
        $mail->SMTPOptions = array(
            'ssl' => array(
                'verify_peer' => false,
                'verify_peer_name' => false,
                'allow_self_signed' => true
            )
        );
        $mail->Host = 'smtp.yandex.com';
        $mail->Port = 587;
        $mail->Username = 'auth.glynet@yandex.com';
        $mail->Password = 'glynet1998';
        $mail->SMTPAuth = true;
        $mail->SMTPSecure = 'tls';
        $mail->setFrom('auth.glynet@yandex.com', 'Eva Team');
        $mail->addAddress($who);
        $mail->isHTML(true);
        $mail->Subject = $subject;
        $mail->Body = $body;
        $mail->send();
    }
    require_once 'connect.php';

    if ($_POST['register']) {
        $username = $_POST['username'];
        $team = $_POST['team'];
        $mail = $_POST['mail'];
        $password = $_POST['password'];
        $code = md5(rand(0,9999999999));

        if ($username == "") {
            $username = "John Doe";
        }

        if ($mail == "") {
            echo "E-Postayı boş girdiniz.";
        } else {
            if ($password == "") {
                echo "Şifreyi boş girdiniz.";
            } else {
                $insert = mysql_query("INSERT INTO eva_team (code, username, mail, password, team, active, admin) VALUES ('$code', '$username', '$mail', '$password', '$team', '0', '0')");
                if ($insert) {
                    echo "Kayıt işleminiz başarılı, yetkili tarafından hesabınızın onaylanmasını beklemelisiniz.";

                    echo "<div style='display: none;'>";
                    $body = "Yeni kayıt işlemi<br><br>Kullanıcı adı: <b>$username</b><br>E-Posta: <b>$mail</b><br> Takımı: <b>$team</b><br><br>Bu kişiyi onaylıyorsan tıkla: <a href='https://www.glynet.com/eva.dashboard/accept_user.php?code=$code'>Buraya tıkla</a>";
                    send_mail("metehansaral@gmail.com", "Eva - Kayıt isteği", $body); 
                    send_mail("majorisha7@hotmail.com", "Eva - Kayıt isteği", $body);   
                    echo "</div>";
                } else {
                    echo "Sunucu tarafında bir sıkıntı yaşandı";
                }
            }
        }
    } else {
        echo "Post ederken sıkıntı oldu";
    }

    header("location:./wait.php");
?>