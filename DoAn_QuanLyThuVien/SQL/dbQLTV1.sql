USE [master]
GO
CREATE DATABASE [dbQLNS]
 CONTAINMENT = NONE

 ALTER DATABASE [dbQLNS] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbQLNS].[dbo].[sp_fulltext_database] @action =N'enable'
end
GO
ALTER DATABASE [dbQLNS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbQLNS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbQLNS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbQLNS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbQLNS] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbQLNS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbQLNS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbQLNS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbQLNS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbQLNS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbQLNS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbQLNS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbQLNS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbQLNS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbQLNS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbQLNS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbQLNS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbQLNS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbQLNS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbQLNS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbQLNS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbQLNS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbQLNS] SET RECOVERY FULL 
GO
ALTER DATABASE [dbQLNS] SET  MULTI_USER 
GO
ALTER DATABASE [dbQLNS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbQLNS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbQLNS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbQLNS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbQLNS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbQLNS', N'ON'
GO
ALTER DATABASE [dbQLNS] SET QUERY_STORE = OFF
GO
USE [dbQLNS]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [dbQLNS]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET DATEFORMAT dmy
CREATE TABLE [dbo].[TaiKhoan] (
    [TenTaiKhoan] VARCHAR (50) NOT NULL,
    [MatKhau]     VARCHAR (50) NULL,
    [Email]       VARCHAR (50) NULL,
    [Admin]       BIT          NULL,
    CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED ([TenTaiKhoan] ASC)
);
GO
CREATE TABLE [dbo].[SinhVien] (
    [MaSV]     NVARCHAR (100) NOT NULL,
    [HoTen]    NVARCHAR (100) NULL,
    [NgaySinh] DATE           NULL,
    [GioiTinh] NVARCHAR (10)  NULL,
    [Lop]      NVARCHAR (50)  NULL,
    [Khoa]     NVARCHAR (50)  NULL,
    [DiaChi]   NVARCHAR (200) NULL,
    [Email]    NVARCHAR (100) NULL,
    [SDT]      NVARCHAR (20)  NULL,
    CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED ([MaSV] ASC)
);
GO
CREATE TABLE [dbo].[ThuThu] (
    [MaThuThu]         INT            NOT NULL,
    [TenThuThu]        NVARCHAR (100) NULL,
    [GioiTinh]         NVARCHAR (10)  NULL,
    [NgaySinh]         DATE           NULL,
    [DiaChi]           NVARCHAR (255) NULL,
    [SDT]              NVARCHAR (15)  NULL,
    [Email]            NVARCHAR (100) NULL,
    [NgayBatDauLam]    DATE           NULL,
    [NgayNghiViec]     DATE           NULL,
    [TrangThaiLamViec] NVARCHAR (20)  NULL,
    [Khoa]             NVARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([MaThuThu] ASC)
);
GO
CREATE TABLE [dbo].[Sach] (
    [MaSach]     NVARCHAR (100)  NOT NULL,
    [TenSach]    NVARCHAR (100)  NULL,
    [TheLoai]    NVARCHAR (100)  NULL,
    [TacGia]     NVARCHAR (100)  NULL,
    [NhaXuatBan] NVARCHAR (100)  NULL,
    [NamXuatBan] INT             NULL,
    [GiaTien]    DECIMAL (18, 2) NULL,
    [SoLuong]    INT             NULL,
    [TinhTrang]  NVARCHAR (100)  NULL,
    [ChatLuong]  NVARCHAR (100)  NULL,
    CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED ([MaSach] ASC)
);
GO

CREATE TABLE [dbo].[SoMuonTra] (
    [MaMuonSach]       NVARCHAR (100) NOT NULL,
    [MaSach]           NVARCHAR (100) NULL,
    [MaSV]             NVARCHAR (100) NULL,
    [HoTen]            NVARCHAR (100) NULL,
    [TenSach]          NVARCHAR (100) NULL,
    [NgayMuon]         DATE           NULL,
    [NgayTra]          DATE           NULL,
    [TinhTrangMuonTra] NVARCHAR (100) NULL,
    CONSTRAINT [PK_SoMuonTra] PRIMARY KEY CLUSTERED ([MaMuonSach] ASC),
    CONSTRAINT [FK_SoMuonTra_Sach] FOREIGN KEY ([MaSach]) REFERENCES [dbo].[Sach] ([MaSach]),
    CONSTRAINT [FK_SoMuonTra_SinhVien] FOREIGN KEY ([MaSV]) REFERENCES [dbo].[SinhVien] ([MaSV])
);
GO
CREATE TABLE [dbo].[BaoCao] (
    [MaBaoCao]  NVARCHAR (50)  NOT NULL,
    [MaSach]    NVARCHAR (100) NULL,
    [TenSach]   NVARCHAR (100) NULL,
    [ChatLuong] NVARCHAR (100) NULL,
    [SoLuong]   INT            NULL,
    [BoSung]    INT            NULL,
    [HuySach]   INT            NULL,
    CONSTRAINT [PK_BaoCao] PRIMARY KEY CLUSTERED ([MaBaoCao] ASC),
    CONSTRAINT [FK_BaoCao_Sach] FOREIGN KEY ([MaSach]) REFERENCES [dbo].[Sach] ([MaSach])
);
GO
CREATE TABLE [dbo].[MuaSach] (
    [MaGiaoDich] NVARCHAR (50)   NOT NULL,
    [MaSach]     NVARCHAR (100)  NULL,
    [MaSV]       NVARCHAR (100)  NULL,
    [HoTen]      NVARCHAR (100)  NULL,
    [TenSach]    NVARCHAR (100)  NULL,
    [NgayMua]    DATE            NULL,
    [Gia]        DECIMAL (10, 2) NULL,
    [SoLuong]    INT             NULL,
    CONSTRAINT [PK_MuaSach] PRIMARY KEY CLUSTERED ([MaGiaoDich] ASC),
    CONSTRAINT [FK_MuaSach_Sach] FOREIGN KEY ([MaSach]) REFERENCES [dbo].[Sach] ([MaSach]),
    CONSTRAINT [FK_MuaSach_SinhVien] FOREIGN KEY ([MaSV]) REFERENCES [dbo].[SinhVien] ([MaSV])
);
GO
INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Lop, Khoa, DiaChi, Email, SDT ) VALUES
('SV001', 'Nguyễn Văn An', '2000-05-15', 'Nam', 'CNTT1', 'Công nghệ thông tin', ' TP.HCM', 'nguyenvanan@uneti.com', '0912345678'),
('SV002', 'Trần Thị Bình', '2001-03-22', 'Nữ', 'KT1', 'Kế toán', ' TP.HCM', 'tranthibinh@uneti.com', '0987654321'),
('SV003', 'Lê Hoàng Cường', '1999-11-30', 'Nam', 'QTKD1', 'Quản trị kinh doanh', 'TP.HCM', 'lehoangcuong@uneti.com', '0978123456'),
('SV004', 'Phạm Thị Dung', '2000-07-10', 'Nữ', 'NN1', 'Ngoại ngữ', 'TP.HCM', 'phamthidung@uneti.com', '0965432187'),
('SV005', 'Vũ Minh Đức', '2001-01-25', 'Nam', 'CNTT2', 'Công nghệ thông tin', ' TP.HCM', 'vuminhduc@uneti.com', '0932165498'),
('SV006', 'Đặng Thị Hương', '1999-09-18', 'Nữ', 'KT2', 'Kế toán', 'TP.HCM', 'dangthihuong@uneti.com', '0918273645'),
('SV007', 'Hoàng Văn Khải', '2000-12-05', 'Nam', 'QTKD2', 'Quản trị kinh doanh', 'TP.HCM', 'hoangvankhai@uneti.com', '0981234567');

