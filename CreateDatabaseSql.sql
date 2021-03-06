USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 15/06/22 7:49:33 PM ******/
CREATE DATABASE [QLTV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLTV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLTV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\QLTV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLTV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLTV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QLTV] SET QUERY_STORE = OFF
GO
USE [QLTV]
GO
/****** Object:  Table [dbo].[Muon]    Script Date: 15/06/22 7:49:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muon](
	[maSV] [varchar](10) NOT NULL,
	[maSach] [varchar](10) NOT NULL,
	[maNV] [varchar](10) NULL,
	[ngayMuon] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[maSach] ASC,
	[maSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 15/06/22 7:49:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNV] [varchar](10) NOT NULL,
	[tenNV] [nvarchar](32) NULL,
	[sdt] [varchar](10) NULL,
	[quyen] [int] NULL,
	[pathImg] [char](32) NULL,
PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 15/06/22 7:49:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[maNXB] [varchar](10) NOT NULL,
	[tenNXB] [nvarchar](32) NULL,
	[diachi] [nvarchar](50) NULL,
	[sdt] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[maNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 15/06/22 7:49:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[maSach] [varchar](10) NOT NULL,
	[tenSach] [nvarchar](32) NULL,
	[sl] [int] NULL,
	[tenTG] [nvarchar](32) NULL,
	[maTL] [varchar](10) NULL,
	[maNXB] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 15/06/22 7:49:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[maSV] [varchar](10) NOT NULL,
	[tenSV] [nvarchar](32) NULL,
PRIMARY KEY CLUSTERED 
(
	[maSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 15/06/22 7:49:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[taiKhoan] [varchar](20) NOT NULL,
	[matKhau] [varchar](20) NOT NULL,
	[maNV] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[taiKhoan] ASC,
	[matKhau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 15/06/22 7:49:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[maTL] [varchar](10) NOT NULL,
	[tenTL] [nvarchar](32) NULL,
	[vitri] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[maTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tra]    Script Date: 15/06/22 7:49:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tra](
	[maSV] [varchar](10) NOT NULL,
	[maSach] [varchar](10) NOT NULL,
	[maNV] [varchar](10) NULL,
	[ngayMuon] [date] NULL,
	[ngayTra] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[maSach] ASC,
	[maSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Muon] ([maSV], [maSach], [maNV], [ngayMuon]) VALUES (N'20110632', N'CS02', N'NV01', CAST(N'2022-05-29' AS Date))
INSERT [dbo].[Muon] ([maSV], [maSach], [maNV], [ngayMuon]) VALUES (N'20110630', N'CS03', N'NV01', CAST(N'2022-05-29' AS Date))
INSERT [dbo].[Muon] ([maSV], [maSach], [maNV], [ngayMuon]) VALUES (N'20110630', N'CS04', N'NV01', CAST(N'2022-06-10' AS Date))
INSERT [dbo].[Muon] ([maSV], [maSach], [maNV], [ngayMuon]) VALUES (N'20110630', N'LT02', N'NV01', CAST(N'2022-05-29' AS Date))
INSERT [dbo].[Muon] ([maSV], [maSach], [maNV], [ngayMuon]) VALUES (N'20110632', N'LT04', N'NV01', CAST(N'2022-05-30' AS Date))
GO
INSERT [dbo].[NhanVien] ([maNV], [tenNV], [sdt], [quyen], [pathImg]) VALUES (N'NV01', N'Nguyễn Hữu Đạt', N'0397926273', 0, N'Dat.jpg                         ')
INSERT [dbo].[NhanVien] ([maNV], [tenNV], [sdt], [quyen], [pathImg]) VALUES (N'NV02', N'Nguyễn Duy Đăng', N'', 0, NULL)
INSERT [dbo].[NhanVien] ([maNV], [tenNV], [sdt], [quyen], [pathImg]) VALUES (N'NV03', N'Nguyễn Duy Đăng', N'', 1, NULL)
INSERT [dbo].[NhanVien] ([maNV], [tenNV], [sdt], [quyen], [pathImg]) VALUES (N'NV06', N'', N'', 1, NULL)
GO
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diachi], [sdt]) VALUES (N'Default', N'Chưa có NXB', NULL, NULL)
INSERT [dbo].[NXB] ([maNXB], [tenNXB], [diachi], [sdt]) VALUES (N'NXB01', N'Đụng đâu làm đó', N'Thủ Đức', N'0397926273')
GO
INSERT [dbo].[Sach] ([maSach], [tenSach], [sl], [tenTG], [maTL], [maNXB]) VALUES (N'CS01', N'Chủ nghĩa tối giản', 10, N'Chi Nguyễn', N'CS', N'NXB01')
INSERT [dbo].[Sach] ([maSach], [tenSach], [sl], [tenTG], [maTL], [maNXB]) VALUES (N'CS02', N'Sống một đời ý nghĩa', 12, N'Chưa biết', N'CS', N'NXB01')
INSERT [dbo].[Sach] ([maSach], [tenSach], [sl], [tenTG], [maTL], [maNXB]) VALUES (N'CS03', N'Đắc nhân tâm', 6, N'Chi Nguyễn', N'CS', N'NXB01')
INSERT [dbo].[Sach] ([maSach], [tenSach], [sl], [tenTG], [maTL], [maNXB]) VALUES (N'CS04', N'VietNam', 2, N'NHD', N'CS', N'NXB01')
INSERT [dbo].[Sach] ([maSach], [tenSach], [sl], [tenTG], [maTL], [maNXB]) VALUES (N'CS05', N'Cuộc sống của nhiệm màu', 10, N'Nguyễn Hữu Đạt', N'CS', N'NXB01')
INSERT [dbo].[Sach] ([maSach], [tenSach], [sl], [tenTG], [maTL], [maNXB]) VALUES (N'LT01', N'Lập trình và cuộc sống', 0, N'Jeff Atwood', N'LT', N'NXB01')
INSERT [dbo].[Sach] ([maSach], [tenSach], [sl], [tenTG], [maTL], [maNXB]) VALUES (N'LT02', N'Code dạo kỹ sư', 15, N'Phạm Huy Hoàng', N'LT', N'NXB01')
INSERT [dbo].[Sach] ([maSach], [tenSach], [sl], [tenTG], [maTL], [maNXB]) VALUES (N'LT03', N'Lập trình C#', 6, N'No1', N'LT', N'NXB01')
INSERT [dbo].[Sach] ([maSach], [tenSach], [sl], [tenTG], [maTL], [maNXB]) VALUES (N'LT04', N'Lập trình Basic', 13, N'Nguyễn Văn A', N'LT', N'NXB01')
INSERT [dbo].[Sach] ([maSach], [tenSach], [sl], [tenTG], [maTL], [maNXB]) VALUES (N'LT05', N'Có không giữ mất kiếm chi', 10, N'Nguyễn Đạt', N'CS', N'NXB01')
GO
INSERT [dbo].[SinhVien] ([maSV], [tenSV]) VALUES (N'20110630', N'Nguyễn Hữu Đạt')
INSERT [dbo].[SinhVien] ([maSV], [tenSV]) VALUES (N'20110632', N'Nguyễn Duy Đăng')
GO
INSERT [dbo].[TaiKhoan] ([taiKhoan], [matKhau], [maNV]) VALUES (N'nguyendat', N'123456', N'NV01')
INSERT [dbo].[TaiKhoan] ([taiKhoan], [matKhau], [maNV]) VALUES (N'dangml', N'1', N'NV02')
INSERT [dbo].[TaiKhoan] ([taiKhoan], [matKhau], [maNV]) VALUES (N'user', N'1', N'NV03')
GO
INSERT [dbo].[TheLoai] ([maTL], [tenTL], [vitri]) VALUES (N'CS', N'Cuộc sống', N'KV1 kệ 5')
INSERT [dbo].[TheLoai] ([maTL], [tenTL], [vitri]) VALUES (N'Default', N'Not found', N'Not found')
INSERT [dbo].[TheLoai] ([maTL], [tenTL], [vitri]) VALUES (N'LT', N'Lập trình', N'KV2 kệ 2')
INSERT [dbo].[TheLoai] ([maTL], [tenTL], [vitri]) VALUES (N'TT', N'Thực Tập', N'KV1 Kệ 2')
GO
INSERT [dbo].[Tra] ([maSV], [maSach], [maNV], [ngayMuon], [ngayTra]) VALUES (N'20110630', N'CS01', N'NV01', CAST(N'2022-06-10' AS Date), CAST(N'2022-06-10' AS Date))
INSERT [dbo].[Tra] ([maSV], [maSach], [maNV], [ngayMuon], [ngayTra]) VALUES (N'20110630', N'CS02', N'NV01', CAST(N'2022-06-10' AS Date), CAST(N'2022-06-10' AS Date))
INSERT [dbo].[Tra] ([maSV], [maSach], [maNV], [ngayMuon], [ngayTra]) VALUES (N'20110630', N'CS03', N'NV01', CAST(N'2022-05-29' AS Date), CAST(N'2022-05-29' AS Date))
INSERT [dbo].[Tra] ([maSV], [maSach], [maNV], [ngayMuon], [ngayTra]) VALUES (N'20110630', N'CS04', N'NV01', CAST(N'2022-06-02' AS Date), CAST(N'2022-06-03' AS Date))
INSERT [dbo].[Tra] ([maSV], [maSach], [maNV], [ngayMuon], [ngayTra]) VALUES (N'20110632', N'LT02', N'NV01', CAST(N'2022-05-30' AS Date), CAST(N'2022-05-30' AS Date))
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TaiKhoan__7A3EC7D43F6FFE25]    Script Date: 15/06/22 7:49:33 PM ******/
ALTER TABLE [dbo].[TaiKhoan] ADD UNIQUE NONCLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TaiKhoan__B4C453189E6ACE64]    Script Date: 15/06/22 7:49:33 PM ******/
ALTER TABLE [dbo].[TaiKhoan] ADD UNIQUE NONCLUSTERED 
(
	[taiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NhanVien] ADD  DEFAULT ((1)) FOR [quyen]
GO
ALTER TABLE [dbo].[Sach] ADD  DEFAULT ((1)) FOR [sl]
GO
ALTER TABLE [dbo].[Muon]  WITH CHECK ADD FOREIGN KEY([maNV])
REFERENCES [dbo].[NhanVien] ([maNV])
GO
ALTER TABLE [dbo].[Muon]  WITH CHECK ADD FOREIGN KEY([maSach])
REFERENCES [dbo].[Sach] ([maSach])
GO
ALTER TABLE [dbo].[Muon]  WITH CHECK ADD FOREIGN KEY([maSV])
REFERENCES [dbo].[SinhVien] ([maSV])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([maNXB])
REFERENCES [dbo].[NXB] ([maNXB])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD FOREIGN KEY([maTL])
REFERENCES [dbo].[TheLoai] ([maTL])
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD FOREIGN KEY([maNV])
REFERENCES [dbo].[NhanVien] ([maNV])
GO
ALTER TABLE [dbo].[Tra]  WITH CHECK ADD FOREIGN KEY([maNV])
REFERENCES [dbo].[NhanVien] ([maNV])
GO
ALTER TABLE [dbo].[Tra]  WITH CHECK ADD FOREIGN KEY([maSach])
REFERENCES [dbo].[Sach] ([maSach])
GO
ALTER TABLE [dbo].[Tra]  WITH CHECK ADD FOREIGN KEY([maSV])
REFERENCES [dbo].[SinhVien] ([maSV])
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
