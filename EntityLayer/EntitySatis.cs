using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class EntitySatis
    {
        private int _SatisId;
        private int _UrunId;
        private int _PersonelId;
        private int _MusteriId;
        private string _Urun;
        private string _Personel;
        private string _Musteri;
        private decimal _Tutar;

        public int SatisId { get => _SatisId; set => _SatisId = value; }
        public string Urun { get => _Urun; set => _Urun = value; }
        public string Personel { get => _Personel; set => _Personel = value; }
        public string Musteri { get => _Musteri; set => _Musteri = value; }
        public decimal Tutar { get => _Tutar; set => _Tutar = value; }
        public int UrunId { get => _UrunId; set => _UrunId = value; }
        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public int MusteriId { get => _MusteriId; set => _MusteriId = value; }
    }
}