INSERT INTO Sach (MaSach, TenSach, TheLoai, TacGia, NhaXuatBan, NamXuatBan, GiaTien, SoLuong, TinhTrang, ChatLuong) VALUES
('MS001', 'Nhập môn lập trình C++', 'Công nghệ thông tin', 'Trần Văn An', 'NXB Giáo dục', 2020, 120000, 50, 'Còn hàng', 'Tốt'),
('MS002', 'Giáo trình Toán cao cấp', 'Toán học', 'Lê Thị Bình', 'NXB Đại học Quốc gia', 2019, 95000, 30, 'Còn hàng', 'Rất tốt'),
('MS003', 'Lịch sử Việt Nam tập 1', 'Lịch sử', 'Nguyễn Văn Cường', 'NXB Chính trị Quốc gia', 2018, 150000, 0, 'Hết hàng', 'Khá'),
('MS004', 'Kỹ thuật lập trình hướng đối tượng', 'Công nghệ thông tin', 'Phạm Hoàng Dũng', 'NXB Khoa học Kỹ thuật', 2021, 180000, 45, 'Còn hàng', 'Tốt'),
('MS005', 'Từ điển Anh - Việt', 'Ngôn ngữ', 'Vũ Thị Hương', 'NXB Từ điển Bách khoa', 2022, 250000, 15, 'Còn hàng', 'Rất tốt'),
('MS006', 'Cơ sở dữ liệu SQL', 'Công nghệ thông tin', 'Đặng Minh Khải', 'NXB Thông tin & Truyền thông', 2020, 135000, 0, 'Hết hàng', 'Trung bình'),
('MS007', 'Kinh tế vi mô', 'Kinh tế', 'Hoàng Ngọc Lan', 'NXB Kinh tế', 2019, 110000, 35, 'Còn hàng', 'Tốt');

INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, Email, Admin) VALUES
-- Tài khoản Admin (Admin = 1)
('admin', 'admin123', 'admin@uneti.com', 1),
('quantri', 'quantri456', 'quantri@uneti.com', 1),
('nguyenvanA', 'Abc@1234', 'nguyenvana@uneti.com', 1),

-- Tài khoản Người dùng thường (Admin = 0)
('tranthiB', 'Bcd@5678', 'tranthib@uneti.com', 0),
('levanC', 'Cde@9012', 'levanc@uneti.com', 0),
('phamthuD', 'Def@3456', 'phamthud@uneti.com', 0),
('hoangminhE', 'Efg@7890', 'hoangminhe@uneti.com', 0);

INSERT INTO Thuthu (MaThuThu, TenThuThu, GioiTinh, NgaySinh, SDT, Email, NgayBatDauLam, NgayNghiViec, TrangThaiLamViec, Khoa) VALUES
('TT001', 'Nguyễn Thị Mai', 'Nữ', '1985-03-15', '0912345678', 'nguyenthimai@uneti.com', '2010-05-10', NULL, 'Đang làm việc', 'Khoa CNTT'),
('TT002', 'Trần Văn Nam', 'Nam', '1990-07-22', '0987654321', 'tranvannam@uneti.com', '2015-11-20', NULL, 'Đang làm việc', 'Khoa Kế toán'),
('TT003', 'Lê Thị Hương', 'Nữ', '1988-12-30', '0978123456', 'lethihuong@uneti.com', '2012-09-15', '2023-01-10', 'Đã nghỉ việc', 'Khoa Ngoại ngữ'),
('TT004', 'Phạm Văn Đức', 'Nam', '1992-05-18', '0965432187', 'phamvanduc@uneti.com', '2018-03-05', NULL, 'Đang làm việc', 'Khoa QTKD'),
('TT005', 'Vũ Thị Lan', 'Nữ', '1995-09-25', '0932165498', 'vuthilan@uneti.com', '2020-07-01', NULL, 'Đang làm việc', 'Khoa CNTT'),
('TT006', 'Đặng Văn Minh', 'Nam', '1987-11-08', '0918273645', 'dangvanminh@uneti.com', '2013-02-14', '2022-06-30', 'Đã nghỉ việc', 'Khoa Kế toán');

