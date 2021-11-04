USE [master]
GO
/****** Object:  Database [OkulDb]    Script Date: 4.11.2021 20:58:17 ******/
CREATE DATABASE [OkulDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OkulDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\OkulDb.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OkulDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\OkulDb_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OkulDb] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OkulDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OkulDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OkulDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OkulDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OkulDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OkulDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [OkulDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OkulDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OkulDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OkulDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OkulDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OkulDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OkulDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OkulDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OkulDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OkulDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [OkulDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OkulDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OkulDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OkulDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OkulDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OkulDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OkulDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OkulDb] SET RECOVERY FULL 
GO
ALTER DATABASE [OkulDb] SET  MULTI_USER 
GO
ALTER DATABASE [OkulDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OkulDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OkulDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OkulDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [OkulDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'OkulDb', N'ON'
GO
USE [OkulDb]
GO
/****** Object:  Table [dbo].[tblBolumler]    Script Date: 4.11.2021 20:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBolumler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BolumAdi] [nchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblOgrenciler]    Script Date: 4.11.2021 20:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOgrenciler](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nchar](50) NULL,
	[Soyadi] [nchar](50) NULL,
	[OgrNo] [nchar](10) NULL,
	[TcNo] [nchar](11) NULL,
	[Dtarihi] [datetime] NULL,
	[BolumId] [int] NULL,
	[SehirId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblSehirler]    Script Date: 4.11.2021 20:58:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSehirler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sehir] [nvarchar](255) NULL,
 CONSTRAINT [PK_tblSehirler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tblBolumler] ON 

INSERT [dbo].[tblBolumler] ([Id], [BolumAdi]) VALUES (1, N'Bilgisayar                                        ')
INSERT [dbo].[tblBolumler] ([Id], [BolumAdi]) VALUES (2, N'Elektrik                                          ')
INSERT [dbo].[tblBolumler] ([Id], [BolumAdi]) VALUES (3, N'Elektronik                                        ')
INSERT [dbo].[tblBolumler] ([Id], [BolumAdi]) VALUES (4, N'Matematik                                         ')
INSERT [dbo].[tblBolumler] ([Id], [BolumAdi]) VALUES (5, N'Yazılım                                           ')
INSERT [dbo].[tblBolumler] ([Id], [BolumAdi]) VALUES (6, N'YBS                                               ')
INSERT [dbo].[tblBolumler] ([Id], [BolumAdi]) VALUES (7, N'İşletme                                           ')
INSERT [dbo].[tblBolumler] ([Id], [BolumAdi]) VALUES (8, N'İktisat                                           ')
INSERT [dbo].[tblBolumler] ([Id], [BolumAdi]) VALUES (9, N'Edebiyat                                          ')
INSERT [dbo].[tblBolumler] ([Id], [BolumAdi]) VALUES (10, N'İstatistik                                        ')
INSERT [dbo].[tblBolumler] ([Id], [BolumAdi]) VALUES (11, N'aaa                                               ')
SET IDENTITY_INSERT [dbo].[tblBolumler] OFF
SET IDENTITY_INSERT [dbo].[tblSehirler] ON 

INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (1, N'ADANA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (2, N'ADIYAMAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (3, N'AFYON')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (4, N'AĞRI')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (5, N'AMASYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (6, N'ANKARA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (7, N'ANTALYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (8, N'ARTVİN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (9, N'AYDIN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (10, N'BALIKESİR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (11, N'BİLECİK')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (12, N'BİNGÖL')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (13, N'BİTLİS')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (14, N'BOLU')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (15, N'BURDUR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (16, N'BURSA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (17, N'ÇANAKKALE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (18, N'ÇANKIRI')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (19, N'ÇORUM')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (20, N'DENİZLİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (21, N'DİYARBAKIR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (22, N'EDİRNE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (23, N'ELAZIĞ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (24, N'ERZİNCAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (25, N'ERZURUM')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (26, N'ESKİŞEHİR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (27, N'GAZİANTEP')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (28, N'GİRESUN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (29, N'GÜMÜŞHANE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (30, N'HAKKARİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (31, N'HATAY')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (32, N'ISPARTA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (33, N'İÇEL')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (34, N'İSTANBUL')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (35, N'İZMİR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (36, N'KARS')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (37, N'KASTAMONU')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (38, N'KAYSERİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (39, N'KIRKLARELİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (40, N'KIRŞEHİR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (41, N'KOCAELİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (42, N'KONYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (43, N'KÜTAHYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (44, N'MALATYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (45, N'MANİSA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (46, N'KAHRAMANMARAŞ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (47, N'MARDİN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (48, N'MUĞLA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (49, N'MUŞ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (50, N'NEVŞEHİR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (51, N'NİĞDE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (52, N'ORDU')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (53, N'RİZE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (54, N'SAKARYA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (55, N'SAMSUN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (56, N'SİİRT')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (57, N'SİNOP')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (58, N'SİVAS')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (59, N'TEKİRDAĞ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (60, N'TOKAT')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (61, N'TRABZON')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (62, N'TUNCELİ')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (63, N'ŞANLIURFA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (64, N'UŞAK')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (65, N'VAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (66, N'YOZGAT')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (67, N'ZONGULDAK')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (68, N'AKSARAY')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (69, N'BAYBURT')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (70, N'KARAMAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (71, N'KIRIKKALE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (72, N'BATMAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (73, N'ŞIRNAK')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (74, N'BARTIN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (75, N'ARDAHAN')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (76, N'IĞDIR')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (77, N'YALOVA')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (78, N'KARABÜK')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (79, N'KİLİS')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (80, N'OSMANİYE')
INSERT [dbo].[tblSehirler] ([id], [sehir]) VALUES (81, N'DÜZCE')
SET IDENTITY_INSERT [dbo].[tblSehirler] OFF
ALTER TABLE [dbo].[tblOgrenciler]  WITH CHECK ADD  CONSTRAINT [FK_tblOgrenciler_TotblBolumler] FOREIGN KEY([BolumId])
REFERENCES [dbo].[tblBolumler] ([Id])
GO
ALTER TABLE [dbo].[tblOgrenciler] CHECK CONSTRAINT [FK_tblOgrenciler_TotblBolumler]
GO
ALTER TABLE [dbo].[tblOgrenciler]  WITH CHECK ADD  CONSTRAINT [FK_tblOgrenciler_TotblSehirler] FOREIGN KEY([SehirId])
REFERENCES [dbo].[tblSehirler] ([id])
GO
ALTER TABLE [dbo].[tblOgrenciler] CHECK CONSTRAINT [FK_tblOgrenciler_TotblSehirler]
GO
USE [master]
GO
ALTER DATABASE [OkulDb] SET  READ_WRITE 
GO
