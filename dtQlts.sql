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
	idTableD INT IDENTITY(0, 1) PRIMARY KEY NOT NULL,
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
	idCategoriesD INT NOT NULL, 

	MaDrink AS CASE idCategoriesD
			WHEN 1 THEN 
			(IIF(idDrink < 10 , ISNULL(N'TS0000' + CAST(idDrink AS NVARCHAR(10)), 'X') , ISNULL(N'TS000' + CAST(idDrink AS NVARCHAR(10)), 'X')))
			WHEN 2 THEN 
			(IIF(idDrink < 10 , ISNULL(N'TD0000' + CAST(idDrink AS NVARCHAR(10)), 'X') , ISNULL(N'TD000' + CAST(idDrink AS NVARCHAR(10)), 'X')))
			WHEN 3 THEN 
			(IIF(idDrink < 10 , ISNULL(N'BA0000' + CAST(idDrink AS NVARCHAR(10)), 'X') , ISNULL(N'BA000' + CAST(idDrink AS NVARCHAR(10)), 'X')))
			WHEN 4 THEN 
			(IIF(idDrink < 10 , ISNULL(N'TAN0000' + CAST(idDrink AS NVARCHAR(10)), 'X') , ISNULL(N'TAN000' + CAST(idDrink AS NVARCHAR(10)), 'X')))
			WHEN 5 THEN 
			(IIF(idDrink < 10 , ISNULL(N'CA0000' + CAST(idDrink AS NVARCHAR(10)), 'X') , ISNULL(N'CA000' + CAST(idDrink AS NVARCHAR(10)), 'X')))
			WHEN 6 THEN 
			(IIF(idDrink < 10 , ISNULL(N'YO0000' + CAST(idDrink AS NVARCHAR(10)), 'X') , ISNULL(N'YO000' + CAST(idDrink AS NVARCHAR(10)), 'X')))
			WHEN 7 THEN 
			(IIF(idDrink < 10 , ISNULL(N'SA0000' + CAST(idDrink AS NVARCHAR(10)), 'X') , ISNULL(N'SA000' + CAST(idDrink AS NVARCHAR(10)), 'X')))
			ELSE ISNULL(N'K000' + CAST(idDrink AS NVARCHAR(10)), 'X')
	END,
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
	idCateNV INT NOT NULL DEFAULT 1, -- 1 là part - time, 2 là full - time
	luongUncheck FLOAT DEFAULT 0,
	luongCashout FLOAT DEFAULT 0,
	MaNV AS CASE idCateNV
	WHEN 1 THEN 
			ISNULL(N'PT0000' + CAST(idNhanVien AS NVARCHAR(10)), 'X')
			ELSE ISNULL(N'FT000' + CAST(idNhanVien AS NVARCHAR(10)), 'X')
			END,
	FOREIGN KEY (idCateNV) REFERENCES cateNhanVien(idCateNV) 
)
GO
CREATE TABLE NgayLuong
(
	idNgayLuong INT IDENTITY PRIMARY KEY,
	idNhanVien INT NOT NULL,
	ngay DATE NOT NULL DEFAULT GETDATE(),
	luongNgay FLOAT DEFAULT 0,
	cateL INT DEFAULT 0,
	FOREIGN KEY (idNhanVien) REFERENCES NhanVien(idNhanVien)
)
GO

CREATE TABLE ThanhToan
(
	idThanhToan INT IDENTITY PRIMARY KEY,
	idNhanVien INT NOT NULL,
	dateCheckout DATE DEFAULT GETDATE(),
	luongCheckout FLOAT NOT NULL,
	MaTT AS ISNULL(N'TT0000'  + CAST(idNhanVien AS NVARCHAR(10)) + CAST(DATEPART(day , dateCheckout) as NVARCHAR(10)) + CAST(idThanhToan as NVARCHAR(10)), 'X')
)
GO

CREATE TABLE Bill
(
	idBill INT IDENTITY PRIMARY KEY,
	idTableD INT NOT NULL, -- 0 là take away
	nmPeople INT NOT NULL,
	getIn DATETIME NOT NULL DEFAULT GETDATE(),
	getOut DATETIME , 
	statusBill INT NOT NULL DEFAULT 0,
	sale FLOAT NOT NULL DEFAULT 0,
	totalPrice FLOAT NOT NULL DEFAULT 0, -- 0 trống 1 , có người
	MaBill AS CASE idTableD
			WHEN 0 THEN 
			(IIF(idBill < 10 , ISNULL(N'TK00' + CAST(idTableD AS NVARCHAR(10)) + CAST(idBill AS NVARCHAR(10)), 'X') , ISNULL(N'TK0'+ CAST(idTableD AS NVARCHAR(10)) + CAST(idBill AS NVARCHAR(10)), 'X')))
			ELSE (IIF(idBill < 10 , ISNULL(N'TB00'+ CAST(idTableD AS NVARCHAR(10)) + CAST(idBill AS NVARCHAR(10)), 'X') , ISNULL(N'TB0'+ CAST(idTableD AS NVARCHAR(10)) + CAST(idBill AS NVARCHAR(10)), 'X')))
	END,
	FOREIGN KEY (idTableD) REFERENCES TableD (idTableD)
)
GO

