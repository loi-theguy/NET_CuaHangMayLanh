USE [master]
GO
/****** Object:  Database [QL_MAYLANH2]    Script Date: 12/28/2020 4:56:15 PM ******/
CREATE DATABASE [QL_MAYLANH2]
GO
ALTER DATABASE [QL_MAYLANH2] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_MAYLANH2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_MAYLANH2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_MAYLANH2] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_MAYLANH2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_MAYLANH2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_MAYLANH2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QL_MAYLANH2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_MAYLANH2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_MAYLANH2] SET  MULTI_USER 
GO
ALTER DATABASE [QL_MAYLANH2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_MAYLANH2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_MAYLANH2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_MAYLANH2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QL_MAYLANH2]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MAHD] [int] NOT NULL,
	[MASP] [int] NOT NULL,
	[SOLUONG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietNhapKho]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietNhapKho](
	[MANHAP] [int] NOT NULL,
	[MASP] [int] NOT NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MANHAP] ASC,
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MAHD] [int] IDENTITY(1,1) NOT NULL,
	[MAKH] [int] NULL,
	[MANV] [int] NULL,
	[NGAYLAP] [nvarchar](30) NULL,
	[TONGTIEN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MAKH] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[NGAYSINH] [nvarchar](30) NULL,
	[NGAYLAP] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiNhanVien]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiNhanVien](
	[LOAI] [int] NOT NULL,
	[TENLOAI] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[LOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MANV] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](30) NULL,
	[NGAYSINH] [nvarchar](10) NULL,
	[NGAYVL] [nvarchar](10) NULL,
	[LOAI] [int] NULL,
	[USERNAME] [nvarchar](50) NULL,
	[MATKHAU] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhapKho]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapKho](
	[MANHAP] [int] IDENTITY(1,1) NOT NULL,
	[MANV] [int] NULL,
	[NGAYNHAP] [nvarchar](30) NULL,
	[TONGTIEN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MANHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaSanXuat]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaSanXuat](
	[MANSX] [int] IDENTITY(1,1) NOT NULL,
	[TENNSX] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MANSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MASP] [int] IDENTITY(1,1) NOT NULL,
	[TENSP] [nvarchar](50) NULL,
	[MANSX] [int] NULL,
	[SOLUONG] [int] NULL,
	[DONGIA] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[View_ChiTietHoaDon]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[View_ChiTietHoaDon] as
