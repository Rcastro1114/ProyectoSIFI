-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema bd_sifi
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `bd_sifi` ;

-- -----------------------------------------------------
-- Schema bd_sifi
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bd_sifi` DEFAULT CHARACTER SET utf8 ;
SHOW WARNINGS;
USE `bd_sifi` ;

-- -----------------------------------------------------
-- Table `Direcciones`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Direcciones` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Direcciones` (
  `idDirecciones` INT NOT NULL,
  `Direccion` VARCHAR(45) NOT NULL,
  `Municipio` VARCHAR(40) NOT NULL,
  `Departamento` VARCHAR(45) NULL,
  `Direccionescol` VARCHAR(35) NULL,
  PRIMARY KEY (`idDirecciones`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Empleados`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Empleados` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Empleados` (
  `idEmpleados` INT NOT NULL AUTO_INCREMENT,
  `Nombres` VARCHAR(35) NOT NULL,
  `Apellidos` VARCHAR(35) NOT NULL,
  `FechaNacimiento` DATE NOT NULL,
  `DUI` VARCHAR(10) NOT NULL,
  `Telefono` VARCHAR(10) NULL,
  `CorreoElectronico` VARCHAR(25) NULL,
  `Direcciones_idDirecciones` INT NOT NULL,
  PRIMARY KEY (`idEmpleados`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Clasificaciones`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Clasificaciones` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Clasificaciones` (
  `idClasificaciones` INT NOT NULL AUTO_INCREMENT,
  `Clasificacion` VARCHAR(30) NULL,
  PRIMARY KEY (`idClasificaciones`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Opciones`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Opciones` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Opciones` (
  `idOpciones` INT NOT NULL,
  `Opcion` VARCHAR(30) NULL,
  `Clasificaciones_idClasificaciones` INT NOT NULL,
  PRIMARY KEY (`idOpciones`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Roles`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Roles` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Roles` (
  `idRoles` INT NOT NULL AUTO_INCREMENT,
  `Rol` VARCHAR(45) NULL,
  PRIMARY KEY (`idRoles`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Permisos`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Permisos` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Permisos` (
  `idPermisos` INT NOT NULL AUTO_INCREMENT,
  `Roles_idRoles` INT NOT NULL,
  `Opciones_idOpciones` INT NOT NULL,
  PRIMARY KEY (`idPermisos`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Usuarios`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Usuarios` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Usuarios` (
  `idUsuarios` INT NOT NULL AUTO_INCREMENT,
  `Usuario` VARCHAR(15) NOT NULL,
  `Clave` VARCHAR(10) NOT NULL,
  `Empleados_idEmpleados` INT NOT NULL,
  `Roles_idRoles` INT NOT NULL,
  PRIMARY KEY (`idUsuarios`))
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
  `Precio_unitario` DECIMAL(4,2) NULL,
  `Marca` VARCHAR(25) NULL,
  `Stock` INT NULL,
  `Cantidad_MAX` INT NULL,
  `Cantidad_MIN` INT NULL,
  PRIMARY KEY (`idProductos`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `DetalleCompras`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DetalleCompras` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `DetalleCompras` (
  `idDetalleCompras` INT NOT NULL AUTO_INCREMENT,
  `Producto` VARCHAR(40) NULL,
  `Stock` INT NULL,
  `Precio_unitario` DECIMAL(4,2) NULL,
  `Precio_total` DECIMAL(4,2) NULL,
  `Productos_idProductos` INT NOT NULL,
  PRIMARY KEY (`idDetalleCompras`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Proveedores`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Proveedores` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Proveedores` (
  `idProveedores` INT NOT NULL AUTO_INCREMENT,
  `Proveedor` VARCHAR(30) NULL,
  `Telefono` VARCHAR(10) NULL,
  `Correo` VARCHAR(25) NULL,
  `Direcciones_idDirecciones` INT NOT NULL,
  PRIMARY KEY (`idProveedores`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Compras`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Compras` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Compras` (
  `idCompras` INT NOT NULL,
  `Fecha` DATE NOT NULL,
  `DetalleCompras_idDetalleCompras` INT NOT NULL,
  `Proveedores_idProveedores` INT NOT NULL,
  PRIMARY KEY (`idCompras`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Clientes`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Clientes` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Clientes` (
  `idClientes` INT NOT NULL AUTO_INCREMENT,
  `Nombres` VARCHAR(35) NOT NULL,
  `Apellidos` VARCHAR(35) NOT NULL,
  `Telefono` VARCHAR(10) NULL,
  `Correo` VARCHAR(25) NULL,
  `Direcciones_idDirecciones` INT NOT NULL,
  PRIMARY KEY (`idClientes`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `DetalleVentas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DetalleVentas` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `DetalleVentas` (
  `idDetalleVentas` INT NOT NULL AUTO_INCREMENT,
  `Produto` VARCHAR(35) NOT NULL,
  `Stock` INT NOT NULL,
  `Precio_unitario` DECIMAL(4,2) NOT NULL,
  `Precio_total` DECIMAL(4,2) NOT NULL,
  `Productos_idProductos` INT NOT NULL,
  PRIMARY KEY (`idDetalleVentas`))
ENGINE = InnoDB;

SHOW WARNINGS;

-- -----------------------------------------------------
-- Table `Ventas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Ventas` ;

SHOW WARNINGS;
CREATE TABLE IF NOT EXISTS `Ventas` (
  `idVentas` INT NOT NULL AUTO_INCREMENT,
  `Fecha` DATE NULL,
  `Clientes_idClientes` INT NOT NULL,
  `DetalleVentas_idDetalleVentas` INT NOT NULL,
  PRIMARY KEY (`idVentas`))
ENGINE = InnoDB;

SHOW WARNINGS;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
