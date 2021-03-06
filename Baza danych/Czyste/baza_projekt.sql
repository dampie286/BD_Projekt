USE [master]
GO
/****** Object:  Database [Baza_projekt]    Script Date: 17.01.2020 13:13:22 ******/
CREATE DATABASE [Baza_projekt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Baza_projekt_Data', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Baza_projekt.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Baza_projekt_Log', FILENAME = N'D:\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Baza_projekt.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Baza_projekt] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Baza_projekt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Baza_projekt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Baza_projekt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Baza_projekt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Baza_projekt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Baza_projekt] SET ARITHABORT OFF 
GO
ALTER DATABASE [Baza_projekt] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Baza_projekt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Baza_projekt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Baza_projekt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Baza_projekt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Baza_projekt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Baza_projekt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Baza_projekt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Baza_projekt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Baza_projekt] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Baza_projekt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Baza_projekt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Baza_projekt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Baza_projekt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Baza_projekt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Baza_projekt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Baza_projekt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Baza_projekt] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Baza_projekt] SET  MULTI_USER 
GO
ALTER DATABASE [Baza_projekt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Baza_projekt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Baza_projekt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Baza_projekt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Baza_projekt] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Baza_projekt] SET QUERY_STORE = OFF
GO
USE [Baza_projekt]
GO
/****** Object:  Table [dbo].[Care_serviceSet]    Script Date: 17.01.2020 13:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Care_serviceSet](
	[care_service_id] [int] IDENTITY(1,1) NOT NULL,
	[date_from] [datetime] NOT NULL,
	[data_to] [datetime] NULL,
	[price] [float] NOT NULL,
	[Care_care_id] [int] NOT NULL,
	[Company_company_id] [int] NOT NULL,
	[Service_service_id] [int] NOT NULL,
 CONSTRAINT [PK_Care_serviceSet] PRIMARY KEY CLUSTERED 
(
	[care_service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CareSet]    Script Date: 17.01.2020 13:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CareSet](
	[care_id] [int] IDENTITY(1,1) NOT NULL,
	[date_from] [datetime] NOT NULL,
	[date_to] [datetime] NULL,
	[Vehicle_vehicle_id] [int] NOT NULL,
	[Keeper_worker_id] [int] NOT NULL,
 CONSTRAINT [PK_CareSet] PRIMARY KEY CLUSTERED 
(
	[care_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Check_vehicleSet]    Script Date: 17.01.2020 13:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Check_vehicleSet](
	[check_id] [int] IDENTITY(1,1) NOT NULL,
	[tech_review] [datetime] NOT NULL,
	[oil_change] [datetime] NOT NULL,
	[oil_change_mileage] [int] NOT NULL,
	[timing_gear] [datetime] NOT NULL,
	[timing_gear_mileage] [int] NOT NULL,
	[Vehicle_vehicle_id] [int] NOT NULL,
 CONSTRAINT [PK_Check_vehicleSet] PRIMARY KEY CLUSTERED 
(
	[check_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanySet]    Script Date: 17.01.2020 13:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanySet](
	[company_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[address] [nvarchar](max) NOT NULL,
	[phone_nr] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CompanySet] PRIMARY KEY CLUSTERED 
(
	[company_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseSet]    Script Date: 17.01.2020 13:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseSet](
	[purchase_id] [int] IDENTITY(1,1) NOT NULL,
	[purchase_date] [datetime] NOT NULL,
	[mileage] [int] NULL,
	[litres] [float] NULL,
	[type] [nvarchar](max) NULL,
	[price] [float] NOT NULL,
	[Rent_rent_id] [int] NOT NULL,
 CONSTRAINT [PK_PurchaseSet] PRIMARY KEY CLUSTERED 
(
	[purchase_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentSet]    Script Date: 17.01.2020 13:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentSet](
	[rent_id] [int] IDENTITY(1,1) NOT NULL,
	[purpose] [nvarchar](max) NOT NULL,
	[date_from] [datetime] NOT NULL,
	[date_to] [datetime] NOT NULL,
	[mileage_start] [int] NOT NULL,
	[Worker_worker_id] [int] NOT NULL,
	[Reservation_reservation_id] [int] NOT NULL,
	[Vehicle_vehicle_id] [int] NOT NULL,
	[mileage_end] [int] NULL,
 CONSTRAINT [PK_RentSet] PRIMARY KEY CLUSTERED 
(
	[rent_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservationSet]    Script Date: 17.01.2020 13:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservationSet](
	[reservation_id] [int] IDENTITY(1,1) NOT NULL,
	[purpose] [nvarchar](max) NOT NULL,
	[date_from] [datetime] NOT NULL,
	[date_to] [datetime] NOT NULL,
	[Worker_worker_id] [int] NOT NULL,
	[Vehicle_vehicle_id] [int] NOT NULL,
 CONSTRAINT [PK_ReservationSet] PRIMARY KEY CLUSTERED 
(
	[reservation_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceSet]    Script Date: 17.01.2020 13:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceSet](
	[service_id] [int] IDENTITY(1,1) NOT NULL,
	[is_repair] [bit] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ServiceSet] PRIMARY KEY CLUSTERED 
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleSet]    Script Date: 17.01.2020 13:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleSet](
	[vehicle_id] [int] IDENTITY(1,1) NOT NULL,
	[brand] [nvarchar](max) NOT NULL,
	[model] [nvarchar](max) NOT NULL,
	[version] [nvarchar](max) NOT NULL,
	[equipment] [nvarchar](max) NOT NULL,
	[licence_plate] [nvarchar](max) NOT NULL,
	[avg_consumption] [float] NOT NULL,
	[fuel_type] [nvarchar](max) NOT NULL,
	[available] [nvarchar](max) NOT NULL,
	[mileage] [int] NULL,
 CONSTRAINT [PK_VehicleSet] PRIMARY KEY CLUSTERED 
(
	[vehicle_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkerSet]    Script Date: 17.01.2020 13:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkerSet](
	[worker_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[surname] [nvarchar](max) NOT NULL,
	[position] [nvarchar](max) NOT NULL,
	[PESEL] [nvarchar](max) NOT NULL,
	[date_of_birth] [datetime] NOT NULL,
	[password] [nvarchar](max) NOT NULL,
	[phone_nr] [nvarchar](max) NOT NULL,
	[city] [nvarchar](max) NULL,
	[city_code] [nvarchar](max) NULL,
	[street] [nvarchar](max) NULL,
	[house] [nvarchar](max) NULL,
 CONSTRAINT [PK_WorkerSet] PRIMARY KEY CLUSTERED 
(
	[worker_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkerSet_Keeper]    Script Date: 17.01.2020 13:13:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkerSet_Keeper](
	[keeper_id] [int] NOT NULL,
	[worker_id] [int] NOT NULL,
 CONSTRAINT [PK_WorkerSet_Keeper] PRIMARY KEY CLUSTERED 
(
	[worker_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Care_serviceCare]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Care_serviceCare] ON [dbo].[Care_serviceSet]
(
	[Care_care_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CompanyCare_service]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_CompanyCare_service] ON [dbo].[Care_serviceSet]
(
	[Company_company_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ServiceCare_service]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ServiceCare_service] ON [dbo].[Care_serviceSet]
(
	[Service_service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CareKeeper]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_CareKeeper] ON [dbo].[CareSet]
(
	[Keeper_worker_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_CareVehicle]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_CareVehicle] ON [dbo].[CareSet]
(
	[Vehicle_vehicle_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_Check_vehicleVehicle]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_Check_vehicleVehicle] ON [dbo].[Check_vehicleSet]
(
	[Vehicle_vehicle_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_RentPurchase]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_RentPurchase] ON [dbo].[PurchaseSet]
(
	[Rent_rent_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_RentVehicle]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_RentVehicle] ON [dbo].[RentSet]
(
	[Vehicle_vehicle_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ReservationRent]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ReservationRent] ON [dbo].[RentSet]
(
	[Reservation_reservation_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_WorkerRent]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_WorkerRent] ON [dbo].[RentSet]
(
	[Worker_worker_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_ReservationVehicle]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_ReservationVehicle] ON [dbo].[ReservationSet]
(
	[Vehicle_vehicle_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_FK_WorkerReservation]    Script Date: 17.01.2020 13:13:22 ******/
