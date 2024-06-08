using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Algoritma2
{
    public class Employee
    {
        public int id;
        public string ad;        
        public string soyAd;
        public int age;
        public string Ad{get => ad; set => ad = value.ToLower();}
        public string SoyAd{get => soyAd; set => soyAd = value.ToUpper();}
    }
}