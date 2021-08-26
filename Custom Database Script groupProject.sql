USE master
GO

/****** Object:  Database AP     ******/
IF DB_ID('DnD') IS NOT NULL
	DROP DATABASE DnD
GO

CREATE DATABASE DnD
GO 

USE DnD
GO

/****** Object:  Table Description  ******/ 
CREATE TABLE Description(
	DescriptionID int IDENTITY(1,1) NOT NULL  PRIMARY KEY,
	HairStyle     varchar(15)       NOT NULL,
	HairColor     varchar(15)       NULL,
	EyeColor      varchar(15)       NOT NULL,
	SkinType      varchar(10)       NOT NULL,
	SkinColor     varchar(15)       NOT NULL,
	RaceName        varchar	(30)       NOT NULL, 
	
)
GO
/**** Table: [Description] Values ****/
SET IDENTITY_INSERT Description ON 
INSERT Description (DescriptionID, HairStyle,HairColor,EyeColor,SkinType,SkinColor,RaceName) VALUES 
(1, 'long', 'White','Green','scaled','Ray-Green','dragon-born'),
(2,'bald', 'None','Green','lizard','Light Ray-Green','lizard-men' ),
(3,'wavy' , 'Golden','Grey','flesh','White','human'),
(4,'flames' ,'Red','Demon Red','bones','Black','skeleton')
SET IDENTITY_INSERT Description OFF
/****** Object:  Table CharterSheet  ******/ 
CREATE TABLE CharaterSheet(
	SheetID         int IDENTITY (1,1) NOT NULL PRIMARY KEY,
	CharaterName     varchar (50)       NOT NULL,
	[Description]   int                NOT NULL REFERENCES Description(DescriptionID),
	ClassName       varchar(25)        NOT NULL,
)
/**** Table: CharterSheet Values ****/
SET IDENTITY_INSERT CharaterSheet ON 
INSERT CharaterSheet(SheetID, CharaterName,Description,ClassName) VALUES 
(1, 'Kurg "Oathstriker" Ostineogugbu',1,'dragon-rider'),
(2, 'Ared',2,'wizard'),
(3, 'asgard',3,'demi-god'),
(4, 'Rularshend',4,'archer')
SET IDENTITY_INSERT CharterSheet OFF



