-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: factura
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `IDcliente` varchar(25) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Direccion` varchar(100) DEFAULT NULL,
  `Correo` varchar(45) DEFAULT NULL,
  `Telefono` varchar(15) DEFAULT NULL,
  `EstaActivo` tinyint NOT NULL,
  `FechaNacimiento` datetime DEFAULT NULL,
  PRIMARY KEY (`IDcliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `detallefactura`
--

DROP TABLE IF EXISTS `detallefactura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallefactura` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `IDfactura` int NOT NULL,
  `CodigoProducto` varchar(80) NOT NULL,
  `Precio` decimal(10,0) NOT NULL,
  `Cantidad` int NOT NULL,
  `Total` decimal(10,0) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_detalle_factura_idx` (`IDfactura`),
  KEY `fk_detalle_producto_idx` (`CodigoProducto`),
  CONSTRAINT `fk_detalle_factura` FOREIGN KEY (`IDfactura`) REFERENCES `factura` (`ID`),
  CONSTRAINT `fk_detalle_producto` FOREIGN KEY (`CodigoProducto`) REFERENCES `producto` (`Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `factura` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Fecha` datetime NOT NULL,
  `IDcliente` varchar(25) NOT NULL,
  `CodigoUsuario` varchar(50) NOT NULL,
  `ISV` decimal(10,0) NOT NULL,
  `Descuento` decimal(10,0) NOT NULL,
  `SubTotal` decimal(10,0) NOT NULL,
  `Total` decimal(10,0) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `fk_factura_cliente_idx` (`IDcliente`),
  KEY `fk_factura_usuario_idx` (`CodigoUsuario`),
  CONSTRAINT `fk_factura_cliente` FOREIGN KEY (`IDcliente`) REFERENCES `clientes` (`IDcliente`),
  CONSTRAINT `fk_factura_usuario` FOREIGN KEY (`CodigoUsuario`) REFERENCES `usuarios` (`CodigoUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `Codigo` varchar(80) NOT NULL,
  `Descripcion` varchar(200) NOT NULL,
  `Existencia` int NOT NULL,
  `Precio` decimal(10,0) NOT NULL,
  `Foto` longblob,
  `EstaActivo` tinyint NOT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `CodigoUsuario` varchar(50) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Contrasena` varchar(80) NOT NULL,
  `Correo` varchar(45) DEFAULT NULL,
  `Rol` varchar(20) NOT NULL,
  `Foto` longblob,
  `FechaCreacion` datetime NOT NULL,
  `EstaActivo` tinyint NOT NULL,
  PRIMARY KEY (`CodigoUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-24 18:00:46