select MAHD,s.MASP,TENSP,ct.SOLUONG from ChiTietHoaDon ct, SanPham s where s.MASP=ct.MASP
GO
/****** Object:  View [dbo].[View_CT_HOADON]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[View_CT_HOADON] as
select MAHD,SanPham.MASP,TENSP,ChiTietHoaDon.SOLUONG from ChiTietHoaDon, SanPham where SanPham.MASP=ChiTietHoaDon.MASP
GO
/****** Object:  View [dbo].[View_CT_NHAPKHO]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_CT_NHAPKHO] as
select MANHAP,s.MASP,TENSP,ct.SOLUONG as SOLUONG,ct.DONGIA as DONGIA 
from ChiTietNhapKho ct, SanPham s 
where s.MASP=ct.MASP
GO
/****** Object:  View [dbo].[View_Report_HoaDon]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_Report_HoaDon] as
select MAHD, kh.MAKH,kh.HOTEN as TENKH,nv.MANV,nv.HOTEN as TENNV,hd.NGAYLAP,TONGTIEN from HoaDon hd, KhachHang kh, NhanVien nv where hd.MAKH=kh.MAKH and nv.MANV=hd.MANV

GO
/****** Object:  View [dbo].[View_Report_NhanVien]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_Report_NhanVien] as
select MANV,HOTEN,NGAYSINH,NGAYVL,TENLOAI from NhanVien n, LoaiNhanVien l where n.LOAI=l.LOAI
GO
/****** Object:  View [dbo].[View_Report_NhapKho]    Script Date: 12/28/2020 4:56:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[View_Report_NhapKho] as
select MANHAP,nv.MANV,HOTEN,NGAYNHAP,TONGTIEN from NhapKho nk, NhanVien nv where nk.MANV=nv.MANV

GO
INSERT [dbo].[ChiTietHoaDon] ([MAHD], [MASP], [SOLUONG]) VALUES (16, 5, 3)
INSERT [dbo].[ChiTietHoaDon] ([MAHD], [MASP], [SOLUONG]) VALUES (17, 4, 2)
INSERT [dbo].[ChiTietHoaDon] ([MAHD], [MASP], [SOLUONG]) VALUES (18, 2, 1)
INSERT [dbo].[ChiTietHoaDon] ([MAHD], [MASP], [SOLUONG]) VALUES (19, 2, 1)
INSERT [dbo].[ChiTietNhapKho] ([MANHAP], [MASP], [SOLUONG], [DONGIA]) VALUES (1002, 2, 2, 12000000)
INSERT [dbo].[ChiTietNhapKho] ([MANHAP], [MASP], [SOLUONG], [DONGIA]) VALUES (1003, 3, 5, 9990000)
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MAHD], [MAKH], [MANV], [NGAYLAP], [TONGTIEN]) VALUES (16, 1, 1, N'21/12/2020', 33870000)
INSERT [dbo].[HoaDon] ([MAHD], [MAKH], [MANV], [NGAYLAP], [TONGTIEN]) VALUES (17, 1, 1, N'21/12/2020', 20980000)
INSERT [dbo].[HoaDon] ([MAHD], [MAKH], [MANV], [NGAYLAP], [TONGTIEN]) VALUES (18, 7, 1004, N'21/12/2020', 10590000)
INSERT [dbo].[HoaDon] ([MAHD], [MAKH], [MANV], [NGAYLAP], [TONGTIEN]) VALUES (19, 7, 1004, N'21/12/2020', 10590000)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MAKH], [HOTEN], [NGAYSINH], [NGAYLAP]) VALUES (1, N'Nguyen thi A', N'11/11/2000', N'15/10/2020')
INSERT [dbo].[KhachHang] ([MAKH], [HOTEN], [NGAYSINH], [NGAYLAP]) VALUES (2, N'Tran Van B', N'12/01/1999', N'22/01/2020')
INSERT [dbo].[KhachHang] ([MAKH], [HOTEN], [NGAYSINH], [NGAYLAP]) VALUES (7, N'Nguyen Van Cao', N'11/11/1991', N'21/12/2020')
INSERT [dbo].[KhachHang] ([MAKH], [HOTEN], [NGAYSINH], [NGAYLAP]) VALUES (9, N'Le Van Tuan', N'22/11/1990', N'28/12/2020')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[LoaiNhanVien] ([LOAI], [TENLOAI]) VALUES (1, N'Chủ quản lý')
INSERT [dbo].[LoaiNhanVien] ([LOAI], [TENLOAI]) VALUES (2, N'Nhân viên quản lý')
INSERT [dbo].[LoaiNhanVien] ([LOAI], [TENLOAI]) VALUES (3, N'Nhân viên bán hàng')
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MANV], [HOTEN], [NGAYSINH], [NGAYVL], [LOAI], [USERNAME], [MATKHAU]) VALUES (1, N'Nguyen Thi F', N'11/11/2000', N'01/01/2020', 1, N'nguyenf', N'123')
INSERT [dbo].[NhanVien] ([MANV], [HOTEN], [NGAYSINH], [NGAYVL], [LOAI], [USERNAME], [MATKHAU]) VALUES (2, N'Tran Thi B', N'01/06/1999', N'12/03/2020', 2, N'tranb', N'2321')
INSERT [dbo].[NhanVien] ([MANV], [HOTEN], [NGAYSINH], [NGAYVL], [LOAI], [USERNAME], [MATKHAU]) VALUES (3, N'Nguyen van C', N'20/11/1998', N'06/09/2019', 3, N'nguyenc', N'123')
INSERT [dbo].[NhanVien] ([MANV], [HOTEN], [NGAYSINH], [NGAYVL], [LOAI], [USERNAME], [MATKHAU]) VALUES (1002, N'Admin', N'11/11/1999', N'01/01/2020', 1, N'admin', N'admin')
INSERT [dbo].[NhanVien] ([MANV], [HOTEN], [NGAYSINH], [NGAYVL], [LOAI], [USERNAME], [MATKHAU]) VALUES (1003, N'Tran Thanh Xuan', N'21/12/1990', N'01/05/2020', 2, N'xuan', N'xuan')
INSERT [dbo].[NhanVien] ([MANV], [HOTEN], [NGAYSINH], [NGAYVL], [LOAI], [USERNAME], [MATKHAU]) VALUES (1004, N'Nguyen Ngoc', N'30/10/1997', N'29/10/2020', 3, N'ngoc', N'ngoc')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
SET IDENTITY_INSERT [dbo].[NhapKho] ON 

INSERT [dbo].[NhapKho] ([MANHAP], [MANV], [NGAYNHAP], [TONGTIEN]) VALUES (1002, 1002, N'21/12/2020', 24000000)
INSERT [dbo].[NhapKho] ([MANHAP], [MANV], [NGAYNHAP], [TONGTIEN]) VALUES (1003, 1002, N'21/12/2020', 49950000)
SET IDENTITY_INSERT [dbo].[NhapKho] OFF
SET IDENTITY_INSERT [dbo].[NhaSanXuat] ON 

INSERT [dbo].[NhaSanXuat] ([MANSX], [TENNSX]) VALUES (1, N'SAMSUNG')
INSERT [dbo].[NhaSanXuat] ([MANSX], [TENNSX]) VALUES (2, N'PANASONIC')
INSERT [dbo].[NhaSanXuat] ([MANSX], [TENNSX]) VALUES (3, N'SHARP')
INSERT [dbo].[NhaSanXuat] ([MANSX], [TENNSX]) VALUES (4, N'TOSHIBA')
INSERT [dbo].[NhaSanXuat] ([MANSX], [TENNSX]) VALUES (5, N'DAIKIN')
INSERT [dbo].[NhaSanXuat] ([MANSX], [TENNSX]) VALUES (6, N'LG')
SET IDENTITY_INSERT [dbo].[NhaSanXuat] OFF
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MASP], [TENSP], [MANSX], [SOLUONG], [DONGIA]) VALUES (2, N'Samsung Inverter 1.5 HP AR13TYHYCWKNSV', 1, 12, 10590000)
INSERT [dbo].[SanPham] ([MASP], [TENSP], [MANSX], [SOLUONG], [DONGIA]) VALUES (3, N'LG Inverter 1.5 HP V13ENH', 6, 10, 10590000)
INSERT [dbo].[SanPham] ([MASP], [TENSP], [MANSX], [SOLUONG], [DONGIA]) VALUES (4, N'Sharp Inverter 1.5 HP AH-XP13WMW', 3, 6, 10490000)
INSERT [dbo].[SanPham] ([MASP], [TENSP], [MANSX], [SOLUONG], [DONGIA]) VALUES (5, N'Daikin 1.5 HP ATF35UV1V', 5, 8, 11290000)
INSERT [dbo].[SanPham] ([MASP], [TENSP], [MANSX], [SOLUONG], [DONGIA]) VALUES (6, N'Panasonic 1.5 HP CU/CS-N12WKH-8M', 2, 20, 11290000)
INSERT [dbo].[SanPham] ([MASP], [TENSP], [MANSX], [SOLUONG], [DONGIA]) VALUES (7, N'Toshiba Inverter 1 HP RAS-H10D2KCVG-V', 4, 25, 9490000)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((0)) FOR [SOLUONG]
GO
ALTER TABLE [dbo].[ChiTietNhapKho] ADD  DEFAULT ((0)) FOR [SOLUONG]
GO
ALTER TABLE [dbo].[ChiTietNhapKho] ADD  DEFAULT ((0)) FOR [DONGIA]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [TONGTIEN]
GO
ALTER TABLE [dbo].[NhapKho] ADD  DEFAULT ((0)) FOR [TONGTIEN]
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((0)) FOR [SOLUONG]
GO
ALTER TABLE [dbo].[SanPham] ADD  DEFAULT ((0)) FOR [DONGIA]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_HoaDon] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HoaDon] ([MAHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_SanPham] FOREIGN KEY([MASP])
REFERENCES [dbo].[SanPham] ([MASP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_CTHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_CTNhapKho_NHapKho] FOREIGN KEY([MANHAP])
REFERENCES [dbo].[NhapKho] ([MANHAP])
GO
ALTER TABLE [dbo].[ChiTietNhapKho] CHECK CONSTRAINT [FK_CTNhapKho_NHapKho]
GO
ALTER TABLE [dbo].[ChiTietNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_CTNhapKho_SanPham] FOREIGN KEY([MASP])
REFERENCES [dbo].[SanPham] ([MASP])
GO
ALTER TABLE [dbo].[ChiTietNhapKho] CHECK CONSTRAINT [FK_CTNhapKho_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_KhachHang] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KhachHang] ([MAKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_CTHoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTHoaDon_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_CTHoaDon_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien_loai] FOREIGN KEY([LOAI])
REFERENCES [dbo].[LoaiNhanVien] ([LOAI])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [fk_nhanvien_loai]
GO
ALTER TABLE [dbo].[NhapKho]  WITH CHECK ADD  CONSTRAINT [FK_CTNhapKho_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[NhanVien] ([MANV])
GO
ALTER TABLE [dbo].[NhapKho] CHECK CONSTRAINT [FK_CTNhapKho_NhanVien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_NSX_SP] FOREIGN KEY([MANSX])
REFERENCES [dbo].[NhaSanXuat] ([MANSX])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_NSX_SP]
GO
USE [master]
GO
ALTER DATABASE [QL_MAYLANH2] SET  READ_WRITE 
GO

use QL_MAYLANH2
go

/*Trigger thay đổi Tổng tiền nhập kho*/
Create trigger Update_TangTongTienPN ON ChiTietNhapKho After Insert 
as
begin
update NhapKho
set TONGTIEN=NhapKho.TONGTIEN+(SELECT SUM(SOLUONG*DONGIA) 
FROM inserted
where inserted.MANHAP=NhapKho.MANHAP)
from NhapKho
join inserted on NhapKho.MANHAP=inserted.MANHAP
end
go

