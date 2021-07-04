﻿/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:    1
**				ÖĞRENCİ ADI............:    Ece Nur Arslan
**				ÖĞRENCİ NUMARASI.......:    B171210061
**              DERSİN ALINDIĞI GRUP...:    1A
****************************************************************************/

using Archer.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archer.Library.Concrete
{
    internal class Ok : Cisim
    {
        public Ok(Size hareketAlaniBoyutlari, int yayKonumuY, string archer) : base(hareketAlaniBoyutlari)
        {
            if (archer == "centaur")
            {
                Image = Image.FromFile(@"Gorseller\digerOkBu.png");
            }
            else Image = Image.FromFile(@"Gorseller\arrow.png");
            Size = new System.Drawing.Size(102, 26);
            //SizeMode = PictureBoxSizeMode.StretchImage;

            BaslangicKonumunuAyarla(yayKonumuY);
            HareketMesafesi = (int)Width;
        }

        //oku okcu picbox ının ortasından baslatıyor ve panelin en solundan
        private void BaslangicKonumunuAyarla(int yayKonumuY)
        {
            Left = 0;
            Middle = yayKonumuY;
        }
    }
}
