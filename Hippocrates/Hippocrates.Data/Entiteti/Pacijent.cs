﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippocrates.Data.Entiteti
{
    public class Pacijent
    {
        public virtual string Jmbg { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Srednje_slovo { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime Datum_rodjenja { get; set; }
        public virtual string Opstina { get; set; }
        public virtual int Pravo_da_zakaze { get; set; }
        public virtual string Lbo { get; set; }
        public virtual DateTime Vazi_do { get; set; }
        public virtual string Email { get; set; }
        public virtual string Telefon { get; set; }
        
        public virtual IzabraniLekar Lekar { get; set; }
        public virtual IList<Ocena> Ocene { get; set; }
        public virtual IList<Terapija> Terapije { get; set; }
        public virtual IList<PrimioVakcinu> PrimioVakcinuVakcine { get; set; }
        public virtual IList<Dijagnostifikovano> DijagnostifikovanoDijagnoze { get; set; }
        public virtual IList<Termin> Termini { get; set; }
        public virtual IList<ZahtevZaPromenu> Zahtevi { get; set; }
        public virtual IList<TerminBolnica> TerminiBolnica { get; set; }

        public Pacijent()
        {
            Ocene = new List<Ocena>();
            PrimioVakcinuVakcine = new List<PrimioVakcinu>();
            DijagnostifikovanoDijagnoze = new List<Dijagnostifikovano>();
            Terapije = new List<Terapija>();
            Termini = new List<Termin>();
            Zahtevi = new List<ZahtevZaPromenu>();
            TerminiBolnica = new List<TerminBolnica>();
        }

        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
