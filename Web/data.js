$(function(){
	$.data = function(){
		var status = "true"
		$.ajax({
			type: "post",
			url: "data.php",
			data: { "status": status },
			dataType: "json",
			success: function(cevap) {
				// Araba takip
				myMap.geoObjects.removeAll()

				var myGeoObject = new ymaps.Placemark([cevap.geolocation1, cevap.geolocation2], {
					iconCaption: 'Hız: ' + cevap.hiz + ', Akım: ' + cevap.akim
				}, {
					preset: "islands#circleDotIcon",
				});
				myMap.geoObjects.add(myGeoObject);
				myMap.setCenter([cevap.geolocation1, cevap.geolocation2]);

				// Batarya
				document.getElementById("batarya_yuzde").innerHTML = cevap.sarj + "%"
				var yuzde = cevap.sarj * 7;
				$('#batarya_yuzde_cizgi').css("width", yuzde + "px");

				// Sıcaklık
				document.getElementById("sicaklik_yuzde").innerHTML = cevap.sicaklik + "℃";
				var syuzde = cevap.sicaklik * 2;
				$('#sicaklik_yuzde_cizgi').css("height", syuzde + "px");

				// 30'a kadar yeşil 50den fazla kırmızı 40'tan 50'ye kadar turuncu 

				document.getElementById("sicaklik1_yuzde").innerHTML = cevap.sicaklik1 + "℃";
				var syuzde1 = cevap.sicaklik1 * 2;
				$('#sicaklik1_yuzde_cizgi').css("height", syuzde1 + "px");

				document.getElementById("sicaklik2_yuzde").innerHTML = cevap.sicaklik2 + "℃";
				var syuzde2 = cevap.sicaklik2 * 2;
				$('#sicaklik2_yuzde_cizgi').css("height", syuzde2 + "px");

				// document.getElementById("sicaklik3_yuzde").innerHTML = cevap.sicaklik3 + "℃";
				// var syuzde3 = cevap.sicaklik3 * 2;
				// $('#sicaklik3_yuzde_cizgi').css("height", syuzde3 + "px");
				
				// Hız

				document.getElementById("hiz_durum").innerHTML = cevap.hiz;
				var hizgosterge = cevap.hiz * 2;
				$('#hiz_gosterge').css("width", hizgosterge + "px");

				// Akım
				var akim = cevap.akim;
				let sarjkontrol = akim.includes("-")

				if (sarjkontrol === true) {
					if (akim.includes("-0") === false) {
						$('#akim_gucu').css("color", "#a6abad")
						$('#sarj_oluyor').show();
					} else {
						$('#akim_gucu').css("color", "white")
						$('#sarj_oluyor').hide();
					}
				} else {
					$('#akim_gucu').css("color", "white")
					$('#sarj_oluyor').hide();
				}

				document.getElementById("akim_gucu").innerHTML = akim;

				if (akim < 3) {
					$('#yildirim').css("background-color", "#03bafc")
					console.log(akim)
					if (akim === "0.0" || akim === "0") {
						$('#guc_yok').show();
					} else {
						$('#guc_yok').hide();
					}
				} else {
					if (akim < 150) {
						$('#yildirim').css("background-color", "#edb621")
					} else {
						if (151 < akim && akim < 250) {
							$('#yildirim').css("background-color", "#ff8400")
						} else {
							$('#yildirim').css("background-color", "red")
						}
					}
				}
				
				// Akım
				var volt = cevap.volt1_1 + cevap.volt1_2 + cevap.volt1_3

				document.getElementById("volt1_1_gucu").innerHTML = cevap.volt1_1;
				document.getElementById("volt1_2_gucu").innerHTML = cevap.volt1_2;
				document.getElementById("volt1_3_gucu").innerHTML = cevap.volt1_3;

				document.getElementById("volt2_1_gucu").innerHTML = cevap.volt2_1;
				document.getElementById("volt2_2_gucu").innerHTML = cevap.volt2_2;
				document.getElementById("volt2_3_gucu").innerHTML = cevap.volt2_3;

				document.getElementById("volt3_1_gucu").innerHTML = cevap.volt3_1;
				document.getElementById("volt3_2_gucu").innerHTML = cevap.volt3_2;
				document.getElementById("volt3_3_gucu").innerHTML = cevap.volt3_3;
			
				if (volt < 143) {
					$('#volt').css("background-color", "#edb621")
				} else {
					if (144 < volt && volt < 288) {
						$('#volt').css("background-color", "#ff8400")
					} else {
						$('#volt').css("background-color", "red")
					}
				}
			}
		});
	}
	
	setInterval('$.data()', 1000);

});