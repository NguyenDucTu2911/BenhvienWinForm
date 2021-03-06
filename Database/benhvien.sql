USE [master]
GO
/****** Object:  Database [benhvien]    Script Date: 7/3/2022 10:20:18 AM ******/
CREATE DATABASE [benhvien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'benhvien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\benhvien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'benhvien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\benhvien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [benhvien] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [benhvien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [benhvien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [benhvien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [benhvien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [benhvien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [benhvien] SET ARITHABORT OFF 
GO
ALTER DATABASE [benhvien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [benhvien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [benhvien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [benhvien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [benhvien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [benhvien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [benhvien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [benhvien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [benhvien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [benhvien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [benhvien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [benhvien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [benhvien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [benhvien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [benhvien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [benhvien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [benhvien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [benhvien] SET RECOVERY FULL 
GO
ALTER DATABASE [benhvien] SET  MULTI_USER 
GO
ALTER DATABASE [benhvien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [benhvien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [benhvien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [benhvien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [benhvien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'benhvien', N'ON'
GO
ALTER DATABASE [benhvien] SET QUERY_STORE = OFF
GO
USE [benhvien]
GO
/****** Object:  Table [dbo].[Benh]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Benh](
	[MaBenh] [int] NOT NULL,
	[TenBenh] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_Benh] PRIMARY KEY CLUSTERED 
(
	[MaBenh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BenhAn]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhAn](
	[MaBenhan] [nvarchar](20) NOT NULL,
	[MaBN] [nvarchar](20) NULL,
	[MaPK] [nchar](10) NULL,
	[MaDonThuoc] [varchar](10) NULL,
	[MaXN] [nchar](10) NULL,
	[MaDK] [int] NULL,
	[MaBenh] [int] NULL,
 CONSTRAINT [PK_BenhAn_1] PRIMARY KEY CLUSTERED 
(
	[MaBenhan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_DonThuoc]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DonThuoc](
	[MaDonThuoc] [varchar](10) NOT NULL,
	[MaThuoc] [varchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Ngay] [nvarchar](50) NOT NULL,
	[Lieu] [nvarchar](50) NOT NULL,
	[ThoiDiemSuDung] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_CT_DonThuoc] PRIMARY KEY CLUSTERED 
(
	[MaDonThuoc] ASC,
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dakhoa]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dakhoa](
	[MaDK] [int] NOT NULL,
	[MaBN] [nvarchar](20) NOT NULL,
	[HoTenBN] [nvarchar](50) NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[MaBS] [nvarchar](20) NOT NULL,
	[HoTenBS] [nvarchar](50) NULL,
	[ThongTinBenh] [nvarchar](500) NOT NULL,
	[KhamTongThe] [nvarchar](500) NULL,
	[KhamTungBoPhan] [nvarchar](500) NULL,
	[TomTatLamSan] [nvarchar](500) NULL,
	[ChuanDoanNhapVien] [nvarchar](500) NULL,
	[Thuoc] [nvarchar](500) NULL,
	[MaDonThuoc] [varchar](10) NULL,
 CONSTRAINT [PK_dakhoa] PRIMARY KEY CLUSTERED 
(
	[MaDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dboctxetnghiem]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dboctxetnghiem](
	[MaDK] [int] NOT NULL,
	[MaXN] [nchar](10) NOT NULL,
	[SoDangKy] [int] NOT NULL,
 CONSTRAINT [PK_dboctxetnghiem] PRIMARY KEY CLUSTERED 
(
	[MaDK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDichVu] [int] NOT NULL,
	[TenDichVu] [nvarchar](500) NOT NULL,
	[DonGia] [int] NOT NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DSbacsi]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSbacsi](
	[MaBS] [nvarchar](20) NOT NULL,
	[HoTenBS] [nvarchar](150) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](500) NOT NULL,
	[SDT] [nchar](15) NOT NULL,
	[KhoaID] [int] NOT NULL,
	[ChucVu] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_DSbacsi] PRIMARY KEY CLUSTERED 
(
	[MaBS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DSbenhnhan]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DSbenhnhan](
	[MaBN] [nvarchar](20) NOT NULL,
	[HoTen] [nvarchar](150) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[DanToc] [nvarchar](20) NOT NULL,
	[QuocTich] [nvarchar](20) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[NgheNghiep] [nvarchar](50) NOT NULL,
	[DoiTuong] [nvarchar](20) NOT NULL,
	[SoBHYT] [nchar](20) NOT NULL,
	[GiaTriBHYT] [date] NOT NULL,
	[PhongKham] [nvarchar](50) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[MaXN] [nchar](10) NULL,
	[MaHoaDon] [char](10) NULL,
 CONSTRAINT [PK_DSbenhnhan] PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dstaikhoan]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dstaikhoan](
	[Taikhoan] [nvarchar](50) NOT NULL,
	[Matkhau] [nvarchar](50) NOT NULL,
	[MaNhom] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[MaNguoiDung] [int] NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dstaikhoan] PRIMARY KEY CLUSTERED 
(
	[Taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DsXetNghiem]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DsXetNghiem](
	[MaXN] [nchar](10) NOT NULL,
	[TenXn] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_DsXetNghiem] PRIMARY KEY CLUSTERED 
(
	[MaXN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [char](10) NOT NULL,
	[MaBS] [nvarchar](20) NOT NULL,
	[MaBN] [nvarchar](20) NOT NULL,
	[NgayLap] [date] NOT NULL,
	[ThanhTien] [int] NOT NULL,
	[MaDichVu] [int] NOT NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[KhoaID] [int] NOT NULL,
	[TenKhoa] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[KhoaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LePhi]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LePhi](
	[MaLePhi] [int] NOT NULL,
	[NgayDong] [date] NOT NULL,
	[SoTien] [money] NOT NULL,
	[MaBN] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_LePhi] PRIMARY KEY CLUSTERED 
(
	[MaLePhi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhomnguoidung]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhomnguoidung](
	[MaNhom] [nchar](10) NOT NULL,
	[TenNhom] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_nhomnguoidung] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [varchar](10) NOT NULL,
	[TenThuoc] [nvarchar](100) NULL,
	[NhomThuoc] [nvarchar](200) NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[HangSanXuat] [nvarchar](100) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ToaThuoc]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ToaThuoc](
	[MaDonThuoc] [varchar](10) NOT NULL,
	[MaBN] [nvarchar](20) NOT NULL,
	[MaBS] [nvarchar](20) NOT NULL,
	[NgayKeDonThuoc] [date] NOT NULL,
	[GioTao] [time](7) NOT NULL,
	[LoiDan] [nvarchar](200) NOT NULL,
	[TenBN] [nvarchar](150) NOT NULL,
	[TenBS] [nvarchar](150) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ToaThuoc] PRIMARY KEY CLUSTERED 
(
	[MaDonThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VatTu]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VatTu](
	[MaVT] [nchar](10) NOT NULL,
	[TenVT] [nvarchar](50) NOT NULL,
	[Hang] [nvarchar](50) NOT NULL,
	[SL] [int] NOT NULL,
 CONSTRAINT [PK_VatTu] PRIMARY KEY CLUSTERED 
(
	[MaVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VienPhi]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VienPhi](
	[MaVienPhi] [int] NOT NULL,
	[NgayDong] [date] NOT NULL,
	[SoTienVP] [money] NOT NULL,
	[MaBN] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_VienPhi] PRIMARY KEY CLUSTERED 
(
	[MaVienPhi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[xetnghiem]    Script Date: 7/3/2022 10:20:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[xetnghiem](
	[SoDangKy] [int] NOT NULL,
	[MaBN] [nvarchar](20) NOT NULL,
	[HoTen] [nvarchar](150) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[MaBS] [nvarchar](20) NOT NULL,
	[HoTenBS] [nvarchar](150) NULL,
	[YeuCauXetNghiem] [nvarchar](200) NOT NULL,
	[ChuanDoan] [nvarchar](200) NOT NULL,
	[YeuCau] [nvarchar](200) NULL,
	[Maxn] [nchar](10) NULL,
 CONSTRAINT [PK_xetnghiem] PRIMARY KEY CLUSTERED 
(
	[SoDangKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BenhAn]  WITH CHECK ADD  CONSTRAINT [FK_BenhAn_Benh] FOREIGN KEY([MaBenh])
REFERENCES [dbo].[Benh] ([MaBenh])
GO
ALTER TABLE [dbo].[BenhAn] CHECK CONSTRAINT [FK_BenhAn_Benh]
GO
ALTER TABLE [dbo].[BenhAn]  WITH CHECK ADD  CONSTRAINT [FK_BenhAn_dakhoa] FOREIGN KEY([MaDK])
REFERENCES [dbo].[dakhoa] ([MaDK])
GO
ALTER TABLE [dbo].[BenhAn] CHECK CONSTRAINT [FK_BenhAn_dakhoa]
GO
ALTER TABLE [dbo].[BenhAn]  WITH CHECK ADD  CONSTRAINT [FK_BenhAn_DSbenhnhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[DSbenhnhan] ([MaBN])
GO
ALTER TABLE [dbo].[BenhAn] CHECK CONSTRAINT [FK_BenhAn_DSbenhnhan]
GO
ALTER TABLE [dbo].[BenhAn]  WITH CHECK ADD  CONSTRAINT [FK_BenhAn_ToaThuoc] FOREIGN KEY([MaDonThuoc])
REFERENCES [dbo].[ToaThuoc] ([MaDonThuoc])
GO
ALTER TABLE [dbo].[BenhAn] CHECK CONSTRAINT [FK_BenhAn_ToaThuoc]
GO
ALTER TABLE [dbo].[CT_DonThuoc]  WITH CHECK ADD  CONSTRAINT [FK_CT_DonThuoc_Thuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[CT_DonThuoc] CHECK CONSTRAINT [FK_CT_DonThuoc_Thuoc]
GO
ALTER TABLE [dbo].[dakhoa]  WITH CHECK ADD  CONSTRAINT [FK_dakhoa_DSbacsi] FOREIGN KEY([MaBS])
REFERENCES [dbo].[DSbacsi] ([MaBS])
GO
ALTER TABLE [dbo].[dakhoa] CHECK CONSTRAINT [FK_dakhoa_DSbacsi]
GO
ALTER TABLE [dbo].[dboctxetnghiem]  WITH CHECK ADD  CONSTRAINT [FK_dboctxetnghiem_DsXetNghiem] FOREIGN KEY([MaXN])
REFERENCES [dbo].[DsXetNghiem] ([MaXN])
GO
ALTER TABLE [dbo].[dboctxetnghiem] CHECK CONSTRAINT [FK_dboctxetnghiem_DsXetNghiem]
GO
ALTER TABLE [dbo].[dboctxetnghiem]  WITH CHECK ADD  CONSTRAINT [FK_dboctxetnghiem_xetnghiem1] FOREIGN KEY([SoDangKy])
REFERENCES [dbo].[xetnghiem] ([SoDangKy])
GO
ALTER TABLE [dbo].[dboctxetnghiem] CHECK CONSTRAINT [FK_dboctxetnghiem_xetnghiem1]
GO
ALTER TABLE [dbo].[DSbacsi]  WITH CHECK ADD  CONSTRAINT [FK_DSbacsi_Khoa] FOREIGN KEY([KhoaID])
REFERENCES [dbo].[Khoa] ([KhoaID])
GO
ALTER TABLE [dbo].[DSbacsi] CHECK CONSTRAINT [FK_DSbacsi_Khoa]
GO
ALTER TABLE [dbo].[dstaikhoan]  WITH CHECK ADD  CONSTRAINT [FK_dstaikhoan_nhomnguoidung] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[nhomnguoidung] ([MaNhom])
GO
ALTER TABLE [dbo].[dstaikhoan] CHECK CONSTRAINT [FK_dstaikhoan_nhomnguoidung]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_DichVu] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([MaDichVu])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_DichVu]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_DSbenhnhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[DSbenhnhan] ([MaBN])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_DSbenhnhan]
GO
ALTER TABLE [dbo].[LePhi]  WITH CHECK ADD  CONSTRAINT [FK_LePhi_DSbenhnhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[DSbenhnhan] ([MaBN])
GO
ALTER TABLE [dbo].[LePhi] CHECK CONSTRAINT [FK_LePhi_DSbenhnhan]
GO
ALTER TABLE [dbo].[VienPhi]  WITH CHECK ADD  CONSTRAINT [FK_VienPhi_DSbenhnhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[DSbenhnhan] ([MaBN])
GO
ALTER TABLE [dbo].[VienPhi] CHECK CONSTRAINT [FK_VienPhi_DSbenhnhan]
GO
ALTER TABLE [dbo].[xetnghiem]  WITH CHECK ADD  CONSTRAINT [FK_xetnghiem_DSbenhnhan] FOREIGN KEY([MaBN])
REFERENCES [dbo].[DSbenhnhan] ([MaBN])
GO
ALTER TABLE [dbo].[xetnghiem] CHECK CONSTRAINT [FK_xetnghiem_DSbenhnhan]
GO
USE [master]
GO
ALTER DATABASE [benhvien] SET  READ_WRITE 
GO
