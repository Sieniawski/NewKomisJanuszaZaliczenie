using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKomisJanuszaZaliczenie
{
    class Pojazd
    {
        private float f_cenaZakupu;
        private float f_marza;
        private int i_rokProdukcji;
        
        //getery podst wartosci
        public float Marza
        {
            get
            {
                return f_marza;
            }
        }

        public float CenaZakupu
        {
            get {
                return f_cenaZakupu;
            }
        }

        public int RokProdukcji
        {
            get {
                return i_rokProdukcji;
            }
        }

        void wyswietlRok()
        {

        }

        float podajCeneKoncowa()
        {
            float cenaKoncowa = CenaZakupu + Marza;
            return cenaKoncowa;
        }

        //public abstract string wyswietlMarke();
        //public abstract string wyswietlModel();
        //public abstract string wyswietlTypPojazdu();
    }
}
