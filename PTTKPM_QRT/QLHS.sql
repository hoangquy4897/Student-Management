Create database QLHS

go

use QLHS

go

create table HOCSINH
(
	MaHS int not null primary key,
	HoTen nvarchar(100),
	Phai nvarchar(3),
	NgaySinh datetime,
	DiaChi nvarchar (250),
	MaLop varchar(2),
	MaKhoi int,
	SDT char(12)
)

go

create table KHOI
(
	MaKhoi int not null primary key,
	TenKhoi nvarchar(15),
	SoLopToiDa int
)

go

create table LOP
(
	MaLop varchar(2)not null,
	MaKhoi int not null,
	TenLop varchar (10),
	SiSo int
	primary key (MaLop, MaKhoi)
)

go

create table MONHOC
(
	MaMonHoc varchar(10)not null primary key,
	TenMonHoc nvarchar(25)
)

go

Create table HOCKY
(
	MaHocKy varchar(2)not null,
	NamHoc int not null
	primary key(MaHocKy, NamHoc)
)

go

create table DIEMMON
(
	MaHS int not null,
	MaMonHoc varchar(10) not null,
	MaHocKy varchar(2) not null,
	NamHoc int not null,
	DiemTrungBinh float
	primary key (MaHS,MaMonHoc,MaHocKy,NamHoc)
)

go

create table CHITIETDIEM
(
	MaHS int not null,
	MaMonHoc varchar(10) not null,
	MaHocKy varchar(2) not null,
	NamHoc int not null,
	MaKT varchar(3) not null,
	Diem float,
	Lan int not null
	primary key(MaHS,MaMonHoc,MaHocKy,NamHoc, MaKT,Lan)
)

go

create table LOAIKIEMTRA
(
	MaLKT varchar(3) not null primary key,
	TenLKT nvarchar(25),
)

go

create table QUYDINH
(
	MAQD int not null primary key,
	TenQD nvarchar(25),
	GhiChu nvarchar (250),
)

go

create table TAIKHOAN
(
	LoaiTaiKhoan varchar(2),
	ID varchar(7) not null primary key,
	Pass varchar (25),
)

go

create table VANG
(
	MaHS int not null,
	Vang int,
	MaHocKy varchar(2) not null,
	NamHoc int not null
	primary key(MaHS,MaHocKy,NamHoc)
)

alter table HOCSINH 
add constraint FK_HOCSINH_LOP
foreign key (MaLop, MaKhoi)
references LOP(MaLop, MaKhoi)

go

alter table LOP 
add constraint FK_LOP_KHOI
foreign key (MaKhoi)
references KHOI(MaKhoi)

go

alter table CHITIETDIEM
add constraint FK_CHITIETDIEM_HOCSINH
foreign key (MaHS)
references HOCSINH(MaHS)

go 

alter table CHITIETDIEM
add constraint FK_CHITIETDIEM_MONHOC
foreign key (MaMonHoc)
references MONHOC(MaMonHoc)

go

alter table CHITIETDIEM
add constraint FK_CHITIETDIEM_HOCKY
foreign key (MaHocKy,NamHoc)
references HOCKY(MaHocKy, NamHoc)


go

alter table CHITIETDIEM
add constraint FK_CHITIETDIEM_LOAIKIEMTRA
foreign key (MaKT)
references LOAIKIEMTRA (MaLKT)

go

alter table CHITIETDIEM
add constraint FK_CHITIETDIEM_DIEMMON
foreign key (MaHS,MaMonHoc,MaHocKy,NamHoc)
references DIEMMON(MaHS,MaMonHoc,MaHocKy,NamHoc)

go 

alter table VANG
add constraint FK_VANG_HOCSINH
foreign key (MaHS)
references HOCSINH(MaHS)

go 

alter table VANG
add constraint FK_VANG_HOCKY
foreign key (MaHocKy,NamHoc)
references HOCKY(MaHocKy,NamHoc)

go 

insert into TAIKHOAN values ('GV','GV001','admin001')
insert into TAIKHOAN values ('GV','GV002','admin002')
insert into TAIKHOAN values ('GV','GV003','admin003')
insert into TAIKHOAN values ('GV','GV004','admin004')


insert into TAIKHOAN values ('HS','10001','hs10001')
insert into TAIKHOAN values ('HS','10002','hs10002')
insert into TAIKHOAN values ('HS','11001','hs11001')
insert into TAIKHOAN values ('HS','11002','hs11002')
insert into TAIKHOAN values ('HS','12001','hs12001')

insert into QUYDINH values (1,N'Quy Định 1',N'Tuổi học sinh lớn hơn 15 và bé hơn 20')
insert into QUYDINH values (2,N'Quy Đinh 2',N'Có 3 khối lớp: 10,11,12. Khối 10 có 4 lớp: 10A1, 10A2, 10A3, 10A4. Khối 11 có 3 lớp: 11A1,11A2, 11A3. Khối 12 có 2 lớp: 12A1, 12A2. Mỗi lớp có không quá 40 hs')
insert into QUYDINH values (3,N'Quy Định 3',N'Có 2 học kỳ (I,II). Có 9 môn học (Toán, Lý, Hóa, Sinh, Sử, Địa, Văn, Đạo đức, Thể dục)')
insert into QUYDINH values (4,N'Quy Định 4',N'Học sinh đạt môn nếu có điểm trung bình >= 5.')
insert into QUYDINH values (5,N'Quy Định 5',N'Người dùng có thể thay đổi các qui định: QĐ1: Thay đổi tuổi tối thiểu, tối đa. QĐ2: Thay đổi sĩ số tối đa của các lớp, số lượng và tên các lớp trong trường. QĐ4: Thay đổi số lượng và tên các môn học. QĐ5: Thay đổi điểm chuẩn đạt môn')

insert into LOAIKIEMTRA values ('M',N'Miệng')
insert into LOAIKIEMTRA values ('15P',N'15 Phút')
insert into LOAIKIEMTRA values ('1T',N'1 Tiết')
insert into LOAIKIEMTRA values ('HK',N'Thi Học Kỳ')


