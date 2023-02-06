using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLib.model
{
    public class Medlem
    {
        private String _navn;
        private readonly int _medlemsId;
        private String _mobil;
        private String _løbeHold;
        private double _pris;

        public string Navn { 
            get => _navn;
            set
            {
                if (string.IsNullOrWhiteSpace(value) )
                {
                    throw new ArgumentNullException("Navn er krævet");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentException("Navn skal være mindst 3 tegn langt");
                }
                _navn = value;
            }
            }
        public int MedlemsId { get => _medlemsId;  }
        public string Mobil { 
            get => _mobil;
            set {
                if (string.IsNullOrWhiteSpace(value) )
                {
                    throw new ArgumentNullException("Mobil er krævet");
                }
                if (value.Length < 8 || 12 < value.Length)
                {
                    throw new ArgumentException("mobil skal være mellem 8 - 12 tegn langt");
                }

                _mobil = value; 
            }
        }
        public string LøbeHold { 
            get => _løbeHold;
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("LøbeHold er krævet");
                }
                if (!(value == "sort" || value == "blå" || value == "grøn" || value == "gul" || value == "orange" || value == "rød" ))
                {
                    throw new ArgumentException("LøbeHold skal være 'sort' 'blå' 'grøn' 'gul' 'orange' eller 'rød'");
                }
                _løbeHold = value; 
            }
        }
        public double Pris { 
            get => _pris;
            set { 
                if (value < 50)
                {
                    throw new ArgumentException("Pris er mindst 50");
                }
                _pris = value; 
            }
        }

        public Medlem(string navn, int medlemsId, string mobil, string løbeHold, double pris)
        {
            Navn = navn;
            _medlemsId = medlemsId;
            Mobil = mobil;
            LøbeHold = løbeHold;
            Pris = pris;
        }

        public Medlem():this("dummy",0,"11111111", "rød", 50)
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(MedlemsId)}={MedlemsId.ToString()}, {nameof(Mobil)}={Mobil}, {nameof(LøbeHold)}={LøbeHold}, {nameof(Pris)}={Pris.ToString()}}}";
        }
    }
}
