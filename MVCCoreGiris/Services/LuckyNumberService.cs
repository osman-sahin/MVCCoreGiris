using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreGiris.Services
{
    // this service give us a randomly selected number.
    public class LuckyNumberService
    {
        private readonly static Random rnd = new Random();  // static yapma nedenimiz ilk kullanımda bir kez olusturulup tekrar tekrar olusturulmaması

        public int LuckyNumber { get; private set; }

        //static LuckyNumberService()    // static ctor icinde yeni orneklenebilir. ama static olmayan kısımda orneklenemez.
        //{
        //    rnd = new Random();
        //    rnd = new Random();
        //}

        public LuckyNumberService()
        {
            LuckyNumber = rnd.Next(10);
        }
    }
}