insert into MONHOC values ('T',N'Toán')
insert into MONHOC values ('L',N'Lý')
insert into MONHOC values ('H',N'Hóa')
insert into MONHOC values ('Si',N'Sinh')
insert into MONHOC values ('Su',N'Sử')
insert into MONHOC values ('D',N'Địa')
insert into MONHOC values ('V',N'Văn')
insert into MONHOC values ('DD',N'Đạo Đức')
insert into MONHOC values ('TD',N'Thể Dục')

insert into HOCKY values ('I',2016)
insert into HOCKY values ('II',2016)
insert into HOCKY values ('I',2017)
insert into HOCKY values ('II',2017)


insert into KHOI values (10,N'Khối 10',4)
insert into KHOI values (11,N'Khối 11',3)
insert into KHOI values (12,N'Khối 12',2)


insert into LOP values ('A1',10,'10A1',1)
insert into LOP values ('A2',10,'10A2',1)
insert into LOP values ('A3',10,'10A3',0)
insert into LOP values ('A4',10,'10A4',0)
insert into LOP values ('A1',11,'11A1',0)
insert into LOP values ('A2',11,'11A2',1)
insert into LOP values ('A3',11,'11A3',1)
insert into LOP values ('A1',12,'12A1',1)
insert into LOP values ('A2',12,'10A2',0)

insert into HOCSINH values (10001,N'Nguyễn Văn An',N'Nam','6/21/2002',N'205, Phan Huy Ích, Gò Vấp, TP HCM', 'A1',10, '0908765432')
insert into HOCSINH values (10002,N'Nguyễn Văn Huy',N'Nam','3/17/2002',N'206, Nguyễn Văn Công, Gò Vấp, TP HCM', 'A2',10, '01233232233')
insert into HOCSINH values (11001,N'Nguyễn Thị Linh',N'Nữ','5/6/2001',N'123, Nguyễn Văn Cừ, Q5, TP HCM', 'A2',11, '0987656763')
insert into HOCSINH values (11002,N'Trần Anh Tuấn',N'Nam','4/19/2001',N'207, Nguyễn Đình Chiểu, Q3, TP HCM', 'A3',11, '0983355733')
insert into HOCSINH values (12001,N'Nguyễn Thị Oanh',N'Nữ','9/5/2000',N'56, Trần Cao Vân, Phú Nhuận, TP HCM', 'A1',12, '0981864511')

insert into HOCSINH values (10003,N'Nguyễn Thanh Phương',N'Nam','12/30/2003',N'205, Nguyễn Kiệm, Gò Vấp, TP HCM', NULL, 10, '01687699127')
insert into HOCSINH values (10004,N'Trần Huỳnh Trường Huy',N'Nam','5/27/2001',N'20, Nguyễn Văn Nghi, P7, Gò Vấp, TP HCM', NULL, 10, '0987655234')
insert into HOCSINH values (11003,N'Nguyễn Thị Yến Nhi',N'Nữ','10/16/2001',N'45, Lê Đức Thọ, P5, Gò Vấp, TP HCM', NULL, 11, '01693373663')
insert into HOCSINH values (11004,N'Bùi Hữu Phước',N'Nam','7/29/2001',N'227, Phạm Văn Chiêu,P14, Gò Vấp, TP HCM', NULL, 11, '0981865523')
insert into HOCSINH values (12002,N'Lê Thị Kim Ngân',N'Nữ','5/9/2000',N'56, Hoàng Văn Thụ, P15, Phú Nhuận, TP HCM', NULL, 12, '0987654132')

insert into HOCSINH values (10005,N'Lưu Hoàng Khôi ',N'Nam','6/10/2002',N'598, Trường Chinh, P13, Tân Bình, TP HCM', NULL, 10, '01633631069')
insert into HOCSINH values (10006,N'Dương Lê Khang',N'Nam','4/7/2002',N'227, Phạm Văn Chiêu, P14, Gò Vấp, TP HCM', NULL, 10, '0964499563')
insert into HOCSINH values (11005,N'Đỗ Ngọc Hà',N'Nữ','12/16/2001',N'192 CMT8, P10, Q3, TP HCM', NULL, 11, '01687699127')
insert into HOCSINH values (11006,N'Lê Thành Trung',N'Nam','9/14/2001',N'311, Lê Văn Sĩ, P13, Q3, TP HCM', NULL, 11, '0981769912')
insert into HOCSINH values (12003,N'Đỗ Thị Thanh Vy',N'Nữ','8/2/2000',N'7 Lê Đại Hành, P15, Q11, TP HCM', NULL, 12, '0969963369')

insert into HOCSINH values (10007,N'Nguyễn Trung Đạo',N'Nam','12/16/2002',N'512 Hồng Bàng, P12, Q6, TP HCM', NULL,10, '0963869127')
insert into HOCSINH values (10008,N'Trần Tiền Đạo',N'Nam','1/24/2002',N'206, 1 Hậu Giang, P2, Q6 , TP HCM', NULL,10, '01627699107')
insert into HOCSINH values (11007,N'Trần Thị Ánh Tuyết',N'Nữ','10/17/2001',N'411 Trần Hưng Đạo, P14, Q5, TP HCM', NULL,11, '01655631063')
insert into HOCSINH values (11008,N'Lê Quốc Bảo',N'Nam','9/2/2001',N'202, Nguyễn Thị Minh Khai, P6, Q3, TP HCM', NULL,11, '01697699107')
insert into HOCSINH values (12004,N'Huỳnh Thị Trúc Ly',N'Nữ','11/22/2000',N'536, Xô Viết Nghệ Tĩnh, P25 , Bình Thạnh, TP HCM', NULL,12, '0973214759')