CREATE TABLE BillInfo
(
	idBillInfo INT IDENTITY PRIMARY KEY, 
	idBill INT NOT NULL,
	idDrink INT NOT NULL,
	countD INT NOT NULL DEFAULT 1,
	price FLOAT NOT NULL DEFAULT 0,
	MaBill AS CASE IIF(idBillInfo > 10 , 1 ,2)
			WHEN 1 THEN 
				ISNULL(N'MA00' + CAST(idDrink AS NVARCHAR(10)) + CAST(idBillInfo AS NVARCHAR(10)), 'X')
			ELSE ISNULL(N'BT00'+ CAST(idDrink AS NVARCHAR(10)) + CAST(idBillInfo AS NVARCHAR(10)), 'X')
	END,
	FOREIGN KEY (idBill) REFERENCES Bill (idBill) ,
	FOREIGN KEY (idDrink) REFERENCES Drink (idDrink)
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
	N'Take away'
)

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

CREATE PROC USP_UpdateLuongNgay
@idNgayLuong INT,
@idNhanVien INT,
@cateL INT,
@luongNgay FLOAT
AS
BEGIN
	UPDATE NgayLuong
	SET idNhanVien = @idNhanVien , cateL = @cateL , luongNgay = @luongNgay 
	WHERE idNhanVien = @idNhanVien
END
GO

CREATE PROC USP_InsertNgayLuong
@idNhanVien INT,
@cateL INT,
@luongNgay FLOAT
AS
BEGIN
	INSERT NgayLuong
	(
		idNhanVien , cateL , luongNgay
	)
	VALUES
	(
		@idNhanVien , @cateL , @luongNgay
	)
END
GO

CREATE PROC USP_GetListDrinkByIdCategory
@idCategoriesD INT
AS
BEGIN
	SELECT nameDrink FROM Drink WHERE idCategoriesD = @idCategoriesD
	GROUP BY nameDrink
END
GO



CREATE PROC USP_InsertNewBillTable
@idTableD INT,
@nmPeople INT
AS
BEGIN
	INSERT Bill
	(
		idTableD , nmPeople
	)
	VALUES
	(
		@idTableD , @nmPeople
	)
END
GO

CREATE PROC USP_UpdateStatusTable
@idTableD INT
AS
BEGIN
	UPDATE TableD
	SET status = 1
	WHERE idTableD = @idTableD
END
GO
SELECT * FROM Bill
CREATE PROC USP_AddBillInfoByIdBill
@idBill INT , 
@idDrink INT ,
@countD INT,
@price FLOAT
AS
BEGIN
	INSERT BillInfo
	(
		idBill , idDrink , countD , price
	)
	VALUES
	(
		@idBill , @idDrink , @countD , @price
	)
END
GO

CREATE PROC USP_DeleteBillInfoById
@idBillInfo INT
AS
BEGIN
	DELETE FROM BillInfo
	WHERE idBillInfo = @idBillInfo
END
GO

CREATE PROC UpdateBillInfoById
@countD INT,
@price FLOAT , 
@idBillInfo INT
AS
BEGIN
	UPDATE BillInfo
	SET countD += @countD , price += @price
	WHERE idBillInfo = @idBillInfo
END
GO

CREATE PROC USP_UpdateAccountByUserNameNoType
@userName NVARCHAR(100),
@displayName NVARCHAR(100),
@password NVARCHAR(1000)
AS
BEGIN
	UPDATE AccountD
	SET displayName = @displayName , password = @password
	WHERE userName = @userName
END
GO

CREATE PROC USP_InsertNhanvien 
@tenNhanVien NVARCHAR(100), 
@idCateNV INT
AS
BEGIN
	INSERT NhanVien
	(
		tenNhanVien  , idCateNV , maNhanVien
	)
	VALUES
	(
		@tenNhanVien , @idCateNV , N'default'
	)
END
GO

CREATE PROC USP_CheckOutBill
@idBill INT, 
@sale FLOAT, 
@totalPrice FLOAT, 
@getOut DATETIME
AS
BEGIN
	UPDATE Bill
	SET getOut = @getOut , statusBill = 1 , sale = @sale , totalPrice = @totalPrice
	WHERE idBill = @idBill
END
GO

CREATE PROC USP_CleanTableByIdTable
@idTableD INT
AS
BEGIN
	UPDATE TableD
	SET status = 0
	WHERE idTableD = @idTableD
END
GO

CREATE VIEW BC_DoanhSo
AS
SELECT Count(idBill) as soBill , cast(getIn as date) as dates  , SUM(totalPrice*100 /(100 - sale)) as tongtien , SUM(totalPrice*100 /(100 - sale) - totalPrice) as sale, SUM(totalPrice) as totalPrice
FROM Bill 
WHERE statusBill = 1
GROUP BY cast(getIn as date)
GO

