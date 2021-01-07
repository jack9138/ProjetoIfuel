-- MariaDB dump 10.17  Distrib 10.4.11-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: ifuel
-- ------------------------------------------------------
-- Server version	10.4.11-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
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
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `automovel` (
  `Cod_auto` int(11) NOT NULL AUTO_INCREMENT,
  `Nome_modelo` varchar(15) DEFAULT NULL,
  `consumo_auto` float(3,2) DEFAULT NULL,
  `Tipo_comb` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`Cod_auto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
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
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `avaliacao` (
  `ID_AV` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Posto` int(11) DEFAULT NULL,
  `Nota_Posto` char(1) DEFAULT NULL,
  `Cod_Autor` int(11) DEFAULT NULL,
  `AV_Comentario` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ID_AV`),
  KEY `ID_Posto` (`ID_Posto`),
  KEY `Cod_Autor` (`Cod_Autor`),
  CONSTRAINT `avaliacao_ibfk_1` FOREIGN KEY (`ID_Posto`) REFERENCES `posto` (`ID_Posto`),
  CONSTRAINT `avaliacao_ibfk_2` FOREIGN KEY (`Cod_Autor`) REFERENCES `cliente` (`ID_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
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
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `ID_Cliente` int(11) NOT NULL AUTO_INCREMENT,
  `Nome_Cliente` varchar(20) DEFAULT NULL,
  `Email_Cliente` varchar(15) DEFAULT NULL,
  `Carro_cliente` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Cliente`),
  KEY `Carro_cliente` (`Carro_cliente`),
  CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`Carro_cliente`) REFERENCES `automovel` (`Cod_auto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
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
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `combustivel` (
  `Cod_comb` int(11) NOT NULL AUTO_INCREMENT,
  `Nome_comb` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`Cod_comb`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `combustivel`
--

LOCK TABLES `combustivel` WRITE;
/*!40000 ALTER TABLE `combustivel` DISABLE KEYS */;
/*!40000 ALTER TABLE `combustivel` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `posto`
--

DROP TABLE IF EXISTS `posto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `posto` (
  `ID_Posto` int(11) NOT NULL AUTO_INCREMENT,
  `Nome_Posto` varchar(20) DEFAULT NULL,
  `CNPJ_Posto` int(14) DEFAULT NULL,
  `UF_Posto` char(2) DEFAULT NULL,
  `Cidade_Posto` varchar(20) DEFAULT NULL,
  `Rua_Posto` varchar(20) DEFAULT NULL,
  `Bairro_Posto` varchar(20) DEFAULT NULL,
  `CEP_Posto` int(8) DEFAULT NULL,
  `Combustivel1_Posto` int(11) DEFAULT NULL,
  `Combustivel2_Posto` int(11) DEFAULT NULL,
  `Combustivel3_Posto` int(11) DEFAULT NULL,
  `Combustivel4_Posto` int(11) DEFAULT NULL,
  `Combustivel5_Posto` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID_Posto`),
  KEY `Combustivel1_Posto` (`Combustivel1_Posto`),
  KEY `Combustivel2_Posto` (`Combustivel2_Posto`),
  KEY `Combustivel3_Posto` (`Combustivel3_Posto`),
  KEY `Combustivel4_Posto` (`Combustivel4_Posto`),
  KEY `Combustivel5_Posto` (`Combustivel5_Posto`),
  CONSTRAINT `posto_ibfk_1` FOREIGN KEY (`Combustivel1_Posto`) REFERENCES `combustivel` (`Cod_comb`),
  CONSTRAINT `posto_ibfk_2` FOREIGN KEY (`Combustivel2_Posto`) REFERENCES `combustivel` (`Cod_comb`),
  CONSTRAINT `posto_ibfk_3` FOREIGN KEY (`Combustivel3_Posto`) REFERENCES `combustivel` (`Cod_comb`),
  CONSTRAINT `posto_ibfk_4` FOREIGN KEY (`Combustivel4_Posto`) REFERENCES `combustivel` (`Cod_comb`),
  CONSTRAINT `posto_ibfk_5` FOREIGN KEY (`Combustivel5_Posto`) REFERENCES `combustivel` (`Cod_comb`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posto`
--

LOCK TABLES `posto` WRITE;
/*!40000 ALTER TABLE `posto` DISABLE KEYS */;
/*!40000 ALTER TABLE `posto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usersistema`
--

DROP TABLE IF EXISTS `usersistema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usersistema` (
  `ID_USR` int(11) DEFAULT NULL,
  `LOGIN_USR` varchar(25) DEFAULT NULL,
  `SENHA_USR` varchar(25) NOT NULL,
  KEY `ID_USR` (`ID_USR`),
  CONSTRAINT `usersistema_ibfk_1` FOREIGN KEY (`ID_USR`) REFERENCES `cliente` (`ID_Cliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
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
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `valor` (
  `ID_Valor` int(11) NOT NULL AUTO_INCREMENT,
  `ID_Posto` int(11) DEFAULT NULL,
  `Cod_comb` int(11) DEFAULT NULL,
  `Data_Valor` datetime DEFAULT NULL,
  `Comb_Valor` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`ID_Valor`),
  KEY `Cod_comb` (`Cod_comb`),
  KEY `ID_Posto` (`ID_Posto`),
  CONSTRAINT `valor_ibfk_1` FOREIGN KEY (`Cod_comb`) REFERENCES `combustivel` (`Cod_comb`),
  CONSTRAINT `valor_ibfk_2` FOREIGN KEY (`ID_Posto`) REFERENCES `posto` (`ID_Posto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
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

-- Dump completed on 2021-01-06 21:09:27
