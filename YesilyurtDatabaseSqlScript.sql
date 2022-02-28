-- create database
create database YesilyurtDb2022
go

use  YesilyurtDb2022
go

-------------------------------------------------------------------
--*****************   KULLANICI   *********************************
-------------------------------------------------------------------

create table Kullanici
(
Id int IDENTITY(1,1) primary key,
KullaniciAdi nvarchar(50) not null unique,
Parola nvarchar(20),
Yetki nvarchar(30) default 'Read',
CreateTime datetime default GETDATE(),
)
go
--Yetki Read / Write

CREATE PROCEDURE Add_Kullanici 
(
@KullaniciAdi nvarchar(50), 
@Parola nvarchar(20)
)
as
begin 
insert into Kullanici (KullaniciAdi,Parola) values (@KullaniciAdi,@Parola)

end
go

create procedure Delete_Kullanici
(
@Id int
)
as
begin 
delete from Kullanici where Id=@Id
end
go

create procedure Update_Kullanici
(
@Id int,
@KullaniciAdi nvarchar(50) ,
@Parola nvarchar(20),
@Yetki nvarchar(30)
)
as 
begin
update Kullanici set KullaniciAdi=@KullaniciAdi, Parola=@Parola , Yetki=@Yetki where Id=@Id
end

go
exec Add_Kullanici @KullaniciAdi='Admin', @Parola='1'
go

insert into Kullanici (KullaniciAdi,Parola,Yetki) values ('caglar','4817','Write')

go

create procedure GetAll_Kullanici
as 
select * from Kullanici
go

-------------------------------------------------------------------
--*****************   CÝFTCÝLER   *********************************
-------------------------------------------------------------------

Create Table Ciftciler
(
Id int IDENTITY(1,1) primary key,
TcKimlikNo nvarchar(11) not null unique,
NameSurname nvarchar(50) not null,
FatherName nvarchar(20) not null,
MotherName nvarchar(20) not null,
Birthday nvarchar(20)  default 'bilinmiyor' ,

Gender nvarchar(20)  default 'bilinmiyor',
MaritalStatus nvarchar(20) default 'bilinmiyor',
MobilePhone nvarchar(20) default '000-0000',
HomePhone nvarchar(20) default '000-0000',
Email nvarchar(30) default 'bilinmiyor',
City nvarchar(20) default 'TOKAT',
Town nvarchar(20) default 'YEÞÝLYURT',
Village nvarchar(20),
Note varchar(250),
KullaniciId int not null,
CreateTime datetime default GETDATE(),
FOREIGN KEY (KullaniciId) REFERENCES Kullanici(Id)

)
go

create procedure Add_Ciftci
(
@TcKimlikNo nvarchar(11),
@NameSurname nvarchar(50),
@FatherName nvarchar(20),
@MotherName nvarchar(20),
@Birthday nvarchar(20) ,
@Gender nvarchar(20),
@MaritalStatus nvarchar(20),
@MobilePhone nvarchar(20),
@HomePhone nvarchar(20),
@Email nvarchar(30),
@City nvarchar(20),
@Town nvarchar(20) ,
@Village nvarchar(20),
@Note varchar(250),
@KullaniciId int
)
as 
begin
 insert into Ciftciler (TcKimlikNo,NameSurname,FatherName,MotherName,Birthday,Gender,MaritalStatus,
 MobilePhone,HomePhone,Email,City,Town,Village,Note,KullaniciId) values (@TcKimlikNo,@NameSurname,
 @FatherName,@MotherName,@Birthday,@Gender,@MaritalStatus,@MobilePhone,@HomePhone,@Email,@City,
 @Town,@Village,@Note,@KullaniciId)
end

go

create procedure Delete_Ciftci
(
@Id int
)
as
begin
delete from Ciftciler where Id=@Id
end

go

create procedure Update_Ciftci
(
@Id int,
@TcKimlikNo nvarchar(11),
@NameSurname nvarchar(50),
@FatherName nvarchar(20),
@MotherName nvarchar(20),
@Birthday nvarchar(20) ,

@Gender nvarchar(20),
@MaritalStatus nvarchar(20),
@MobilePhone nvarchar(20),
@HomePhone nvarchar(20),
@Email nvarchar(30),
@City nvarchar(20),
@Town nvarchar(20) ,
@Village nvarchar(20),
@Note varchar(250),
@KullaniciId int
)
as 
begin
 update Ciftciler set TcKimlikNo=@TcKimlikNo,NameSurname=@NameSurname,FatherName=@FatherName,MotherName=@MotherName,
 Birthday=@Birthday,Gender=@Gender,MaritalStatus=@MaritalStatus,MobilePhone=@MobilePhone,
 HomePhone=@HomePhone,Email=@Email,City=@City,Town=@Town,Village=@Village,Note=@Note,KullaniciId=@KullaniciId where Id=@Id