CREATE VIEW DrinkPerTime
AS
SELECT  MaDrink , nameDrink , soLuong , days
FROM Drink INNER JOIN
	(SELECT SUM(countD) as soLuong , idDrink as categories , cast(getIn as date) as days
	FROM Bill INNER JOIN BillInfo
		ON Bill.idBill = BillInfo.idBill
	WHERE Bill.statusBill = 1
	GROUP BY cast(getIn as date) , idDrink) as B
	ON Drink.idDrink = B.categories
GO


CREATE PROC NumberCategoriesOnAll
@idCategoriesD INT, 
@getIn DATE
AS
BEGIN
	SELECT SUM(countD)
	FROM Drink as d INNER JOIN BillInfo as i ON d.idDrink = i.idDrink INNER JOIN Bill as b ON i.idBill = b.idBill
	WHERE b.statusBill = 1 AND d.idCategoriesD = @idCategoriesD AND cast(getIn as Date) = @getIn
END
GO 

CREATE PROC DrinkPerWeek
@days DATE
AS
BEGIN
	SELECT MaDrink , nameDrink ,  Sum(soLuong) as soLuong
	FROM DrinkPerTime 
	WHERE days BETWEEN  DATEADD(DAY , -6,  @days)  AND @days
	GROUP BY nameDrink , MaDrink
	ORDER BY soLuong DESC
END
GO


CREATE PROC AllProductsSale
@getIn DATE
AS
SELECT SUM(countD)
	FROM BillInfo as i INNER JOIN Bill as b ON i.idBill = b.idBill
	WHERE b.statusBill = 1 AND cast(getIn as Date) = @getIn
GO

CREATE PROC BC_DoanhThuNgay
@date DATE
AS
BEGIN
	SELECT  MaBill , totalPrice*100 /(100 - sale) as tongtien , totalPrice*100 /(100 - sale) - totalPrice as sale, totalPrice , cast(getIn as date) as date
	FROM Bill 
	WHERE statusBill = 1 AND cast(getIn as date) = @date
END
GO

CREATE PROC BC_DoanhThuTuan
@days DATE
AS
BEGIN
	SELECT * FROM BC_DoanhSo
	WHERE dates BETWEEN  DATEADD(DAY , -6,  @days)  AND @days
END
GO


CREATE PROC BC_DoanhThuThang
@date DATE
AS
BEGIN
	SELECT * FROM BC_DoanhSo
	WHERE dates BETWEEN DATEADD(DAY,1,EOMONTH(@date,-1)) AND EOMONTH(@date)
END
GO

CREATE PROC USP_TKTakeAway
AS
BEGIN
	SELECT t.nmTK , b.nmBill , t.days
	FROM (SELECT COUNT(idBill) as nmTK, CAST(getIn as date) as days
	FROM Bill
	WHERE idTableD = 0
	GROUP BY CAST(getIn as date)) as t INNER JOIN (SELECT COUNT(idBill) as nmBill, CAST(getIn as date) as days
	FROM Bill
	GROUP BY CAST(getIn as date)) as b
	ON t.days = b.days
END
GO

CREATE PROC UpdateLuongNV
@idNhanVien INT,
@cateNew FLOAT,
@cateOld FLOAT
AS
BEGIN
	UPDATE NhanVien
	SET luongUncheck = luongUncheck + (@cateNew - @cateOld)
	WHERE idNhanVien = @idNhanVien
END
GO

CREATE PROC AddLuongNV
@idNhanVien INT,
@cateNew FLOAT
AS
BEGIN
	UPDATE NhanVien
	SET luongUncheck = luongUncheck + @cateNew
	WHERE idNhanVien = @idNhanVien
END
GO

CREATE PROC USP_Cashout
@idNhanVien INT,
@luongCheckout FLOAT
AS
BEGIN
	INSERT ThanhToan
	(
		idNhanVien , luongCheckout
	)
	VALUES
	(
		@idNhanVien , @luongCheckout
	)
END
GO

CREATE PROC UpdateNVCashout
@idNhanVien INT
AS
BEGIN
	UPDATE NhanVien
	SET luongUncheck = 0 , luongCashout = luongCashout + luongUncheck
	WHERE idNhanVien = @idNhanVien
END
GO

CREATE PROC BC_LuongNV
@date as DATE
AS
BEGIN
	SELECT tenNhanVien , SUM(luongUncheck + luongCashout) as totalLuong,  SUM(luongUncheck) as uncheckLuong, SUM(luongCashout) as checkLuong 
	FROM (NhanVien INNER JOIN ThanhToan ON NhanVien.idNhanVien = ThanhToan.idNhanVien)
	WHERE dateCheckout BETWEEN DATEADD(DAY,1,EOMONTH(@date,-1)) AND EOMONTH(@date)
	GROUP BY tenNhanVien
END
GO

SELECT soLuong FROM DrinkPerTime 
WHERE nameDrink = N'Trà sữa trà xanh'
SELECT * FROM Bill
SELECT * FROM NgayLuong
SELECT * FROM NhanVien
SELECT * FROM ThanhToan

