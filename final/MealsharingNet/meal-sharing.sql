CREATE DATABASE  IF NOT EXISTS `heroku_6f51ccfaa614e26` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `heroku_6f51ccfaa614e26`;
-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: eu-cdbr-west-01.cleardb.com    Database: heroku_6f51ccfaa614e26
-- ------------------------------------------------------
-- Server version	5.6.50-log

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
-- Table structure for table `meals`
--

DROP TABLE IF EXISTS `meals`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `meals` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` text COLLATE utf8mb4_unicode_ci,
  `location` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `when` datetime DEFAULT NULL,
  `max_reservations` int(10) NOT NULL,
  `price` decimal(10,0) NOT NULL,
  `created_date` date NOT NULL,
  `img_link` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=345 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `meals`
--

LOCK TABLES `meals` WRITE;
/*!40000 ALTER TABLE `meals` DISABLE KEYS */;
INSERT INTO `meals` VALUES (1,'Yaprak Sarma','Delicious Turkish Food include Rice with grape leaf','Denmark',NULL,12,360,'2021-08-11','https://i4.hurimg.com/i/hurriyet/75/750x422/5b645cde66be5d25a0c1e13c.jpg'),(2,'Manti','Delicious Turkish Food include Mince','Denmark',NULL,12,400,'2021-08-11','https://turkishfoodie.com/wp-content/uploads/2018/07/Kayseri-Mant%C4%B1s%C4%B1.jpg'),(3,'Dolma','Delicious Turkish Food include Rice, Mince with pepper','Denmark',NULL,12,300,'2021-08-08','https://im.haberturk.com/2020/03/12/ver1584022582/2612045_810x458.jpg'),(4,'Pasta','Delicious homemade pasta with cheese','Denmark',NULL,8,240,'2021-08-05','https://i2.milimaj.com/i/milliyet/75/0x410/5f15bc8a55428412e03417c6.jpg'),(5,'Soup','Amazing tomato soup','Denmark',NULL,12,180,'2021-08-10','https://assets.tmecosys.com/image/upload/t_web600x528/img/recipe/ras/Assets/B8EF66BD-C565-430C-A945-D94DB606C818/Derivates/186F86D5-053E-4EB7-A1BF-3D22FC9D4F56.jpg'),(6,'Fish Fry','Fish fry with potato','Denmark',NULL,8,320,'2021-08-07','https://kfoods.com/images1/newrecipeicon/pomfret-fish-fry_3128.jpg'),(225,'Menemen','Delicious breakfast food with tomato, pepper, onion, egg','Soro / Denmark',NULL,8,200,'0000-00-00','https://i4.hurimg.com/i/hurriyet/75/750x422/5ba380a7c03c0e04b884fec1.jpg'),(265,'Butter Chicken','Delicious butter chicken with salad','Copenhagen / Denmark',NULL,10,400,'2021-10-13','https://img.taste.com.au/AbiWkcA0/taste/2016/11/easy-butter-chicken-74432-1.jpeg'),(315,'Dried onion burger','with dried onions and hot checken','København',NULL,25,124,'2021-10-21','https://media-cdn.tripadvisor.com/media/photo-m/1280/17/82/25/ea/n7-random-pleasure-ingrchicken.jpg');
/*!40000 ALTER TABLE `meals` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservations`
--

DROP TABLE IF EXISTS `reservations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservations` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `number_of_guests` int(10) NOT NULL,
  `meal_id` int(10) NOT NULL,
  `created_date` date NOT NULL,
  `contact_phonenumber` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `contact_name` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `contact_email` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_reservation_meal_meal` (`meal_id`),
  CONSTRAINT `fk_reservation_meal_meal` FOREIGN KEY (`meal_id`) REFERENCES `meals` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=123124 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservations`
--

LOCK TABLES `reservations` WRITE;
/*!40000 ALTER TABLE `reservations` DISABLE KEYS */;
INSERT INTO `reservations` VALUES (1,8,1,'2021-08-11','11 11 11 11','Semih','abc@mail.com'),(2,3,2,'2021-08-10','22 22 22 22','Yusuf','def@mail.com'),(3,12,3,'2021-08-08','33 33 33 33','Ayse','ghj@mail.com'),(4,6,4,'2021-08-12','55 55 55 55','John','zxc@mail.com'),(5,2,5,'2021-08-10','66 66 66 66','Angel','vbn@mail.com'),(6,7,6,'2021-08-11','77 77 77 77','Don','qwe@mail.com'),(105,10,5,'2021-10-16','12 12 12 12','John','johnsmail@mail.com'),(115,4,1,'2021-10-16','20685612','ррр','458@gmail.com'),(135,15,315,'2021-10-21','11112222','BIkram','bik@bik.com'),(145,3,2,'2021-10-26','43435532','sera','ser@gmailcom'),(155,0,1,'2021-12-07','','',''),(165,2,2,'2021-12-07','1234','Test','test@test.com'),(175,1,2,'2022-01-02','12 12 12 12','kjnn','test@test.test');
/*!40000 ALTER TABLE `reservations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reviews`
--

DROP TABLE IF EXISTS `reviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reviews` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `description` text COLLATE utf8mb4_unicode_ci,
  `meal_id` int(10) NOT NULL,
  `stars` int(10) NOT NULL,
  `created_date` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_review_meal_meal` (`meal_id`),
  CONSTRAINT `fk_review_meal_meal` FOREIGN KEY (`meal_id`) REFERENCES `meals` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=1111 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reviews`
--

LOCK TABLES `reviews` WRITE;
/*!40000 ALTER TABLE `reviews` DISABLE KEYS */;
INSERT INTO `reviews` VALUES (1,'Very Delicious','Best food of my life',1,5,'2021-08-11'),(2,'Amazing','Amazing Food',2,5,'2021-08-11'),(3,'Awesome','Awesome Food',4,5,'2021-08-12'),(4,'Really Bad','Bad taste and very salty',5,1,'2021-08-11'),(5,'Good','Normal Taste',6,3,'2021-08-11'),(6,'Amazing','Everyone need to eat this food',1,5,'2021-10-13'),(135,'Good','I like it',1,4,'2021-10-16'),(155,'Good','That was good',2,4,'2022-01-02');
/*!40000 ALTER TABLE `reviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Primary Key',
  `name` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1111 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'semih','semih@hotmail.com','5555555');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-03  2:36:13