insert into HOCSINH values (10009,N'Nguyễn Đình Vỹ',N'Nam','2/12/2002',N'192 Nguyễn Thị Định, P.An Phú, Q2, TP HCM', NULL,10, '01647285172')
insert into HOCSINH values (10010,N'Nguyễn Đình Thái Bảo',N'Nam','1/20/2002',N'343 Đình Nghi Xuân, Q.Bình Tân , TP HCM', NULL,10, '0984684653')
insert into HOCSINH values (11009,N'Nguyễn Thị Minh Thư',N'Nữ','11/2/2001',N'103 Đặng Chất, P2, Q8, TP HCM', NULL,11, '01647940419')
insert into HOCSINH values (11010,N'Nguyễn Văn Trung',N'Nam','9/16/2001',N'202, Bạch Đằng, P24, Q. Bình Thạnh, TP HCM', NULL,11, '0932614587')
insert into HOCSINH values (12005,N'Nguyễn Thị Trúc Thanh',N'Nữ','10/12/2000',N'158 Nguyễn Hữu Cảnh, Bình Thạnh, TP HCM', NULL,12, '0935777538')

insert into DIEMMON values (10001,'T','I',2017,8.4)
insert into DIEMMON values (10001,'L','I',2017,9)
insert into DIEMMON values (10001,'H','I',2017,8.3)
insert into DIEMMON values (10001,'Si','I',2017,8.2)
insert into DIEMMON values (10001,'Su','I',2017,8.1)
insert into DIEMMON values (10001,'D','I',2017,7.4)
insert into DIEMMON values (10001,'V','I',2017,5.4)
insert into DIEMMON values (10001,'DD','I',2017,6.4)
insert into DIEMMON values (10001,'TD','I',2017,8.5)
insert into DIEMMON values (12001,'L','I',2017,6.5)
insert into DIEMMON values (12001,'L','II',2017,7)
insert into DIEMMON values (12001,'Su','I',2017,10)
insert into DIEMMON values (12001,'Su','I',2018,9.5)
insert into DIEMMON values (12001,'Su','II',2017,9)
insert into DIEMMON values (11001,'H','I',2017,7.0)
insert into DIEMMON values (11002,'H','I',2017,9.0)
insert into DIEMMON values (10002,'TD','I',2017,9.0)

insert into CHITIETDIEM values (10001,'T','I',2017,'15P',8.5,1)
insert into CHITIETDIEM values (10001,'T','I',2017,'15P',7,2)
insert into CHITIETDIEM values (10001,'T','I',2017,'1T',9,2)
insert into CHITIETDIEM values (10001,'T','I',2017,'M',9.0,1)
insert into CHITIETDIEM values (10001,'T','I',2017,'1T',9.5,1)
insert into CHITIETDIEM values (10001,'T','I',2017,'HK',8.5,1)

insert into CHITIETDIEM values (10001,'L','I',2017,'15P',8,1)
insert into CHITIETDIEM values (10001,'L','I',2017,'15P',7.5,2)
insert into CHITIETDIEM values (10001,'L','I',2017,'1T',6,2)
insert into CHITIETDIEM values (10001,'L','I',2017,'M',9.5,1)
insert into CHITIETDIEM values (10001,'L','I',2017,'1T',7.5,1)
insert into CHITIETDIEM values (10001,'L','I',2017,'HK',5.5,1)

insert into CHITIETDIEM values (10001,'H','I',2017,'15P',7.0,1)
insert into CHITIETDIEM values (10001,'H','I',2017,'15P',7.0,2)
insert into CHITIETDIEM values (10001,'H','I',2017,'1T',6.5,2)
insert into CHITIETDIEM values (10001,'H','I',2017,'M',6.5,1)
insert into CHITIETDIEM values (10001,'H','I',2017,'1T',8.5,1)
insert into CHITIETDIEM values (10001,'H','I',2017,'HK',6.5,1)

insert into CHITIETDIEM values (10001,'Si','I',2017,'15P',8.5,1)
insert into CHITIETDIEM values (10001,'Si','I',2017,'15P',9.5,2)
insert into CHITIETDIEM values (10001,'Si','I',2017,'1T',6.0,2)
insert into CHITIETDIEM values (10001,'Si','I',2017,'M',9.0,1)
insert into CHITIETDIEM values (10001,'Si','I',2017,'1T',7.0,1)
insert into CHITIETDIEM values (10001,'Si','I',2017,'HK',5.0,1)

insert into CHITIETDIEM values (10001,'Su','I',2017,'15P',4.5,1)
insert into CHITIETDIEM values (10001,'Su','I',2017,'15P',3,2)
insert into CHITIETDIEM values (10001,'Su','I',2017,'1T',6,2)
insert into CHITIETDIEM values (10001,'Su','I',2017,'M',9.0,1)
insert into CHITIETDIEM values (10001,'Su','I',2017,'1T',8.0,1)
insert into CHITIETDIEM values (10001,'Su','I',2017,'HK',4.5,1)

insert into CHITIETDIEM values (10001,'D','I',2017,'15P',8.0,1)
insert into CHITIETDIEM values (10001,'D','I',2017,'15P',7.5,2)
insert into CHITIETDIEM values (10001,'D','I',2017,'1T',6.5,2)
insert into CHITIETDIEM values (10001,'D','I',2017,'M',9.0,1)
insert into CHITIETDIEM values (10001,'D','I',2017,'1T',7.0,1)
insert into CHITIETDIEM values (10001,'D','I',2017,'HK',7.0,1)

insert into CHITIETDIEM values (10001,'V','I',2017,'15P',4.0,1)
insert into CHITIETDIEM values (10001,'V','I',2017,'15P',5.5,2)
insert into CHITIETDIEM values (10001,'V','I',2017,'1T',6.5,2)
insert into CHITIETDIEM values (10001,'V','I',2017,'M',6.0,1)
insert into CHITIETDIEM values (10001,'V','I',2017,'1T',6.0,1)
insert into CHITIETDIEM values (10001,'V','I',2017,'HK',5.0,1)

insert into CHITIETDIEM values (10001,'DD','I',2017,'15P',8.0,1)
insert into CHITIETDIEM values (10001,'DD','I',2017,'15P',7.5,2)
insert into CHITIETDIEM values (10001,'DD','I',2017,'1T',6.5,2)
insert into CHITIETDIEM values (10001,'DD','I',2017,'M',9.0,1)
insert into CHITIETDIEM values (10001,'DD','I',2017,'1T',7.0,1)
insert into CHITIETDIEM values (10001,'DD','I',2017,'HK',7.0,1)

