/*
Navicat MySQL Data Transfer

Source Server         : MySQL
Source Server Version : 50018
Source Host           : localhost:3306
Source Database       : baza_ppj

Target Server Type    : MYSQL
Target Server Version : 50018
File Encoding         : 65001

Date: 2022-04-05 12:19:52
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `artikal`
-- ----------------------------
DROP TABLE IF EXISTS `artikal`;
CREATE TABLE `artikal` (
  `artikal_id` int(10) NOT NULL auto_increment,
  `naziv_artikla` varchar(50) default NULL,
  `vrsta_artikla` varchar(50) NOT NULL,
  `cijena` double(10,2) NOT NULL,
  PRIMARY KEY  (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of artikal
-- ----------------------------

-- ----------------------------
-- Table structure for `kupac`
-- ----------------------------
DROP TABLE IF EXISTS `kupac`;
CREATE TABLE `kupac` (
  `kupac_id` int(10) NOT NULL auto_increment,
  `ime` varchar(30) default NULL,
  `prezime` varchar(30) NOT NULL,
  `grad` varchar(30) NOT NULL,
  `adresa` varchar(30) default NULL,
  `telefon` varchar(30) default NULL,
  `user` varchar(50) NOT NULL,
  `pass` varchar(50) NOT NULL,
  PRIMARY KEY  (`kupac_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of kupac
-- ----------------------------
INSERT INTO `kupac` VALUES ('1', 'Mujo', 'Mujic', 'Sarajevo', 'Ferhadija 15', '123.123.123', 'mujo.m', '1mujo.m');

-- ----------------------------
-- Table structure for `narudzbenica`
-- ----------------------------
DROP TABLE IF EXISTS `narudzbenica`;
CREATE TABLE `narudzbenica` (
  `narudzbenica_id` int(10) NOT NULL auto_increment,
  `kupac_id` int(10) NOT NULL,
  `datum_narudzbe` date NOT NULL,
  PRIMARY KEY  (`narudzbenica_id`),
  KEY `narudzbenica_kupac_kupac_id` (`kupac_id`),
  CONSTRAINT `narudzbenica_kupac_kupac_id` FOREIGN KEY (`kupac_id`) REFERENCES `kupac` (`kupac_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of narudzbenica
-- ----------------------------

-- ----------------------------
-- Table structure for `skladiste`
-- ----------------------------
DROP TABLE IF EXISTS `skladiste`;
CREATE TABLE `skladiste` (
  `id` int(10) NOT NULL auto_increment,
  `artikal_id` int(10) NOT NULL,
  `kolicina_stanje` int(10) NOT NULL,
  PRIMARY KEY  (`id`),
  KEY `skladiste_artikal_artikal_id` (`artikal_id`),
  CONSTRAINT `skladiste_artikal_artikal_id` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of skladiste
-- ----------------------------

-- ----------------------------
-- Table structure for `stavka_narudzbenice`
-- ----------------------------
DROP TABLE IF EXISTS `stavka_narudzbenice`;
CREATE TABLE `stavka_narudzbenice` (
  `stavka_id` int(10) NOT NULL auto_increment,
  `narudzbenica_id` int(10) NOT NULL,
  `artikal_id` int(10) NOT NULL,
  `kolicina` int(20) NOT NULL,
  PRIMARY KEY  (`stavka_id`),
  KEY `stavka_narudzbenice_narudzbenica_narudzbenica_id` (`narudzbenica_id`),
  KEY `stavka_narudzbenice_artikal_artikal_id` (`artikal_id`),
  CONSTRAINT `stavka_narudzbenice_artikal_artikal_id` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`),
  CONSTRAINT `stavka_narudzbenice_narudzbenica_narudzbenica_id` FOREIGN KEY (`narudzbenica_id`) REFERENCES `narudzbenica` (`narudzbenica_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of stavka_narudzbenice
-- ----------------------------
