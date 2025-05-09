-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema registros
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema registros
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `registros` DEFAULT CHARACTER SET utf8 ;
USE `registros` ;

-- -----------------------------------------------------
-- Table `registros`.`registro`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `registros`.`registro` (
  `create_time` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP,
  `update_time` TIMESTAMP NULL,
  `id_registro` INT GENERATED ALWAYS AS () STORED,
  `num_placa` VARCHAR(45) NOT NULL,
  `tipo` VARCHAR(45) NOT NULL,
  `entrada` DATETIME NOT NULL,
  `salida` DATETIME NULL,
  PRIMARY KEY (`id_registro`),
  UNIQUE INDEX `id_registro_UNIQUE` (`id_registro` ASC) VISIBLE);


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