CREATE NONCLUSTERED INDEX [IX_FK_WorkerReservation] ON [dbo].[ReservationSet]
(
	[Worker_worker_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Care_serviceSet]  WITH CHECK ADD  CONSTRAINT [FK_Care_serviceCare] FOREIGN KEY([Care_care_id])
REFERENCES [dbo].[CareSet] ([care_id])
GO
ALTER TABLE [dbo].[Care_serviceSet] CHECK CONSTRAINT [FK_Care_serviceCare]
GO
ALTER TABLE [dbo].[Care_serviceSet]  WITH CHECK ADD  CONSTRAINT [FK_CompanyCare_service] FOREIGN KEY([Company_company_id])
REFERENCES [dbo].[CompanySet] ([company_id])
GO
ALTER TABLE [dbo].[Care_serviceSet] CHECK CONSTRAINT [FK_CompanyCare_service]
GO
ALTER TABLE [dbo].[Care_serviceSet]  WITH CHECK ADD  CONSTRAINT [FK_ServiceCare_service] FOREIGN KEY([Service_service_id])
REFERENCES [dbo].[ServiceSet] ([service_id])
GO
ALTER TABLE [dbo].[Care_serviceSet] CHECK CONSTRAINT [FK_ServiceCare_service]
GO
ALTER TABLE [dbo].[CareSet]  WITH CHECK ADD  CONSTRAINT [FK_CareKeeper] FOREIGN KEY([Keeper_worker_id])
REFERENCES [dbo].[WorkerSet_Keeper] ([worker_id])
GO
ALTER TABLE [dbo].[CareSet] CHECK CONSTRAINT [FK_CareKeeper]
GO
ALTER TABLE [dbo].[CareSet]  WITH CHECK ADD  CONSTRAINT [FK_CareVehicle] FOREIGN KEY([Vehicle_vehicle_id])
REFERENCES [dbo].[VehicleSet] ([vehicle_id])
GO
ALTER TABLE [dbo].[CareSet] CHECK CONSTRAINT [FK_CareVehicle]
GO
ALTER TABLE [dbo].[Check_vehicleSet]  WITH CHECK ADD  CONSTRAINT [FK_Check_vehicleVehicle] FOREIGN KEY([Vehicle_vehicle_id])
REFERENCES [dbo].[VehicleSet] ([vehicle_id])
GO
ALTER TABLE [dbo].[Check_vehicleSet] CHECK CONSTRAINT [FK_Check_vehicleVehicle]
GO
ALTER TABLE [dbo].[PurchaseSet]  WITH CHECK ADD  CONSTRAINT [FK_RentPurchase] FOREIGN KEY([Rent_rent_id])
REFERENCES [dbo].[RentSet] ([rent_id])
GO
ALTER TABLE [dbo].[PurchaseSet] CHECK CONSTRAINT [FK_RentPurchase]
GO
ALTER TABLE [dbo].[RentSet]  WITH CHECK ADD  CONSTRAINT [FK_RentVehicle] FOREIGN KEY([Vehicle_vehicle_id])
REFERENCES [dbo].[VehicleSet] ([vehicle_id])
GO
ALTER TABLE [dbo].[RentSet] CHECK CONSTRAINT [FK_RentVehicle]
GO
ALTER TABLE [dbo].[RentSet]  WITH CHECK ADD  CONSTRAINT [FK_ReservationRent] FOREIGN KEY([Reservation_reservation_id])
REFERENCES [dbo].[ReservationSet] ([reservation_id])
GO
ALTER TABLE [dbo].[RentSet] CHECK CONSTRAINT [FK_ReservationRent]
GO
ALTER TABLE [dbo].[RentSet]  WITH CHECK ADD  CONSTRAINT [FK_WorkerRent] FOREIGN KEY([Worker_worker_id])
REFERENCES [dbo].[WorkerSet] ([worker_id])
GO
ALTER TABLE [dbo].[RentSet] CHECK CONSTRAINT [FK_WorkerRent]
GO
ALTER TABLE [dbo].[ReservationSet]  WITH CHECK ADD  CONSTRAINT [FK_ReservationVehicle] FOREIGN KEY([Vehicle_vehicle_id])
REFERENCES [dbo].[VehicleSet] ([vehicle_id])
GO
ALTER TABLE [dbo].[ReservationSet] CHECK CONSTRAINT [FK_ReservationVehicle]
GO
ALTER TABLE [dbo].[ReservationSet]  WITH CHECK ADD  CONSTRAINT [FK_WorkerReservation] FOREIGN KEY([Worker_worker_id])
REFERENCES [dbo].[WorkerSet] ([worker_id])
GO
ALTER TABLE [dbo].[ReservationSet] CHECK CONSTRAINT [FK_WorkerReservation]
GO
ALTER TABLE [dbo].[WorkerSet_Keeper]  WITH CHECK ADD  CONSTRAINT [FK_Keeper_inherits_Worker] FOREIGN KEY([worker_id])
REFERENCES [dbo].[WorkerSet] ([worker_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[WorkerSet_Keeper] CHECK CONSTRAINT [FK_Keeper_inherits_Worker]
GO
USE [master]
GO
ALTER DATABASE [Baza_projekt] SET  READ_WRITE 
GO