insert into CHITIETDIEM values (10001,'TD','I',2017,'15P',8.5,1)
insert into CHITIETDIEM values (10001,'TD','I',2017,'15P',7.0,2)
insert into CHITIETDIEM values (10001,'TD','I',2017,'1T',7.5,2)
insert into CHITIETDIEM values (10001,'TD','I',2017,'M',8.0,1)
insert into CHITIETDIEM values (10001,'TD','I',2017,'1T',5.0,1)
insert into CHITIETDIEM values (10001,'TD','I',2017,'HK',7.0,1)

insert into CHITIETDIEM values (12001,'L','I',2017,'1T',6.5,1)
insert into CHITIETDIEM values (12001,'Su','I',2017,'15P',10,1)
insert into CHITIETDIEM values (11001,'H','I',2017,'1T',7.0,1)
insert into CHITIETDIEM values (11002,'H','I',2017,'1T',9.0,1)

insert into CHITIETDIEM values (10002,'TD','I',2017,'15P',null,1)
insert into CHITIETDIEM values (10002,'TD','I',2017,'15P',null,2)
insert into CHITIETDIEM values (10002,'TD','I',2017,'1T',null,2)
insert into CHITIETDIEM values (10002,'TD','I',2017,'M',null,1)
insert into CHITIETDIEM values (10002,'TD','I',2017,'1T',null,1)
insert into CHITIETDIEM values (10002,'TD','I',2017,'HK',null,1)

go

-- Đăng nhập
CREATE PROC USP_Login
@userName nvarchar(100) , @passWord nvarchar(100)
AS
BEGIN
	Select * From TAIKHOAN Where ID = @userName and Pass = @passWord
END
GO


-- Lấy loại tài khoản
Create Proc USP_LoginTypeID
@userName varchar(10), @passWord varchar(10)
as
begin
	Select LoaiTaiKhoan From TAIKHOAN Where ID = @userName and Pass = @passWord
end
go

-- Get tài khoản bằng tên tài khoản
Create Proc USP_GetAccountByID
@userName varchar(10)
as
begin
	Select * From TAIKHOAN Where ID = @userName
end
go

-- Xuất học sinh trong trong tìm kiếm học sinh
Create Proc USP_ShowStudent_SearchingStudent @name nvarchar(100)
as
begin
	Select hs.HoTen as [Họ Tên], hs.NgaySinh as [Ngày Sinh], hs.Phai as [Giới Tính], hs.DiaChi as [Địa chỉ], hs.SDT as [Số Điện Thoại]
	From HOCSINH hs
	Where hs.HoTen = @name
end
go

-- Cập nhật điểm cho bảng chi tiết điểm
Create Proc USP_UpdateTable
@Score float, @StudentID int, @Year int, @SubjectID varchar(10), @Semester varchar(10), @TestID varchar(10), @Frequency int
as
begin
	Update CHITIETDIEM Set Diem = @Score Where MaHS = @StudentID and NamHoc = @Year and MaMonHoc = @SubjectID and MaHocKy = @Semester and MaKT = @TestID and Lan = @Frequency
end
go

-- Load ra điểm của học sinh theo môn học, học kì, năm học, loại kt và lần kt
Create proc USP_AddingScore
@Grade int, @Class varchar(10), @Semester varchar(10), @Subject varchar(10), @TestID varchar(10), @Year int, @Frequency int
as
begin
Select hs.MaHS as [Mã HS], hs.HoTen as [Họ tên], ct.MaMonHoc as [Mã môn học], ct.MaHocKy as [Học kì], ct.NamHoc as [Năm học], ct.MaKT as [Loại KT],ct.Diem as [Điểm],ct.Lan as [Lần]
From HOCSINH hs, CHITIETDIEM ct
Where hs.MaHS = ct.MaHS  and ct.MaHocKy = @Semester and ct.MaMonHoc = @Subject and ct.MaKT = @TestID and ct.NamHoc = @Year and ct.Lan = @Frequency
		and hs.MaKhoi = @Grade and hs.MaLop = @Class
end
go

-- Những học sinh chưa tạo điểm trung bình
Create proc USP_StudentNotHaveAVGScore
@Subject varchar(10), @Semester varchar(10), @Year int, @Grade int
as
begin
Select hs1.MaHS
From HOCSINH hs1
Where hs1.MaKhoi = @Grade and hs1.MaHS not in(Select hs.MaHS
						From HOCSINH hs, DIEMMON dm
						Where dm.MaHocKy = @Semester and dm.MaMonHoc = @Subject and dm.NamHoc = @Year and dm.MaHS = hs.MaHS and hs.MaKhoi = @Grade)
end
go

-- Chọn những học sinh trong 1 khối có điểm
Create Proc USP_CreateScoreTable
@Year int, @SubjectID varchar(10), @Semester varchar(10), @TestID varchar(10), @Frequency int, @Grade int, @Class varchar(10)
as
begin
Select hs1.MaHS
From HOCSINH hs1
Where hs1.MaKhoi = @Grade and hs1.MaHS not in (Select hs.MaHS
						From HOCSINH hs, CHITIETDIEM ct
						Where hs.MaHS = ct.MaHS  and ct.MaHocKy = @Semester and ct.MaMonHoc = @SubjectID and ct.MaKT = @TestID and ct.NamHoc = @Year and ct.Lan = @Frequency
								and hs.MaKhoi = @Grade and hs.MaLop = @Class)
end
go

-- Tạo bảng điểm trong chi tiết điểm vs điểm bẳng null
Create Proc USP_InsertNullValue
@StudentID int, @Year int, @SubjectID varchar(10), @Semester varchar(10), @TestID varchar(10), @Frequency int
as
begin
	Insert into CHITIETDIEM values(@StudentID,@SubjectID,@Semester,@Year,@TestID,null,@Frequency)
end
go

