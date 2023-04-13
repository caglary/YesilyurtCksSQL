CREATE TABLE [dbo].[icmal_fark_odemesi_yagli_tohumlu](
	[id] [int]  identity(1,1 ) primary key,
	[kimlikNo] [nvarchar](11) not NULL,
	[urun] [nvarchar](50) NULL,
	[destege_tabi_alan(da)] [numeric](10, 3) NULL,
	[uretim_miktari(kg)] [numeric](10, 3) NULL,
	[satis_miktari(kg)] [numeric](10, 3) NULL,
	[destege_tabi_miktar(kg)] [numeric](10, 3) NULL,
	[destek_tutari(TL)] [numeric](10, 2) NULL,
)

CREATE TABLE [dbo].[icmal_KOOG](
	[id] [int]  identity(1,1 ) primary key,
	[kimlikNo] [nvarchar](11) not NULL,
	
	[Kat� Organik �r�n (Kg)] [numeric](10, 3) NULL,
	[Kat� Organik Toprak D�zenleyici (Kg)] [numeric](10, 3) NULL,
	[Kat� Organomineral �r�n (Kg)] [numeric](10, 3) NULL,
	[Kaplama G�bre (Kg)] [numeric](10, 3) NULL,
	[Organik G�bre (Kg)] [numeric](10, 3) NULL,
	[destege_tabi_alan(da)] [numeric](10, 3) NULL,
	[destek_tutari(TL)] [numeric](10, 2) NULL,
)
CREATE TABLE [dbo].[icmal_fark_odemesi](
	[id] [int]  identity(1,1 ) primary key,
	[kimlikNo] [nvarchar](11) not NULL,
	[urun] [nvarchar](50) NULL,
	[destege_tabi_alan(da)] [numeric](10, 3) NULL,
	[uretim_miktari(kg)] [numeric](10, 3) NULL,
	[satis_miktari(kg)] [numeric](10, 3) NULL,
	[destege_tabi_miktar(kg)] [numeric](10, 3) NULL,
	[destek_tutari(TL)] [numeric](10, 2) NULL,
)
CREATE TABLE [dbo].[icmal_mgd](
	[id] [int]  identity(1,1 ) primary key,
	[kimlikNo] [nvarchar](11) not NULL,
	[Mazot Alan�(da)] [numeric](10, 3) NULL,
	[Mazot Destekleme Miktar�(TL)] [numeric](10, 2) NULL,
	[G�bre Alan� (da))] [numeric](10, 3) NULL,
	[G�bre Destekleme Miktar�(TL)] [numeric](10, 2) NULL,
	[Toplam Destekleme Miktar�(TL)] [numeric](10, 3) NULL,
	[Vergi Kesintisi (TL) ] [numeric](10, 2) NULL,
	[Net �denecek Tutar (TL) ] [numeric](10, 2) NULL,

)
CREATE TABLE [dbo].[icmal_stkd](
	[id] [int]  identity(1,1 ) primary key,
	[kimlikNo] [nvarchar](11) not NULL,
	[�r�n] [nvarchar](50) not NULL,

	[Fatura Miktar� (kg)] [numeric](10, 3) NULL,
	[Destekleme Alan� (da)] [numeric](10, 3) NULL,
	
	[Destekleme  Miktar� (TL)] [numeric](10, 2) NULL,

)
CREATE TABLE [dbo].[icmal_tmo](
	[id] [int]  identity(1,1 ) primary key,
	[kimlikNo] [nvarchar](11) not NULL,
	[urun] [nvarchar](50) NULL,
	[destege_tabi_alan(da)] [numeric](10, 3) NULL,
	[uretim_miktari(kg)] [numeric](10, 3) NULL,
	[satis_miktari(kg)] [numeric](10, 3) NULL,
	[destege_tabi_miktar(kg)] [numeric](10, 3) NULL,
	[destek_tutari(TL)] [numeric](10, 2) NULL,
)
