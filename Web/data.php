<?php
	require_once "connect.php";

	if ($_POST) {

		// $array[<name>] = <value>

		$veri = mysql_fetch_array(mysql_query("SELECT * FROM degerler"));

		$array['sarj'] = $veri['charge'];

		$array['sicaklik'] = $veri['heat'];
		$array['sicaklik1'] = $veri['heat1'];
		$array['sicaklik2'] = $veri['heat2'];
		
		$array['hiz'] = $veri['speed'];

		$array['akim'] = $veri['current'];

		$array['volt1_1'] = $veri['maxcell1'];
		$array['volt1_2'] = $veri['maxcell2'];
		$array['volt1_3'] = $veri['maxcell3'];

		$array['volt2_1'] = $veri['mincell1'];
		$array['volt2_2'] = $veri['mincell2'];
		$array['volt2_3'] = $veri['mincell3'];

		$array['volt3_1'] = $veri['difference1'];
		$array['volt3_2'] = $veri['difference2'];
		$array['volt3_3'] = $veri['difference3'];

		$array['geolocation1'] = $veri['location1'];
		$array['geolocation2'] = $veri['location2'];

		$lastupdate = $veri['last_update'];
		$old_time = date();

		if ($lastupdate == $old_time)
		
		echo json_encode($array);
	}
?>