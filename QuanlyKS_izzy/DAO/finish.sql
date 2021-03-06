USE [master]
GO
/****** Object:  Database [quanlykhachsan]    Script Date: 05/30/2016 15:59:13 ******/
CREATE DATABASE [quanlykhachsan] ON  PRIMARY 
( NAME = N'quanlykhachsan', FILENAME = N'E:\Cosodulieu\QuanlyKS_izzy\quanlykhachsan.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'quanlykhachsan_log', FILENAME = N'E:\Cosodulieu\QuanlyKS_izzy\quanlykhachsan_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [quanlykhachsan] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [quanlykhachsan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [quanlykhachsan] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [quanlykhachsan] SET ANSI_NULLS OFF
GO
ALTER DATABASE [quanlykhachsan] SET ANSI_PADDING OFF
GO
ALTER DATABASE [quanlykhachsan] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [quanlykhachsan] SET ARITHABORT OFF
GO
ALTER DATABASE [quanlykhachsan] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [quanlykhachsan] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [quanlykhachsan] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [quanlykhachsan] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [quanlykhachsan] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [quanlykhachsan] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [quanlykhachsan] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [quanlykhachsan] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [quanlykhachsan] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [quanlykhachsan] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [quanlykhachsan] SET  DISABLE_BROKER
GO
ALTER DATABASE [quanlykhachsan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [quanlykhachsan] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [quanlykhachsan] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [quanlykhachsan] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [quanlykhachsan] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [quanlykhachsan] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [quanlykhachsan] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [quanlykhachsan] SET  READ_WRITE
GO
ALTER DATABASE [quanlykhachsan] SET RECOVERY FULL
GO
ALTER DATABASE [quanlykhachsan] SET  MULTI_USER
GO
ALTER DATABASE [quanlykhachsan] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [quanlykhachsan] SET DB_CHAINING OFF
GO
USE [quanlykhachsan]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDichVu] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [nvarchar](50) NULL,
	[Gia] [varchar](10) NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DICHVU] ON
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [Gia]) VALUES (1, N'Giặt ủi', N'100000')
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [Gia]) VALUES (2, N'Nước khoáng', N'10000')
SET IDENTITY_INSERT [dbo].[DICHVU] OFF
/****** Object:  Table [dbo].[THAYDOIQUYDINH]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THAYDOIQUYDINH](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenThayDoi] [varchar](15) NULL,
	[NoiDungThayDoi] [nvarchar](200) NULL,
	[NgayThayDoi] [date] NULL,
 CONSTRAINT [PK_THAYDOIQUYDINH] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[SoCMND] [char](9) NULL,
	[NgayVaoLam] [date] NULL,
	[LoaiNhanVien] [int] NULL,
	[GioiTinh] [bit] NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[MaLoaiPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiPhong] [nchar](10) NULL,
 CONSTRAINT [PK_LOAIPHONG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiPhong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LOAIPHONG] ON
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (1, N'Đơn       ')
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (2, N'Đôi       ')
INSERT [dbo].[LOAIPHONG] ([MaLoaiPhong], [TenLoaiPhong]) VALUES (3, N'Vip       ')
SET IDENTITY_INSERT [dbo].[LOAIPHONG] OFF
/****** Object:  Table [dbo].[LOAINHANVIEN]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAINHANVIEN](
	[MaLoaiNV] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiNhanVien] [nvarchar](20) NULL,
 CONSTRAINT [PK_LOAINHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LOAINHANVIEN] ON
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNV], [TenLoaiNhanVien]) VALUES (1, N'Admin')
SET IDENTITY_INSERT [dbo].[LOAINHANVIEN] OFF
/****** Object:  Table [dbo].[LOAIKHACHHANG]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIKHACHHANG](
	[MaLoaiKH] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIKHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaLoaiKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LOAIKHACHHANG] ON
INSERT [dbo].[LOAIKHACHHANG] ([MaLoaiKH], [TenLoaiKH]) VALUES (1, N'Nội Địa')
INSERT [dbo].[LOAIKHACHHANG] ([MaLoaiKH], [TenLoaiKH]) VALUES (2, N'Quốc Tế')
SET IDENTITY_INSERT [dbo].[LOAIKHACHHANG] OFF
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [int] IDENTITY(1,1) NOT NULL,
	[TenKH] [nvarchar](50) NOT NULL,
	[GioiTinh] [int] NOT NULL,
	[SoCMND] [char](9) NULL,
	[LoaiKHID] [int] NOT NULL,
	[SoDienThoai] [varchar](11) NULL,
	[Email] [varchar](50) NULL,
	[DiemThuong] [decimal](18, 0) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (1, N'Nam', 1, N'024924085', 1, N'01234567891', N'kiemsi789@yahoo.com', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (2, N'Bảo', 0, N'024924087', 1, N'01234567891', N'kiemsi456@yahoo.com', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (3, N'Nam', 1, N'024924088', 1, N'01234567891', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (4, N'Nam2', 1, N'024924088', 1, N'01234567891', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (5, N'Nam', 1, N'024924088', 1, N'01234567891', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (6, N'Nam4', 1, N'024924088', 1, N'01234567891', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (7, N'Nam5', 1, N'024924088', 1, N'01234567891', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (8, N'Nam6', 1, N'024924088', 1, N'01234567891', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (9, N'Nam7', 1, N'024924088', 1, N'01234567891', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (10, N'Nam8', 1, N'024924088', 1, N'01234567891', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (11, N'Nam9', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (12, N'Nam10', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (13, N'Nam11', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (14, N'Nam12', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (15, N'Nam13', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (16, N'Nam14', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (17, N'Nam15', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (18, N'Nam16', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (19, N'Nam', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (20, N'Nam', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (21, N'Nam', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (22, N'Nam', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (23, N'Ban', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (24, N'abc1', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (25, N'abc2', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (26, N'abc3', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (27, N'Nam09', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (29, N'Nam10', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (30, N'Nam11', 1, N'024924088', 1, N'01234567892', N'', CAST(0 AS Decimal(18, 0)))
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [GioiTinh], [SoCMND], [LoaiKHID], [SoDienThoai], [Email], [DiemThuong]) VALUES (31, N'Nam Tét', 1, N'024924087', 1, N'01234567891', N'', CAST(0 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MaTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nchar](50) NULL,
	[SoCMND] [char](9) NULL,
	[NgayVaoLam] [date] NULL,
	[NgaySinh] [date] NULL,
	[email] [varchar](50) NULL,
	[SoDienThoai] [varchar](11) NULL,
	[Username] [varchar](20) NULL,
	[PassWord] [varchar](50) NULL,
	[LoaiTaiKhoan] [int] NULL,
	[Active] [bit] NULL,
	[Deleted] [bit] NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[TAIKHOAN] ON
INSERT [dbo].[TAIKHOAN] ([MaTaiKhoan], [HoTen], [SoCMND], [NgayVaoLam], [NgaySinh], [email], [SoDienThoai], [Username], [PassWord], [LoaiTaiKhoan], [Active], [Deleted]) VALUES (2, N'admin                                             ', N'1        ', CAST(0xDB3A0B00 AS Date), CAST(0x07240B00 AS Date), N'abc@yahoo.com', N'01234567891', N'admin', N'21232f297a57a5a743894a0e4a801fc3', 1, 1, 0)
SET IDENTITY_INSERT [dbo].[TAIKHOAN] OFF
/****** Object:  Table [dbo].[PHONG]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHONG](
	[MaPhong] [int] IDENTITY(1,1) NOT NULL,
	[TenPhong] [varchar](5) NULL,
	[Tang] [int] NULL,
	[TinhTrangPhong] [int] NULL,
	[LoaiPhong] [int] NULL,
	[MoTaPhong] [nvarchar](200) NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PHONG] ON
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [Tang], [TinhTrangPhong], [LoaiPhong], [MoTaPhong]) VALUES (2, N'P1001', 1, -1, 1, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [Tang], [TinhTrangPhong], [LoaiPhong], [MoTaPhong]) VALUES (3, N'P1002', 1, 1, 1, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [Tang], [TinhTrangPhong], [LoaiPhong], [MoTaPhong]) VALUES (4, N'P1003', 1, -1, 2, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [Tang], [TinhTrangPhong], [LoaiPhong], [MoTaPhong]) VALUES (5, N'P2001', 2, 1, 3, NULL)
INSERT [dbo].[PHONG] ([MaPhong], [TenPhong], [Tang], [TinhTrangPhong], [LoaiPhong], [MoTaPhong]) VALUES (6, N'P2002', 2, 0, 2, N'Đặt Từ 12-13h')
SET IDENTITY_INSERT [dbo].[PHONG] OFF
/****** Object:  Table [dbo].[PHIEUTHUE]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUTHUE](
	[MaPhieuThue] [int] IDENTITY(1,1) NOT NULL,
	[TenPhieuThue] [nvarchar](50) NULL,
	[TinhTrangPhieuThue] [varchar](20) NULL,
	[MaPhong] [int] NULL,
	[NgayLap] [datetime] NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[MaKH] [int] NULL,
 CONSTRAINT [PK_PHIEUTHUE] PRIMARY KEY CLUSTERED 
(
	[MaPhieuThue] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PHIEUTHUE] ON
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (8, N'Phiếu Thuê Phòng P1001', N'-1', 2, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 1)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (10, N'Phiếu Thuê Phòng DevExpress.XtraEditors.TextEdit', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 7)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (11, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 9)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (12, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 10)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (13, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 11)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (14, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 12)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (15, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 13)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (16, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 14)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (17, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 15)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (18, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 16)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (19, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 18)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (20, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 19)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (21, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 20)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (22, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 21)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (23, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 22)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (24, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 23)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (25, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 24)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (26, N'Phiếu Thuê Phòng P1002', N'-1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 25)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (27, N'Phiếu Thuê Phòng P1002', N'2', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6D3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 26)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (31, N'Phiếu Thuê Phòng P1002', N'1', 3, CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), CAST(0x6C3B0B00 AS Date), 30)
INSERT [dbo].[PHIEUTHUE] ([MaPhieuThue], [TenPhieuThue], [TinhTrangPhieuThue], [MaPhong], [NgayLap], [NgayBatDau], [NgayKetThuc], [MaKH]) VALUES (32, N'Phiếu Thuê Phòng P1001', N'2', 2, CAST(0x6E3B0B00 AS Date), CAST(0x6E3B0B00 AS Date), CAST(0x6E3B0B00 AS Date), 31)
SET IDENTITY_INSERT [dbo].[PHIEUTHUE] OFF
/****** Object:  Table [dbo].[HOADON]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [date] NULL,
	[TongGia] [varchar](10) NULL,
	[NhanVien] [int] NULL,
	[Phong] [int] NULL,
	[MaPhieuThue] [int] NULL,
	[TinhTrang] [int] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[HOADON] ON
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLap], [TongGia], [NhanVien], [Phong], [MaPhieuThue], [TinhTrang]) VALUES (12, CAST(0x6C3B0B00 AS Date), N'100000', 2, 3, 27, 2)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLap], [TongGia], [NhanVien], [Phong], [MaPhieuThue], [TinhTrang]) VALUES (16, CAST(0x6C3B0B00 AS Date), N'0', 2, 3, 31, 1)
INSERT [dbo].[HOADON] ([MaHoaDon], [NgayLap], [TongGia], [NhanVien], [Phong], [MaPhieuThue], [TinhTrang]) VALUES (17, CAST(0x6E3B0B00 AS Date), N'110000', 2, 2, 32, 2)
SET IDENTITY_INSERT [dbo].[HOADON] OFF
/****** Object:  Table [dbo].[CHITIETHOADON]    Script Date: 05/30/2016 15:59:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHOADON](
	[UUID] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [int] NOT NULL,
	[MaDichVu] [int] NULL,
	[NgaySuDung] [date] NULL,
	[Phong] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] ON
INSERT [dbo].[CHITIETHOADON] ([UUID], [MaHD], [MaDichVu], [NgaySuDung], [Phong]) VALUES (5, 12, 2, CAST(0x6C3B0B00 AS Date), 3)
INSERT [dbo].[CHITIETHOADON] ([UUID], [MaHD], [MaDichVu], [NgaySuDung], [Phong]) VALUES (2, 12, 1, CAST(0x6C3B0B00 AS Date), 3)
INSERT [dbo].[CHITIETHOADON] ([UUID], [MaHD], [MaDichVu], [NgaySuDung], [Phong]) VALUES (6, 16, 1, CAST(0x6E3B0B00 AS Date), 3)
INSERT [dbo].[CHITIETHOADON] ([UUID], [MaHD], [MaDichVu], [NgaySuDung], [Phong]) VALUES (10, 16, 2, CAST(0x6E3B0B00 AS Date), 3)
INSERT [dbo].[CHITIETHOADON] ([UUID], [MaHD], [MaDichVu], [NgaySuDung], [Phong]) VALUES (22, 17, 1, CAST(0x6E3B0B00 AS Date), 2)
INSERT [dbo].[CHITIETHOADON] ([UUID], [MaHD], [MaDichVu], [NgaySuDung], [Phong]) VALUES (23, 17, 2, CAST(0x6E3B0B00 AS Date), 2)
SET IDENTITY_INSERT [dbo].[CHITIETHOADON] OFF
/****** Object:  ForeignKey [FK_KHACHHANG_LOAIKHACHHANG]    Script Date: 05/30/2016 15:59:14 ******/
ALTER TABLE [dbo].[KHACHHANG]  WITH CHECK ADD  CONSTRAINT [FK_KHACHHANG_LOAIKHACHHANG] FOREIGN KEY([LoaiKHID])
REFERENCES [dbo].[LOAIKHACHHANG] ([MaLoaiKH])
GO
ALTER TABLE [dbo].[KHACHHANG] CHECK CONSTRAINT [FK_KHACHHANG_LOAIKHACHHANG]
GO
/****** Object:  ForeignKey [FK_TAIKHOAN_LOAINHANVIEN]    Script Date: 05/30/2016 15:59:14 ******/
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_LOAINHANVIEN] FOREIGN KEY([LoaiTaiKhoan])
REFERENCES [dbo].[LOAINHANVIEN] ([MaLoaiNV])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_LOAINHANVIEN]
GO
/****** Object:  ForeignKey [FK_PHONG_LOAIPHONG]    Script Date: 05/30/2016 15:59:14 ******/
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_LOAIPHONG] FOREIGN KEY([LoaiPhong])
REFERENCES [dbo].[LOAIPHONG] ([MaLoaiPhong])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_LOAIPHONG]
GO
/****** Object:  ForeignKey [FK_PHIEUTHUE_KHACHHANG]    Script Date: 05/30/2016 15:59:14 ******/
ALTER TABLE [dbo].[PHIEUTHUE]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUE_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[PHIEUTHUE] CHECK CONSTRAINT [FK_PHIEUTHUE_KHACHHANG]
GO
/****** Object:  ForeignKey [FK_PHIEUTHUE_PHONG]    Script Date: 05/30/2016 15:59:14 ******/
ALTER TABLE [dbo].[PHIEUTHUE]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUTHUE_PHONG] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[PHIEUTHUE] CHECK CONSTRAINT [FK_PHIEUTHUE_PHONG]
GO
/****** Object:  ForeignKey [FK_HOADON_PHIEUTHUE]    Script Date: 05/30/2016 15:59:14 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_PHIEUTHUE] FOREIGN KEY([MaPhieuThue])
REFERENCES [dbo].[PHIEUTHUE] ([MaPhieuThue])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_PHIEUTHUE]
GO
/****** Object:  ForeignKey [FK_HOADON_PHONG]    Script Date: 05/30/2016 15:59:14 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_PHONG] FOREIGN KEY([Phong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_PHONG]
GO
/****** Object:  ForeignKey [FK_HOADON_TAIKHOAN]    Script Date: 05/30/2016 15:59:14 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_TAIKHOAN] FOREIGN KEY([NhanVien])
REFERENCES [dbo].[TAIKHOAN] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_TAIKHOAN]
GO
/****** Object:  ForeignKey [FK_CHITIETHOADON_DICHVU]    Script Date: 05/30/2016 15:59:14 ******/
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_DICHVU] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DICHVU] ([MaDichVu])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_DICHVU]
GO
/****** Object:  ForeignKey [FK_CHITIETHOADON_HOADON]    Script Date: 05/30/2016 15:59:14 ******/
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHoaDon])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_HOADON]
GO
/****** Object:  ForeignKey [FK_CHITIETHOADON_PHONG]    Script Date: 05/30/2016 15:59:14 ******/
ALTER TABLE [dbo].[CHITIETHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHOADON_PHONG] FOREIGN KEY([Phong])
REFERENCES [dbo].[PHONG] ([MaPhong])
GO
ALTER TABLE [dbo].[CHITIETHOADON] CHECK CONSTRAINT [FK_CHITIETHOADON_PHONG]
GO
