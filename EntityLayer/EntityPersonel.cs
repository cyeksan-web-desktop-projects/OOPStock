using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int _PersonelId;
        private string _PersonelAd;
        private string _PersonelSoyad;
        private byte _PersonelDepartmanId;
        private string _PersonelDepartman;
        private decimal _PersonelMaas;

        public int PersonelId { get => _PersonelId; set => _PersonelId = value; }
        public string PersonelAd { get => _PersonelAd; set => _PersonelAd = value; }
        public string PersonelSoyad { get => _PersonelSoyad; set => _PersonelSoyad = value; }
        public byte PersonelDepartmanId { get => _PersonelDepartmanId; set => _PersonelDepartmanId = value; }
        public string PersonelDepartman { get => _PersonelDepartman; set => _PersonelDepartman = value; }
        public decimal PersonelMaas { get => _PersonelMaas; set => _PersonelMaas = value; }
    }
}
