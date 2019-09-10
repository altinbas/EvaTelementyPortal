<?php
    require_once 'connect.php';

    $c = $_COOKIE['code'];
    $c = mysql_query("SELECT * FROM eva_team WHERE code='$c'");

    if (mysql_num_rows($c) == 0) {
        header("location:./login");
    }

    $user = mysql_fetch_object($c);
    
    if ($user->active == "0") {
        header("location:./inactive");
    }
?>
<html>
    <head>
        <title>Dashboard</title>
        <meta name="viewport" content="width=device-width, initial-scale=0.5">
    </head>

    <script src="jquery-3.3.0.min.js"></script>
    <script src="data.js"></script>

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
            margin: 80px auto;
        }

        .sc-gauge  { width:280px; }
        .sc-background { position:relative; height:150px; margin-bottom:10px; background-color:#5a5e65; border-radius:150px 150px 0 0; overflow:hidden; text-align:center; }
        .sc-mask { position:absolute; top:20px; right:20px; left:20px; height:130px; background-color:#1c2025; border-radius:150px 150px 0 0 }
        .sc-percentage { transition-duration: 2s; position:absolute; top: 255px; left: -20%; height:400%; margin-left:100px; background-color:#00aeef; }
        .sc-percentage { transform:rotate(158deg); transform-origin:top center; }
        .sc-min { float:left; }
        .sc-max { float:right; }
        .sc-value { position:absolute; top:50%; left:0; width:100%;  font-size:48px; font-weight:700 }

        .batarya_cizgi {
            margin-top: 10px;
            height: 40px;
            background: #5a5e65;
            border-radius: 50px;
            width: 700px;
        }

        @media (max-width: 500px) {
            #content {
                width: 300px;
                position: relative;
                margin: 100px auto;
            }
        }
        table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

td, th {
  border: 1px solid #5a5e65;
  text-align: left;
  padding: 8px;
}

tr:nth-child(even) {
  background-color: #5a5e65;
}

::-webkit-scrollbar {
    width: 6px;
    height: 6px;
}
::-webkit-scrollbar-track {
    background: #1a1e21;
}
::-webkit-scrollbar-thumb {
    background: #3c4347;
    border-radius: 50px;
}
::-webkit-scrollbar-thumb:hover {
    background: rgb(129, 129, 129);
}
    </style>

    <script>
        $(document).ready(function() {
            <?php
                if ($_GET['view'] == "logs") {
                    echo "
            window.history.pushState('Object', 'Title', `logs`);
            $('#logs').show();
            $('#content').hide();
                    ";
                } else {
                    echo "
            window.history.pushState('Object', 'Title', ``);
            $('#logs').hide();
            $('#content').show();
                    ";
                }
            ?>
        });
    </script>
    
    <body>
        <div id="content">
            <div style="text-align: center;">
                <img src="logo.png" style="height: 90px;">
                <br><br><br>
                <button onclick="window.history.pushState('Object', 'Title', `logs`); $('#users').hide(); $('#logs').show(); $('#content').hide();" style="padding: 13px 25px; font-weight: bold; border-radius: 20px; background: #5a5e65; border: none; color: white; cursor: pointer; ">Geçmiş kayıtlara bak</button>
                <?php if ($user->admin == "1") { ?>
                &nbsp;
                <button onclick="window.history.pushState('Object', 'Title', `home`); $('#users').show(); $('#logs').hide(); $('#content').hide();" style="padding: 13px 25px; font-weight: bold; border-radius: 20px; background: #5a5e65; border: none; color: white; cursor: pointer; ">Kişiler</button>
                <?php } ?>  
                &nbsp;
                <a href="quit.php">
                    <button style="padding: 13px 25px; font-weight: bold; border-radius: 20px; background: #5a5e65; border: none; color: white; cursor: pointer; ">Çıkış yap</button>
                </a>
            </div>
            <br><br><br>
            <div id="batarya">
                <a style="font-size: 30px; font-weight: bold;">Batarya durumu</a>
                <br><br>
                <div class="batarya_cizgi">
                    <div style="text-align: center; padding-top: 12px;">
                        <a id="batarya_yuzde" style="color: white; font-weight: bold;"></a>    
                    </div>
                    <div id="batarya_yuzde_cizgi" style="border-radius: 50px; margin-top: -31px; transition-duration: 2s; background: #41b4ff; height: 40px; width: 0px;"></div>
                </div>
            </div>
            <br><br><br><br>
            <div style="float: left; width: 430px;" id="hiz">
                <a style="font-size: 30px; font-weight: bold;">Hız durumu</a>
                <br><br>
                <div style="margin-top: 10px;">
                    <div class="sc-gauge">
                        <div class="sc-background">
                        <div id="hiz_gosterge" style="width: 0px;" class="sc-percentage"></div>
                        <div class="sc-mask"></div>
                            <span id="hiz_durum" class="sc-value">0</span>
                            <br>
                            <a style=""></a>
                        </div>
                        <span class="sc-min">0</span>
                        <span class="sc-max">150</span>
                    </div>
                </div>
            </div>
            <div style="float: left;" id="akim">
                <a style="font-size: 30px; font-weight: bold;">Akım</a>
                <br><br>
                <div style="margin-top: 10px; height: 220px;">
                    <div style="float: left;">
                        <img src="yildirim.png" id="yildirim" style="background-color: #edba2f; transition-duration: .5s; height: 178px;">
                    </div>
                    <div style="float: left; margin-left: 60px;">
                        <a style="font-weight: bold; font-size: 30px; color: #d8dcde;">Çekilen akım</a>
                        <br>
                        <a style="font-weight: bold; font-size: 70px;" id="akim_gucu"></a>
                        <br>
                        <a style="font-size: 18px; color: #d8dcde; display: none;" id="sarj_oluyor">Şarj oluyor</a>
                        <a style="font-size: 18px; color: #d8dcde; display: none;" id="guc_yok">Güç gelmiyor</a>
                    </div>
                </div>
            </div>
            <br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>
            <div id="araba_nerede">
                <a style="font-size: 30px; font-weight: bold;">Araba nerede?</a>
                <br><br>
                <div style="display: block;">
                    <div id="yandex_map">
                        <script src="https://api-maps.yandex.ru/2.1/?lang=en_RU&apikey=<your API-key>" type="text/javascript"></script>
                        <style>
                            #map {
                                width: 1000px;
                                height: 330px;
                                border-radius: 50px;
                            }
                        </style>
                        <div id="map"></div>
                        <script>
                            ymaps.ready(function () {
                                window.myMap = new ymaps.Map("map", {
                                    center: [40.743865, 29.782439],
                                    zoom: 16
                                    // type: 'yandex#satellite'
                                }, {
                                    searchControlProvider: 'yandex#search'
                                }),

                                window.myGeoObject = new ymaps.GeoObject({
                                    geometry: {
                                        type: "Point",
                                        coordinates: [40.743865, 29.782439]
                                    }
                                }, {
                                    preset: 'islands#circleIcon',    
                                    iconCaption: 'Hız: ',
                                    draggable: true
                                }),
                                myPieChart = new ymaps.Placemark([
                                    55.847, 
                                ]);

                                myMap.geoObjects.add(myGeoObject)
                            });
                        </script>
                    </div>
                </div>
            </div>
            <br><br><br><br>
            <div id="akim">
                <a style="font-size: 30px; font-weight: bold;">Volt</a>
                <br><br>
                <div style="margin-top: 10px; height: 220px;">
                    <div style="float: left;">
                        <img src="kablo.png" id="volt" style="background-color: #edba2f; transition-duration: .5s; height: 220px;">
                    </div>
                    <div style="float: left; margin-left: 60px; width: 130px;">
                        <a style="font-weight: bold; font-size: 30px; color: #d8dcde;">Hücre 1</a>
                        <br>
                        <a style="font-weight: bold; font-size: 20px; color: #d8dcde;">maks</a>
                        <a style="font-weight: bold; font-size: 55px;" id="volt1_1_gucu"></a>
                        <div style="margin-top: 20px;">
                            <a style="font-weight: bold; font-size: 20px; color: #d8dcde;">min</a>
                            <a style="font-weight: bold; font-size: 55px;" id="volt2_1_gucu"></a>
                        </div>
                        <div style="margin-top: 20px;">
                            <a style="font-weight: bold; font-size: 20px; color: #d8dcde;">fark</a>
                            <a style="font-weight: bold; font-size: 55px;" id="volt3_1_gucu"></a>
                        </div>
                    </div>
                    <div style="float: left; margin-left: 60px; width: 130px;">
                        <a style="font-weight: bold; font-size: 30px; color: #d8dcde;">Hücre 2</a>
                        <br>
                        <a style="font-weight: bold; font-size: 20px; color: #d8dcde;">maks</a>
                        <a style="font-weight: bold; font-size: 55px;" id="volt1_2_gucu"></a>
                        <div style="margin-top: 20px;">
                            <a style="font-weight: bold; font-size: 20px; color: #d8dcde;">min</a>
                            <a style="font-weight: bold; font-size: 55px;" id="volt2_2_gucu"></a>
                        </div>
                        <div style="margin-top: 20px;">
                            <a style="font-weight: bold; font-size: 20px; color: #d8dcde;">fark</a>
                            <a style="font-weight: bold; font-size: 55px;" id="volt3_2_gucu"></a>
                        </div>
                    </div>
                    <div style="float: left; margin-left: 60px; width: 130px;">
                        <a style="font-weight: bold; font-size: 30px; color: #d8dcde;">Hücre 3</a>
                        <br>
                        <a style="font-weight: bold; font-size: 20px; color: #d8dcde;">maks</a>
                        <a style="font-weight: bold; font-size: 55px;" id="volt1_3_gucu"></a>
                        <div style="margin-top: 20px;">
                            <a style="font-weight: bold; font-size: 20px; color: #d8dcde;">min</a>
                            <a style="font-weight: bold; font-size: 55px;" id="volt2_3_gucu"></a>
                        </div>
                        <div style="margin-top: 20px;">
                            <a style="font-weight: bold; font-size: 20px; color: #d8dcde;">fark</a>
                            <a style="font-weight: bold; font-size: 55px;" id="volt3_3_gucu"></a>
                        </div>
                    </div>
                </div>
            </div>
            <br><br><br><br><br><br><br><br>
            <div id="sicaklik">
                <a style="font-size: 30px; font-weight: bold;">Sıcaklık durumu</a>
                <br><br>
                <div style="margin-top: 10px;">
                    <div style="width: 200px; height: 200px;">
                        <div style="height: 200px; border-radius: 50px; background: #5a5e65; width: 25px; margin-left: 18.5px;">
                            <div id="sicaklik_yuzde_cizgi" style="transition-duration: 2s; width: 25px; height: 0px; background: #0fbf50; border-radius: 50px; bottom: 0; position: absolute;"></div>
                        </div>
                        <div style="background: #5a5e65; height: 60px; width: 60px; margin-top: -15px; border-radius: 100%;">
                            <div id="heat1_renk1" style="width: 60px; height: 60px; background: #0fbf50; border-radius: 100%;">
                                <div style="text-align: center; padding-top: 21px;">
                                    <a id="sicaklik_yuzde" style="font-weight: bold;"></a>
                                </div>
                            </div>
                        </div>
                    </div>     
                    <div style="width: 200px; height: 200px; margin-top: -200px; margin-left: 200px">
                        <div style="height: 200px; border-radius: 50px; background: #5a5e65; width: 25px; margin-left: 18.5px;">
                            <div id="sicaklik1_yuzde_cizgi" style="transition-duration: 2s; width: 25px; height: 0px; background: #f7f547; border-radius: 50px; bottom: 0; position: absolute;"></div>
                        </div>
                        <div style="background: #5a5e65; height: 60px; width: 60px; margin-top: -15px; border-radius: 100%;">
                            <div style="width: 60px; height: 60px; background: #f7f547; border-radius: 100%;">
                                <div style="text-align: center; padding-top: 21px;">
                                    <a id="sicaklik1_yuzde" style="font-weight: bold; color: black;"></a>
                                </div>
                            </div>
                        </div>
                    </div>     
                    <div style="width: 200px; height: 200px; margin-top: -200px; margin-left: 400px">
                        <div style="height: 200px; border-radius: 50px; background: #5a5e65; width: 25px; margin-left: 18.5px;">
                            <div id="sicaklik2_yuzde_cizgi" style="transition-duration: 2s; width: 25px; height: 0px; background: #1bdcac; border-radius: 50px; bottom: 0; position: absolute;"></div>
                        </div>
                        <div style="background: #5a5e65; height: 60px; width: 60px; margin-top: -15px; border-radius: 100%;">
                            <div style="width: 60px; height: 60px; background: #1bdcac; border-radius: 100%;">
                                <div style="text-align: center; padding-top: 21px;">
                                    <a id="sicaklik2_yuzde" style="font-weight: bold; color: black;"></a>
                                </div>
                            </div>
                        </div>
                    </div>  
                    <div style="width: 200px; height: 200px; margin-top: -200px; margin-left: 600px; display: none;">
                        <div style="height: 200px; border-radius: 50px; background: #5a5e65; width: 25px; margin-left: 18.5px;">
                            <div id="sicaklik3_yuzde_cizgi" style="transition-duration: 2s; width: 25px; height: 0px; background: #f277d4; border-radius: 50px; bottom: 0; position: absolute;"></div>
                        </div>
                        <div style="background: #5a5e65; height: 60px; width: 60px; margin-top: -15px; border-radius: 100%;">
                            <div style="width: 60px; height: 60px; background: #f277d4; border-radius: 100%;">
                                <div style="text-align: center; padding-top: 21px;">
                                    <a id="sicaklik3_yuzde" style="font-weight: bold; color: black;"></a>
                                </div>
                            </div>
                        </div>
                    </div>     
                </div>
            </div>
        </div>
        <?php if ($user->admin == "1") { ?>
        <div id="users" style="padding: 20px 0px; display: none; height: 100%;">
            <div style="margin-left: 25px;">
                <img onclick="window.history.pushState('Object', 'Title', `home`); $('#users').hide(); $('#logs').hide(); $('#content').show();" src="left.png" style="height: 40px; cursor: pointer;">
                <div style="margin-left: 65px; margin-top: -35px;">
                    <a style="font-size: 30px;"><b>Kayıtlı takım üyeleri</b></a>
                </div>
            </div>
            <br>
            <br>
            <div style="margin-left: 25px;">
                <table>
                    <tr>
                        <th>Kullanıcı adı</th>
                        <th>E-Posta</th>
                        <th>Ekip</th>
                        <th>Aktif mi?</th>
                        <th>Admin?</th>
                    </tr>
                    <?php
                        $u = mysql_query("SELECT * FROM eva_team ORDER BY id DESC");
                        while ($y = mysql_fetch_array($u)) {
                            $t1 = array(
                                "1",
                                "2",
                                "3",
                                "4",
                                "5"
                            );
                            $t2 = array(
                                "Otonom & Telemetri",
                                "Mekanik",
                                "Elektrik",
                                "İdari tanıtım",
                                "Proje takip optimizasyon"
                            );
                            $team = str_replace($t1, $t2, $y['team']);

                            echo "
                    <tr>
                        <td>{$y['username']}</td>
                        <td>{$y['mail']}</td>
                        <td>{$team}</td>
                        <td>{$y['active']}</td>
                        <td>{$y['admin']}</td>
                    </tr>
                            ";
                        }
                    ?>
                </table>
            </div>
        </div>
        <?php } ?>
        <div id="logs" style="padding: 20px 0px; width: 3500px; height: 100%;">
            <div style="margin-left: 25px;">
                <img onclick="window.history.pushState('Object', 'Title', `home`); $('#users').hide(); $('#logs').hide(); $('#content').show();" src="left.png" style="height: 40px; cursor: pointer;">
                <div style="margin-left: 65px; margin-top: -35px;">
                    <a style="font-size: 30px;"><b>Haraket dökümü</b></a>
                </div>
            </div>
            <br>
            <br>
            <div id="charge_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Şarj</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='100' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>
            <div id="speed_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Hız</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='001' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>
            <div id="current_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Akım</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='110' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>
            <div id="heat_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Sıcaklık 1</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='120' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }
                        
                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>
            <div id="heat2_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Sıcaklık 2</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='121' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>
            <div id="heat3_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Sıcaklık 3</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='122' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>

            <div id="maxvolt1_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Maks Volt 1</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='130' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>
            <div id="maxvolt2_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Maks Volt 2</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='131' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>
            <div id="maxvolt3_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Maks Volt 3</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='132' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>

            <div id="minvolt1_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Min Volt 1</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='140' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>
            <div id="minvolt2_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Min Volt 2</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='141' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>
            <div id="minvolt3_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Min Volt 3</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='142' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>

            <div id="diffvolt1_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Fark Volt 1</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='150' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>
            <div id="diffvolt2_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Fark Volt 2</b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='151' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>
            <div id="diffvolt3_log" style="float: left; margin-left: 25px; width: 170px; padding: 15px; border-radius: 10px; background: #5a5e65; color: white;">
                <a style="font-size: 23px;"><b>Fark Volt 3<b></a>
                <hr style="margin-top: 15px;">
                <br>
                <?php
                    $log = mysql_query("SELECT * FROM logs WHERE module_id='152' ORDER BY date DESC LIMIT 0,300");
                    while ($l = mysql_fetch_array($log)) {
                        $date = explode(" ", $l['date']);
                        if ($date[0] == date("d.m.Y")) { $date = "<a style='color: #2ee6d6;'>$date[1]</a>"; } else { $date = "<a style='color: #ff3030;'>$date[1]</a>"; }

                        echo "<div style='height: 30px;'><span style='font-size: 19px'>{$l['value']} - {$date}</span></div>";
                    }
                ?>
            </div>

            
        </div>
    </body>
</html>