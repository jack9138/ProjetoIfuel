CREATE DATABASE  IF NOT EXISTS `ifuel` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `ifuel`;
-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ifuel
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `automovel`
--

DROP TABLE IF EXISTS `automovel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `automovel` (
  `Cod_auto` int NOT NULL AUTO_INCREMENT,
  `Nome_modelo` varchar(15) DEFAULT NULL,
  `consumo_auto` float(3,2) DEFAULT NULL,
  `Tipo_comb` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`Cod_auto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `automovel`
--

LOCK TABLES `automovel` WRITE;
/*!40000 ALTER TABLE `automovel` DISABLE KEYS */;
/*!40000 ALTER TABLE `automovel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `avaliacao`
--

DROP TABLE IF EXISTS `avaliacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `avaliacao` (
  `ID_AVALIACAO` int NOT NULL AUTO_INCREMENT,
  `DATA_AV` datetime DEFAULT NULL,
  `NOTA_AV` int DEFAULT NULL,
  `COMENT_AV` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID_AVALIACAO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `avaliacao`
--

LOCK TABLES `avaliacao` WRITE;
/*!40000 ALTER TABLE `avaliacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `avaliacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `ID_Cliente` int NOT NULL AUTO_INCREMENT,
  `Nome_Cliente` varchar(20) DEFAULT NULL,
  `Email_Cliente` varchar(15) DEFAULT NULL,
  `CPF` varchar(20) DEFAULT NULL,
  `Bairro` varchar(20) DEFAULT NULL,
  `CIDADE` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `combustivel`
--

DROP TABLE IF EXISTS `combustivel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `combustivel` (
  `Cod_Comb` int NOT NULL AUTO_INCREMENT,
  `Nome_Comb` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Cod_Comb`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `combustivel`
--

LOCK TABLES `combustivel` WRITE;
/*!40000 ALTER TABLE `combustivel` DISABLE KEYS */;
INSERT INTO `combustivel` VALUES (1,'Gasolina'),(2,'Diesel'),(3,'Etanol'),(4,'Gás natural');
/*!40000 ALTER TABLE `combustivel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `posto`
--

DROP TABLE IF EXISTS `posto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posto` (
  `ID_Posto` int NOT NULL AUTO_INCREMENT,
  `Nome_Posto` varchar(20) DEFAULT NULL,
  `CNPJ_POSTO` varchar(20) NOT NULL,
  `UF_POSTO` varchar(2) DEFAULT NULL,
  `Cidade_Posto` varchar(20) DEFAULT NULL,
  `Rua_Posto` varchar(20) DEFAULT NULL,
  `Bairro_Posto` varchar(20) DEFAULT NULL,
  `CEP_Posto` int DEFAULT NULL,
  `Combustivel1_Posto` int DEFAULT NULL,
  `Combustivel2_Posto` int DEFAULT NULL,
  `Combustivel3_Posto` int DEFAULT NULL,
  `Combustivel4_Posto` int DEFAULT NULL,
  `Combustivel5_Posto` int DEFAULT NULL,
  PRIMARY KEY (`ID_Posto`),
  KEY `Combustivel1_Posto` (`Combustivel1_Posto`),
  KEY `Combustivel2_Posto` (`Combustivel2_Posto`),
  KEY `Combustivel3_Posto` (`Combustivel3_Posto`),
  KEY `Combustivel4_Posto` (`Combustivel4_Posto`),
  KEY `Combustivel5_Posto` (`Combustivel5_Posto`),
  CONSTRAINT `posto_ibfk_1` FOREIGN KEY (`Combustivel1_Posto`) REFERENCES `combustivel` (`Cod_Comb`),
  CONSTRAINT `posto_ibfk_2` FOREIGN KEY (`Combustivel2_Posto`) REFERENCES `combustivel` (`Cod_Comb`),
  CONSTRAINT `posto_ibfk_3` FOREIGN KEY (`Combustivel3_Posto`) REFERENCES `combustivel` (`Cod_Comb`),
  CONSTRAINT `posto_ibfk_4` FOREIGN KEY (`Combustivel4_Posto`) REFERENCES `combustivel` (`Cod_Comb`),
  CONSTRAINT `posto_ibfk_5` FOREIGN KEY (`Combustivel5_Posto`) REFERENCES `combustivel` (`Cod_Comb`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posto`
--

LOCK TABLES `posto` WRITE;
/*!40000 ALTER TABLE `posto` DISABLE KEYS */;
/*!40000 ALTER TABLE `posto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `postosistema`
--

DROP TABLE IF EXISTS `postosistema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `postosistema` (
  `ID_USR` int DEFAULT NULL,
  `LOGIN_USR` varchar(25) DEFAULT NULL,
  `SENHA_USR` varchar(25) NOT NULL,
  KEY `ID_USR` (`ID_USR`),
  CONSTRAINT `postosistema_ibfk_1` FOREIGN KEY (`ID_USR`) REFERENCES `posto` (`ID_Posto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `postosistema`
--

LOCK TABLES `postosistema` WRITE;
/*!40000 ALTER TABLE `postosistema` DISABLE KEYS */;
/*!40000 ALTER TABLE `postosistema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usersistema`
--

DROP TABLE IF EXISTS `usersistema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usersistema` (
  `ID_USR` int DEFAULT NULL,
  `LOGIN_USR` varchar(25) DEFAULT NULL,
  `SENHA_USR` varchar(25) NOT NULL,
  KEY `ID_USR` (`ID_USR`),
  CONSTRAINT `usersistema_ibfk_1` FOREIGN KEY (`ID_USR`) REFERENCES `cliente` (`ID_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usersistema`
--

LOCK TABLES `usersistema` WRITE;
/*!40000 ALTER TABLE `usersistema` DISABLE KEYS */;
/*!40000 ALTER TABLE `usersistema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `valor`
--

DROP TABLE IF EXISTS `valor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `valor` (
  `ID_Valor` int NOT NULL AUTO_INCREMENT,
  `ID_Posto` int DEFAULT NULL,
  `Cod_comb` int DEFAULT NULL,
  `Data_Valor` datetime DEFAULT NULL,
  `Comb_Valor` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`ID_Valor`),
  KEY `Cod_comb` (`Cod_comb`),
  KEY `ID_Posto` (`ID_Posto`),
  CONSTRAINT `valor_ibfk_1` FOREIGN KEY (`Cod_comb`) REFERENCES `combustivel` (`Cod_Comb`),
  CONSTRAINT `valor_ibfk_2` FOREIGN KEY (`ID_Posto`) REFERENCES `posto` (`ID_Posto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `valor`
--

LOCK TABLES `valor` WRITE;
/*!40000 ALTER TABLE `valor` DISABLE KEYS */;
/*!40000 ALTER TABLE `valor` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-01-26 23:04:43
