-- MySqlBackup.NET 2.3.6
-- Dump Time: 2024-01-06 20:17:15
-- --------------------------------------
-- Server version 10.4.28-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of klienci
-- 

DROP TABLE IF EXISTS `klienci`;
CREATE TABLE IF NOT EXISTS `klienci` (
  `id_klienta` int(11) NOT NULL AUTO_INCREMENT,
  `imie` varchar(15) DEFAULT NULL,
  `nazwisko` varchar(15) DEFAULT NULL,
  `adres` varchar(15) DEFAULT NULL,
  `telefon` varchar(15) DEFAULT NULL,
  `email` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_klienta`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table klienci
-- 

/*!40000 ALTER TABLE `klienci` DISABLE KEYS */;
INSERT INTO `klienci`(`id_klienta`,`imie`,`nazwisko`,`adres`,`telefon`,`email`) VALUES(1,'siema','elo',NULL,NULL,NULL),(2,'siema','elowqeqwe',NULL,NULL,NULL),(3,'Jan','Kowalski',NULL,NULL,NULL);
/*!40000 ALTER TABLE `klienci` ENABLE KEYS */;

-- 
-- Definition of logi
-- 

DROP TABLE IF EXISTS `logi`;
CREATE TABLE IF NOT EXISTS `logi` (
  `id_logu` int(11) NOT NULL AUTO_INCREMENT,
  `Data_godzina` datetime NOT NULL,
  `Typ` varchar(15) NOT NULL,
  `Wiadomosc` varchar(50) NOT NULL,
  PRIMARY KEY (`id_logu`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table logi
-- 

/*!40000 ALTER TABLE `logi` DISABLE KEYS */;
INSERT INTO `logi`(`id_logu`,`Data_godzina`,`Typ`,`Wiadomosc`) VALUES(1,'2023-12-15 00:00:00','Sukces','Poprawnie zalogowano użytkownika ziomek'),(2,'2023-12-15 16:38:02','Sukces','Poprawnie zalogowano użytkownika ziomek'),(3,'2023-12-15 16:39:20','Sukces','Poprawnie zalogowano użytkownika ziomek'),(4,'2023-12-15 16:50:31','Informacja','Dodano rekord do bazy danych'),(5,'2023-12-15 16:53:25','Ostrzezenie','Zle zalogowanie'),(6,'2023-12-15 16:57:36','Blad','Blad krytyczny'),(7,'2023-12-15 16:58:46','Blad','Blad krytyczny'),(8,'2023-12-15 16:58:53','Blad','Blad krytyczny'),(9,'2023-12-15 16:58:54','Blad','Blad krytyczny'),(10,'2023-12-15 16:58:55','Blad','Blad krytyczny'),(11,'2023-12-15 16:58:57','Blad','Blad krytyczny'),(12,'2023-12-15 16:58:58','Blad','Blad krytyczny'),(13,'2023-12-15 16:58:59','Blad','Blad krytyczny'),(14,'2023-12-15 16:59:19','Blad','Blad krytyczny'),(15,'2023-12-15 16:59:20','Blad','Blad krytyczny'),(16,'2023-12-15 16:59:34','Blad','Blad krytyczny'),(17,'2022-12-15 15:38:21','Sukces','Siema'),(18,'2023-12-22 19:25:36','Blad','Blad krytyczny');
/*!40000 ALTER TABLE `logi` ENABLE KEYS */;

-- 
-- Definition of pakiety_promocyjne
-- 

DROP TABLE IF EXISTS `pakiety_promocyjne`;
CREATE TABLE IF NOT EXISTS `pakiety_promocyjne` (
  `id_pakietu` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa_pakietu` varchar(15) DEFAULT NULL,
  `data_rozpoczecia` date DEFAULT NULL,
  `data_zakonczenia` date DEFAULT NULL,
  PRIMARY KEY (`id_pakietu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table pakiety_promocyjne
-- 

/*!40000 ALTER TABLE `pakiety_promocyjne` DISABLE KEYS */;

/*!40000 ALTER TABLE `pakiety_promocyjne` ENABLE KEYS */;

-- 
-- Definition of role
-- 

DROP TABLE IF EXISTS `role`;
CREATE TABLE IF NOT EXISTS `role` (
  `kod_roli` varchar(15) NOT NULL,
  `nazwa` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`kod_roli`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table role
-- 

/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role`(`kod_roli`,`nazwa`) VALUES('KRW','Kierownik'),('SPR','Sprzedawca'),('SRW','Serwisant');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;

-- 
-- Definition of salony
-- 

DROP TABLE IF EXISTS `salony`;
CREATE TABLE IF NOT EXISTS `salony` (
  `id_salonu` int(11) NOT NULL AUTO_INCREMENT,
  `miejscowosc` varchar(15) DEFAULT NULL,
  `ulica` varchar(15) DEFAULT NULL,
  `kod_pocztowy` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_salonu`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table salony
-- 

/*!40000 ALTER TABLE `salony` DISABLE KEYS */;
INSERT INTO `salony`(`id_salonu`,`miejscowosc`,`ulica`,`kod_pocztowy`) VALUES(1,'39-200','Gliwice','Luzycka');
/*!40000 ALTER TABLE `salony` ENABLE KEYS */;

-- 
-- Definition of pracownicy
-- 

DROP TABLE IF EXISTS `pracownicy`;
CREATE TABLE IF NOT EXISTS `pracownicy` (
  `id_pracownika` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(15) DEFAULT NULL,
  `haslo` varchar(15) DEFAULT NULL,
  `imie` varchar(15) DEFAULT NULL,
  `nazwisko` varchar(15) DEFAULT NULL,
  `adres` varchar(15) DEFAULT NULL,
  `telefon` varchar(15) DEFAULT NULL,
  `email` varchar(30) DEFAULT NULL,
  `id_salonu` int(11) NOT NULL,
  `kod_roli` varchar(15) NOT NULL,
  PRIMARY KEY (`id_pracownika`),
  KEY `Pracownicy_Role_FK` (`kod_roli`),
  KEY `Pracownicy_Salony_FK` (`id_salonu`),
  CONSTRAINT `Pracownicy_Role_FK` FOREIGN KEY (`kod_roli`) REFERENCES `role` (`kod_roli`),
  CONSTRAINT `Pracownicy_Salony_FK` FOREIGN KEY (`id_salonu`) REFERENCES `salony` (`id_salonu`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table pracownicy
-- 

/*!40000 ALTER TABLE `pracownicy` DISABLE KEYS */;
INSERT INTO `pracownicy`(`id_pracownika`,`login`,`haslo`,`imie`,`nazwisko`,`adres`,`telefon`,`email`,`id_salonu`,`kod_roli`) VALUES(8,'grzesiu1234','grzegorz123','Grzegorz','Kowalski','xd','987654321','grzegorz@innymial.com',1,'KRW'),(12,'jkowlaski123','haslo123456','Janek','Kowaslki','Gliwice,Zwycięs','234567890','jkowalski@o2.co',1,'SPR'),(13,'mkolano12','haslo1234567','Marcin','Kolano','Gliwice,ZZ12','123456789','mkolano@gmail.c',1,'KRW'),(14,'bbb134','fsdfsdfsfdssfdf','bbbb','bbbb','Gliwice,aaa123','343234123','bbb@xd.com',1,'KRW'),(15,'jwroc22','1qazxsW@','Jacek','Wrocławski','Gliwicenormal12','123456789','jwroc22@gmail.c',1,'SPR'),(17,'mkapus12','1qazxsfsfsf','Marcin','Kapusta','Gliwice,Wrocław','123456789','mkapusta@gmail.',1,'KRW'),(18,'akap22','qwertyui','Andrzej','Kapusta','Wrocławska4','323232323','akap@gmail.com',1,'SRW'),(20,'akowalski12','12345678','Andrzej','Kowalski','Wrocławska3','123456789','andrzej@gmail.c',1,'SPR'),(21,'mkow399','Haslo12345','Marcin','Kowalczyk','Wrocławka3','123456789','mkowal123@o2.pl',1,'SPR');
/*!40000 ALTER TABLE `pracownicy` ENABLE KEYS */;

-- 
-- Definition of samochody
-- 

DROP TABLE IF EXISTS `samochody`;
CREATE TABLE IF NOT EXISTS `samochody` (
  `id_samochodu` int(11) NOT NULL AUTO_INCREMENT,
  `Model` varchar(15) DEFAULT NULL,
  `Marka` varchar(15) DEFAULT NULL,
  `Kolor` varchar(15) DEFAULT NULL,
  `Typ_nadwozia` varchar(15) DEFAULT NULL,
  `Moc_silnika` int(11) DEFAULT NULL,
  `Wyposazenie` varchar(15) DEFAULT NULL,
  `Srednie_spalanie` int(11) DEFAULT NULL,
  `Typ_silnika` varchar(15) DEFAULT NULL,
  `Cena_podstawowa` double DEFAULT NULL,
  `id_salonu` int(11) NOT NULL,
  `liczba_drzwi` int(11) DEFAULT NULL,
  `ilosc_miejsc` int(11) DEFAULT NULL,
  `VIN` varchar(15) DEFAULT NULL,
  `Rabat` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_samochodu`),
  KEY `Samochody_Salony_FK` (`id_salonu`),
  CONSTRAINT `Samochody_Salony_FK` FOREIGN KEY (`id_salonu`) REFERENCES `salony` (`id_salonu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table samochody
-- 

/*!40000 ALTER TABLE `samochody` DISABLE KEYS */;

/*!40000 ALTER TABLE `samochody` ENABLE KEYS */;

-- 
-- Definition of pakiety_samochody
-- 

DROP TABLE IF EXISTS `pakiety_samochody`;
CREATE TABLE IF NOT EXISTS `pakiety_samochody` (
  `id_pakietu` int(11) NOT NULL,
  `id_samochodu` int(11) NOT NULL,
  `wysokosc_promocji` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_pakietu`,`id_samochodu`),
  KEY `FK_ASS_4` (`id_samochodu`),
  CONSTRAINT `FK_ASS_3` FOREIGN KEY (`id_pakietu`) REFERENCES `pakiety_promocyjne` (`id_pakietu`),
  CONSTRAINT `FK_ASS_4` FOREIGN KEY (`id_samochodu`) REFERENCES `samochody` (`id_samochodu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table pakiety_samochody
-- 

/*!40000 ALTER TABLE `pakiety_samochody` DISABLE KEYS */;

/*!40000 ALTER TABLE `pakiety_samochody` ENABLE KEYS */;

-- 
-- Definition of uslugi
-- 

DROP TABLE IF EXISTS `uslugi`;
CREATE TABLE IF NOT EXISTS `uslugi` (
  `id_uslugi` int(11) NOT NULL AUTO_INCREMENT,
  `nazwa` varchar(15) DEFAULT NULL,
  `cena_uslugi` double DEFAULT NULL,
  `typ_uslugi` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_uslugi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table uslugi
-- 

/*!40000 ALTER TABLE `uslugi` DISABLE KEYS */;

/*!40000 ALTER TABLE `uslugi` ENABLE KEYS */;

-- 
-- Definition of pracownicy_uslugi
-- 

DROP TABLE IF EXISTS `pracownicy_uslugi`;
CREATE TABLE IF NOT EXISTS `pracownicy_uslugi` (
  `id_pracownika` int(11) NOT NULL,
  `id_uslugi` int(11) NOT NULL,
  PRIMARY KEY (`id_pracownika`,`id_uslugi`),
  KEY `FK_ASS_8` (`id_uslugi`),
  CONSTRAINT `FK_ASS_7` FOREIGN KEY (`id_pracownika`) REFERENCES `pracownicy` (`id_pracownika`),
  CONSTRAINT `FK_ASS_8` FOREIGN KEY (`id_uslugi`) REFERENCES `uslugi` (`id_uslugi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table pracownicy_uslugi
-- 

/*!40000 ALTER TABLE `pracownicy_uslugi` DISABLE KEYS */;

/*!40000 ALTER TABLE `pracownicy_uslugi` ENABLE KEYS */;

-- 
-- Definition of samochody_uslugi
-- 

DROP TABLE IF EXISTS `samochody_uslugi`;
CREATE TABLE IF NOT EXISTS `samochody_uslugi` (
  `id_samochodu` int(11) NOT NULL,
  `id_uslugi` int(11) NOT NULL,
  PRIMARY KEY (`id_samochodu`,`id_uslugi`),
  KEY `FK_ASS_12` (`id_uslugi`),
  CONSTRAINT `FK_ASS_11` FOREIGN KEY (`id_samochodu`) REFERENCES `samochody` (`id_samochodu`),
  CONSTRAINT `FK_ASS_12` FOREIGN KEY (`id_uslugi`) REFERENCES `uslugi` (`id_uslugi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table samochody_uslugi
-- 

/*!40000 ALTER TABLE `samochody_uslugi` DISABLE KEYS */;

/*!40000 ALTER TABLE `samochody_uslugi` ENABLE KEYS */;

-- 
-- Definition of uslugi_pakiety
-- 

DROP TABLE IF EXISTS `uslugi_pakiety`;
CREATE TABLE IF NOT EXISTS `uslugi_pakiety` (
  `id_uslugi` int(11) NOT NULL,
  `id_pakietu` int(11) NOT NULL,
  `wysokosc_promocji` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_uslugi`,`id_pakietu`),
  KEY `FK_ASS_13` (`id_pakietu`),
  CONSTRAINT `FK_ASS_10` FOREIGN KEY (`id_uslugi`) REFERENCES `uslugi` (`id_uslugi`),
  CONSTRAINT `FK_ASS_13` FOREIGN KEY (`id_pakietu`) REFERENCES `pakiety_promocyjne` (`id_pakietu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table uslugi_pakiety
-- 

/*!40000 ALTER TABLE `uslugi_pakiety` DISABLE KEYS */;

/*!40000 ALTER TABLE `uslugi_pakiety` ENABLE KEYS */;

-- 
-- Definition of zamowienia
-- 

DROP TABLE IF EXISTS `zamowienia`;
CREATE TABLE IF NOT EXISTS `zamowienia` (
  `id_zamowienia` int(11) NOT NULL AUTO_INCREMENT,
  `id_klienta` int(11) NOT NULL,
  `id_pracownika` int(11) NOT NULL,
  `typ_zakupu` varchar(15) DEFAULT NULL,
  `calkowity_koszt` double DEFAULT NULL,
  `DATA` date DEFAULT NULL,
  PRIMARY KEY (`id_zamowienia`),
  KEY `Zamowienia_Klienci_FK` (`id_klienta`),
  KEY `Zamowienia_Pracownicy_FK` (`id_pracownika`),
  CONSTRAINT `Zamowienia_Klienci_FK` FOREIGN KEY (`id_klienta`) REFERENCES `klienci` (`id_klienta`),
  CONSTRAINT `Zamowienia_Pracownicy_FK` FOREIGN KEY (`id_pracownika`) REFERENCES `pracownicy` (`id_pracownika`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table zamowienia
-- 

/*!40000 ALTER TABLE `zamowienia` DISABLE KEYS */;

/*!40000 ALTER TABLE `zamowienia` ENABLE KEYS */;

-- 
-- Definition of samochody_zamowienia
-- 

DROP TABLE IF EXISTS `samochody_zamowienia`;
CREATE TABLE IF NOT EXISTS `samochody_zamowienia` (
  `id_samochodu` int(11) NOT NULL,
  `id_zamowienia` int(11) NOT NULL,
  PRIMARY KEY (`id_samochodu`,`id_zamowienia`),
  KEY `FK_ASS_2` (`id_zamowienia`),
  CONSTRAINT `FK_ASS_1` FOREIGN KEY (`id_samochodu`) REFERENCES `samochody` (`id_samochodu`),
  CONSTRAINT `FK_ASS_2` FOREIGN KEY (`id_zamowienia`) REFERENCES `zamowienia` (`id_zamowienia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table samochody_zamowienia
-- 

/*!40000 ALTER TABLE `samochody_zamowienia` DISABLE KEYS */;

/*!40000 ALTER TABLE `samochody_zamowienia` ENABLE KEYS */;

-- 
-- Definition of zamowienia_uslugi
-- 

DROP TABLE IF EXISTS `zamowienia_uslugi`;
CREATE TABLE IF NOT EXISTS `zamowienia_uslugi` (
  `id_zamowienia` int(11) NOT NULL,
  `id_uslugi` int(11) NOT NULL,
  PRIMARY KEY (`id_zamowienia`,`id_uslugi`),
  KEY `FK_ASS_6` (`id_uslugi`),
  CONSTRAINT `FK_ASS_5` FOREIGN KEY (`id_zamowienia`) REFERENCES `zamowienia` (`id_zamowienia`),
  CONSTRAINT `FK_ASS_6` FOREIGN KEY (`id_uslugi`) REFERENCES `uslugi` (`id_uslugi`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- 
-- Dumping data for table zamowienia_uslugi
-- 

/*!40000 ALTER TABLE `zamowienia_uslugi` DISABLE KEYS */;

/*!40000 ALTER TABLE `zamowienia_uslugi` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2024-01-06 20:17:15
-- Total time: 0:0:0:0:809 (d:h:m:s:ms)
