CREATE DATABASE dtQLTraSua
GO

USE dtQLTraSua
GO

--Create Table
CREATE TABLE TypeAccount
(
	idTypeAccount INT IDENTITY PRIMARY KEY NOT NULL,
	nameTypeAccount NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE AccountD
(
	userName NVARCHAR(100) PRIMARY KEY NOT NULL ,
	displayName NVARCHAR(100) NOT NULL ,
	password NVARCHAR(1000) NOT NULL , 
	idTypeAccount INT NOT NULL ,

	FOREIGN KEY (idTypeAccount) REFERENCES TypeAccount(idTypeAccount) 
)
GO

CREATE TABLE TableD
(
	idTableD INT IDENTITY PRIMARY KEY NOT NULL,
	nameTable NVARCHAR(100) NOT NULL , 
	numberPeople INT NOT NULL DEFAULT 0,
	status INT NOT NULL  DEFAULT 0 -- 0 là còn 1 là trống
)
GO

CREATE TABLE CategoriesD
(
	idCategoriesD INT IDENTITY PRIMARY KEY NOT NULL,
	nameCategories NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE SizeDrink
(
	idSizeDrink INT IDENTITY PRIMARY KEY NOT NULL,
	nameSizeDrink NVARCHAR(100) NOT NULL
)
GO

CREATE TABLE Drink
(
	idDrink INT IDENTITY PRIMARY KEY NOT NULL,
	nameDrink NVARCHAR(100) NOT NULL, 
	price float NOT NULL,
	idSizeDrink INT NOT NULL,
	picture IMAGE,
	idCategoriesD INT NOT NULL

	FOREIGN KEY (idCategoriesD) REFERENCES CategoriesD(idCategoriesD) ,
	FOREIGN KEY (idSizeDrink) REFERENCES SizeDrink(idSizeDrink) 
)
GO

CREATE TABLE cateNhanvien
(
	idCateNV INT IDENTITY PRIMARY KEY,
	cateNhanVien NVARCHAR(100) NOT NULL
)
GO
CREATE TABLE NhanVien
(
	idNhanVien INT IDENTITY PRIMARY KEY,
	maNhanVien NVARCHAR(10) NOT NULL,
	tenNhanVien NVARCHAR(100) NOT NULL,
	idCateNV INT NOT NULL DEFAULT 1 -- 1 là part - time, 2 là full - time
	
	FOREIGN KEY (idCateNV) REFERENCES cateNhanVien(idCateNV) 
)
GO

CREATE TABLE NgayLuong
(
	idNgayLuong INT IDENTITY PRIMARY KEY,
	idNhanVien INT NOT NULL,
	ngay DATE NOT NULL DEFAULT GETDATE(),
	luongNgay FLOAT DEFAULT 0,
	luongCon FLOAT DEFAULT 0,
	tongLuong FLOAT DEFAULT 0
	FOREIGN KEY (idNhanVien) REFERENCES NhanVien(idNhanVien)
)
GO
--INSERT Table

-- Drink

-- Size Drink
INSERT SizeDrink
(
	nameSizeDrink
)
VALUES
(
	N'Lớn'
)
INSERT SizeDrink
(
	nameSizeDrink
)
VALUES
(
	N'Trung bình'
)
INSERT SizeDrink
(
	nameSizeDrink
)
VALUES
(
	N'Nhỏ'
)
GO
-- TypeAccount
INSERT TypeAccount
(
	nameTypeAccount
)
VALUES
(
	N'admin'
)
INSERT TypeAccount
(
	nameTypeAccount
)
VALUES
(
	N'user'
)
GO
-- AccountD
INSERT AccountD
(
	userName, displayName , password , idTypeAccount
)
VALUES
(	N'admin', N'Nhan' , N'222169221178921913582207772364834422165' , 1)
GO

INSERT TableD
(
	nameTable
)
VALUES
(
	N'1'
)
INSERT TableD
(
	nameTable
)
VALUES
(
	N'2'
)
INSERT TableD
(
	nameTable
)
VALUES
(
	N'3'
)
INSERT TableD
(
	nameTable
)
VALUES
(
	N'4'
)
INSERT TableD
(
	nameTable
)
VALUES
(
	N'5'
)
INSERT TableD
(
	nameTable
)
VALUES
(
	N'6'
)
INSERT TableD
(
	nameTable
)
VALUES
(
	N'7'
)
INSERT TableD
(
	nameTable
)
VALUES
(
	N'8'
)
INSERT TableD
(
	nameTable
)
VALUES
(
	N'9'
)
INSERT TableD
(
	nameTable
)
VALUES
(
	N'10'
)
GO

--Insert Categories
INSERT CategoriesD
(
	nameCategories
)
VALUES
(
	N'Trà sữa'
)
INSERT CategoriesD
(
	nameCategories
)
VALUES
(
	N'Trà đào'
)
INSERT CategoriesD
(
	nameCategories
)
VALUES
(
	N'Bánh'
)
INSERT CategoriesD
(
	nameCategories
)
VALUES
(
	N'Thức ăn nhanh'
)
INSERT CategoriesD
(
	nameCategories
)
VALUES
(
	N'Capuchino'
)
INSERT CategoriesD
(
	nameCategories
)
VALUES
(
	N'Yoshake'
)
INSERT CategoriesD
(
	nameCategories
)
VALUES
(
	N'Soda'
)
GO

INSERT Drink
(
	nameDrink , price ,  idSizeDrink , idCategoriesD
)
VALUES
(
	N'Trà sữa trà xanh' , 15000 , 1 , 1
)
INSERT Drink
(
	nameDrink , price ,  idSizeDrink , idCategoriesD
)
VALUES
(
	N'Trà sữa Socola' , 15000 , 1 , 1
)
INSERT Drink
(
	nameDrink , price ,  idSizeDrink , idCategoriesD
)
VALUES
(
	N'Trà đào có đào' , 12000 , 1 , 2
)
INSERT Drink
(
	nameDrink , price ,  idSizeDrink , idCategoriesD
)
VALUES
(
	N'Trà đào không đào' , 10000 , 1 , 2
)
INSERT Drink
(
	nameDrink , price ,  idSizeDrink , idCategoriesD
)
VALUES
(
	N'Trà sữa trà xanh' , 12000 , 3 , 1
)
INSERT Drink
(
	nameDrink , price ,  idSizeDrink , idCategoriesD
)
VALUES
(
	N'Trà sữa Socola' , 12000 , 3 , 1
)
INSERT Drink
(
	nameDrink , price ,  idSizeDrink , idCategoriesD
)
VALUES
(
	N'Phô mai que' , 10000 , 1 , 4
)
INSERT Drink
(
	nameDrink , price ,  idSizeDrink , idCategoriesD
)
VALUES
(
	N'Bánh rán Đô rê mon' , 10000 , 1 , 3
)

GO
INSERT cateNhanvien
(
	cateNhanVien
)
VALUES
(
	N'Part-Time'
)
INSERT cateNhanvien
(
	cateNhanVien
)
VALUES
(
	N'Full-Time'
)
GO
INSERT NhanVien
(
	maNhanVien , tenNhanVien , idCateNV
)
VALUES
(
	N'P001' , N'Dương Ngọc Nhẫn' , 1
)
INSERT NhanVien
(
	maNhanVien , tenNhanVien , idCateNV
)
VALUES
(
	N'P002' , N'Nguyễn Thị Huyền' , 1
)
INSERT NhanVien
(
	maNhanVien , tenNhanVien , idCateNV
)
VALUES
(
	N'F001' , N'Đỗ Anh Tâm' , 2
)
INSERT NhanVien
(
	maNhanVien , tenNhanVien , idCateNV
)
VALUES
(
	N'F002' , N'Thái Văn Sơn' , 2
)
GO

INSERT NgayLuong
(
	idNhanVien
)
VALUES
(
	1
)
INSERT NgayLuong
(
	idNhanVien
)
VALUES
(
	2
)
INSERT NgayLuong
(
	idNhanVien
)
VALUES
(
	3
)
INSERT NgayLuong
(
	idNhanVien
)
VALUES
(
	4
)
GO
--Create proc
CREATE PROC USP_CheckLogin
@useName NVARCHAR(100),
@password NVARCHAR(1000)
AS
BEGIN
	SELECT * FROM AccountD WHERE userName = @useName AND password = @password
END
GO
CREATE PROC USP_AddAccountByUserName
@userName NVARCHAR(100),
@displayName NVARCHAR(100),
@idTypeAccount INT,
@password NVARCHAR(1000)
AS
BEGIN
	INSERT AccountD
	(
		userName , displayName , idTypeAccount , password
	)
	VALUES
	(
		@userName , @displayName , @idTypeAccount , @password
	)
END
GO

CREATE PROC USP_UpdateAccountByUserNameNoPass
@userName NVARCHAR(100) , 
@displayName NVARCHAR(100) , 
@idTypeAccount INT
AS
BEGIN
	UPDATE AccountD
	SET displayName = @displayName , idTypeAccount = @idTypeAccount
	WHERE userName = @userName
END
GO

CREATE PROC USP_UpdateAccountByUserName
@userName NVARCHAR(100),
@displayName NVARCHAR(100),
@idTypeAccount INT,
@password NVARCHAR(1000)
AS
BEGIN
	UPDATE AccountD
	SET displayName = @displayName , idTypeAccount = @idTypeAccount , password = @password
	WHERE userName = @userName
END
GO

CREATE PROC USP_AddTable
@nameTable NVARCHAR(100)
AS
BEGIN
	INSERT TableD 
	(
		nameTable
	)
	VALUES
	(
		@nameTable
	)
END
GO

CREATE PROC USP_AddNewCategories
@nameCategories NVARCHAR(100)
AS
BEGIN
	INSERT CategoriesD
	(
		nameCategories
	)
	VALUES
	(
		@nameCategories
	)
END
GO

CREATE PROC USP_UpdateCategoriesName
@nameold NVARCHAR(100),
@namenew NVARCHAR(100)
AS
BEGIN
	UPDATE CategoriesD
	SET nameCategories = @namenew
	WHERE nameCategories = @nameold
END
GO

CREATE PROC USP_GetListDrinkByToDtgv
AS
BEGIN
	SELECT nameDrink , nameCategories , nameSizeDrink , price
	FROM (Drink INNER JOIN SizeDrink ON Drink.idSizeDrink = SizeDrink.idSizeDrink) INNER JOIN CategoriesD ON Drink.idCategoriesD = CategoriesD.idCategoriesD
END
GO

CREATE PROC USP_AddDrinkNoImagge
@nameDrink NVARCHAR(100),
@price FLOAT,
@idCategoriesD INT,
@idSizeDrink INT
AS
BEGIN
	INSERT Drink
	(
		nameDrink , price , idCategoriesD , idSizeDrink
	)
	VALUES
	(
		@nameDrink , @price ,@idCategoriesD , @idSizeDrink
	)
END
GO

CREATE PROC USP_AddDrinkWithImage
@nameDrink NVARCHAR(100),
@price FLOAT,
@idCategoriesD INT,
@idSizeDrink INT,
@picture IMAGE
AS
BEGIN
	INSERT Drink
	(
		nameDrink , price , idCategoriesD , idSizeDrink , picture
	)
	VALUES
	(
		@nameDrink , @price ,@idCategoriesD , @idSizeDrink , @picture
	)
END
GO


CREATE PROC USP_EditDrinkNoImage
@nameDrink NVARCHAR(100),
@price FLOAT,
@idCategoriesD INT,
@idSizeDrink INT,
@idDrink INT
AS
BEGIN
	UPDATE Drink
	SET nameDrink = @nameDrink , price = @price , idCategoriesD = @idCategoriesD , idSizeDrink = @idSizeDrink
	WHERE idDrink = @idDrink
END
GO

CREATE PROC USP_EditDrinkWithImage
@nameDrink NVARCHAR(100),
@price FLOAT,
@idCategoriesD INT,
@idSizeDrink INT,
@picture IMAGE,
@idDrink INT
AS
BEGIN
	UPDATE Drink
	SET nameDrink = @nameDrink , price = @price , idCategoriesD = @idCategoriesD , idSizeDrink = @idSizeDrink , picture = @picture
	WHERE idDrink = @idDrink
END
GO
--Select



--Table Date cho Calendar
SELECT * FROM NgayLuong
SELECT * FROM NhanVien