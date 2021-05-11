using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class EntityDepartman
    {
        private byte _DepartmanId;
        private string _DepartmanAd;

        public byte DepartmanId { get => _DepartmanId; set => _DepartmanId = value; }
        public string DepartmanAd { get => _DepartmanAd; set => _DepartmanAd = value; }
    }
}
