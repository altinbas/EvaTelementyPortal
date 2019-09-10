<?php
    use PHPMailer\PHPMailer\PHPMailer;
    use PHPMailer\PHPMailer\Exception;
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
    $mail->Port = '587';
    $mail->Username = 'auth.glynet@yandex.com';
    $mail->Password = 'glynet1998';
    $mail->SMTPAuth = true;
    $mail->SMTPSecure = 'tls';
    $mail->setFrom('auth.glynet@yandex.com', 'Example - Admin');
    $mail->addAddress('metehansaral@gmail.com');
    $mail->isHTML(false);
    $mail->Subject = 'Test İleti';
    $mail->Body = 'Merhaba, Bu ileti test amaçlı iletilmiştir. Bilginize.';
    if($mail->send()) {
        echo('Mesaj gönderildi.');
    } else {
        echo('Mail gönderilemedi.');
    }
?>