-- Load tất cả các điểm theo môn học của một học sinh
Create Proc USP_SearchingScore
@Year int, @Semester varchar(10), @StudentID varchar(20)
as
begin
Select mh.TenMonHoc as [Môn học],dt_m.Diem as [Miệng], dt_15p1.Diem as [15p lần 1],dt_15p2.Diem as [15p lần 2],dt_1t1.Diem as [1T lần 1],dt_1t2.Diem as [1T lần 2],dt_hk.Diem as [Học kì]
From HOCSINH hs, MONHOC mh,
				(Select * From CHITIETDIEM ct Where ct.MaKT = '15P' and ct.Lan = 1 and ct.NamHoc = @Year  and ct.MaHocKy = @Semester) as dt_15p1,
				(Select * From CHITIETDIEM ct Where ct.MaKT = '15P' and ct.Lan = 2 and ct.NamHoc = @Year  and ct.MaHocKy = @Semester) as dt_15p2,
				(Select * From CHITIETDIEM ct Where ct.MaKT = 'M' and ct.Lan = 1 and ct.NamHoc = @Year  and ct.MaHocKy = @Semester) as dt_m,
				(Select * From CHITIETDIEM ct Where ct.MaKT = '1T' and ct.Lan = 1 and ct.NamHoc = @Year  and ct.MaHocKy = @Semester) as dt_1t1,
				(Select * From CHITIETDIEM ct Where ct.MaKT = '1T' and ct.Lan = 2 and ct.NamHoc = @Year  and ct.MaHocKy = @Semester) as dt_1t2,
				(Select * From CHITIETDIEM ct Where ct.MaKT = 'HK' and ct.Lan = 1 and ct.NamHoc = @Year  and ct.MaHocKy = @Semester) as dt_hk
Where hs.MaHS = dt_15p1.MaHS and hs.MaHS = @StudentID and mh.MaMonHoc = dt_15p1.MaMonHoc and mh.MaMonHoc = dt_15p2.MaMonHoc and mh.MaMonHoc =dt_m.MaMonHoc
			and mh.MaMonHoc = dt_1t1.MaMonHoc and mh.MaMonHoc = dt_1t2.MaMonHoc and mh.MaMonHoc = dt_hk.MaMonHoc and hs.MaHS = dt_15p2.MaHS and hs.MaHS = dt_m.MaHS
			and hs.MaHS = dt_1t1.MaHS and hs.MaHS = dt_1t2.MaHS and hs.MaHS = dt_hk.MaHS
Group by mh.TenMonHoc,dt_15p1.Diem,dt_15p2.Diem,dt_m.Diem,dt_1t1.Diem,dt_1t2.Diem,dt_hk.Diem
end
go

-- Xuất danh sách học sinh
Create Proc USP_ShowStudent @grade int , @numOfStudent int
as
begin
	;With StudentShow as(Select hs.HoTen as [Họ Tên], hs.NgaySinh as [Ngày Sinh], hs.Phai as [Giới Tính], hs.DiaChi as [Địa chỉ], hs.SDT as [Số Điện Thoại]
	From HOCSINH hs
	Where hs.MaKhoi = @grade and hs.MaLop is null)

	Select Top(@numOfStudent) * From StudentShow
end
go

--Xếp lớp theo danh sách lớp
Create Proc USP_ValidateListClass 
@grade int , @numOfStudent int, @class varchar(10)
as
begin
	;With StudentShow as(Select hs.MaHS , hs.HoTen , hs.NgaySinh , hs.Phai , hs.DiaChi , hs.SDT
	From HOCSINH hs
	Where hs.MaKhoi = @grade and hs.MaLop is null)

	Update HOCSINH Set MaLop = @class Where MaHS in (Select temp.MaHS From(Select Top(@numOfStudent) * From StudentShow) as temp)
end
go

-- Lấy mã học sinh của những học sinh đủ điểm trung bình
Create Proc USP_GetStudentID_AvgScore
@Year int, @Subject varchar(10), @Semester varchar(10)
as
begin
Select hs.MaHS
From HOCSINH hs,(Select * From CHITIETDIEM ct Where ct.MaKT = '15P' and ct.Lan = 1 and ct.NamHoc = @Year and ct.MaMonHoc = @Subject and ct.MaHocKy = @Semester) as dt_15p1,
				(Select * From CHITIETDIEM ct Where ct.MaKT = '15P' and ct.Lan = 2 and ct.NamHoc = @Year and ct.MaMonHoc = @Subject and ct.MaHocKy = @Semester) as dt_15p2,
				(Select * From CHITIETDIEM ct Where ct.MaKT = 'M' and ct.Lan = 1 and ct.NamHoc = @Year and ct.MaMonHoc = @Subject and ct.MaHocKy = @Semester) as dt_m,
				(Select * From CHITIETDIEM ct Where ct.MaKT = '1T' and ct.Lan = 1 and ct.NamHoc = @Year and ct.MaMonHoc = @Subject and ct.MaHocKy = @Semester) as dt_1t1,
				(Select * From CHITIETDIEM ct Where ct.MaKT = '1T' and ct.Lan = 2 and ct.NamHoc = @Year and ct.MaMonHoc = @Subject and ct.MaHocKy = @Semester) as dt_1t2,
				(Select * From CHITIETDIEM ct Where ct.MaKT = 'HK' and ct.Lan = 1 and ct.NamHoc = @Year and ct.MaMonHoc = @Subject and ct.MaHocKy = @Semester) as dt_hk
Where hs.MaHS = dt_15p1.MaHS and hs.MaHS = dt_15p2.MaHS and hs.MaHS = dt_m.MaHS and hs.MaHS = dt_1t1.MaHS and hs.MaHS = dt_1t2.MaHS and hs.MaHS = dt_hk.MaHS
end
go

