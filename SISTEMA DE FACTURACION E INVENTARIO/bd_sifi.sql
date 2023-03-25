-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema sifi_prueba
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `sifi_prueba` ;

-- -----------------------------------------------------
-- Schema sifi_prueba
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `sifi_prueba` DEFAULT CHARACTER SET utf8 ;
SHOW WARNINGS;
USE `sifi_prueba` ;

-- -----------------------------------------------------
-- Table `Opciones`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Opciones` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Opciones` (
  `idOpciones` INT NOT NULL AUTO_INCREMENT,
  `Usuario` VARCHAR(10) NULL,
  `Clave` VARCHAR(8) NULL,
  `idEmpleados` INT NOT NULL,
  `idRoles` INT NULL,
  PRIMARY KEY (`idOpciones`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Empleados`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Empleados` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Empleados` (
  `idEmpleados` INT NOT NULL AUTO_INCREMENT,
  `Nombres` VARCHAR(35) NULL,
  `Apellidos` VARCHAR(35) NULL,
  `Genero` CHAR(1) NULL,
  `Telefono` VARCHAR(10) NULL,
  `Correo` VARCHAR(45) NULL,
  PRIMARY KEY (`idEmpleados`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Compras`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Compras` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Compras` (
  `idCompras` INT NOT NULL AUTO_INCREMENT,
  `idProveedor` INT NOT NULL,
  `Fecha` DATE NOT NULL,
  `idDetalleCompras` INT NOT NULL,
  PRIMARY KEY (`idCompras`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `DetalleCompras`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DetalleCompras` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `DetalleCompras` (
  `idDetalleCompras` INT NOT NULL AUTO_INCREMENT,
  `idProducto` INT NOT NULL,
  `Producto` VARCHAR(35) NULL,
  `Stock` INT NULL,
  `Precio_unitario` DECIMAL(2,8) NULL,
  `Precio_total` DECIMAL(2,8) NULL,
  PRIMARY KEY (`idDetalleCompras`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Ventas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Ventas` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Ventas` (
  `idVentas` INT NOT NULL AUTO_INCREMENT,
  `idCliente` INT NULL,
  `idDetalleVentas` INT NULL,
  `Fecha` DATE NULL,
  PRIMARY KEY (`idVentas`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `DetalleVentas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DetalleVentas` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `DetalleVentas` (
  `idDetalleVentas` INT NOT NULL,
  `idProducto` INT NOT NULL,
  `Producto` VARCHAR(35) NULL,
  `Stock` INT NULL,
  `Precio_unitario` DECIMAL(2,8) NULL,
  `Precio_total` DECIMAL(2,8) NULL,
  PRIMARY KEY (`idDetalleVentas`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `StockProductos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `StockProductos` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `StockProductos` (
  `idStockProductos` INT NOT NULL,
  `idProductos` INT NULL,
  `Stock` INT NULL,
  `Cantidad_MAX` INT NULL,
  `Cantidad_MIN` INT NULL,
  PRIMARY KEY (`idStockProductos`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Productos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Productos` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Productos` (
  `idProductos` INT NOT NULL AUTO_INCREMENT,
  `Producto` VARCHAR(35) NULL,
  `idCategorias` INT NULL,
  `Marca` VARCHAR(15) NULL,
  `Precio_unitario` DECIMAL(2,8) NULL,
  PRIMARY KEY (`idProductos`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `CategoriaProductos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `CategoriaProductos` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `CategoriaProductos` (
  `idCategoriaProductos` INT NOT NULL AUTO_INCREMENT,
  `Categoria` VARCHAR(20) NULL,
  PRIMARY KEY (`idCategoriaProductos`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Clientes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Clientes` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Clientes` (
  `idClientes` INT NOT NULL AUTO_INCREMENT,
  `Nombres` VARCHAR(35) NULL,
  `Apellidos` VARCHAR(35) NULL,
  `Telefono` VARCHAR(9) NULL,
  `DUI` VARCHAR(9) NULL,
  PRIMARY KEY (`idClientes`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Permisos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Permisos` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Permisos` (
  `idPermisos` INT NOT NULL AUTO_INCREMENT,
  `idRoles` INT NOT NULL,
  `idOpciones` INT NOT NULL,
  PRIMARY KEY (`idPermisos`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Opciones`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Opciones` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Opciones` (
  `idOpciones` INT NOT NULL AUTO_INCREMENT,
  `Usuario` VARCHAR(10) NULL,
  `Clave` VARCHAR(8) NULL,
  `idEmpleados` INT NOT NULL,
  `idRoles` INT NULL,
  PRIMARY KEY (`idOpciones`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Clasificaciones`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Clasificaciones` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Clasificaciones` (
  `idClasificaciones` INT NOT NULL AUTO_INCREMENT,
  `Clasificacion` VARCHAR(45) NULL,
  PRIMARY KEY (`idClasificaciones`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Roles`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Roles` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Roles` (
  `idRoles` INT NOT NULL AUTO_INCREMENT,
  `Rol` VARCHAR(30) NULL,
  PRIMARY KEY (`idRoles`))
ENGINE = InnoDB;

SHOW WARNINGS;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
