-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 10 Eyl 2019, 15:08:02
-- Sunucu sürümü: 5.7.19
-- PHP Sürümü: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `eva_test`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `degerler`
--

DROP TABLE IF EXISTS `degerler`;
CREATE TABLE IF NOT EXISTS `degerler` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `speed` varchar(10) NOT NULL,
  `heat` varchar(10) NOT NULL,
  `charge` varchar(10) NOT NULL,
  `heat1` varchar(10) NOT NULL,
  `heat2` varchar(10) NOT NULL,
  `current` varchar(10) NOT NULL,
  `maxcell1` varchar(30) NOT NULL,
  `maxcell2` varchar(30) NOT NULL,
  `maxcell3` varchar(30) NOT NULL,
  `mincell1` varchar(30) NOT NULL,
  `mincell2` varchar(30) NOT NULL,
  `mincell3` varchar(30) NOT NULL,
  `difference1` varchar(30) NOT NULL,
  `difference2` varchar(30) NOT NULL,
  `difference3` varchar(30) NOT NULL,
  `location1` varchar(100) NOT NULL,
  `location2` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `degerler`
--

INSERT INTO `degerler` (`id`, `speed`, `heat`, `charge`, `heat1`, `heat2`, `current`, `maxcell1`, `maxcell2`, `maxcell3`, `mincell1`, `mincell2`, `mincell3`, `difference1`, `difference2`, `difference3`, `location1`, `location2`) VALUES
(1, '0', '0', '100', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '41.057810', '28.820699');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `eva_team`
--

DROP TABLE IF EXISTS `eva_team`;
CREATE TABLE IF NOT EXISTS `eva_team` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(100) NOT NULL,
  `username` varchar(100) NOT NULL,
  `mail` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `team` varchar(20) NOT NULL,
  `active` varchar(10) NOT NULL,
  `admin` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `logs`
--

DROP TABLE IF EXISTS `logs`;
CREATE TABLE IF NOT EXISTS `logs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `module_id` varchar(10) NOT NULL,
  `value` varchar(20) NOT NULL,
  `date` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
