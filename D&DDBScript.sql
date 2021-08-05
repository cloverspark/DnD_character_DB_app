USE [master]
GO

drop database if exists DnD
go
/****** Object:  Database [DnD2]    Script Date: 7/19/2021 2:33:51 PM ******/
CREATE DATABASE [DnD]
GO
USE [DnD]
GO
/****** Object:  Table [dbo].[Armor]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Armor](
	[ArmorID] [int] IDENTITY(1,1) NOT NULL,
	[ArmorType] [int] NOT NULL,
	[ArmorName] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ArmorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArmorType]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArmorType](
	[ArmorTypeID] [int] IDENTITY(1,1) NOT NULL,
	[ArmorType] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ArmorTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CharterSheet]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CharterSheet](
	[SheetID] [int] IDENTITY(1,1) NOT NULL,
	[CharterName] [varchar](50) NOT NULL,
	[Race] [int] NOT NULL,
	[Description] [int] NOT NULL,
	[class] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SheetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassID] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [varchar](15) NOT NULL,
	[Armor] [int] NOT NULL,
	[Weapon1] [int] NOT NULL,
	[Weapon2] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DamageType]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DamageType](
	[DamageTypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeOfDamage] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DamageTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Description]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Description](
	[DescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[HairStyle] [int] NOT NULL,
	[HairColor] [varchar](15) NULL,
	[EyeColor] [varchar](15) NOT NULL,
	[SkinType] [int] NOT NULL,
	[SkinColor] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DescriptionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HairStyle]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HairStyle](
	[HairStyleID] [int] IDENTITY(1,1) NOT NULL,
	[HairStyle] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HairStyleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Race]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Race](
	[RaceID] [int] IDENTITY(1,1) NOT NULL,
	[RaceName] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RaceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SkinType]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SkinType](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[SkinType] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stat]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stat](
	[StatsID] [int] IDENTITY(1,1) NOT NULL,
	[StatsNum] [int] NOT NULL,
	[RacialBonus] [decimal](3, 1) NULL,
	[BaseScore] [decimal](3, 1) NOT NULL,
	[Modifier] [decimal](3, 1) NULL,
PRIMARY KEY CLUSTERED 
(
	[StatsID] ASC,
	[StatsNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatName]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatName](
	[NameID] [int] IDENTITY(1,1) NOT NULL,
	[StatName] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NameID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Weapons]    Script Date: 7/19/2021 2:33:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Weapons](
	[WeaponsID] [int] IDENTITY(1,1) NOT NULL,
	[DamageType] [int] NOT NULL,
	[WeaponName] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[WeaponsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Armor] ON 
GO
INSERT [dbo].[Armor] ([ArmorID], [ArmorType], [ArmorName]) VALUES (1, 1, N'Studded leather')
GO
INSERT [dbo].[Armor] ([ArmorID], [ArmorType], [ArmorName]) VALUES (2, 2, N'Hide')
GO
INSERT [dbo].[Armor] ([ArmorID], [ArmorType], [ArmorName]) VALUES (3, 1, N'Leather')
GO
INSERT [dbo].[Armor] ([ArmorID], [ArmorType], [ArmorName]) VALUES (4, 3, N'Plate')
GO
SET IDENTITY_INSERT [dbo].[Armor] OFF
GO
SET IDENTITY_INSERT [dbo].[ArmorType] ON 
GO
INSERT [dbo].[ArmorType] ([ArmorTypeID], [ArmorType]) VALUES (1, N'Light Armor')
GO
INSERT [dbo].[ArmorType] ([ArmorTypeID], [ArmorType]) VALUES (2, N'Medium Armor')
GO
INSERT [dbo].[ArmorType] ([ArmorTypeID], [ArmorType]) VALUES (3, N'Heavy Armor')
GO
SET IDENTITY_INSERT [dbo].[ArmorType] OFF
GO
SET IDENTITY_INSERT [dbo].[CharterSheet] ON 
GO
INSERT [dbo].[CharterSheet] ([SheetID], [CharterName], [Race], [Description], [class]) VALUES (1, N'Kurg "Oathstriker" Ostineogugbu', 8, 1, 1)
GO
INSERT [dbo].[CharterSheet] ([SheetID], [CharterName], [Race], [Description], [class]) VALUES (2, N'Ared', 10, 2, 2)
GO
INSERT [dbo].[CharterSheet] ([SheetID], [CharterName], [Race], [Description], [class]) VALUES (3, N'asgard', 16, 3, 3)
GO
INSERT [dbo].[CharterSheet] ([SheetID], [CharterName], [Race], [Description], [class]) VALUES (4, N'Rularshend', 2, 4, 4)
GO
SET IDENTITY_INSERT [dbo].[CharterSheet] OFF
GO
SET IDENTITY_INSERT [dbo].[Class] ON 
GO
INSERT [dbo].[Class] ([ClassID], [ClassName], [Armor], [Weapon1], [Weapon2]) VALUES (1, N'Rogue', 1, 2, 18)
GO
INSERT [dbo].[Class] ([ClassID], [ClassName], [Armor], [Weapon1], [Weapon2]) VALUES (2, N'Barbarian', 2, 13, 15)
GO
INSERT [dbo].[Class] ([ClassID], [ClassName], [Armor], [Weapon1], [Weapon2]) VALUES (3, N'Cleric', 3, 16, 26)
GO
INSERT [dbo].[Class] ([ClassID], [ClassName], [Armor], [Weapon1], [Weapon2]) VALUES (4, N'Paladin', 4, 21, 12)
GO
SET IDENTITY_INSERT [dbo].[Class] OFF
GO
SET IDENTITY_INSERT [dbo].[DamageType] ON 
GO
INSERT [dbo].[DamageType] ([DamageTypeID], [TypeOfDamage]) VALUES (1, N'Magical')
GO
INSERT [dbo].[DamageType] ([DamageTypeID], [TypeOfDamage]) VALUES (2, N' Ranged')
GO
INSERT [dbo].[DamageType] ([DamageTypeID], [TypeOfDamage]) VALUES (3, N' Melee')
GO
SET IDENTITY_INSERT [dbo].[DamageType] OFF
GO
SET IDENTITY_INSERT [dbo].[Description] ON 
GO
INSERT [dbo].[Description] ([DescriptionID], [HairStyle], [HairColor], [EyeColor], [SkinType], [SkinColor]) VALUES (1, 1, N'White', N'Green', 1, N'Ray-Green')
GO
INSERT [dbo].[Description] ([DescriptionID], [HairStyle], [HairColor], [EyeColor], [SkinType], [SkinColor]) VALUES (2, 3, NULL, N'Green', 1, N'Light Ray-Green')
GO
INSERT [dbo].[Description] ([DescriptionID], [HairStyle], [HairColor], [EyeColor], [SkinType], [SkinColor]) VALUES (3, 2, N'Golden', N'Grey', 1, N'White')
GO
INSERT [dbo].[Description] ([DescriptionID], [HairStyle], [HairColor], [EyeColor], [SkinType], [SkinColor]) VALUES (4, 4, N'Red', N'Demon Red', 2, N'Black')
GO
SET IDENTITY_INSERT [dbo].[Description] OFF
GO
SET IDENTITY_INSERT [dbo].[HairStyle] ON 
GO
INSERT [dbo].[HairStyle] ([HairStyleID], [HairStyle]) VALUES (1, N'Short')
GO
INSERT [dbo].[HairStyle] ([HairStyleID], [HairStyle]) VALUES (2, N'Long')
GO
INSERT [dbo].[HairStyle] ([HairStyleID], [HairStyle]) VALUES (3, N'Bald')
GO
INSERT [dbo].[HairStyle] ([HairStyleID], [HairStyle]) VALUES (4, N'horns')
GO
SET IDENTITY_INSERT [dbo].[HairStyle] OFF
GO
SET IDENTITY_INSERT [dbo].[Race] ON 
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (1, N'Aarakocra')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (2, N'Dragonborn')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (3, N'Hill Dwarf')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (4, N'Mountain Dwarf')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (5, N'Eladrin Elf')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (6, N'High Elf')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (7, N'Wood Elf')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (8, N'Goliath')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (9, N'Half-Elf')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (10, N'Half-Orc')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (11, N'Lightfoot Halfling')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (12, N'Stout Halfling')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (13, N'Human')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (14, N'Genasi')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (15, N'Tiefling')
GO
INSERT [dbo].[Race] ([RaceID], [RaceName]) VALUES (16, N'Variant Aasimar')
GO
SET IDENTITY_INSERT [dbo].[Race] OFF
GO
SET IDENTITY_INSERT [dbo].[SkinType] ON 
GO
INSERT [dbo].[SkinType] ([TypeID], [SkinType]) VALUES (1, N'Skin')
GO
INSERT [dbo].[SkinType] ([TypeID], [SkinType]) VALUES (2, N'Scaled')
GO
INSERT [dbo].[SkinType] ([TypeID], [SkinType]) VALUES (3, N'Fur')
GO
SET IDENTITY_INSERT [dbo].[SkinType] OFF
GO
SET IDENTITY_INSERT [dbo].[Stat] ON 
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (1, 1, CAST(2.0 AS Decimal(3, 1)), CAST(12.0 AS Decimal(3, 1)), CAST(2.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (1, 2, CAST(0.0 AS Decimal(3, 1)), CAST(15.0 AS Decimal(3, 1)), CAST(2.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (1, 3, CAST(1.0 AS Decimal(3, 1)), CAST(13.0 AS Decimal(3, 1)), CAST(2.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (1, 4, CAST(0.0 AS Decimal(3, 1)), CAST(8.0 AS Decimal(3, 1)), CAST(-1.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (1, 5, CAST(0.0 AS Decimal(3, 1)), CAST(14.0 AS Decimal(3, 1)), CAST(12.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (1, 6, CAST(0.0 AS Decimal(3, 1)), CAST(10.0 AS Decimal(3, 1)), CAST(0.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (2, 1, CAST(2.0 AS Decimal(3, 1)), CAST(10.0 AS Decimal(3, 1)), CAST(1.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (2, 2, CAST(0.0 AS Decimal(3, 1)), CAST(17.0 AS Decimal(3, 1)), CAST(3.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (2, 3, CAST(1.0 AS Decimal(3, 1)), CAST(16.0 AS Decimal(3, 1)), CAST(3.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (2, 4, CAST(0.0 AS Decimal(3, 1)), CAST(13.0 AS Decimal(3, 1)), CAST(1.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (2, 5, CAST(0.0 AS Decimal(3, 1)), CAST(15.0 AS Decimal(3, 1)), CAST(2.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (2, 6, CAST(0.0 AS Decimal(3, 1)), CAST(6.0 AS Decimal(3, 1)), CAST(-2.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (3, 1, CAST(0.0 AS Decimal(3, 1)), CAST(13.0 AS Decimal(3, 1)), CAST(1.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (3, 2, CAST(0.0 AS Decimal(3, 1)), CAST(8.0 AS Decimal(3, 1)), CAST(-1.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (3, 3, CAST(0.0 AS Decimal(3, 1)), CAST(14.0 AS Decimal(3, 1)), CAST(2.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (3, 4, CAST(0.0 AS Decimal(3, 1)), CAST(10.0 AS Decimal(3, 1)), CAST(0.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (3, 5, CAST(1.0 AS Decimal(3, 1)), CAST(15.0 AS Decimal(3, 1)), CAST(3.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (3, 6, CAST(2.0 AS Decimal(3, 1)), CAST(12.0 AS Decimal(3, 1)), CAST(2.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (4, 1, CAST(2.0 AS Decimal(3, 1)), CAST(15.0 AS Decimal(3, 1)), CAST(3.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (4, 2, CAST(0.0 AS Decimal(3, 1)), CAST(10.0 AS Decimal(3, 1)), CAST(0.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (4, 3, CAST(0.0 AS Decimal(3, 1)), CAST(13.0 AS Decimal(3, 1)), CAST(1.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (4, 4, CAST(0.0 AS Decimal(3, 1)), CAST(8.0 AS Decimal(3, 1)), CAST(-1.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (4, 5, CAST(0.0 AS Decimal(3, 1)), CAST(12.0 AS Decimal(3, 1)), CAST(1.0 AS Decimal(3, 1)))
GO
INSERT [dbo].[Stat] ([StatsID], [StatsNum], [RacialBonus], [BaseScore], [Modifier]) VALUES (4, 6, CAST(1.0 AS Decimal(3, 1)), CAST(14.0 AS Decimal(3, 1)), CAST(2.0 AS Decimal(3, 1)))
GO
SET IDENTITY_INSERT [dbo].[Stat] OFF
GO
SET IDENTITY_INSERT [dbo].[StatName] ON 
GO
INSERT [dbo].[StatName] ([NameID], [StatName]) VALUES (1, N'Strength')
GO
INSERT [dbo].[StatName] ([NameID], [StatName]) VALUES (2, N'Dexterity')
GO
INSERT [dbo].[StatName] ([NameID], [StatName]) VALUES (3, N'Constitution')
GO
INSERT [dbo].[StatName] ([NameID], [StatName]) VALUES (4, N'Intelligence')
GO
INSERT [dbo].[StatName] ([NameID], [StatName]) VALUES (5, N'Wisdom')
GO
INSERT [dbo].[StatName] ([NameID], [StatName]) VALUES (6, N'Charisma')
GO
SET IDENTITY_INSERT [dbo].[StatName] OFF
GO
SET IDENTITY_INSERT [dbo].[Weapons] ON 
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (1, 1, N'Spells')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (2, 3, N'Club')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (3, 3, N'Dagger')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (4, 3, N'Greatclub')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (5, 3, N'Handaxe')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (6, 3, N'Javelin')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (7, 3, N'Light Hammer')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (8, 3, N'Mace')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (9, 3, N'Quarterstaff')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (10, 3, N'Sickle')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (11, 3, N'Spear')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (12, 3, N'Lance')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (13, 3, N'Greatsword')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (14, 3, N'Greataxe')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (15, 3, N'Battleaxe')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (16, 3, N'Morningstar')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (17, 3, N'Shortsword')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (18, 3, N'Rapier')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (19, 3, N'Scimitar')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (20, 3, N'Trident')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (21, 3, N'Warhammer')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (22, 3, N'Maul')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (23, 2, N'Crossbow, light')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (24, 2, N'Shortbow')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (25, 2, N'Sling')
GO
INSERT [dbo].[Weapons] ([WeaponsID], [DamageType], [WeaponName]) VALUES (26, 3, N'Shield')
GO
SET IDENTITY_INSERT [dbo].[Weapons] OFF
GO
ALTER TABLE [dbo].[Armor]  WITH CHECK ADD FOREIGN KEY([ArmorType])
REFERENCES [dbo].[ArmorType] ([ArmorTypeID])
GO
ALTER TABLE [dbo].[CharterSheet]  WITH CHECK ADD FOREIGN KEY([class])
REFERENCES [dbo].[Class] ([ClassID])
GO
ALTER TABLE [dbo].[CharterSheet]  WITH CHECK ADD FOREIGN KEY([Description])
REFERENCES [dbo].[Description] ([DescriptionID])
GO
ALTER TABLE [dbo].[CharterSheet]  WITH CHECK ADD FOREIGN KEY([Race])
REFERENCES [dbo].[Race] ([RaceID])
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD FOREIGN KEY([Armor])
REFERENCES [dbo].[Armor] ([ArmorID])
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD FOREIGN KEY([Weapon1])
REFERENCES [dbo].[Weapons] ([WeaponsID])
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD FOREIGN KEY([Weapon2])
REFERENCES [dbo].[Weapons] ([WeaponsID])
GO
ALTER TABLE [dbo].[Description]  WITH CHECK ADD FOREIGN KEY([HairStyle])
REFERENCES [dbo].[HairStyle] ([HairStyleID])
GO
ALTER TABLE [dbo].[Description]  WITH CHECK ADD FOREIGN KEY([SkinType])
REFERENCES [dbo].[SkinType] ([TypeID])
GO
ALTER TABLE [dbo].[Stat]  WITH CHECK ADD FOREIGN KEY([StatsID])
REFERENCES [dbo].[Description] ([DescriptionID])
GO
ALTER TABLE [dbo].[Stat]  WITH CHECK ADD FOREIGN KEY([StatsNum])
REFERENCES [dbo].[StatName] ([NameID])
GO
ALTER TABLE [dbo].[Weapons]  WITH CHECK ADD FOREIGN KEY([DamageType])
REFERENCES [dbo].[DamageType] ([DamageTypeID])
GO
USE [master]
GO
ALTER DATABASE [DnD2] SET  READ_WRITE 
GO
