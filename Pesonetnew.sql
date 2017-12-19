# SQL Manager 2010 for MySQL 4.5.0.9
# ---------------------------------------
# Host     : localhost
# Port     : 3306
# Database : pesonet


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;

SET FOREIGN_KEY_CHECKS=0;

DROP DATABASE IF EXISTS `pesonet`;

CREATE DATABASE `pesonet`
    CHARACTER SET 'latin1'
    COLLATE 'latin1_swedish_ci';

USE `pesonet`;

#
# Structure for the `brand` table : 
#

CREATE TABLE `brand` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `Title` (`Title`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

#
# Structure for the `supplier` table : 
#

CREATE TABLE `supplier` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `ContactPerson` varchar(50) NOT NULL,
  `Adrs` varchar(100) NOT NULL,
  `ContactNumbers` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

#
# Structure for the `recieving` table : 
#

CREATE TABLE `recieving` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `SupplierID` int(11) DEFAULT '0',
  `Petsa` date DEFAULT NULL,
  `FormType` varchar(20) NOT NULL,
  `FormSerial` int(11) DEFAULT '0',
  `Remarks` varchar(100) DEFAULT NULL,
  `ReceivedBy` varchar(100) NOT NULL,
  `Takna` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  KEY `SupplierID` (`SupplierID`),
  CONSTRAINT `recieving_fk` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`ID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `unit` table : 
#

CREATE TABLE `unit` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `Title` (`Title`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

#
# Structure for the `itemrecieved` table : 
#

CREATE TABLE `itemrecieved` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `MasterID` int(11) DEFAULT NULL,
  `UnitID` int(11) DEFAULT NULL,
  `BrandID` int(11) DEFAULT NULL,
  `Model` varchar(20) NOT NULL,
  `Capacity` varchar(20) NOT NULL,
  `Specs` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  KEY `MasterID` (`MasterID`),
  KEY `BrandID` (`BrandID`),
  KEY `UnitID` (`UnitID`),
  CONSTRAINT `itemrecieved_fk` FOREIGN KEY (`MasterID`) REFERENCES `recieving` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `itemrecieved_fk1` FOREIGN KEY (`UnitID`) REFERENCES `unit` (`ID`) ON UPDATE CASCADE,
  CONSTRAINT `itemrecieved_fk2` FOREIGN KEY (`BrandID`) REFERENCES `brand` (`ID`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `receipt` table : 
#

CREATE TABLE `receipt` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Title` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `Title` (`Title`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

#
# Data for the `brand` table  (LIMIT 0,500)
#

INSERT INTO `brand` (`ID`, `Title`) VALUES 
  (1,'Asus'),
  (2,'Kingstone'),
  (3,'Intel');
COMMIT;

#
# Data for the `supplier` table  (LIMIT 0,500)
#

INSERT INTO `supplier` (`ID`, `Name`, `ContactPerson`, `Adrs`, `ContactNumbers`) VALUES 
  (1,'datalan','elly zamora','r. calo st., butuan city','085 341-2479');
COMMIT;

#
# Data for the `unit` table  (LIMIT 0,500)
#

INSERT INTO `unit` (`ID`, `Title`) VALUES 
  (1,'Memory'),
  (2,'Processor'),
  (3,'Hard Drive');
COMMIT;

#
# Data for the `receipt` table  (LIMIT 0,500)
#

INSERT INTO `receipt` (`ID`, `Title`) VALUES 
  (1,'Official Receipt'),
  (2,'Sales Invoice');
COMMIT;



/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;