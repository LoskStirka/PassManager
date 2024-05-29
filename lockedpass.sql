CREATE DATABASE  IF NOT EXISTS `lockedpass` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `lockedpass`;
-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: lockedpass
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `passwords`
--

DROP TABLE IF EXISTS `passwords`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `passwords` (
  `idPass` int NOT NULL AUTO_INCREMENT,
  `name` varchar(35) NOT NULL,
  `login` varchar(25) NOT NULL,
  `password` varchar(50) NOT NULL,
  `url` varchar(100) DEFAULT NULL,
  `comment` varchar(50) DEFAULT NULL,
  `category` varchar(25) NOT NULL,
  PRIMARY KEY (`idPass`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `passwords`
--

LOCK TABLES `passwords` WRITE;
/*!40000 ALTER TABLE `passwords` DISABLE KEYS */;
INSERT INTO `passwords` VALUES (19,'Вконтакте','+7 902 738-14-54','321x123Q8Jasd','','Моя страница вк','Соц. Сеть'),(20,'ГосУслуги','snegoweek12@yandex.ru','12212321Sw!','https://gosuslugi.ru/','Никогда не заходи туда...','Форум'),(22,'Робукс','stinkysloth60','812393321','https://roblox.com','Рб аккаунт сестры','Аккаунт'),(23,'Фриланс','snegoweek12@yandex.ru','32171123','https://kwork.ru','','Форум'),(24,'Крипта','losk_stirka','123xdsa3218asd6!','https://okx.com/','','Другое'),(25,'Дневник','movchinnikova2206201','asdxbdsa321','','Дневник сестры','Форум'),(26,'Авито','+7 902 738-14-54','11231321asd','https://avito.ru/','','Сервис'),(27,'Музыка','losk-busyness@ya.ru','123719321asd!','https://band.link','Сайт с информацией о моих релизах','Сервис'),(28,'Дискорд','pokesnego@gmail.com','asd71237321!','','Мой дс','Сервис'),(29,'Запретограм','losk_stirka','123xkdsa21Qasdh6','https://instagram.com/accounts/login/','Мой инст','Соц. Сеть'),(30,'Телеграм','+7 902 738-14-54','123asd321dsa','https://web.telegram.org/k/','Мой тг','Мессенджер');
/*!40000 ALTER TABLE `passwords` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'lockedpass'
--

--
-- Dumping routines for database 'lockedpass'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-28 23:59:39
