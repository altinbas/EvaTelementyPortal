<?php
    error_reporting(0);
    // header("Content-Type: application/json; charset=UTF-8");

    date_default_timezone_set('Europe/Istanbul');

    if (isset($_POST)) {
        $s_code = $_REQUEST['securityCode'];

        if ($s_code == "71497316eva-msbaatg") {
            require_once 'connect.php';

            $key = $_REQUEST['key'];
            $value = $_REQUEST['value'];
            
            $moduleIdList = array(
                "id100" => "charge", //
                "id001" => "speed", //
                "id110" => "current", //
                "id120" => "heat", //
                "id121" => "heat1", //
                "id122" => "heat2", //
                "id130" => "maxcell1", //
                "id131" => "maxcell2", //
                "id132" => "maxcell3", //
                "id140" => "mincell1", //
                "id141" => "mincell2", //
                "id142" => "mincell3", // 
                "id150" => "difference1", //
                "id151" => "difference2", //
                "id152" => "difference3", //

                // "id" => "geolocation1",
                // "id" => "geolocation2"
            );

            $moduleName = $moduleIdList["id{$key}"];
            
            $date = date("d.m.Y H:i:s");

            $update = mysql_query("UPDATE degerler SET {$moduleName}='{$value}' WHERE id='1'");
            $log = mysql_query("INSERT INTO logs (module_id, value, date) VALUES ('$key', '$value', '$date')");
            if ($log) {

            } else {
                echo mysql_error();
            }
        }
    }
?>