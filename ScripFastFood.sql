USE [master]
GO
/****** Object:  Database [PTMHH_FastFood]    Script Date: 12/8/2020 10:26:47 AM ******/
CREATE DATABASE [PTMHH_FastFood]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PTMHH_FastFood', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PTMHH_FastFood.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PTMHH_FastFood_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PTMHH_FastFood_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PTMHH_FastFood] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PTMHH_FastFood].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PTMHH_FastFood] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET ARITHABORT OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [PTMHH_FastFood] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PTMHH_FastFood] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PTMHH_FastFood] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PTMHH_FastFood] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PTMHH_FastFood] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PTMHH_FastFood] SET  MULTI_USER 
GO
ALTER DATABASE [PTMHH_FastFood] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PTMHH_FastFood] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PTMHH_FastFood] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PTMHH_FastFood] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PTMHH_FastFood] SET DELAYED_DURABILITY = DISABLED 
GO
USE [PTMHH_FastFood]
GO
/****** Object:  Table [dbo].[ANH]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ANH](
	[MaAnh] [int] IDENTITY(1,1) NOT NULL,
	[LinkAnh] [nvarchar](200) NOT NULL,
	[MaSanPham] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaAnh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BANNER]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANNER](
	[MaBanner] [int] IDENTITY(1,1) NOT NULL,
	[LinkAnh] [nvarchar](200) NOT NULL,
	[GhiChu] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBanner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETDONHANG]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETDONHANG](
	[SoLuong] [int] NOT NULL,
	[DonGia] [varchar](50) NOT NULL,
	[MaSanPham] [int] NOT NULL,
	[MaDonHang] [int] NOT NULL,
 CONSTRAINT [ListDonHang] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC,
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[SoLuong] [int] NOT NULL,
	[MaNL] [int] NOT NULL,
	[MaPhieuNhap] [int] NOT NULL,
 CONSTRAINT [PhieuNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC,
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CHITIETPHIEUXUAT]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUXUAT](
	[MaNL] [int] NOT NULL,
	[MaPhieuXuat] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_CHITIETPHIEUXUAT_1] PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC,
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CUAHANG]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CUAHANG](
	[MaCuaHang] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[SDT] [varchar](15) NOT NULL,
	[MaXa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCuaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DANHMUCSANPHAM]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUCSANPHAM](
	[MaDM] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DONHANG]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DONHANG](
	[MaDonHang] [int] IDENTITY(1,1) NOT NULL,
	[NgayDat] [date] NOT NULL,
	[NgayGiao] [date] NOT NULL,
	[ThanhTien] [varchar](20) NOT NULL,
	[TrangThai] [bit] NOT NULL,
	[MaNguoiDung] [int] NULL,
	[MaKhachHang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HUYEN]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HUYEN](
	[MaHuyen] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MaTinh] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[TaiKhoan] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LICHSUTHAYDOI]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LICHSUTHAYDOI](
	[MaLichSuThayDoi] [int] IDENTITY(1,1) NOT NULL,
	[DiaDiem] [nvarchar](100) NULL,
	[SDT] [varchar](15) NULL,
	[ngayThayDoi] [datetime2](0) NULL,
	[MatKhau] [varchar](50) NULL,
	[MaKhachHang] [int] NOT NULL,
 CONSTRAINT [PK_LICHSUTHAYDOI] PRIMARY KEY CLUSTERED 
(
	[MaLichSuThayDoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[MaNguoiDung] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[ViTri] [varchar](15) NOT NULL,
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[NgaySinh] [date] NULL,
	[MaCuaHang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUYENLIEU]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUYENLIEU](
	[MaNL] [int] IDENTITY(1,1) NOT NULL,
	[TenNguyenLieu] [nvarchar](50) NOT NULL,
	[DonViTinh] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[SDT] [nvarchar](50) NOT NULL,
	[MaXa] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[NgayViet] [date] NOT NULL,
	[GhiChu] [nvarchar](50) NOT NULL,
	[MaNCC] [int] NULL,
	[MaNguoiDung] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[MaPhieuXuat] [int] NOT NULL,
	[NgayTao] [datetime2](0) NULL,
	[LuotTaoTrongNgay] [int] NULL,
	[GhiChu] [nvarchar](200) NULL,
	[MaNguyenLieu] [int] NOT NULL,
	[MaNguoiDung] [int] NOT NULL,
 CONSTRAINT [PK_PHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MaSanPham] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[DonGia] [decimal](18, 2) NOT NULL,
	[MoTa] [nvarchar](200) NOT NULL,
	[MaDM] [int] NULL,
 CONSTRAINT [PK__SanPham__FAC7442D2D27B809] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SANPHAM_CUAHANG]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM_CUAHANG](
	[MaSPCH] [int] IDENTITY(1,1) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[MaSanPham] [int] NULL,
	[MaCuaHang] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSPCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TINH]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINH](
	[MaTinh] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[XA]    Script Date: 12/8/2020 10:26:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XA](
	[MaXa] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[MaHuyen] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaXa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CHITIETDONHANG] ([SoLuong], [DonGia], [MaSanPham], [MaDonHang]) VALUES (4, N'150000', 6, 2)
INSERT [dbo].[CHITIETDONHANG] ([SoLuong], [DonGia], [MaSanPham], [MaDonHang]) VALUES (2, N'5000', 6, 3)
INSERT [dbo].[CHITIETDONHANG] ([SoLuong], [DonGia], [MaSanPham], [MaDonHang]) VALUES (2, N'10000', 6, 4)
INSERT [dbo].[CHITIETDONHANG] ([SoLuong], [DonGia], [MaSanPham], [MaDonHang]) VALUES (2, N'20000', 6, 5)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaNL], [MaPhieuXuat], [SoLuong]) VALUES (1, 1, 9)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaNL], [MaPhieuXuat], [SoLuong]) VALUES (1, 5, 12)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaNL], [MaPhieuXuat], [SoLuong]) VALUES (3, 2, 10)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaNL], [MaPhieuXuat], [SoLuong]) VALUES (4, 3, 8)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaNL], [MaPhieuXuat], [SoLuong]) VALUES (5, 4, 7)
SET IDENTITY_INSERT [dbo].[CUAHANG] ON 

INSERT [dbo].[CUAHANG] ([MaCuaHang], [Ten], [TrangThai], [SDT], [MaXa]) VALUES (1, N'Chi Nhánh Hà Nam', 1, N'0963966405', 3)
INSERT [dbo].[CUAHANG] ([MaCuaHang], [Ten], [TrangThai], [SDT], [MaXa]) VALUES (2, N'Chi nhánh Phú Thọ', 1, N'0987654321', 1)
INSERT [dbo].[CUAHANG] ([MaCuaHang], [Ten], [TrangThai], [SDT], [MaXa]) VALUES (3, N'Chi Nhánh Thái Bình', 1, N'0987656789', 2)
INSERT [dbo].[CUAHANG] ([MaCuaHang], [Ten], [TrangThai], [SDT], [MaXa]) VALUES (4, N'Chi Nhánh Nghệ An', 1, N'0912345678', 4)
INSERT [dbo].[CUAHANG] ([MaCuaHang], [Ten], [TrangThai], [SDT], [MaXa]) VALUES (5, N'Chi Nhánh Bắc Ninh', 1, N'0999999999', 5)
SET IDENTITY_INSERT [dbo].[CUAHANG] OFF
SET IDENTITY_INSERT [dbo].[DANHMUCSANPHAM] ON 

INSERT [dbo].[DANHMUCSANPHAM] ([MaDM], [Ten]) VALUES (1, N'xoi 1')
INSERT [dbo].[DANHMUCSANPHAM] ([MaDM], [Ten]) VALUES (2, N'Trung ')
INSERT [dbo].[DANHMUCSANPHAM] ([MaDM], [Ten]) VALUES (3, N'BanhBao')
INSERT [dbo].[DANHMUCSANPHAM] ([MaDM], [Ten]) VALUES (4, N'Mi')
INSERT [dbo].[DANHMUCSANPHAM] ([MaDM], [Ten]) VALUES (5, N'Pizza')
INSERT [dbo].[DANHMUCSANPHAM] ([MaDM], [Ten]) VALUES (6, N'Pho')
INSERT [dbo].[DANHMUCSANPHAM] ([MaDM], [Ten]) VALUES (7, N'HamBurGer')
INSERT [dbo].[DANHMUCSANPHAM] ([MaDM], [Ten]) VALUES (8, N'BanhMi')
INSERT [dbo].[DANHMUCSANPHAM] ([MaDM], [Ten]) VALUES (9, N'Ga Ran 1')
SET IDENTITY_INSERT [dbo].[DANHMUCSANPHAM] OFF
SET IDENTITY_INSERT [dbo].[DONHANG] ON 

INSERT [dbo].[DONHANG] ([MaDonHang], [NgayDat], [NgayGiao], [ThanhTien], [TrangThai], [MaNguoiDung], [MaKhachHang]) VALUES (1, CAST(N'2020-09-09' AS Date), CAST(N'2020-09-09' AS Date), N'10000', 1, 2, 1)
INSERT [dbo].[DONHANG] ([MaDonHang], [NgayDat], [NgayGiao], [ThanhTien], [TrangThai], [MaNguoiDung], [MaKhachHang]) VALUES (2, CAST(N'2020-09-09' AS Date), CAST(N'2020-09-09' AS Date), N'50000', 1, 2, 2)
INSERT [dbo].[DONHANG] ([MaDonHang], [NgayDat], [NgayGiao], [ThanhTien], [TrangThai], [MaNguoiDung], [MaKhachHang]) VALUES (3, CAST(N'2020-09-09' AS Date), CAST(N'2020-09-09' AS Date), N'10000', 1, 2, 4)
INSERT [dbo].[DONHANG] ([MaDonHang], [NgayDat], [NgayGiao], [ThanhTien], [TrangThai], [MaNguoiDung], [MaKhachHang]) VALUES (4, CAST(N'2020-09-09' AS Date), CAST(N'2020-09-09' AS Date), N'20000', 1, 2, 1)
INSERT [dbo].[DONHANG] ([MaDonHang], [NgayDat], [NgayGiao], [ThanhTien], [TrangThai], [MaNguoiDung], [MaKhachHang]) VALUES (5, CAST(N'2020-09-09' AS Date), CAST(N'2020-09-09' AS Date), N'10000', 1, 2, 3)
INSERT [dbo].[DONHANG] ([MaDonHang], [NgayDat], [NgayGiao], [ThanhTien], [TrangThai], [MaNguoiDung], [MaKhachHang]) VALUES (6, CAST(N'2020-12-12' AS Date), CAST(N'2020-12-12' AS Date), N'500000', 0, 2, 1)
INSERT [dbo].[DONHANG] ([MaDonHang], [NgayDat], [NgayGiao], [ThanhTien], [TrangThai], [MaNguoiDung], [MaKhachHang]) VALUES (7, CAST(N'2020-12-12' AS Date), CAST(N'2020-12-12' AS Date), N'500000', 1, 3, 1)
SET IDENTITY_INSERT [dbo].[DONHANG] OFF
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MaKhachHang], [Ten], [TaiKhoan]) VALUES (1, N'ThucCD', N'ThucCD')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [Ten], [TaiKhoan]) VALUES (2, N'Datngth', N'Datngth')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [Ten], [TaiKhoan]) VALUES (3, N'DatDQ', N'DatDQ')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [Ten], [TaiKhoan]) VALUES (4, N'Sonvt', N'Sonvt')
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
SET IDENTITY_INSERT [dbo].[LICHSUTHAYDOI] ON 

INSERT [dbo].[LICHSUTHAYDOI] ([MaLichSuThayDoi], [DiaDiem], [SDT], [ngayThayDoi], [MatKhau], [MaKhachHang]) VALUES (1, N'180 hoàng  qu?c vi?t', N'1234567', CAST(N'2020-12-06 00:00:00.0000000' AS DateTime2), N'1', 1)
INSERT [dbo].[LICHSUTHAYDOI] ([MaLichSuThayDoi], [DiaDiem], [SDT], [ngayThayDoi], [MatKhau], [MaKhachHang]) VALUES (2, N'210 hoàng  qu?c vi?t', N'3456789', CAST(N'2020-12-06 00:00:00.0000000' AS DateTime2), N'1', 2)
INSERT [dbo].[LICHSUTHAYDOI] ([MaLichSuThayDoi], [DiaDiem], [SDT], [ngayThayDoi], [MatKhau], [MaKhachHang]) VALUES (3, N'198 C?u Gi?y', N'98765432', CAST(N'2020-12-06 00:00:00.0000000' AS DateTime2), N'1', 3)
INSERT [dbo].[LICHSUTHAYDOI] ([MaLichSuThayDoi], [DiaDiem], [SDT], [ngayThayDoi], [MatKhau], [MaKhachHang]) VALUES (4, N'398 C?u Gi?y', N'34569876', CAST(N'2020-12-06 00:00:00.0000000' AS DateTime2), N'1', 4)
SET IDENTITY_INSERT [dbo].[LICHSUTHAYDOI] OFF
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] ON 

INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [ViTri], [TaiKhoan], [MatKhau], [NgaySinh], [MaCuaHang]) VALUES (1, N'ThucCD', N'QuanLy', N'ThucCD', N'1', CAST(N'1997-09-09' AS Date), 2)
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [ViTri], [TaiKhoan], [MatKhau], [NgaySinh], [MaCuaHang]) VALUES (2, N'ThanhDat', N'QuanLy', N'Datngth', N'1', CAST(N'1999-04-11' AS Date), 3)
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [ViTri], [TaiKhoan], [MatKhau], [NgaySinh], [MaCuaHang]) VALUES (3, N'DangDat', N'QuanLy', N'DatDQ', N'1', CAST(N'1999-12-12' AS Date), 4)
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [ViTri], [TaiKhoan], [MatKhau], [NgaySinh], [MaCuaHang]) VALUES (4, N'SON', N'Quanly', N'Sonvt', N'1', CAST(N'1999-04-12' AS Date), 5)
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [ViTri], [TaiKhoan], [MatKhau], [NgaySinh], [MaCuaHang]) VALUES (5, N'Nhung', N'QuanLy', N'Nhungngth', N'1', CAST(N'1999-12-12' AS Date), 1)
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [ViTri], [TaiKhoan], [MatKhau], [NgaySinh], [MaCuaHang]) VALUES (6, N'admin', N'QuanLy', N'1', N'1', CAST(N'1999-12-12' AS Date), 1)
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [ViTri], [TaiKhoan], [MatKhau], [NgaySinh], [MaCuaHang]) VALUES (7, N'Nguyễn Anh Duy', N'Nhân Viên', N'Duy', N'Duy', CAST(N'1999-12-12' AS Date), 1)
INSERT [dbo].[NGUOIDUNG] ([MaNguoiDung], [Ten], [ViTri], [TaiKhoan], [MatKhau], [NgaySinh], [MaCuaHang]) VALUES (8, N'Trần Trọng Nghĩa', N'Nhân Viên', N'nghia', N'1', CAST(N'1999-12-06' AS Date), 3)
SET IDENTITY_INSERT [dbo].[NGUOIDUNG] OFF
SET IDENTITY_INSERT [dbo].[NGUYENLIEU] ON 

INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNguyenLieu], [DonViTinh]) VALUES (1, N'Bánh mì', N'Cái')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNguyenLieu], [DonViTinh]) VALUES (2, N'Bánh Bao', N'Cái')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNguyenLieu], [DonViTinh]) VALUES (3, N'Mì Tôm', N'Gói')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNguyenLieu], [DonViTinh]) VALUES (4, N'Thịt bò', N'Kg')
INSERT [dbo].[NGUYENLIEU] ([MaNL], [TenNguyenLieu], [DonViTinh]) VALUES (5, N'Xúc Xích', N'Túi')
SET IDENTITY_INSERT [dbo].[NGUYENLIEU] OFF
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([MaNCC], [Ten], [SDT], [MaXa]) VALUES (1, N'Trường Hải', N'0987654321', 1)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [Ten], [SDT], [MaXa]) VALUES (2, N'Cung Đình', N'6754367843', 2)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [Ten], [SDT], [MaXa]) VALUES (3, N'Xúc Xích Đức Việt', N'0987666666', 3)
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [Ten], [SDT], [MaXa]) VALUES (4, N'Minh Tâm', N'0987655555', 4)
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayViet], [GhiChu], [MaNCC], [MaNguoiDung]) VALUES (1, CAST(N'2020-12-12' AS Date), N'??y ?? ', 1, 1)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayViet], [GhiChu], [MaNCC], [MaNguoiDung]) VALUES (2, CAST(N'2020-09-09' AS Date), N'??y ?? ', 1, 2)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayViet], [GhiChu], [MaNCC], [MaNguoiDung]) VALUES (3, CAST(N'2020-08-08' AS Date), N'??y ?? ', 1, 3)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayViet], [GhiChu], [MaNCC], [MaNguoiDung]) VALUES (4, CAST(N'2020-07-07' AS Date), N'??y ?? ', 1, 4)
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayTao], [LuotTaoTrongNgay], [GhiChu], [MaNguyenLieu], [MaNguoiDung]) VALUES (1, CAST(N'2020-12-12 00:00:00.0000000' AS DateTime2), 1, N'??y ??', 2, 2)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayTao], [LuotTaoTrongNgay], [GhiChu], [MaNguyenLieu], [MaNguoiDung]) VALUES (2, CAST(N'2020-09-09 00:00:00.0000000' AS DateTime2), 1, N'??y ??', 3, 2)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayTao], [LuotTaoTrongNgay], [GhiChu], [MaNguyenLieu], [MaNguoiDung]) VALUES (3, CAST(N'2020-07-07 00:00:00.0000000' AS DateTime2), 1, N'??y ??', 4, 2)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayTao], [LuotTaoTrongNgay], [GhiChu], [MaNguyenLieu], [MaNguoiDung]) VALUES (4, CAST(N'2020-08-08 00:00:00.0000000' AS DateTime2), 1, N'??y ??', 5, 2)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayTao], [LuotTaoTrongNgay], [GhiChu], [MaNguyenLieu], [MaNguoiDung]) VALUES (5, CAST(N'2020-12-05 00:00:00.0000000' AS DateTime2), 1, N'??y ??', 1, 2)
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 

INSERT [dbo].[SANPHAM] ([MaSanPham], [Ten], [DonGia], [MoTa], [MaDM]) VALUES (1, N'Pizza', CAST(111.00 AS Decimal(18, 2)), N'size M', 1)
INSERT [dbo].[SANPHAM] ([MaSanPham], [Ten], [DonGia], [MoTa], [MaDM]) VALUES (2, N'Pizza', CAST(123.00 AS Decimal(18, 2)), N'size L', 1)
INSERT [dbo].[SANPHAM] ([MaSanPham], [Ten], [DonGia], [MoTa], [MaDM]) VALUES (4, N'Pizza', CAST(133.00 AS Decimal(18, 2)), N'size XL', 1)
INSERT [dbo].[SANPHAM] ([MaSanPham], [Ten], [DonGia], [MoTa], [MaDM]) VALUES (5, N'MiTom', CAST(20000.00 AS Decimal(18, 2)), N'mì tôm ngon sùn s?t', 1)
INSERT [dbo].[SANPHAM] ([MaSanPham], [Ten], [DonGia], [MoTa], [MaDM]) VALUES (6, N'Pizza Hải Sản', CAST(150000.00 AS Decimal(18, 2)), N'Pizza thơm ngon sừn sựt', 3)
INSERT [dbo].[SANPHAM] ([MaSanPham], [Ten], [DonGia], [MoTa], [MaDM]) VALUES (7, N'Hamburger', CAST(10000.00 AS Decimal(18, 2)), N'hamburger ngon nhất hà thành', 4)
INSERT [dbo].[SANPHAM] ([MaSanPham], [Ten], [DonGia], [MoTa], [MaDM]) VALUES (8, N'Bánh Bao Chay', CAST(5000.00 AS Decimal(18, 2)), N'Bánh Bao ngon nóng', 6)
INSERT [dbo].[SANPHAM] ([MaSanPham], [Ten], [DonGia], [MoTa], [MaDM]) VALUES (9, N'Phở Bò', CAST(20000.00 AS Decimal(18, 2)), N'Phở Bò ngon mềm', 2)
INSERT [dbo].[SANPHAM] ([MaSanPham], [Ten], [DonGia], [MoTa], [MaDM]) VALUES (10, N'Ga Ran', CAST(100000.00 AS Decimal(18, 2)), N'ga ran ', 6)
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
SET IDENTITY_INSERT [dbo].[SANPHAM_CUAHANG] ON 

INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (1, 10, 1, 1)
INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (2, 10, 2, 1)
INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (4, 10, 4, 1)
INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (5, 10, 1, 2)
INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (6, 10, 2, 2)
INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (8, 10, 4, 2)
INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (9, 10, 1, 3)
INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (10, 10, 2, 3)
INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (12, 10, 4, 3)
INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (13, 10, 1, 4)
INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (14, 10, 2, 4)
INSERT [dbo].[SANPHAM_CUAHANG] ([MaSPCH], [SoLuong], [MaSanPham], [MaCuaHang]) VALUES (16, 10, 4, 4)
SET IDENTITY_INSERT [dbo].[SANPHAM_CUAHANG] OFF
SET IDENTITY_INSERT [dbo].[TINH] ON 

INSERT [dbo].[TINH] ([MaTinh], [Ten]) VALUES (1, N'PhuTho')
INSERT [dbo].[TINH] ([MaTinh], [Ten]) VALUES (2, N'Nghe An')
INSERT [dbo].[TINH] ([MaTinh], [Ten]) VALUES (3, N'Ha Nam')
INSERT [dbo].[TINH] ([MaTinh], [Ten]) VALUES (4, N'Thai Binh')
INSERT [dbo].[TINH] ([MaTinh], [Ten]) VALUES (5, N'Ha Noi')
SET IDENTITY_INSERT [dbo].[TINH] OFF
ALTER TABLE [dbo].[ANH]  WITH CHECK ADD  CONSTRAINT [FK__Anh__MaSanPham__33D4B598] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[ANH] CHECK CONSTRAINT [FK__Anh__MaSanPham__33D4B598]
GO
ALTER TABLE [dbo].[CHITIETDONHANG]  WITH CHECK ADD FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DONHANG] ([MaDonHang])
GO
ALTER TABLE [dbo].[CHITIETDONHANG]  WITH CHECK ADD FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DONHANG] ([MaDonHang])
GO
ALTER TABLE [dbo].[CHITIETDONHANG]  WITH CHECK ADD  CONSTRAINT [FK__ChiTietDo__MaSan__49C3F6B7] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[CHITIETDONHANG] CHECK CONSTRAINT [FK__ChiTietDo__MaSan__49C3F6B7]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAP] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAP] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNL])
REFERENCES [dbo].[NGUYENLIEU] ([MaNL])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNL])
REFERENCES [dbo].[NGUYENLIEU] ([MaNL])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUXUAT_NGUYENLIEU] FOREIGN KEY([MaNL])
REFERENCES [dbo].[NGUYENLIEU] ([MaNL])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT] CHECK CONSTRAINT [FK_CHITIETPHIEUXUAT_NGUYENLIEU]
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUXUAT_PHIEUXUAT] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PHIEUXUAT] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT] CHECK CONSTRAINT [FK_CHITIETPHIEUXUAT_PHIEUXUAT]
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NGUOIDUNG] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[DONHANG]  WITH CHECK ADD FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NGUOIDUNG] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[HUYEN]  WITH CHECK ADD FOREIGN KEY([MaTinh])
REFERENCES [dbo].[TINH] ([MaTinh])
GO
ALTER TABLE [dbo].[HUYEN]  WITH CHECK ADD FOREIGN KEY([MaTinh])
REFERENCES [dbo].[TINH] ([MaTinh])
GO
ALTER TABLE [dbo].[LICHSUTHAYDOI]  WITH CHECK ADD  CONSTRAINT [FK_LICHSUTHAYDOI_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[LICHSUTHAYDOI] CHECK CONSTRAINT [FK_LICHSUTHAYDOI_KHACHHANG]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD FOREIGN KEY([MaCuaHang])
REFERENCES [dbo].[CUAHANG] ([MaCuaHang])
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD FOREIGN KEY([MaCuaHang])
REFERENCES [dbo].[CUAHANG] ([MaCuaHang])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NGUOIDUNG] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NGUOIDUNG] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_NGUOIDUNG] FOREIGN KEY([MaNguoiDung])
REFERENCES [dbo].[NGUOIDUNG] ([MaNguoiDung])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_NGUOIDUNG]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK__SanPham__MaDM__2F10007B] FOREIGN KEY([MaDM])
REFERENCES [dbo].[DANHMUCSANPHAM] ([MaDM])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK__SanPham__MaDM__2F10007B]
GO
ALTER TABLE [dbo].[SANPHAM_CUAHANG]  WITH CHECK ADD FOREIGN KEY([MaCuaHang])
REFERENCES [dbo].[CUAHANG] ([MaCuaHang])
GO
ALTER TABLE [dbo].[SANPHAM_CUAHANG]  WITH CHECK ADD FOREIGN KEY([MaCuaHang])
REFERENCES [dbo].[CUAHANG] ([MaCuaHang])
GO
ALTER TABLE [dbo].[SANPHAM_CUAHANG]  WITH CHECK ADD  CONSTRAINT [FK__SanPhamCu__MaSan__38996AB5] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SANPHAM] ([MaSanPham])
GO
ALTER TABLE [dbo].[SANPHAM_CUAHANG] CHECK CONSTRAINT [FK__SanPhamCu__MaSan__38996AB5]
GO
ALTER TABLE [dbo].[XA]  WITH CHECK ADD FOREIGN KEY([MaHuyen])
REFERENCES [dbo].[HUYEN] ([MaHuyen])
GO
ALTER TABLE [dbo].[XA]  WITH CHECK ADD FOREIGN KEY([MaHuyen])
REFERENCES [dbo].[HUYEN] ([MaHuyen])
GO
USE [master]
GO
ALTER DATABASE [PTMHH_FastFood] SET  READ_WRITE 
GO
