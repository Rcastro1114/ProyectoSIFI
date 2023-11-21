-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: sifi
-- ------------------------------------------------------
-- Server version	5.7.41-log

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
-- Table structure for table `clasificaciones`
--

DROP TABLE IF EXISTS `clasificaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clasificaciones` (
  `idClasificaciones` int(11) NOT NULL AUTO_INCREMENT,
  `clasificacion` varchar(20) NOT NULL,
  PRIMARY KEY (`idClasificaciones`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clasificaciones`
--

LOCK TABLES `clasificaciones` WRITE;
/*!40000 ALTER TABLE `clasificaciones` DISABLE KEYS */;
INSERT INTO `clasificaciones` VALUES (1,'SISTEMA'),(2,'CLIENTES'),(3,'FACTURACIÓN');
/*!40000 ALTER TABLE `clasificaciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `idClientes` int(11) NOT NULL AUTO_INCREMENT,
  `Nombres` varchar(30) NOT NULL,
  `Apellidos` varchar(30) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Correo` varchar(30) DEFAULT NULL,
  `idDirecciones` int(11) NOT NULL,
  PRIMARY KEY (`idClientes`),
  KEY `fk_idDirecciones_idx` (`idDirecciones`),
  CONSTRAINT `fk_idDirecciones` FOREIGN KEY (`idDirecciones`) REFERENCES `direcciones` (`idDirecciones`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,'Pedro','Hernández','444','ph@gmail.com',1),(2,'Lucas','Hernández','2354-7890','lch@gmail.com',11);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compras`
--

DROP TABLE IF EXISTS `compras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compras` (
  `idCompras` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime NOT NULL,
  `idProveedores` int(11) NOT NULL,
  `idEmpleados` int(11) NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idCompras`),
  KEY `fk_idEmpleados_idx` (`idEmpleados`),
  KEY `fk_idProveedores_idx` (`idProveedores`),
  CONSTRAINT `fk_idEmpleados` FOREIGN KEY (`idEmpleados`) REFERENCES `empleados` (`idEmpleados`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_idProveedores` FOREIGN KEY (`idProveedores`) REFERENCES `proveedores` (`idProveedores`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compras`
--

LOCK TABLES `compras` WRITE;
/*!40000 ALTER TABLE `compras` DISABLE KEYS */;
INSERT INTO `compras` VALUES (1,'2023-06-08 02:29:20',1,1,75.50),(2,'2023-06-08 02:32:56',1,1,100.50),(3,'2023-06-08 02:55:26',1,1,160.00),(4,'2023-06-08 02:56:05',1,1,160.00),(5,'2023-06-08 03:04:58',1,1,10.00),(6,'2023-06-08 03:15:12',1,1,16.00),(7,'2023-06-12 12:11:15',1,1,10.60),(8,'2023-06-12 12:35:48',1,1,75.60),(9,'2023-06-12 15:03:44',1,1,1094.40),(10,'2023-06-12 18:45:17',1,1,302.60);
/*!40000 ALTER TABLE `compras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departamentos` (
  `idDepartamentos` int(11) NOT NULL AUTO_INCREMENT,
  `Departamentos` varchar(30) NOT NULL,
  PRIMARY KEY (`idDepartamentos`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamentos`
--

LOCK TABLES `departamentos` WRITE;
/*!40000 ALTER TABLE `departamentos` DISABLE KEYS */;
INSERT INTO `departamentos` VALUES (1,'Sonsonate'),(2,'Ahuachapán'),(3,'Cabañas'),(4,'Chalatenango'),(5,'Cuscatlán'),(6,'La Libertad'),(7,'La paz'),(8,'La Unión'),(9,'Morazán'),(10,'San Miguel'),(11,'San Salvador'),(12,'San Vicente'),(13,'Santa Ana'),(14,'Usulután');
/*!40000 ALTER TABLE `departamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallecompras`
--

DROP TABLE IF EXISTS `detallecompras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallecompras` (
  `idDetalleCompras` int(11) NOT NULL AUTO_INCREMENT,
  `idProductos` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `idCompras` int(11) NOT NULL,
  `PrecioCompra` decimal(5,2) NOT NULL,
  PRIMARY KEY (`idDetalleCompras`),
  KEY `fk_idProductos_idx` (`idProductos`),
  KEY `fk_idCompras_idx` (`idCompras`),
  CONSTRAINT `fk_idCompras` FOREIGN KEY (`idCompras`) REFERENCES `compras` (`idCompras`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_idProductos` FOREIGN KEY (`idProductos`) REFERENCES `productos` (`idProductos`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallecompras`
--

LOCK TABLES `detallecompras` WRITE;
/*!40000 ALTER TABLE `detallecompras` DISABLE KEYS */;
INSERT INTO `detallecompras` VALUES (1,3,500,1,5.50),(2,4,43,2,6.50),(3,5,43,5,4.50),(4,5,24,5,3.60),(5,6,80,6,4.50),(6,8,92,6,7.90),(7,7,80,7,3.50),(8,10,75,7,4.60),(9,13,75,7,2.50),(10,9,9,8,2.40),(11,14,12,8,4.50),(12,11,140,9,3.40),(13,75,80,9,4.50),(14,47,34,9,7.60),(15,12,89,10,3.40);
/*!40000 ALTER TABLE `detallecompras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalleventas`
--

DROP TABLE IF EXISTS `detalleventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalleventas` (
  `idDetalleVentas` int(11) NOT NULL AUTO_INCREMENT,
  `idVentas` int(11) NOT NULL,
  `idProductos` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `PrecioVenta` decimal(5,2) NOT NULL,
  `VentasNoSujetas` decimal(10,2) DEFAULT NULL,
  `VentasExentas` decimal(10,2) DEFAULT NULL,
  `SubTotal` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idDetalleVentas`),
  KEY `fk_idProductos_idx` (`idVentas`),
  KEY `fkidProductos_idx` (`idProductos`),
  CONSTRAINT `fkidProductos` FOREIGN KEY (`idProductos`) REFERENCES `productos` (`idProductos`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fkidVentas` FOREIGN KEY (`idVentas`) REFERENCES `ventas` (`idVentas`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=121 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalleventas`
--

LOCK TABLES `detalleventas` WRITE;
/*!40000 ALTER TABLE `detalleventas` DISABLE KEYS */;
INSERT INTO `detalleventas` VALUES (8,54,1,8,9.50,NULL,NULL,76.00),(9,55,1,9,9.50,NULL,NULL,85.50),(10,56,1,2,9.50,NULL,NULL,19.00),(11,56,1,2,9.50,NULL,NULL,19.00),(12,58,1,2,9.50,NULL,NULL,19.00),(13,58,1,2,9.50,NULL,NULL,19.00),(14,59,1,2,9.50,NULL,NULL,19.00),(15,60,1,2,9.50,NULL,NULL,19.00),(16,61,2,3,5.25,NULL,NULL,15.75),(17,65,1,2,9.50,NULL,NULL,19.00),(18,69,1,3,9.50,NULL,NULL,28.50),(19,70,1,2,9.50,NULL,NULL,19.00),(20,71,1,3,9.50,NULL,NULL,28.50),(21,72,1,4,9.50,NULL,NULL,38.00),(22,73,1,2,9.50,NULL,NULL,19.00),(23,74,1,5,9.50,NULL,NULL,47.50),(24,73,1,7,8.90,NULL,NULL,89.00),(25,75,1,2,9.50,NULL,NULL,19.00),(26,76,1,4,9.50,NULL,NULL,38.00),(27,76,1,4,9.50,NULL,NULL,38.00),(28,77,3,54,8.60,NULL,NULL,464.40),(29,78,1,23,9.50,NULL,NULL,218.50),(30,79,1,3,9.50,NULL,NULL,28.50),(31,80,1,8,9.50,NULL,NULL,76.00),(32,80,2,9,5.25,NULL,NULL,47.25),(33,80,5,6,0.80,NULL,NULL,4.80),(34,81,2,5,5.25,NULL,NULL,26.25),(35,81,1,8,9.50,NULL,NULL,76.00),(36,81,2,3,5.25,NULL,NULL,15.75),(37,82,1,8,9.50,NULL,NULL,76.00),(38,82,4,4,2.50,NULL,NULL,10.00),(39,82,8,5,8.00,NULL,NULL,40.00),(40,83,1,5,9.50,NULL,NULL,47.50),(41,83,5,8,0.80,NULL,NULL,6.40),(42,84,1,8,9.50,NULL,NULL,76.00),(43,84,8,5,8.00,NULL,NULL,40.00),(44,85,2,6,5.25,NULL,NULL,31.50),(45,85,2,4,5.25,NULL,NULL,21.00),(46,86,1,7,9.50,NULL,NULL,66.50),(47,86,3,5,8.60,NULL,NULL,43.00),(48,87,1,5,9.50,NULL,NULL,47.50),(49,87,4,8,2.50,NULL,NULL,20.00),(50,88,2,6,5.25,NULL,NULL,31.50),(51,88,6,9,0.90,NULL,NULL,8.10),(52,88,3,9,8.60,NULL,NULL,77.40),(53,88,8,7,8.00,NULL,NULL,56.00),(54,89,1,7,9.50,NULL,NULL,66.50),(55,89,7,5,1.00,NULL,NULL,5.00),(56,89,9,3,3.50,NULL,NULL,10.50),(57,89,13,7,3.00,NULL,NULL,21.00),(58,90,1,8,9.50,NULL,NULL,76.00),(59,90,3,6,8.60,NULL,NULL,51.60),(60,90,7,5,1.00,NULL,NULL,5.00),(61,91,2,4,5.25,NULL,NULL,21.00),(62,91,1,3,9.50,NULL,NULL,28.50),(63,92,1,3,9.50,NULL,NULL,28.50),(64,92,3,4,8.60,NULL,NULL,34.40),(65,93,1,3,9.50,NULL,NULL,28.50),(66,93,3,4,8.60,NULL,NULL,34.40),(67,94,3,8,8.60,NULL,NULL,68.80),(68,94,4,5,2.50,NULL,NULL,12.50),(69,94,7,3,1.00,NULL,NULL,3.00),(70,95,1,8,9.50,NULL,NULL,76.00),(71,96,1,7,9.50,NULL,NULL,66.50),(72,97,11,3,2.00,NULL,NULL,6.00),(73,98,1,8,9.50,NULL,NULL,76.00),(74,99,4,4,2.50,NULL,NULL,10.00),(75,99,7,3,1.00,NULL,NULL,3.00),(76,99,1,15,8.50,NULL,NULL,127.50),(77,100,9,1,3.50,NULL,NULL,3.50),(78,101,1,6,9.50,NULL,NULL,57.00),(79,101,7,3,1.00,NULL,NULL,3.00),(80,102,3,5,8.60,NULL,NULL,43.00),(81,103,1,5,9.50,NULL,NULL,47.50),(82,104,3,5,8.60,NULL,NULL,43.00),(83,105,3,3,8.60,NULL,NULL,25.80),(84,106,8,5,7.08,35.40,38.05,35.40),(85,106,3,5,7.61,35.40,38.05,38.05),(86,107,1,3,8.41,12.39,0.00,25.23),(87,107,11,7,1.77,12.39,0.00,12.39),(88,108,1,5,8.41,0.00,77.45,42.05),(89,108,8,5,7.08,0.00,77.45,35.40),(90,109,3,2,7.61,0.00,16.10,15.22),(91,109,14,2,0.44,0.00,16.10,0.88),(92,110,3,6,7.61,101.38,0.00,45.66),(93,110,10,7,7.96,101.38,0.00,55.72),(94,111,11,5,2.00,0.00,0.00,10.00),(95,111,47,4,2.70,0.00,0.00,10.80),(96,111,2,5,5.25,0.00,0.00,26.25),(97,112,2,1,5.25,0.00,0.00,5.25),(98,114,1,2,9.50,0.00,0.00,19.00),(99,115,11,2,2.00,0.00,0.00,4.00),(100,116,3,4,8.60,0.00,0.00,34.40),(101,117,10,3,9.00,0.00,0.00,27.00),(102,117,1,3,9.50,0.00,0.00,28.50),(103,117,10,3,9.00,0.00,0.00,27.00),(104,118,11,3,2.00,0.00,0.00,6.00),(105,119,6,4,0.90,0.00,0.00,3.60),(106,120,7,2,1.00,0.00,0.00,2.00),(107,120,11,2,2.00,0.00,0.00,4.00),(108,121,47,2,2.70,0.00,0.00,5.40),(109,122,11,2,2.00,0.00,0.00,4.00),(110,124,7,1,1.00,0.00,0.00,1.00),(111,124,11,1,2.00,0.00,0.00,2.00),(112,125,11,1,2.00,0.00,0.00,2.00),(113,126,1,1,9.50,0.00,0.00,9.50),(114,127,3,1,8.60,0.00,0.00,8.60),(115,128,11,1,2.00,0.00,0.00,2.00),(116,129,11,1,2.00,0.00,0.00,2.00),(117,130,6,1,0.90,0.00,0.00,0.90),(118,131,8,1,8.00,0.00,0.00,8.00),(119,131,14,1,0.50,0.00,0.00,0.50),(120,132,12,2,3.00,0.00,0.00,6.00);
/*!40000 ALTER TABLE `detalleventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direcciones`
--

DROP TABLE IF EXISTS `direcciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `direcciones` (
  `idDirecciones` int(11) NOT NULL AUTO_INCREMENT,
  `Residencia` varchar(90) NOT NULL,
  `Canton` varchar(90) DEFAULT NULL,
  `Cacerio` varchar(90) DEFAULT NULL,
  `idMunicipios` int(11) NOT NULL,
  PRIMARY KEY (`idDirecciones`),
  KEY `direcciones_ibfk_1` (`idMunicipios`),
  CONSTRAINT `direcciones_ibfk_1` FOREIGN KEY (`idMunicipios`) REFERENCES `municipios` (`idMunicipios`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direcciones`
--

LOCK TABLES `direcciones` WRITE;
/*!40000 ALTER TABLE `direcciones` DISABLE KEYS */;
INSERT INTO `direcciones` VALUES (1,'Col. Santa Eugenia de los Altos',NULL,NULL,1),(2,'Col. Belén',NULL,NULL,3),(3,'Col. 14 de Diciembre',NULL,NULL,2),(4,'Col. Sensunapan','','',2),(5,'Col. San Genaro','','',2),(6,'Col. El Balsamar','','',2),(7,'Col. Santa Marta','','',1),(8,'Col. Sedan','','',1),(9,'Col. San Antonio','','',2),(10,'Col. 5 de diciembre','','',1),(11,'Col. Zedan block 15','','',1),(12,'Col. Sensunapan pasaje 7 block 3',NULL,NULL,2);
/*!40000 ALTER TABLE `direcciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleados`
--

DROP TABLE IF EXISTS `empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empleados` (
  `idEmpleados` int(11) NOT NULL AUTO_INCREMENT,
  `Nombres` varchar(30) NOT NULL,
  `Apellidos` varchar(30) NOT NULL,
  `DUI` varchar(10) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Correo` varchar(30) DEFAULT NULL,
  `idDirecciones` int(11) NOT NULL,
  PRIMARY KEY (`idEmpleados`),
  KEY `fk_idDirecciones_idx` (`idDirecciones`),
  CONSTRAINT `fk2_idDirecciones` FOREIGN KEY (`idDirecciones`) REFERENCES `direcciones` (`idDirecciones`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleados`
--

LOCK TABLES `empleados` WRITE;
/*!40000 ALTER TABLE `empleados` DISABLE KEYS */;
INSERT INTO `empleados` VALUES (1,'RAFAEL ANTONIO','CASTRO PINEDA','06029116-6','7664-5547','rcastropineda@gmail.com',1),(2,'CARMEN MARISOL','ALAS CÁCERES','06031998-1','8765-5423','cmarisol21@gmail.com',2),(4,'Andreas','Cristensen','321234','4444','ancr@gmail.com',8),(5,'Andres','Jaco','32435','22222','Aj@gmail.com',9),(6,'pedro','Castro','2121','31231','pc@gmail.com',10),(7,'REBECA ESMERALDA','PÉREZ HERNÁNDEZ','09128734-4','5543-2345','rbph@gmail.com',12);
/*!40000 ALTER TABLE `empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formasdepagos`
--

DROP TABLE IF EXISTS `formasdepagos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `formasdepagos` (
  `idFormasdePagos` int(11) NOT NULL AUTO_INCREMENT,
  `FormadePago` varchar(35) NOT NULL,
  PRIMARY KEY (`idFormasdePagos`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formasdepagos`
--

LOCK TABLES `formasdepagos` WRITE;
/*!40000 ALTER TABLE `formasdepagos` DISABLE KEYS */;
INSERT INTO `formasdepagos` VALUES (1,'Transferencia bancaria'),(2,'Efectivo'),(3,'Cheque emitido');
/*!40000 ALTER TABLE `formasdepagos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `movimientos`
--

DROP TABLE IF EXISTS `movimientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimientos` (
  `idMovimientos` int(11) NOT NULL AUTO_INCREMENT,
  `idProductos` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `TipodeMovimiento` enum('Entrada','Salida') NOT NULL,
  `Saldo` int(11) NOT NULL,
  PRIMARY KEY (`idMovimientos`),
  KEY `movimientos_ibfk_1` (`idProductos`),
  CONSTRAINT `movimientos_ibfk_1` FOREIGN KEY (`idProductos`) REFERENCES `productos` (`idProductos`)
) ENGINE=InnoDB AUTO_INCREMENT=139 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimientos`
--

LOCK TABLES `movimientos` WRITE;
/*!40000 ALTER TABLE `movimientos` DISABLE KEYS */;
INSERT INTO `movimientos` VALUES (1,1,300,'2023-05-31','Entrada',300),(2,2,75,'2023-06-04','Entrada',75),(3,1,4,'2023-06-04','Salida',296),(4,1,4,'2023-06-04','Salida',292),(5,1,5,'2023-06-04','Salida',287),(6,1,5,'2023-06-04','Salida',282),(7,1,3,'2023-06-04','Salida',279),(8,1,3,'2023-06-04','Salida',276),(9,1,4,'2023-06-05','Salida',272),(10,1,4,'2023-06-05','Salida',268),(11,1,8,'2023-06-06','Salida',260),(12,1,9,'2023-06-07','Salida',251),(13,1,2,'2023-06-07','Salida',249),(14,1,2,'2023-06-07','Salida',247),(15,1,2,'2023-06-07','Salida',245),(16,1,2,'2023-06-07','Salida',243),(17,1,2,'2023-06-07','Salida',241),(18,1,2,'2023-06-07','Salida',239),(19,2,3,'2023-06-07','Salida',72),(20,1,2,'2023-06-07','Salida',237),(21,1,3,'2023-06-07','Salida',234),(22,1,2,'2023-06-07','Salida',232),(23,1,3,'2023-06-07','Salida',229),(24,1,4,'2023-06-07','Salida',225),(25,1,2,'2023-06-07','Salida',223),(26,1,5,'2023-06-07','Salida',218),(27,1,7,'2023-06-07','Salida',211),(28,1,2,'2023-06-07','Salida',209),(29,1,4,'2023-06-07','Salida',205),(30,1,4,'2023-06-07','Salida',201),(32,4,43,'2023-06-08','Entrada',43),(33,5,43,'2023-06-08','Entrada',43),(34,5,24,'2023-06-08','Entrada',67),(35,6,80,'2023-06-08','Entrada',80),(36,8,92,'2023-06-08','Entrada',92),(37,3,54,'2023-06-08','Salida',446),(38,1,23,'2023-06-08','Salida',178),(39,1,3,'2023-06-08','Salida',175),(40,1,8,'2023-06-08','Salida',167),(41,2,9,'2023-06-08','Salida',63),(42,5,6,'2023-06-08','Salida',61),(43,2,5,'2023-06-08','Salida',58),(44,1,8,'2023-06-08','Salida',159),(45,2,3,'2023-06-08','Salida',55),(46,1,8,'2023-06-10','Salida',151),(47,4,4,'2023-06-10','Salida',39),(48,8,5,'2023-06-10','Salida',87),(49,1,5,'2023-06-11','Salida',146),(50,5,8,'2023-06-11','Salida',53),(51,1,8,'2023-06-11','Salida',138),(52,8,5,'2023-06-11','Salida',82),(53,2,6,'2023-06-11','Salida',49),(54,2,4,'2023-06-11','Salida',45),(55,1,7,'2023-06-11','Salida',131),(56,3,5,'2023-06-11','Salida',441),(57,1,5,'2023-06-11','Salida',126),(58,4,8,'2023-06-11','Salida',31),(59,2,6,'2023-06-12','Salida',39),(60,6,9,'2023-06-12','Salida',71),(61,3,9,'2023-06-12','Salida',432),(62,8,7,'2023-06-12','Salida',75),(63,7,80,'2023-06-12','Entrada',80),(64,10,75,'2023-06-12','Entrada',75),(65,13,75,'2023-06-12','Entrada',75),(66,9,9,'2023-06-12','Entrada',9),(67,14,12,'2023-06-12','Entrada',12),(68,1,7,'2023-06-12','Salida',119),(69,7,5,'2023-06-12','Salida',75),(70,9,3,'2023-06-12','Salida',6),(71,13,7,'2023-06-12','Salida',68),(72,11,140,'2023-06-12','Entrada',140),(73,75,80,'2023-06-12','Entrada',80),(74,47,34,'2023-06-12','Entrada',34),(75,1,8,'2023-06-12','Salida',111),(76,3,6,'2023-06-12','Salida',426),(77,7,5,'2023-06-12','Salida',70),(78,2,4,'2023-06-12','Salida',35),(79,1,3,'2023-06-12','Salida',108),(80,1,3,'2023-06-12','Salida',105),(81,3,4,'2023-06-12','Salida',422),(82,1,3,'2023-06-12','Salida',102),(83,3,4,'2023-06-12','Salida',418),(84,12,89,'2023-06-12','Entrada',89),(85,3,8,'2023-06-13','Salida',410),(86,4,5,'2023-06-13','Salida',26),(87,7,3,'2023-06-13','Salida',67),(88,1,8,'2023-06-13','Salida',94),(89,1,7,'2023-10-23','Salida',87),(90,11,3,'2023-11-07','Salida',137),(91,1,8,'2023-11-08','Salida',79),(92,4,4,'2023-11-13','Salida',22),(93,7,3,'2023-11-13','Salida',64),(94,1,15,'2023-11-13','Salida',64),(95,9,1,'2023-11-13','Salida',5),(96,1,6,'2023-11-15','Salida',58),(97,7,3,'2023-11-15','Salida',61),(98,3,5,'2023-11-15','Salida',405),(99,1,5,'2023-11-15','Salida',53),(100,3,5,'2023-11-16','Salida',400),(101,3,3,'2023-11-16','Salida',397),(102,8,5,'2023-11-19','Salida',70),(103,3,5,'2023-11-19','Salida',392),(104,1,3,'2023-11-19','Salida',50),(105,11,7,'2023-11-19','Salida',130),(106,1,5,'2023-11-19','Salida',45),(107,8,5,'2023-11-19','Salida',65),(108,3,2,'2023-11-19','Salida',390),(109,14,2,'2023-11-19','Salida',10),(110,3,6,'2023-11-19','Salida',384),(111,10,7,'2023-11-19','Salida',68),(112,11,5,'2023-11-19','Salida',125),(113,47,4,'2023-11-19','Salida',30),(114,2,5,'2023-11-19','Salida',30),(115,2,1,'2023-11-19','Salida',29),(116,1,2,'2023-11-19','Salida',43),(117,11,2,'2023-11-19','Salida',123),(118,3,4,'2023-11-19','Salida',380),(119,10,3,'2023-11-19','Salida',65),(120,1,3,'2023-11-19','Salida',40),(121,10,3,'2023-11-19','Salida',62),(122,11,3,'2023-11-19','Salida',120),(123,6,4,'2023-11-19','Salida',67),(124,7,2,'2023-11-19','Salida',59),(125,11,2,'2023-11-19','Salida',118),(126,47,2,'2023-11-19','Salida',28),(127,11,2,'2023-11-20','Salida',116),(128,7,1,'2023-11-20','Salida',58),(129,11,1,'2023-11-20','Salida',115),(130,11,1,'2023-11-20','Salida',114),(131,1,1,'2023-11-20','Salida',39),(132,3,1,'2023-11-20','Salida',379),(133,11,1,'2023-11-20','Salida',113),(134,11,1,'2023-11-20','Salida',112),(135,6,1,'2023-11-20','Salida',66),(136,8,1,'2023-11-20','Salida',64),(137,14,1,'2023-11-20','Salida',9),(138,12,2,'2023-11-20','Salida',87);
/*!40000 ALTER TABLE `movimientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `municipios`
--

DROP TABLE IF EXISTS `municipios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `municipios` (
  `idMunicipios` int(11) NOT NULL AUTO_INCREMENT,
  `municipios` varchar(40) NOT NULL,
  `idDepartamentos` int(11) NOT NULL,
  PRIMARY KEY (`idMunicipios`),
  KEY `fk_idDepartamentos_idx` (`idDepartamentos`),
  CONSTRAINT `fk_idDepartamentos` FOREIGN KEY (`idDepartamentos`) REFERENCES `departamentos` (`idDepartamentos`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=263 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `municipios`
--

LOCK TABLES `municipios` WRITE;
/*!40000 ALTER TABLE `municipios` DISABLE KEYS */;
INSERT INTO `municipios` VALUES (1,'Sonzacate',1),(2,'Sonsonate',1),(3,'Acajutla',1),(4,'Armenia',1),(5,'Caluco',1),(6,'Cuisnahuat',1),(7,'Izalco',1),(8,'Juayúa',1),(9,'Nahuizalco',1),(10,'Nahulingo',1),(11,'Salcoatitán',1),(12,'San Antonio del Monte',1),(13,'San Julián',1),(14,'Santa Catarina Masahuat',1),(15,'Santa Isabel Ishuatán',1),(16,'Santo Domingo de Guzmán',1),(17,'Ahuachapán',2),(18,'Apaneca',2),(19,'Atiquizaya',2),(20,'Concepción de Ataco',2),(21,'El Refugio',2),(22,'Guaymango',2),(23,'Jujutla',2),(24,'San Francisco Menéndez',2),(25,'San Lorenzo',2),(26,'San Pedro Puxtla',2),(27,'Tacuba',2),(28,'Turín',2),(29,'Sensuntepeque',3),(30,'Cinquera',3),(31,'Dolores',3),(32,'Guacotecti',3),(33,'Ilobasco',3),(34,'Jutiapa',3),(35,'San Isidro',3),(36,'Tejutepeque',3),(37,'Victoria',3),(38,'Chalatenango',4),(39,'Agua Caliente',4),(40,'Arcatao',4),(41,'Azacualpa',4),(42,'Cancasque',4),(43,'Citalá',4),(44,'Comalapa',4),(45,'Cocepción Quezaltepeque',4),(46,'Dulce Nombre de María',4),(47,'El Carrizal',4),(48,'El Paraíso',4),(49,'La Laguna',4),(50,'La Palma',4),(51,'La Reina',4),(52,'Las Flores',4),(53,'Las Vueltas',4),(54,'Nombre de Jesús',4),(55,'Nueva Concepción',4),(56,'Nueva Trinidad',4),(57,'Ojos de Agua',4),(58,'Potonico',4),(59,'San Antonio de la Cruz',4),(60,'San Antonio Los Ranchos',4),(61,'San Fernando',4),(62,'San Francisco Lempa',4),(63,'San Francisco Morazán',4),(64,'San Ignacio',4),(65,'San Isidro Labrador',4),(66,'San Luis del Carmen',4),(67,'San Miguel de Mercedes',4),(68,'San Rafael',4),(69,'Santa Rita',4),(70,'Tejutla',4),(71,'Cojutepeque',5),(72,'Candelaria',5),(73,'El Carmen',5),(74,'El Rosario',5),(75,'Monte San Juan',5),(76,'Oratorio de Concepción',5),(77,'San Bartolomé Perulapía',5),(78,'San Cristóbal',5),(79,'San José Guayabal',5),(80,'San Pedro Perulapán',5),(81,'San Rafael Cedros',5),(82,'San Ramón',5),(83,'Santa Cruz Analquito',5),(84,'Santa Cruz Michapa',5),(85,'Suchitoto',5),(86,'Tenancingo',5),(87,'Santa Tecla',6),(88,'Antiguo Cuscatlán',6),(89,'Chitiupán',6),(90,'Ciudad Arce',6),(91,'Colón',6),(92,'Comasagua',6),(93,'Huizúcar',6),(94,'Jayaque',6),(95,'Jicalapa',6),(96,'La Libertad',6),(97,'Nuevo Cuscatlán',6),(98,'Quezaltepeque',6),(99,'San Juan Opico',6),(100,'Sacacoyo',6),(101,'San José Villanueva',6),(102,'San Matías',6),(103,'San Pablo Tacachico',6),(104,'Talnique',6),(105,'Tamanique',6),(106,'Teotepeque',6),(107,'Tepecoyo',6),(108,'Zaragoza',6),(109,'Zacatecoluca',7),(110,'Cuyultitán',7),(111,'El Rosario',7),(112,'Jerusalén',7),(113,'Mercedes la Ceiba',7),(114,'Olocuilta',7),(115,'Paraíso de Osorio',7),(116,'San Antonio Masahuat',7),(117,'San Emigdio',7),(118,'San Francisco Chinameca',7),(119,'San Pedro Masahuat',7),(120,'San Juan Nonualco',7),(121,'San Juan Talpa',7),(122,'San Juan Tepezontes',7),(123,'San Luis La Herradura',7),(124,'San Luis Talpa',7),(125,'San Miguel Tepezontes',7),(126,'San Pedro Nonualco',7),(127,'San Rafael Obrajuelo',7),(128,'Santa María Ostuma',7),(129,'Santiago Nonualco',7),(130,'Tapalhuaca',7),(131,'La Unión',8),(132,'Anamorós',8),(133,'Bolívar',8),(134,'Concepción de Oriente',8),(135,'Conchagua',8),(136,'El Carmen',8),(137,'El Sauce',8),(138,'Intipucá',8),(139,'Lislique',8),(140,'Meanguera del Golfo',8),(141,'Nueva Esparta',8),(142,'Pasaquina',8),(143,'Polorós',8),(144,'San Alejo',8),(145,'San José',8),(146,'Santa Rosa de Lima',8),(147,'Yayantique',8),(148,'Yucuaiquín',8),(149,'San Francisco Gotera',9),(150,'Arambala',9),(151,'Cacaopera',9),(152,'Chilanga',9),(153,'Corinto',9),(154,'Delicias de Concepción',9),(155,'El Divisadero',9),(156,'El Rosario',9),(157,'Gualococti',9),(158,'Guatajiagua',9),(159,'Joateca',9),(160,'Jocoaitique',9),(161,'Jocoro',9),(162,'Lolotiquillo',9),(163,'Meanguera',9),(164,'Osicala',9),(165,'Perquín',9),(166,'San Carlos',9),(167,'San Fernando',9),(168,'San Isidro',9),(169,'San Simón',9),(170,'Sensembra',9),(171,'Sociedad',9),(172,'Torola',9),(173,'Yamabal',9),(174,'Yoloaiquín',9),(175,'San Miguel',10),(176,'Carolina',10),(177,'Chapeltique',10),(178,'Chinameca',10),(179,'Chirilagua',10),(180,'Ciudad Barrios',10),(181,'Comacarán',10),(182,'El Trásito',10),(183,'Lolotique',10),(184,'Moncagua',10),(185,'Nueva Guadalupe',10),(186,'Nuevo Edén de San Juan',10),(187,'Quelepa',10),(188,'San Antonio',10),(189,'San Gerardo',10),(190,'San Jorge',10),(191,'San Luis de la Reina',10),(192,'San Rafael Oriente',10),(193,'Sesori',10),(194,'Uluazapa',10),(195,'San Salvador',11),(196,'Aguilares',11),(197,'Apopa',11),(198,'Ayutuxtepeque',11),(199,'Ciudad Delgado',11),(200,'Cuscatancingo',11),(201,'El Paisnal',11),(202,'Guazapa',11),(203,'Ilopango',11),(204,'Mejicanos',11),(205,'Nejapa',11),(206,'Panchimalco',11),(207,'Rosario de Mora',11),(208,'San Marcos',11),(209,'San Martín',11),(210,'Santiago Texacuangos',11),(211,'Santo Tomás',11),(212,'Soyapango',11),(213,'Tonacatepeque',11),(214,'San Vicente',12),(215,'Apastepeque',12),(216,'Guadalupe',12),(217,'San Cayetano Istepeque',12),(218,'San Esteban Catarina',12),(219,'San Ildefonso',12),(220,'San Lorenzo',12),(221,'San Sebastián',12),(222,'Santa Clara',12),(223,'Santo Domingo',12),(224,'Tecoluca',12),(225,'Tepetitán',12),(226,'Verapaz',12),(227,'Santa Ana',13),(228,'Candelaria de la Frontera',13),(229,'Chalchuapa',13),(230,'Coatepeque',13),(231,'El Congo',13),(232,'El Porvenir',13),(233,'Masahuat',13),(234,'Metapán',13),(235,'San Antonio Pajonal',13),(236,'San Sebastián Salitrillo',13),(237,'Santa Rosa Guachipilín',13),(238,'Santiago de la Frontera',13),(239,'Texistepeque',13),(240,'Usulután',14),(241,'Alegría',14),(242,'Berlin',14),(243,'California',14),(244,'Concepción Batres',14),(245,'El Triunfo',14),(246,'Ereguayquín',14),(247,'Estanzuelas',14),(248,'Jiquilisco',14),(249,'Jucuapa',14),(250,'Juacuarán',14),(251,'Mercedes Umaña',14),(252,'Nueva Granada',14),(253,'Ozatlán',14),(254,'Puerto El Triunfo',14),(255,'San Agustín',14),(256,'San Buenaventura',14),(257,'San Dionisio',14),(258,'San Francisco Javier',14),(259,'Santa Elena',14),(260,'Santa María',14),(261,'Santiago de María',14),(262,'Tecapán',14);
/*!40000 ALTER TABLE `municipios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `opciones`
--

DROP TABLE IF EXISTS `opciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `opciones` (
  `idOpciones` int(11) NOT NULL AUTO_INCREMENT,
  `Opciones` varchar(30) NOT NULL,
  `idClasificaciones` int(11) NOT NULL,
  PRIMARY KEY (`idOpciones`),
  KEY `opciones_ibfk_1` (`idClasificaciones`),
  CONSTRAINT `opciones_ibfk_1` FOREIGN KEY (`idClasificaciones`) REFERENCES `clasificaciones` (`idClasificaciones`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opciones`
--

LOCK TABLES `opciones` WRITE;
/*!40000 ALTER TABLE `opciones` DISABLE KEYS */;
INSERT INTO `opciones` VALUES (1,'General',1),(2,'Ventas',1),(3,'Compras',1),(4,'Kardex',1),(5,'Clientes',2),(6,'Stock',1);
/*!40000 ALTER TABLE `opciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `permisos` (
  `idPermisos` int(11) NOT NULL AUTO_INCREMENT,
  `idRoles` int(11) NOT NULL,
  `idOpciones` int(11) NOT NULL,
  PRIMARY KEY (`idPermisos`),
  KEY `permisos_ibfk_1` (`idRoles`),
  KEY `permisos_ibfk_2` (`idOpciones`),
  CONSTRAINT `permisos_ibfk_1` FOREIGN KEY (`idRoles`) REFERENCES `roles` (`idRoles`),
  CONSTRAINT `permisos_ibfk_2` FOREIGN KEY (`idOpciones`) REFERENCES `opciones` (`idOpciones`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
INSERT INTO `permisos` VALUES (1,1,1),(2,1,2),(3,1,3),(4,1,4),(5,2,2),(6,2,5),(7,2,6);
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productos`
--

DROP TABLE IF EXISTS `productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productos` (
  `idProductos` int(11) NOT NULL AUTO_INCREMENT,
  `Productos` varchar(60) NOT NULL,
  `PrecioUnitario` decimal(4,2) NOT NULL,
  `Marca` varchar(25) NOT NULL,
  `Stock` int(11) NOT NULL,
  PRIMARY KEY (`idProductos`)
) ENGINE=InnoDB AUTO_INCREMENT=105 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productos`
--

LOCK TABLES `productos` WRITE;
/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos` VALUES (1,'Bolsa de cemento Cessa',9.50,'Holcim',39),(2,'Cinta metrica',5.25,'Truper',29),(3,'Bolsa de cemento Cuscatlan',8.60,'Holcim',379),(4,'Pegamento PVC',2.50,'Durman',22),(5,'Brocha',0.80,'Truper',53),(6,'Brocha',0.90,'Truper',66),(7,'Brocha',1.00,'Truper',58),(8,'Bolsa de PowerMix',8.00,'Reflex',64),(9,'Tubo PVC 1/2\"',3.50,'Amanco',5),(10,'Galon Pintura',9.00,'Megacolor',62),(11,'Spray',2.00,'ABRO',112),(12,'Llave P/piso',3.00,'Foset',87),(13,'Llave P/piso',3.00,'Foset',68),(14,'Libra clavo 1\"',0.50,'Fiero',9),(15,'Libra clavo 2\"',0.50,'Fiero',0),(16,'Libra clavo 3\"',0.50,'Fiero',0),(17,'Libra clavo 4\"',0.50,'Fiero',0),(18,'QQ Hierro 1/4\"',35.00,'Corinca',0),(19,'QQ Hierro 3/8\"',35.00,'Corinca',0),(20,'Tornillo',0.15,'Truper',0),(21,'Tornillos 6-32 x 1/2\"',0.15,'Ciser',0),(22,'Tornillos 8-32 x 3/4\"',0.30,'Ciser',0),(23,'Tornillos 10-32 x 1\"',0.50,'Ciser',0),(24,'Tornillos 6-32 x 3/4\"',0.30,'Romasa',0),(25,'Tornillos 8-32 x 1\"',0.35,'Romasa',0),(26,'Tornillos 10-32 x 1 1/4\"',0.85,'Romasa',0),(27,'Tornillos 6 x 1\"',0.25,'Martek.',0),(28,'Tornillos 8 x 1 1/4\"',0.50,'Martek.',0),(29,'Tornillos 10 x 2\"',0.65,'Martek.',0),(30,'Tornillos 3/16\" x 1 1/4\"',0.40,'Tornikasa',0),(31,'Tornillos 1/4\" x 2 1/4\"',0.65,'Tornikasa',0),(32,'Tornillos 3/8\" x 3\"',0.75,'Tornikasa',0),(33,'Codo PVC 90 grados 1/2\"',0.30,'Amanco',0),(34,'Codo PVC 90 grados 3/4\"',0.45,'Amanco',0),(35,'Codo PVC 90 grados 1\"',0.90,'Amanco',0),(36,'Codo PVC 90 grados 1 1/4\"',1.30,'Amanco',0),(37,'Codo PVC 90 grados 1 1/2\"',1.90,'Amanco',0),(38,'Codo PVC 90 grados 2\"',2.50,'Amanco',0),(39,'Codo PVC 90 grados 3\"',2.75,'Amanco',0),(40,'Codo PVC 90 grados 4\"',3.80,'Amanco',0),(41,'Codo PVC 90 grados 6\"',4.25,'Amanco',0),(42,'Codo PVC 45 grados 1/2\"',0.35,'Amanco',0),(43,'Codo PVC 45 grados 3/4\"',0.50,'Amanco',0),(44,'Codo PVC 45 grados 1\"',1.00,'Amanco',0),(45,'Codo PVC 45 grados 1 1/4\"',1.30,'Amanco',0),(46,'Codo PVC 45 grados 1 1/2\"',1.90,'Amanco',0),(47,'Codo PVC 45 grados 2\"',2.70,'Amanco',28),(48,'Codo PVC 45 grados 3\"',2.80,'Amanco',0),(49,'Codo PVC 45 grados 4\"',3.90,'Amanco',0),(50,'Codo PVC 45 grados 6\"',4.50,'Amanco',0),(51,'Codo PVC 90 c/r grados 1/2\"',0.35,'Amanco',0),(52,'Codo PVC 90 c/r grados 3/4\"',0.55,'Amanco',0),(53,'Codo PVC 90 c/r grados 1\"',0.95,'Amanco',0),(54,'Codo PVC 90 c/r grados 1 1/4\"',1.50,'Amanco',0),(55,'Codo PVC 90 c/r grados 1 1/2\"',2.00,'Amanco',0),(56,'Codo PVC 90 c/r grados 2\"',2.60,'Amanco',0),(57,'Codo PVC 90 c/r grados 3\"',2.80,'Amanco',0),(58,'Codo PVC 90 c/r grados 4\"',3.90,'Amanco',0),(59,'Codo PVC 90 c/r grados 6\"',4.50,'Amanco',0),(60,'Codo PVC 45 c/r grados 1/2\"',0.35,'Amanco',0),(61,'Codo PVC 45 c/r grados 3/4\"',0.55,'Amanco',0),(62,'Codo PVC 45 c/r grados 1\"',1.50,'Amanco',0),(63,'Codo PVC 45 c/r grados 1 1/4\"',1.60,'Amanco',0),(64,'Codo PVC 45 c/r grados 1 1/2\"',1.95,'Amanco',0),(65,'Codo PVC 45 c/r grados 2\"',2.80,'Amanco',0),(66,'Codo PVC 45 c/r grados 3\"',3.30,'Amanco',0),(67,'Codo PVC 45 c/r grados 4\"',4.00,'Amanco',0),(68,'Codo PVC 45 c/r grados 6\"',5.00,'Amanco',0),(69,'Unión PVC de 1/2\"',0.35,'Amanco',0),(70,'Unión PVC de 3/4\"',0.50,'Amanco',0),(71,'Unión PVC de 1\"',1.00,'Amanco',0),(72,'Unión PVC de 1 1/4\"',1.30,'Amanco',0),(73,'Unión PVC de 1 1/2\"',1.90,'Amanco',0),(74,'Unión PVC de  2\"',2.70,'Amanco',0),(75,'Unión PVC de  3\"',2.80,'Amanco',80),(76,'Unión PVC de  4\"',3.90,'Amanco',0),(77,'Unión PVC de 6\"',4.50,'Amanco',0),(78,'Unión PVC c/r de 1/2\"',0.45,'Amanco',0),(79,'Unión PVC c/r de 3/4\"',0.55,'Amanco',0),(80,'Unión PVC c/r de 1\"',1.25,'Amanco',0),(81,'Unión PVC c/r de 1 1/4\"',1.40,'Amanco',0),(82,'Unión PVC c/r de 1 1/2\"',2.00,'Amanco',0),(83,'Unión PVC c/r de  2\"',2.80,'Amanco',0),(84,'Unión PVC c/r de  3\"',3.00,'Amanco',0),(85,'Unión PVC c/r de  4\"',4.00,'Amanco',0),(86,'Unión PVC c/r de 6\"',4.80,'Amanco',0),(87,'Adaptador PVC  1/2\"',0.35,'Amanco',0),(88,'Adaptador PVC  3/4\"',0.50,'Amanco',0),(89,'Adaptador PVC  1\"',1.00,'Amanco',0),(90,'Adaptador PVC e 1 1/4\"',1.30,'Amanco',0),(91,'Adaptador PVC 1 1/2\"',1.90,'Amanco',0),(92,'Adaptador PVC  2\"',2.70,'Amanco',0),(93,'Adaptador PVC   3\"',2.80,'Amanco',0),(94,'Adaptador PVC  4\"',3.90,'Amanco',0),(95,'Adaptador PVC  6\"',4.50,'Amanco',0),(96,'Tapón PVC 1/2\"',0.35,'Amanco',0),(97,'Tapón PVC 3/4\"',0.50,'Amanco',0),(98,'Tapón PVC 1\"',1.00,'Amanco',0),(99,'Tapón PVCe 1 1/4\"',1.30,'Amanco',0),(100,'Tapón PVC 1 1/2\"',1.90,'Amanco',0),(101,'Tapón PVC 2\"',2.70,'Amanco',0),(102,'Tapón PVC   3\"',2.80,'Amanco',0),(103,'Tapón PVC 4\"',3.90,'Amanco',0),(104,'Tapón PVC  6\"',4.50,'Amanco',0);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedores`
--

DROP TABLE IF EXISTS `proveedores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedores` (
  `idProveedores` int(11) NOT NULL AUTO_INCREMENT,
  `Proveedor` varchar(80) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Correo` varchar(25) NOT NULL,
  `idDirecciones` int(11) NOT NULL,
  PRIMARY KEY (`idProveedores`),
  KEY `proveedores_ibfk_1` (`idDirecciones`),
  CONSTRAINT `proveedores_ibfk_1` FOREIGN KEY (`idDirecciones`) REFERENCES `direcciones` (`idDirecciones`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedores`
--

LOCK TABLES `proveedores` WRITE;
/*!40000 ALTER TABLE `proveedores` DISABLE KEYS */;
INSERT INTO `proveedores` VALUES (1,'La Palma','2222','lp@gmail.com',1);
/*!40000 ALTER TABLE `proveedores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `idRoles` int(11) NOT NULL AUTO_INCREMENT,
  `Roles` varchar(25) NOT NULL,
  PRIMARY KEY (`idRoles`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador'),(2,'Vendedor');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `idUsuarios` int(11) NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(12) NOT NULL,
  `Clave` varchar(200) NOT NULL,
  `idRoles` int(11) NOT NULL,
  `idEmpleados` int(11) NOT NULL,
  PRIMARY KEY (`idUsuarios`),
  KEY `usuarios_ibfk_1` (`idEmpleados`),
  KEY `usuarios_ibfk_2` (`idRoles`),
  CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`idEmpleados`) REFERENCES `empleados` (`idEmpleados`),
  CONSTRAINT `usuarios_ibfk_2` FOREIGN KEY (`idRoles`) REFERENCES `roles` (`idRoles`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,'RCASTRO','62feb4e4213e8b4aec4954f13a264b56449781ab',1,1),(2,'CMARISOL','33360d0f2e7adcb39b688ce770d48f3d0115db6d',2,2),(3,'REBECA','adcd7048512e64b48da55b027577886ee5a36350',2,7);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventas` (
  `idVentas` int(11) NOT NULL AUTO_INCREMENT,
  `NumerodeFactura` varchar(10) DEFAULT NULL,
  `idClientes` int(11) DEFAULT NULL,
  `idEmpleados` int(11) NOT NULL,
  `idFormasdePago` int(11) NOT NULL,
  `Fecha` datetime NOT NULL,
  `Total` decimal(10,2) NOT NULL,
  PRIMARY KEY (`idVentas`),
  KEY `ventas_ibfk_2` (`idEmpleados`),
  KEY `ventas_ibfk_3` (`idFormasdePago`),
  KEY `ventas_ibfk_1` (`idClientes`),
  CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`idClientes`) REFERENCES `clientes` (`idClientes`),
  CONSTRAINT `ventas_ibfk_2` FOREIGN KEY (`idEmpleados`) REFERENCES `empleados` (`idEmpleados`),
  CONSTRAINT `ventas_ibfk_3` FOREIGN KEY (`idFormasdePago`) REFERENCES `formasdepagos` (`idFormasdePagos`)
) ENGINE=InnoDB AUTO_INCREMENT=133 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
INSERT INTO `ventas` VALUES (54,NULL,1,1,1,'2023-06-06 00:00:00',1.00),(55,NULL,1,1,2,'2023-06-07 00:43:26',216.75),(56,NULL,1,1,1,'2023-06-07 11:48:26',29.50),(57,NULL,1,2,1,'2023-06-07 11:54:27',123.50),(58,NULL,1,1,1,'2023-06-07 11:56:04',29.50),(59,NULL,1,1,1,'2023-06-07 14:16:28',34.75),(60,NULL,1,1,1,'2023-06-07 14:36:59',34.75),(61,NULL,1,1,1,'2023-06-07 15:02:31',34.75),(62,NULL,1,1,1,'2023-06-07 15:44:29',39.00),(63,NULL,1,1,1,'2023-06-07 15:46:14',98.00),(64,NULL,1,1,1,'2023-06-07 15:46:18',98.00),(65,NULL,1,1,1,'2023-06-07 15:47:49',34.75),(66,NULL,1,1,1,'2023-06-07 15:56:46',92.75),(67,NULL,1,1,1,'2023-06-07 15:59:46',92.75),(68,NULL,1,1,1,'2023-06-07 16:04:00',139.75),(69,NULL,1,1,1,'2023-06-07 16:05:33',39.00),(70,NULL,1,1,1,'2023-06-07 16:07:23',34.75),(71,NULL,1,1,1,'2023-06-07 16:20:21',49.50),(72,NULL,1,1,1,'2023-06-07 21:47:24',64.25),(73,NULL,1,1,1,'2023-06-07 22:09:07',40.00),(74,NULL,1,1,1,'2023-06-07 22:15:00',168.75),(75,NULL,1,1,1,'2023-06-07 22:30:51',53.75),(76,NULL,1,1,1,'2023-06-07 22:36:39',64.25),(77,NULL,1,1,1,'2023-06-08 03:18:03',1423.15),(78,NULL,1,1,1,'2023-06-08 03:18:53',444.25),(79,NULL,1,1,1,'2023-06-08 03:20:25',42.60),(80,NULL,1,1,1,'2023-06-08 03:22:27',128.05),(81,NULL,1,1,1,'2023-06-08 16:41:44',118.00),(82,NULL,1,1,2,'2023-06-10 16:25:49',126.00),(83,NULL,1,1,1,'2023-06-11 17:46:03',53.90),(84,NULL,1,1,2,'2023-06-11 18:48:05',116.00),(85,NULL,1,1,2,'2023-06-11 18:51:57',52.50),(86,NULL,1,1,1,'2023-06-11 18:53:09',109.50),(87,NULL,1,1,2,'2023-06-11 19:19:52',67.50),(88,NULL,1,1,2,'2023-06-12 00:37:54',173.00),(89,NULL,2,1,1,'2023-06-12 15:01:40',103.00),(90,NULL,1,1,1,'2023-06-12 17:23:49',132.60),(91,NULL,2,2,1,'2023-06-12 17:28:58',49.50),(92,NULL,1,1,1,'2023-06-12 18:00:39',62.90),(93,NULL,1,2,1,'2023-06-12 18:41:14',62.90),(94,NULL,1,1,2,'2023-06-13 09:39:19',84.30),(95,NULL,1,1,1,'2023-06-13 19:07:55',76.00),(96,NULL,1,1,1,'2023-10-23 13:06:56',66.50),(97,NULL,1,1,1,'2023-11-07 23:40:04',6.00),(98,NULL,1,1,1,'2023-11-08 00:42:05',76.00),(99,NULL,1,1,2,'2023-11-13 18:19:42',140.50),(100,NULL,1,1,2,'2023-11-13 20:04:21',3.50),(101,NULL,1,1,1,'2023-11-15 16:25:37',60.00),(102,NULL,1,1,1,'2023-11-15 16:43:21',43.00),(103,NULL,1,1,1,'2023-11-15 18:46:33',47.50),(104,NULL,1,1,1,'2023-11-16 01:30:33',43.00),(105,NULL,1,1,1,'2023-11-16 11:44:52',25.80),(106,NULL,1,1,1,'2023-11-19 17:05:55',73.45),(107,NULL,1,1,1,'2023-11-19 17:39:29',37.62),(108,NULL,1,1,1,'2023-11-19 18:07:30',77.45),(109,NULL,2,1,1,'2023-11-19 18:35:17',16.10),(110,NULL,1,1,1,'2023-11-19 18:43:36',101.38),(111,'0',2,1,1,'2023-11-19 22:20:09',47.05),(112,'',1,1,1,'2023-11-19 22:23:16',5.25),(113,'',2,1,1,'2023-11-19 22:27:02',19.00),(114,'',1,1,1,'2023-11-19 22:35:03',19.00),(115,'',1,1,1,'2023-11-19 22:45:15',4.00),(116,'000000',1,1,1,'2023-11-19 22:48:01',34.40),(117,'',1,1,1,'2023-11-19 22:50:43',27.00),(118,'',2,1,1,'2023-11-19 23:03:56',6.00),(119,NULL,2,1,1,'2023-11-19 23:07:56',3.60),(120,'',2,1,1,'2023-11-19 23:10:19',6.00),(121,NULL,2,1,1,'2023-11-19 23:13:19',5.40),(122,'',2,1,1,'2023-11-20 00:49:12',4.00),(123,'',1,1,1,'2023-11-20 00:49:42',2.00),(124,'',2,1,1,'2023-11-20 01:00:37',3.00),(125,'',1,1,1,'2023-11-20 01:26:44',2.00),(126,'',1,1,1,'2023-11-20 01:29:46',9.50),(127,'',2,1,1,'2023-11-20 01:40:50',8.60),(128,'',1,1,1,'2023-11-20 01:44:14',2.00),(129,'000001',1,1,1,'2023-11-20 01:46:20',2.00),(130,'000002',1,1,1,'2023-11-20 02:15:08',0.90),(131,'000003',1,1,1,'2023-11-20 02:16:14',8.50),(132,'000004',2,1,1,'2023-11-20 02:28:25',6.00);
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-20  9:29:00
