
CREATE SCHEMA IF NOT EXISTS `watchlistv4` DEFAULT CHARACTER SET utf8mb4 ;
USE `watchlistv4` ;

CREATE TABLE IF NOT EXISTS `watchlistv4`.`genero` (
  `idgenero` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idgenero`));


CREATE TABLE IF NOT EXISTS `watchlistv4`.`filme` (
  `idFilme` INT(11) NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(45) NULL DEFAULT NULL,
  `duracao` VARCHAR(45) NULL DEFAULT NULL,
  `resumo` VARCHAR(400) NULL DEFAULT NULL,
  `imagem` VARCHAR(100) NULL DEFAULT NULL,
  `ano` INT(11) NULL DEFAULT NULL,
  `trailer` VARCHAR(100) NULL DEFAULT NULL,
  `visto` INT(100) NULL DEFAULT 0 ,
  `data` Datetime NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idFilme`));


CREATE TABLE IF NOT EXISTS `watchlistv4`.`utilizador` (
  `idUtilizador` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(25) NULL DEFAULT NULL,
  `email` VARCHAR(25) NULL DEFAULT NULL,
  `password` VARCHAR(25) NULL DEFAULT NULL,
  `recuperacao` VARCHAR(50) NULL DEFAULT NULL,
  PRIMARY KEY (`idUtilizador`));

CREATE TABLE IF NOT EXISTS `watchlistv4`.`filme_has_genero` (
  `filme_idFilme` INT(11) NOT NULL,
  `genero_idgenero` INT NOT NULL,
  PRIMARY KEY (`filme_idFilme`, `genero_idgenero`),
  CONSTRAINT `fk_filme_has_genero_filme1`
    FOREIGN KEY (`filme_idFilme`)
    REFERENCES `watchlistv4`.`filme` (`idFilme`),
  CONSTRAINT `fk_filme_has_genero_genero1`
    FOREIGN KEY (`genero_idgenero`)
    REFERENCES `watchlistv4`.`genero` (`idgenero`));


CREATE TABLE IF NOT EXISTS `watchlistv4`.`utilizador_has_filme` (
  `utilizador_idUtilizador` INT(11) NOT NULL,
  `filme_idFilme` INT(11) NOT NULL,
  `rating` INT(11),
  `status` VARCHAR(25),
  PRIMARY KEY (`utilizador_idUtilizador`, `filme_idFilme`),
  CONSTRAINT `fk_utilizador_has_filme_utilizador`
    FOREIGN KEY (`utilizador_idUtilizador`)
    REFERENCES `watchlistv4`.`utilizador` (`idUtilizador`),
  CONSTRAINT `fk_utilizador_has_filme_filme1`
    FOREIGN KEY (`filme_idFilme`)
    REFERENCES `watchlistv4`.`filme` (`idFilme`));
    
CREATE TABLE IF NOT EXISTS `watchlistv4`.`admin` (
  `idAdmin` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(25) NULL DEFAULT NULL,
  `password` VARCHAR(25) NULL DEFAULT NULL,
  PRIMARY KEY (`idAdmin`));
    