Create trigger Update_GiamTongTienPN ON ChiTietNhapKho After Delete 
as
begin
update NhapKho
set TONGTIEN=NhapKho.TONGTIEN-(SELECT SUM(SOLUONG*DONGIA) 
FROM deleted
where MANHAP=NhapKho.MANHAP)
from NhapKho
join deleted on NhapKho.MANHAP=deleted.MANHAP
end
go
/*Trigger thay đổi số lượng sản phẩm sau khi nhập kho*/
create trigger UpdateTonKhoTang_PN on ChiTietNhapKho AFTER insert
as
begin
update SanPham
set SOLUONG=SanPham.SOLUONG+(SELECT SOLUONG
FROM inserted
where MASP=SanPham.MASP)
from SanPham
join inserted on SanPham.MASP=inserted.MASP
end
go

create trigger UpdateTonKHoGiam_PN on ChiTietNhapKho AFTER DELETE
as
begin
update SanPham
set SOLUONG=SanPham.SOLUONG-(SELECT SOLUONG
FROM deleted
where MASP=SanPham.MASP)
from SanPham
join deleted on SanPham.MASP=deleted.MASP
end
go


create trigger set_default on nhapkho after update
as
begin
update NhapKho
set TONGTIEN=0
where TONGTIEN is null or TONGTIEN<0
end
go
/*Trigger thay đổi tổng tiền hóa đơn*/
Create trigger Update_TangTongTien ON CHITIETHOADON After Insert 
as
begin
update HOADON
set TONGTIEN=TONGTIEN+(SELECT SUM(inserted.SOLUONG*s.DONGIA) 
FROM inserted, sanpham s
where inserted.MAHD=HOADON.MAHD and inserted.MASP=s.MASP)
from HOADON
join inserted on HOADON.MAHD=inserted.MAHD
end
go