end



go

create procedure GetAll_Ciftciler
as 
select * from Ciftciler

go

-------------------------------------------------------------------
--*****************   CKS LÝSTESÝ   *********************************
-------------------------------------------------------------------

create table Cks
(
Id int identity(1,1) primary key ,
CiftciId int not null,
DosyaNo int unique not null,
Note nvarchar(250),
KullaniciId int not null,
CreateTime datetime default GETDATE()
FOREIGN KEY (CiftciId) REFERENCES Ciftciler(Id),
FOREIGN KEY (KullaniciId) REFERENCES Kullanici(Id)
)
go

create procedure Add_Cks
(
@CiftciId int ,
@DosyaNo int ,
@Note nvarchar(250),
@KullaniciId int ,
@CreateTime datetime
)
as 
begin
	insert into Cks (CiftciId,DosyaNo,Note,KullaniciId,CreateTime) values (@CiftciId,@DosyaNo,@Note,@KullaniciId,@CreateTime)
end
go

create procedure Delete_Cks
(
@Id int
)
as
begin
	delete from Cks where Id=@Id
end
go

create procedure Update_Cks
(
@Id int,
@CiftciId int ,
@DosyaNo int ,
@Note nvarchar(250),
@KullaniciId int ,
@CreateTime datetime
)
as
begin
	update Cks set CiftciId=@CiftciId,DosyaNo=@DosyaNo,Note=@Note,KullaniciId=@KullaniciId,CreateTime=@CreateTime where Id=@Id
end
go
create procedure GetAll_Cks
as
select *from Cks
go



-------------------------------------------------------------------
--*****************   FÝRMA   *********************************
-------------------------------------------------------------------

create table Firma
(
Id int IDENTITY(1,1) primary key,
FirmaAdi nvarchar(100) not null unique,
VergiNo nvarchar(15)not null unique,
Note nvarchar(250),
KullaniciId int not null,
CreateTime datetime default GETDATE(),
FOREIGN KEY (KullaniciId) REFERENCES Kullanici(Id)

)
go
create procedure Add_Firma
(
@FirmaAdi nvarchar(100) ,
@VergiNo nvarchar(15),
@Note nvarchar(250),
@KullaniciId int
)
as
begin
	insert into Firma (FirmaAdi,VergiNo,Note,KullaniciId) values (@FirmaAdi,@VergiNo,@Note,@KullaniciId)
end
go

create procedure Delete_Firma
(@Id int)
as 
begin
delete from Firma where Id=@Id
end
go

create procedure Update_Firma
(
@Id int,
@FirmaAdi nvarchar(100) ,
@VergiNo nvarchar(15),
@Note nvarchar(250),
@KullaniciId int
)
as
begin 
update Firma set FirmaAdi=@FirmaAdi,VergiNo=@VergiNo,Note=@Note,KullaniciId=@KullaniciId where Id=@Id
end
go

create procedure GetAll_Firma
as
select * from Firma

go

-------------------------------------------------------------------
--*****************   ÜRÜN   *********************************
-------------------------------------------------------------------

create table Urun
(
Id int IDENTITY(1,1) primary key,
UrunAdi nvarchar(100) not null,
UrunCesidi nvarchar(100),
KullaniciId int not null,
CreateTime datetime default GETDATE(),
FOREIGN KEY (KullaniciId) REFERENCES Kullanici(Id)

)
go
create procedure Add_Urun
(
@UrunAdi nvarchar(100) ,
@UrunCesidi nvarchar(100),
@KullaniciId int
)
as
begin
insert into Urun (UrunAdi,UrunCesidi,KullaniciId) values (@UrunAdi,@UrunCesidi,@KullaniciId)
end
go

create procedure Delete_Urun
(@Id int)
as
begin
delete from Urun where Id=@Id
end
go