--Tính điểm trung bình theo môn
Create Proc USP_AverageScore
@Year int, @Semester varchar(10), @Subject varchar(10), @StudentID int
as
begin
Update DIEMMON 
Set DiemTrungBinh = ((Select Diem 
					From CHITIETDIEM ct 
					Where ct.MaKT = '15P' and ct.Lan = 1 and 
					ct.NamHoc = @Year  and ct.MaHocKy = @Semester and 
					ct.MaMonHoc = @Subject and ct.MaHS = @StudentID)
					+ 
					(Select Diem 
					From CHITIETDIEM ct 
					Where ct.MaKT = '15P' and ct.Lan = 2 and 
					ct.NamHoc = @Year  and ct.MaHocKy = @Semester and 
					ct.MaMonHoc = @Subject and ct.MaHS = @StudentID) 
					+
					(Select Diem 
					From CHITIETDIEM ct 
					Where ct.MaKT = 'M' and ct.Lan = 1 and 
					ct.NamHoc = @Year  and ct.MaHocKy = @Semester and 
					ct.MaMonHoc = @Subject and ct.MaHS = @StudentID) 
					+
					((Select Diem 
					From CHITIETDIEM ct 
					Where ct.MaKT = '1T' and ct.Lan = 1 and 
					ct.NamHoc = @Year  and ct.MaHocKy = @Semester and 
					ct.MaMonHoc = @Subject and ct.MaHS = @StudentID) * 2)
					+
					((Select Diem 
					From CHITIETDIEM ct 
					Where ct.MaKT = '1T' and ct.Lan = 2 and 
					ct.NamHoc = @Year  and ct.MaHocKy = @Semester and 
					ct.MaMonHoc = @Subject and ct.MaHS = @StudentID) *2)
					+
					((Select Diem 
					From CHITIETDIEM ct 
					Where ct.MaKT = 'HK' and ct.Lan = 1 and 
					ct.NamHoc = @Year  and ct.MaHocKy = @Semester and 
					ct.MaMonHoc = @Subject and ct.MaHS = @StudentID) *3) ) / 10
Where MaHS = @StudentID and NamHoc = @Year and MaMonHoc = @Subject and MaHocKy = @Semester
end
go

Create Proc USP_SubjectStatistic
@Subject varchar(10), @Year int, @Semester varchar(2)
as
begin
Select lp.TenLop as [Lớp], count(hs.MaHS) as [Sỉ số], temp.SoluongDat as [Số lượng đạt], round(((convert(float,(temp.SoluongDat)))/(convert(float,(count(hs.MaHS)))))*100,1) as [Tỷ lệ(%)]
From HOCSINH hs, DIEMMON dm, LOP lp, (Select lp.TenLop, count(hs.MaHS) as [SoluongDat]
										From HOCSINH hs, DIEMMON dm, LOP lp
										Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'D' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5
										Group by lp.TenLop) as temp
Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'D' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and lp.TenLop = temp.TenLop
Group by lp.TenLop, temp.SoluongDat
end
go

Create Proc USP_SubjectStatisticReport
@Subject varchar(10), @Year int, @Semester varchar(2)
as
begin
Select lp.TenLop as TenLop, count(hs.MaHS) as SiSo, temp.SoluongDat as SoLuongDat, round(((convert(float,(temp.SoluongDat)))/(convert(float,(count(hs.MaHS)))))*100,1) as Tyle
From HOCSINH hs, DIEMMON dm, LOP lp, (Select lp.TenLop, count(hs.MaHS) as [SoluongDat]
										From HOCSINH hs, DIEMMON dm, LOP lp
										Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'D' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5
										Group by lp.TenLop) as temp
Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'D' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and lp.TenLop = temp.TenLop
Group by lp.TenLop, temp.SoluongDat
end
go

--Báo cáo môn học
Create Proc USP_SubjectStatisticReport1
@Subject varchar(10), @Year int, @Semester varchar(2)
as
begin
Select lp.TenLop as TenLop, count(hs.MaHS) as SiSo, temp.SoluongDat as SoLuongDat, round(((convert(float,(temp.SoluongDat)))/(convert(float,(count(hs.MaHS)))))*100,1) as Tyle
From HOCSINH hs, DIEMMON dm, LOP lp, (Select lp.TenLop, count(hs.MaHS) as [SoluongDat]
										From HOCSINH hs, DIEMMON dm, LOP lp
										Where hs.MaHS = dm.MaHS and dm.MaMonHoc = @Subject and dm.NamHoc = @Year and dm.MaHocKy = @Semester and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5
										Group by lp.TenLop) as temp
Where hs.MaHS = dm.MaHS and dm.MaMonHoc = @Subject and dm.NamHoc = @Year and dm.MaHocKy = @Semester and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and lp.TenLop = temp.TenLop
Group by lp.TenLop, temp.SoluongDat
end
go

--Báo cáo học kì
Create Proc USP_SemesterStatisticReport
@Year int, @Semester varchar(2)
as
begin
Select lp.TenLop, count(hs1.MaHS) as SiSo, DatTatCa.SoluongDat as SoLuongDat, round(((convert(float,(DatTatCa.SoluongDat)))/(convert(float,(count(hs1.MaHS)))))*100,1) as Tyle
From HOCSINH hs1, LOP lp,
					(Select lp1.TenLop, count(hs.MaHS) as SoluongDat
					From HOCSINH hs, LOP lp1,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'T' and dm.NamHoc = @Year and dm.MaHocKy = @Semester and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Toan,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'L' and dm.NamHoc = @Year and dm.MaHocKy = @Semester and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Ly,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'H' and dm.NamHoc = @Year and dm.MaHocKy = @Semester and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Hoa,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'Si' and dm.NamHoc = @Year and dm.MaHocKy = @Semester and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Sinh,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'Su' and dm.NamHoc = @Year and dm.MaHocKy = @Semester and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Su,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'D' and dm.NamHoc = @Year and dm.MaHocKy = @Semester and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Dia,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'V' and dm.NamHoc = @Year and dm.MaHocKy = @Semester and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Van,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'DD' and dm.NamHoc = @Year and dm.MaHocKy = @Semester and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as DaoDuc,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'TD' and dm.NamHoc = @Year and dm.MaHocKy = @Semester and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as TheDuc
					Where hs.MaHS = Toan.MaHS and hs.MaHS = Ly.MaHS and hs.MaHS = Hoa.MaHS and hs.MaHS = Sinh.MaHS and hs.MaHS = Su.MaHS and hs.MaHS = Dia.MaHS and hs.MaHS = Van.MaHS and hs.MaHS = DaoDuc.MaHS and hs.MaHS = TheDuc.MaHS and hs.MaKhoi = lp1.MaKhoi and hs.MaLop = lp1.MaLop
					Group by lp1.TenLop) as DatTatCa
