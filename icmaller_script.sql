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
	
	[Katý Organik Ürün (Kg)] [numeric](10, 3) NULL,
	[Katý Organik Toprak Düzenleyici (Kg)] [numeric](10, 3) NULL,
	[Katý Organomineral Ürün (Kg)] [numeric](10, 3) NULL,
	[Kaplama Gübre (Kg)] [numeric](10, 3) NULL,
	[Organik Gübre (Kg)] [numeric](10, 3) NULL,
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
	[Mazot Alaný(da)] [numeric](10, 3) NULL,
	[Mazot Destekleme Miktarý(TL)] [numeric](10, 2) NULL,
	[Gübre Alaný (da))] [numeric](10, 3) NULL,
	[Gübre Destekleme Miktarý(TL)] [numeric](10, 2) NULL,
	[Toplam Destekleme Miktarý(TL)] [numeric](10, 3) NULL,
	[Vergi Kesintisi (TL) ] [numeric](10, 2) NULL,
	[Net Ödenecek Tutar (TL) ] [numeric](10, 2) NULL,

)
CREATE TABLE [dbo].[icmal_stkd](
	[id] [int]  identity(1,1 ) primary key,
	[kimlikNo] [nvarchar](11) not NULL,
	[ürün] [nvarchar](50) not NULL,

	[Fatura Miktarý (kg)] [numeric](10, 3) NULL,
	[Destekleme Alaný (da)] [numeric](10, 3) NULL,
	
	[Destekleme  Miktarý (TL)] [numeric](10, 2) NULL,

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