create procedure Update_Urun
(
@Id int,
@UrunAdi nvarchar(100),
@UrunCesidi nvarchar(100),
@KullaniciId int 
)
as
begin
update Urun set UrunAdi=@UrunAdi, UrunCesidi=@UrunCesidi, KullaniciId=@KullaniciId where Id=@Id
end

go

create procedure GetAll_Urun
as
select * from Urun
go


-------------------------------------------------------------------
--*****************   YEM BÝTKÝLERÝ   *********************************
-------------------------------------------------------------------
create table YemBitkileri
(
Id int IDENTITY(1,1) primary key,
CksId int not null,
UrunId int not null,
DosyaNo int not null,
MuracaatTarihi datetime default getdate(),
EkilisYili nvarchar(4) default '2022',
AraziMahalle nvarchar(20),
Ada nvarchar(5),
Parsel nvarchar(5),
MuracaatAlani nvarchar(10) ,
TespitEdilenAlan nvarchar(10),
KontrolTarihi nvarchar(15),
KontrolEdenler nvarchar(100),
Note nvarchar(250),
KontrolDurumu nvarchar(30) default 'Kontrol Edilmedi',
KullaniciId int not null,
CreateTime datetime default GETDATE()

FOREIGN KEY (CksId) REFERENCES Cks(Id),
FOREIGN KEY (UrunId) REFERENCES Urun(Id),
FOREIGN KEY (KullaniciId) REFERENCES Kullanici(Id)

)
go

create procedure Add_YemBitkileri
(
@CksId int,
@UrunId int,
@DosyaNo int,
@MuracaatTarihi date,
@EkilisYili nvarchar(4),
@AraziMahalle nvarchar(20),
@Ada nvarchar(5),
@Parsel nvarchar(5),
@MuracaatAlani nvarchar(10) ,
@TespitEdilenAlan nvarchar(10),
@KontrolTarihi nvarchar(15),
@KontrolEdenler nvarchar(100),
@Note nvarchar(250),
@KontrolDurumu nvarchar(30) ,
@KullaniciId int

)
as 
begin 
insert into YemBitkileri (CksId,UrunId,DosyaNo,MuracaatTarihi,
EkilisYili,AraziMahalle,Ada,Parsel,MuracaatAlani,TespitEdilenAlan,
KontrolTarihi,KontrolEdenler,Note,KontrolDurumu,KullaniciId) values 
(@CksId,@UrunId,@DosyaNo,@MuracaatTarihi,@EkilisYili,@AraziMahalle,@Ada,@Parsel,@MuracaatAlani,
@TespitEdilenAlan,@KontrolTarihi,@KontrolEdenler,@Note,@KontrolDurumu,@KullaniciId)
end
go

create procedure Delete_YemBitkileri @Id int
as 
delete from YemBitkileri where Id=@Id
go

create procedure Update_YemBitkileri
(
@Id int,
@CksId int,
@UrunId int,
@DosyaNo int,
@MuracaatTarihi date,
@EkilisYili nvarchar(4),
@AraziMahalle nvarchar(20),
@Ada nvarchar(5),
@Parsel nvarchar(5),
@MuracaatAlani nvarchar(10) ,
@TespitEdilenAlan nvarchar(10),
@KontrolTarihi nvarchar(15),
@KontrolEdenler nvarchar(100),
@Note nvarchar(250),
@KontrolDurumu nvarchar(30) ,
@KullaniciId int,
@CreateTime datetime
)
as
begin
update YemBitkileri set CksId=@CksId, UrunId=@UrunId,DosyaNo=@DosyaNo,MuracaatTarihi=@MuracaatTarihi,EkilisYili=@EkilisYili,AraziMahalle=@AraziMahalle,Ada=@Ada,Parsel=@Parsel,
MuracaatAlani=@MuracaatAlani,TespitEdilenAlan=@TespitEdilenAlan,KontrolTarihi=@KontrolTarihi,KontrolEdenler=@KontrolEdenler,Note=@Note,KontrolDurumu=@KontrolDurumu,
KullaniciId=@KullaniciId, @CreateTime=CreateTime where Id=@Id
end
go

create procedure GetAll_YemBitkileri
as
select * from YemBitkileri
go

-------------------------------------------------------------------
--*****************   SERTÝFÝKALI TOHUM   *********************************
-------------------------------------------------------------------