Where hs1.MaLop = lp.MaLop and hs1.MaKhoi = lp.MaKhoi and lp.TenLop = DatTatCa.TenLop
Group by lp.TenLop, DatTatCa.SoluongDat
end

go

--Khởi tạo dữ liệu vắng cho học sinh
Create Proc USP_CreateAbsent
@StudentID int, @Semester varchar(2), @Year int
as
begin
	Insert into VANG values(@StudentID,0,@Semester,@Year)
end

go

-- Đánh vắng
Create Proc USP_Absent
@StudentID int, @Time int, @Semester varchar(2), @Year int
as
begin
	Update VANG set Vang = @Time + 1 Where MaHS = @StudentID and MaHocKy = @Semester and NamHoc = @Year
end

go

-- Load danh sách vắng của học sinh
Create Proc USP_LoadAbsentList
@Semester varchar(2), @Year int
as
begin
Select hs.MaHS as [Mã học sinh], hs.HoTen as [Họ tên], lp.TenLop as [Tên lớp], vg.Vang as [Buổi vắng]
From HOCSINH hs, LOP lp, VANG vg
Where hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and hs.MaHS = vg.MaHS and vg.NamHoc = @Year and vg.MaHocKy = @Semester
end

go

-- Cập nhật bảng học sinh
Create Proc UpdateStudent
@StudentID int, @Name nvarchar(100), @Gender nvarchar(3), @Birthday datetime, @Address nvarchar(250), @Grade int, @Phone char(12)
as
begin
	Update HOCSINH set HoTen = @Name, Phai = @Gender, NgaySinh = @Birthday, DiaChi = @Address, MaKhoi = @Grade, SDT = @Phone Where MaHS = @StudentID
end

go

-- Tìm học sinh có mã học sinh cao nhất của một khối
Create Proc FindMaxStudentID
@Grade int
as
begin
	Select * from HOCSINH hs1 where hs1.MaHS = (Select MAX(hs2.MaHS) from HOCSINH hs2 Where MaKhoi = @Grade)
end
go



-- Nháp
Update HOCSINH set HoTen = @Name, Phai = @Gender, NgaySinh = @Birthday, DiaChi = @Address, MaLop = @ClassID, MaKhoi = @Grade, SDT = @Phone Where MaHS = @StudentID

Select * from CHITIETDIEM Where MaHS = 10002

Select hs1.MaHS
From HOCSINH hs1
Where hs1.MaKhoi = 10 and hs1.MaHS not in(Select hs.MaHS
						From HOCSINH hs, DIEMMON dm
						Where dm.MaHocKy = 'I' and dm.MaMonHoc = 'D' and dm.NamHoc = 2017 and dm.MaHS = hs.MaHS and hs.MaKhoi = 10)
Select hs1.MaHS
From HOCSINH hs1
Where hs1.MaKhoi = @Grade and hs1.MaHS not in(Select hs.MaHS
						From HOCSINH hs, DIEMMON dm
						Where dm.MaHocKy = @Semester and dm.MaMonHoc = @Subject and dm.NamHoc = @Year and dm.MaHS = hs.MaHS and hs.MaKhoi = @Grade)
select * from HOCSINH

Select hs1.MaHS
From HOCSINH hs1
Where hs1.MaKhoi = 10 and hs1.MaHS not in (Select hs.MaHS
						From HOCSINH hs, CHITIETDIEM ct
						Where hs.MaHS = ct.MaHS  and ct.MaHocKy = 'I' and ct.MaMonHoc = 'D' and ct.MaKT = '15P' and ct.NamHoc = 2017 and ct.Lan = 1
								and hs.MaKhoi = 10 and hs.MaLop = 'A1')

Insert into CHITIETDIEM values(10003,'D','I',2017,'15P',null,1)

Select hs.MaHS as [Mã HS], hs.HoTen as [Họ tên], ct.MaMonHoc as [Mã môn học], ct.MaHocKy as [Học kì], ct.NamHoc as [Năm học], ct.MaKT as [Loại KT],ct.Diem as [Điểm],ct.Lan as [Lần]
From HOCSINH hs, CHITIETDIEM ct
Where hs.MaHS = ct.MaHS  and ct.MaHocKy = 'I' and ct.MaMonHoc = 'D' and ct.MaKT = '15P' and ct.NamHoc = 2017 and ct.Lan = 1
		and hs.MaKhoi = 10 and hs.MaLop = 'A1'

select * from DIEMMON where DiemTrungBinh >= 5 and MaMonHoc = 'D'

select * from MONHOC

select * from CHITIETDIEM

Select hs1.MaHS
From HOCSINH hs1
Where hs1.MaKhoi = 10 and hs1.MaHS not in(Select hs.MaHS
						From HOCSINH hs, DIEMMON dm
						Where dm.MaHocKy = 'I' and dm.MaMonHoc = 'TD' and dm.NamHoc = 2017 and dm.MaHS = hs.MaHS and hs.MaKhoi = 10)

Select hs1.MaHS
From HOCSINH hs1
Where hs1.MaKhoi = 10 and hs1.MaHS not in (Select hs.MaHS
						From HOCSINH hs, CHITIETDIEM ct
						Where hs.MaHS = ct.MaHS  and ct.MaHocKy = 'I' and ct.MaMonHoc = 'TD' and ct.MaKT = '15P' and ct.NamHoc = 2017 and ct.Lan = 1
								and hs.MaKhoi = 10 and hs.MaLop = 'A1')
