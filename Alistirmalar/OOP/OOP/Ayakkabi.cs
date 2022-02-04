using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Ayakkabi
    {
        private string markasi;
        public string OkuMarkasi()
        {
            //markasi = "adidas";
            return markasi;
        }
        public void YazMarkasi(string deger)
        {
            markasi = deger;
        }


        private string tipi;

        public string Tipi
        {
            get
            { 
                return tipi;
            }
            set
            { 
                tipi = value;
            }
        }

        public byte Numarasi { get => numarasi; set => numarasi = value; }

        private byte numarasi;


        private string malzemesi;
        public string Renk { get; set; }
        private string bagacikliMi;
    }
}