create table SertifikaliTohum
(
Id int IDENTITY(1,1) primary key,
CksId int not null,
FirmaId int not null,
UrunId int not null,
DosyaNo int not null,
MuracaatTarihi date default getdate(),
SertifikaNo nvarchar(20) not null,
FaturaNo nvarchar(20) not null,
FaturaTarihi date not null,
Miktari nvarchar(10) ,
BirimFiyati  nvarchar (10),
ToplamMaliyet  nvarchar (10),
Note nvarchar(250),
OdemeDurumu nvarchar(30) default 'Ödeme Bekliyor',
KullaniciId int not null,
CreateTime datetime default GETDATE(),

FOREIGN KEY (CksId) REFERENCES Cks(Id),
FOREIGN KEY (FirmaId) REFERENCES Firma(Id),
FOREIGN KEY (UrunId) REFERENCES Urun(Id),
FOREIGN KEY (KullaniciId) REFERENCES Kullanici(Id)

)
go
create procedure Add_SertifikaliTohum
(
@CksId int,
@FirmaId int,
@UrunId int,
@DosyaNo int,
@MuracaatTarihi date ,
@SertifikaNo nvarchar(20) ,
@FaturaNo nvarchar(20) ,
@FaturaTarihi date ,
@Miktari nvarchar(10),
@BirimFiyati nvarchar(10),
@ToplamMaliyet nvarchar(10),
@Note nvarchar(250),
@KullaniciId int
)
as
begin 
insert into SertifikaliTohum (CksId,FirmaId,UrunId,DosyaNo,MuracaatTarihi,SertifikaNo,FaturaNo,FaturaTarihi,Miktari,BirimFiyati,ToplamMaliyet,Note,KullaniciId)
values (@CksId,@FirmaId,@UrunId,@DosyaNo,@MuracaatTarihi,@SertifikaNo,@FaturaNo,@FaturaTarihi,@Miktari,@BirimFiyati,@ToplamMaliyet,@Note,@KullaniciId)
end
go

create procedure Delete_SertifikaliTohum @Id int
as
delete from SertifikaliTohum where Id=@Id
go

create procedure Update_SertifikaliTohum
(
@Id int,
@CksId int,
@FirmaId int,
@UrunId int,
@DosyaNo int,
@MuracaatTarihi date ,
@SertifikaNo nvarchar(20) ,
@FaturaNo nvarchar(20) ,
@FaturaTarihi date ,
@Miktari nvarchar(10),
@BirimFiyati nvarchar(10),
@ToplamMaliyet nvarchar(10),
@Note nvarchar(250),
@KullaniciId int,
@OdemeDurumu nvarchar(30)
)
as
begin 
update SertifikaliTohum set CksId=@CksId,FirmaId=@FirmaId,UrunId=@UrunId,DosyaNo=@DosyaNo,MuracaatTarihi=@MuracaatTarihi,SertifikaNo=@SertifikaNo,
FaturaNo=@FaturaNo,FaturaTarihi=@FaturaTarihi,Miktari=@Miktari,BirimFiyati=@BirimFiyati,ToplamMaliyet=@ToplamMaliyet,Note=@Note,KullaniciId=@KullaniciId,
OdemeDurumu=@OdemeDurumu
where Id=@Id
end
go
create procedure GetAll_SertifikaliTohum
as
select * from SertifikaliTohum
go
-------------------------------------------------------------------
--*****************   SERTÝFÝKALI FÝDAN KULLANIM DESTEÐÝ   *********************************
-------------------------------------------------------------------



-- will code





-------------------------------------------------------------------
--*****************   FARK ÖDEMESÝ   *********************************
-------------------------------------------------------------------

create table FarkOdemesi
(
Id int IDENTITY(1,1) primary key,
CksId int not null,
FirmaId int not null,
UrunId int not null,
DosyaNo int not null,
MuracaatTarihi date default getdate(),
FaturaNo nvarchar(20) not null,
FaturaTarihi date not null,
Miktari nvarchar(10),
BirimFiyati nvarchar(10),
ToplamMaliyet nvarchar(10),
Note nvarchar(250),
OdemeDurumu nvarchar(30) default 'Ödeme Bekliyor',
KullaniciId int not null,
CreateTime datetime default GETDATE(),

FOREIGN KEY (CksId) REFERENCES Cks(Id),
FOREIGN KEY (FirmaId) REFERENCES Firma(Id),
FOREIGN KEY (UrunId) REFERENCES Urun(Id),
FOREIGN KEY (KullaniciId) REFERENCES Kullanici(Id)
)
go