INSERT INTO BaoCao (MaBaoCao, MaSach, TenSach, ChatLuongSach, SoLuong, BoSung, HuySach) VALUES
('BC001', 'MS001', 'Nhập môn lập trình C++', 'Tốt', 5, 10, 0),
('BC002', 'MS002', 'Giáo trình Toán cao cấp', 'Rất tốt', 3, 5, 0),
('BC003', 'MS003', 'Lịch sử Việt Nam tập 1', 'Khá', 0, 0, 15),
('BC004', 'MS004', 'Kỹ thuật lập trình hướng đối tượng', 'Tốt', 2, 8, 0),
('BC005', 'MS005', 'Từ điển Anh - Việt', 'Rất tốt', 1, 5, 0),
('BC006', 'MS006', 'Cơ sở dữ liệu SQL', 'Trung bình', 0, 0, 20),
('BC007', 'MS007', 'Kinh tế vi mô', 'Tốt', 4, 7, 0);

INSERT INTO MuaSach (MaGiaoDich, MaSach, MaSV, HoTen, TenSach, NgayMua, Gia, SoLuong) VALUES
('GD001', 'MS001', 'SV001', 'Nguyễn Văn An', 'Nhập môn lập trình C++', '2023-05-10', 120000, 1),
('GD002', 'MS002', 'SV002', 'Trần Thị Bình', 'Giáo trình Toán cao cấp', '2023-05-12', 95000, 1),
('GD003', 'MS004', 'SV003', 'Lê Hoàng Cường', 'Kỹ thuật lập trình hướng đối tượng', '2023-05-15', 180000, 1),
('GD004', 'MS005', 'SV004', 'Phạm Thị Dung', 'Từ điển Anh - Việt', '2023-05-18', 250000, 1),
('GD005', 'MS007', 'SV005', 'Vũ Minh Đức', 'Kinh tế vi mô', '2023-05-20', 110000, 1),
('GD006', 'MS001', 'SV007', 'Hoàng Văn Khải', 'Nhập môn lập trình C++', '2023-05-25', 120000, 1);

UPDATE MuaSach
SET GiaTien = ms.SoLuong * s.GiaTien
FROM MuaSach ms
INNER JOIN Sach s ON ms.MaSach = s.MaSach;
GO

INSERT INTO SoMuonTra (MaMuonSach, MaSach, MaSV, HoTen, TenSach, NgayMuon, NgayTra, TinhTrangMuonTra) VALUES
('MS001', 'MS001', 'SV001', 'Nguyễn Văn An', 'Nhập môn lập trình C++', '2023-05-01', '2023-05-15', 'Đã trả'),
('MS002', 'MS002', 'SV002', 'Trần Thị Bình', 'Giáo trình Toán cao cấp', '2023-05-03', '2023-05-17', 'Đã trả'),
('MS003', 'MS004', 'SV003', 'Lê Hoàng Cường', 'Kỹ thuật lập trình hướng đối tượng', '2023-05-05', '2023-05-19', 'Đã trả'),
('MS004', 'MS005', 'SV004', 'Phạm Thị Dung', 'Từ điển Anh - Việt', '2023-05-07', NULL, 'Quá hạn'),
('MS005', 'MS007', 'SV005', 'Vũ Minh Đức', 'Kinh tế vi mô', '2023-05-10', '2023-05-24', 'Đã trả');

SELECT TOP 1 Sach.MaSach, Sach.TenSach, Sach.TacGia, COUNT(SoMuonTra.MaSach) AS LuotMuon
FROM SoMuonTra
INNER JOIN Sach ON SoMuonTra.MaSach = Sach.MaSach
WHERE SoMuonTra.TinhTrangMuonTra like  N'Đã trả' COLLATE SQL_Latin1_General_CP1_CI_AI
GROUP BY Sach.MaSach, Sach.TenSach, Sach.TacGia
ORDER BY LuotMuon DESC ;

SELECT TOP 1 Sach.MaSach, Sach.TenSach, Sach.TacGia, SUM(MuaSach.SoLuong) AS LuotMua
FROM MuaSach
INNER JOIN Sach ON MuaSach.MaSach = Sach.MaSach
GROUP BY Sach.MaSach, Sach.TenSach, Sach.TacGia
ORDER BY LuotMua DESC  ;









