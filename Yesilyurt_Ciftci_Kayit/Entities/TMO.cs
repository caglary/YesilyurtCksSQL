using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Yesilyurt_Ciftci_Kayit.Entities
{
    public class TMO
    {
        public int Id { get; set; }
        public int CksId { get; set; }
        public string EvrakKayitNo { get; set; }
        public DateTime EvrakKayitTarihi { get; set; }
        public string Note { get; set; }
        public int FirmaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public int ProductId { get; set; }
        public string Amount { get; set; }
        public int KullaniciId { get; set; }
        public DateTime CreateTime { get; set; }
        public string Donem { get; set; }
    }
}