create procedure Add_FarkOdemesi
(
@CksId int,
@FirmaId int ,
@UrunId int ,
@DosyaNo int ,
@MuracaatTarihi date,
@FaturaNo nvarchar(20),
@FaturaTarihi date,
@Miktari nvarchar(10),
@BirimFiyati nvarchar(10),
@ToplamMaliyet nvarchar(10),
@Note nvarchar(250),
@KullaniciId int
)
as
begin
 insert into FarkOdemesi (CksId,FirmaId,UrunId,DosyaNo,MuracaatTarihi,FaturaNo,FaturaTarihi,Miktari,BirimFiyati,ToplamMaliyet,Note,KullaniciId) values
 (@CksId,@FirmaId,@UrunId,@DosyaNo,@MuracaatTarihi,@FaturaNo,@FaturaTarihi,@Miktari,@BirimFiyati,@ToplamMaliyet,@Note,@KullaniciId)
end
go

create procedure Delete_FarkOdemesi @Id int
as
delete from FarkOdemesi where Id=@Id
go

create procedure Update_FarkOdemesi
(
@Id int,
@CksId int,
@FirmaId int ,
@UrunId int ,
@DosyaNo int ,
@MuracaatTarihi date,
@FaturaNo nvarchar(20),
@FaturaTarihi date,
@Miktari nvarchar(10),
@BirimFiyati nvarchar(10),
@ToplamMaliyet nvarchar(10),
@Note nvarchar(250),
@OdemeDurumu nvarchar(30),
@KullaniciId int
)
as
begin 
update FarkOdemesi set CksId=@CksId,FirmaId=@FirmaId,UrunId=@UrunId,DosyaNo=@DosyaNo,MuracaatTarihi=@MuracaatTarihi,FaturaNo=@FaturaNo,
FaturaTarihi=@FaturaTarihi,Miktari=@Miktari,BirimFiyati=@BirimFiyati,ToplamMaliyet=@ToplamMaliyet,Note=@Note,OdemeDurumu=@OdemeDurumu,KullaniciId=@KullaniciId 
where Id=@Id
end
go

create procedure GetAll_FarkOdemesi
as
select * from FarkOdemesi
go

-------------------------------------------------------------------
--*****************   TABLOLAR   *********************************
-------------------------------------------------------------------

--CÝFTCÝLER

create procedure GetAll_CiftciDataGrid as
select Ciftciler.Id, TcKimlikNo,NameSurname,FatherName,MotherName,Village from Ciftciler
go

--CKS LÝSTESÝ

create procedure GetAll_CksDataGrid
as
select cks.Id, cks.DosyaNo,Ciftciler.TcKimlikNo, Ciftciler.NameSurname,Ciftciler.FatherName,
Ciftciler.MobilePhone,Ciftciler.HomePhone,Ciftciler.Village,cks.Note,Cks.CreateTime
from Cks full  join Ciftciler
on cks.CiftciId=Ciftciler.Id
where Cks.DosyaNo is not null
go

--YEM BÝTKÝSÝ

create procedure GetAll_YemBitkisiDataGrid
as
select 
YemBitkileri.Id,
YemBitkileri.DosyaNo,
Urun.UrunAdi,
YemBitkileri.EkilisYili,
YemBitkileri.AraziMahalle,
YemBitkileri.Ada,
YemBitkileri.Parsel,
YemBitkileri.MuracaatAlani,
YemBitkileri.MuracaatTarihi,
YemBitkileri.CksId,
YemBitkileri.KontrolDurumu,
YemBitkileri.TespitEdilenAlan
from YemBitkileri inner join Cks 
on YemBitkileri.CksId=cks.Id
inner join Urun
on YemBitkileri.UrunId=Urun.Id
go

--FARK ÖDEMESÝ

create procedure GetAll_FarkOdemesiDataGrid
as
select 
FarkOdemesi.Id,
FarkOdemesi.DosyaNo,
Firma.FirmaAdi,
Urun.UrunAdi,
FarkOdemesi.Miktari,
FarkOdemesi.Note,
FarkOdemesi.OdemeDurumu
from FarkOdemesi
inner join cks on FarkOdemesi.CksId=cks.Id
inner join Firma on FarkOdemesi.FirmaId=Firma.Id
inner join Urun on FarkOdemesi.UrunId=Urun.Id


go

--SERTÝFÝKALI TOHUM