Select hs1.MaHS
From HOCSINH hs1
Where hs1.MaKhoi = @Grade and hs1.MaHS not in (Select hs.MaHS
						From HOCSINH hs, CHITIETDIEM ct
						Where hs.MaHS = ct.MaHS  and ct.MaHocKy = @Semester and ct.MaMonHoc = @SubjectID and ct.MaKT = @TestID and ct.NamHoc = @Year and ct.Lan = @Frequency
								and hs.MaKhoi = @Grade and hs.MaLop = @Class)

Select hs.MaHS
From HOCSINH hs,(Select * From CHITIETDIEM ct Where ct.MaKT = '15P' and ct.Lan = 1 and ct.NamHoc = 2017 and ct.MaMonHoc = 'D' and ct.MaHocKy = 'I') as dt_15p1,
				(Select * From CHITIETDIEM ct Where ct.MaKT = '15P' and ct.Lan = 2 and ct.NamHoc = 2017 and ct.MaMonHoc = 'D' and ct.MaHocKy = 'I') as dt_15p2,
				(Select * From CHITIETDIEM ct Where ct.MaKT = 'M' and ct.Lan = 1 and ct.NamHoc = 2017 and ct.MaMonHoc = 'D' and ct.MaHocKy = 'I') as dt_m,
				(Select * From CHITIETDIEM ct Where ct.MaKT = '1T' and ct.Lan = 1 and ct.NamHoc = 2017 and ct.MaMonHoc = 'D' and ct.MaHocKy = 'I') as dt_1t1,
				(Select * From CHITIETDIEM ct Where ct.MaKT = '1T' and ct.Lan = 2 and ct.NamHoc = 2017 and ct.MaMonHoc = 'D' and ct.MaHocKy = 'I') as dt_1t2,
				(Select * From CHITIETDIEM ct Where ct.MaKT = 'HK' and ct.Lan = 1 and ct.NamHoc = 2017 and ct.MaMonHoc = 'D' and ct.MaHocKy = 'I') as dt_hk
Where hs.MaHS = dt_15p1.MaHS and hs.MaHS = dt_15p2.MaHS and hs.MaHS = dt_m.MaHS and hs.MaHS = dt_1t1.MaHS and hs.MaHS = dt_1t2.MaHS and hs.MaHS = dt_hk.MaHS



Select * From HOCSINH

Update DIEMMON set DiemTrungBinh = 4 Where MaHS = 10001 and MaMonHoc = 'D' and MaHocKy = 'I' and NamHoc = 2017

Select lp.TenLop, count(hs.MaHS) as [SoluongDat]
										From HOCSINH hs, DIEMMON dm, LOP lp
										Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'D' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi
										Group by lp.TenLop

Select * from DIEMMON

Select hs.MaHS, hs.MaLop, hs.MaKhoi
From HOCSINH hs,(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'T' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Toan,
				(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'L' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Ly,
				(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'H' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Hoa,
				(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'Si' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Sinh,
				(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'Su' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Su,
				(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'D' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Dia,
				(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'V' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Van,
				(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'DD' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as DaoDuc,
				(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'TD' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as TheDuc
Where hs.MaHS = Toan.MaHS and hs.MaHS = Ly.MaHS and hs.MaHS = Hoa.MaHS and hs.MaHS = Sinh.MaHS and hs.MaHS = Su.MaHS and hs.MaHS = Dia.MaHS and hs.MaHS = Van.MaHS and hs.MaHS = DaoDuc.MaHS and hs.MaHS = TheDuc.MaHS

Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'D' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5

Select lp.TenLop, count(hs1.MaHS) as SiSo, DatTatCa.SoluongDat as SoLuongDat, round(((convert(float,(DatTatCa.SoluongDat)))/(convert(float,(count(hs1.MaHS)))))*100,1) as Tyle
From HOCSINH hs1, LOP lp,
					(Select lp1.TenLop, count(hs.MaHS) as SoluongDat
					From HOCSINH hs, LOP lp1,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'T' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Toan,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'L' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Ly,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'H' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Hoa,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'Si' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Sinh,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'Su' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Su,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'D' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Dia,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'V' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as Van,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'DD' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as DaoDuc,
									(Select hs.MaHS From HOCSINH hs, DIEMMON dm, LOP lp Where hs.MaHS = dm.MaHS and dm.MaMonHoc = 'TD' and dm.NamHoc = 2017 and dm.MaHocKy = 'I' and hs.MaLop is not null and hs.MaLop = lp.MaLop and hs.MaKhoi = lp.MaKhoi and dm.DiemTrungBinh >=5) as TheDuc
					Where hs.MaHS = Toan.MaHS and hs.MaHS = Ly.MaHS and hs.MaHS = Hoa.MaHS and hs.MaHS = Sinh.MaHS and hs.MaHS = Su.MaHS and hs.MaHS = Dia.MaHS and hs.MaHS = Van.MaHS and hs.MaHS = DaoDuc.MaHS and hs.MaHS = TheDuc.MaHS and hs.MaKhoi = lp1.MaKhoi and hs.MaLop = lp1.MaLop
					Group by lp1.TenLop) as DatTatCa
Where hs1.MaLop = lp.MaLop and hs1.MaKhoi = lp.MaKhoi and lp.TenLop = DatTatCa.TenLop
Group by lp.TenLop, DatTatCa.SoluongDat

Select *
From HOCSINH hs, VANG vg
Where hs.MaHS = vg.MaHS

Select * From VANG

Select MaHS From HOCSINH

Create Proc USP_DeleteStudent
@Student
Delete From HOCSINH Where MaHS = 12005


Update HOCSINH set HoTen = N'Trần Tiền Đạo', Phai = 'Nam', NgaySinh = '2002-01-24 00:00:00.000', DiaChi = N'206, 1 Hậu Giang, P2, Q6 , TP HCM', MaLop = NULL, MaKhoi = 10, SDT = '01627699107 ' where MaHS = 10008

Insert into LOP values(null, 10, null

Select * From MONHOC

Update QUYDINH set GhiChu = N'Thay đổi điểm chuẩn đánh giá đạt môn' where MAQD = 4