create trigger set_default0 on hoadon after update
as
begin
update hoadon
set TONGTIEN=0
where TONGTIEN is null or TONGTIEN<0
end
go

Create trigger Update_GiamTongTien ON CHITIETHOADON After Delete 
as
begin
update HOADON
set TONGTIEN=TONGTIEN-(SELECT SUM(deleted.SOLUONG*s.DONGIA) 
FROM deleted, sanpham s
where deleted.MAHD=HOADON.MAHD and deleted.MASP=s.MASP)
from HOADON
join deleted on HOADON.MAHD=deleted.MAHD
end
go
/*Trigger thay đổi số lượng sản phẩm sau khi bán*/
create trigger UpdateSoLuongTonGiam on CHITIETHOADON for insert
as
if (SELECT SOLUONG FROM inserted)>(SELECT SOLUONG
FROM SanPham
where MASP=(SELECT MASP FROM inserted))
ROLLBACK TRAN
else
begin
update SanPham
set SOLUONG=SanPham.SOLUONG-(SELECT SOLUONG
FROM inserted
where MASP=SanPham.MASP)
from SanPham
join inserted on SanPham.MASP=inserted.MASP
end
go

create trigger UpdateSoLuongTang on CHITIETHOADON AFTER DELETE
as
begin
update SanPham
set SOLUONG=SanPham.SOLUONG+(SELECT SOLUONG
FROM deleted
where MASP=SanPham.MASP)
from SanPham
join deleted on SanPham.MASP=deleted.MASP
end
go