create procedure GetAll_SertifikaliTohumDataGrid
as
select 
SertifikaliTohum.Id,
SertifikaliTohum.DosyaNo,
Firma.FirmaAdi,
Urun.UrunAdi,
SertifikaliTohum.Miktari,
SertifikaliTohum.Note,
SertifikaliTohum.OdemeDurumu,
Cks.Id as cksId
from SertifikaliTohum
inner join cks on SertifikaliTohum.CksId=cks.Id
inner join Firma on SertifikaliTohum.FirmaId=Firma.Id
inner join Urun on SertifikaliTohum.UrunId=Urun.Id
 --Id ve CiftciId gerekli kolonlar...
 --id ile kayýta CiftciId ile ciftciye ait kayýda ulaþýlýyor.

go
--KULLANICI

create procedure GetAll_KullaniciDataGrid
as
select Kullanici.Id,
KullaniciAdi from Kullanici

go

--FÝRMA

create procedure GetAll_FirmaDataGrid
as
select Firma.Id, FirmaAdi from Firma
go

--ÜRÜN 
create procedure GetAll_UrunDataGrid
as
select Urun.Id, UrunAdi,UrunCesidi from Urun
go

---------------------------------------------
---          TABLE FOR PRÝNT        ---------
---------------------------------------------

-- YEM BÝTKÝLERÝ FOR PRÝNT

create procedure GetAll_YemBitkileri_ForPrint
as
SELECT 
YemBitkileri.DosyaNo as [Dosya No],
Ciftciler.TcKimlikNo as TcNo,
ciftciler.NameSurname as [Ýsim Soyisim],
YemBitkileri.MuracaatTarihi as [Baþvuru Tarih] ,
YemBitkileri.AraziMahalle as [Köy/Mahalle],
Urun.UrunAdi as [Ürün],
YemBitkileri.Ada,
YemBitkileri.Parsel,
YemBitkileri.MuracaatAlani as [Baþvuru Alan],
YemBitkileri.KontrolDurumu as [Kontrol Durumu],
YemBitkileri.TespitEdilenAlan as [Tespit Edilen Alan]
FROM YemBitkileri inner join Cks
on YemBitkileri.CksId=Cks.Id
inner join Ciftciler on Cks.CiftciId=Ciftciler.Id
inner join Urun on YemBitkileri.UrunId=Urun.Id
order by YemBitkileri.DosyaNo desc
go

-- Fark Odemesi FOR PRÝNT

create procedure GetAll_FarkOdemesi_ForPrint
as
select 
Ciftciler.TcKimlikNo,
Ciftciler.NameSurname,
fark.DosyaNo,
fark.MuracaatTarihi,
firma.FirmaAdi,
Urun.UrunAdi,
fark.Miktari,
fark.OdemeDurumu
from FarkOdemesi as fark
inner join cks on fark.CksId=cks.Id
inner join Firma on firma.Id=fark.FirmaId
inner join Ciftciler on Ciftciler.Id=cks.CiftciId
inner join Urun on Urun.Id=fark.UrunId
order by fark.DosyaNo desc
go

-- Sertifikalý Tohum FOR PRÝNT

create procedure GetAll_SertifikaliTohum_ForPrint
as
select
Ciftciler.TcKimlikNo,
Ciftciler.NameSurname,
SertifikaliTohum.DosyaNo,
SertifikaliTohum.MuracaatTarihi,
Firma.FirmaAdi,
Urun.UrunAdi,
SertifikaliTohum.Miktari,
SertifikaliTohum.OdemeDurumu
from SertifikaliTohum
inner join cks on cks.Id=SertifikaliTohum.CksId
inner join firma on Firma.Id=SertifikaliTohum.FirmaId
inner join Urun on Urun.Id=SertifikaliTohum.UrunId
inner join Ciftciler on Ciftciler.Id=cks.CiftciId
order by SertifikaliTohum.DosyaNo desc
go

--  CKS Listesi FOR PRÝNT

create procedure GetAll_CKS_ForPrint
as
select  cks.DosyaNo,Ciftciler.TcKimlikNo, Ciftciler.NameSurname,Ciftciler.FatherName,
Ciftciler.MobilePhone,Ciftciler.HomePhone,Ciftciler.Village,Cks.CreateTime
from Cks inner  join Ciftciler
on cks.CiftciId=Ciftciler.Id
order by cks.DosyaNo desc
go