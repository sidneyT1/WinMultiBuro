using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB_METIER
{
    public class Ressource
    {
        private string numero;
        private string libelle;
        private string type;
        private int capacite;
        private double tarif;

        public Ressource(string unNumero, string unLibelle, string unType, int uneCapacite, double unTarif)
        {
            this.numero = unNumero;
            this.libelle = unLibelle;
            this.type = unType;
            this.capacite = uneCapacite;
            this.tarif = unTarif;
        }

        public string GetNumero()
        {
            return this.numero;
        }

        public string GetLibelle()
        {
            return this.libelle;
        }

        public string GetUnType()
        {
            return this.type;
        }

        public int GetCapacite() 
        {
            return this.capacite;
        }
        public double GetTarif()
        {
            return this.tarif;
        }

        public void SetNumero(string unNumero)
        {
            this.numero = unNumero;
        }

        public void SetLibelle(string unLibelle)
        {
            this.libelle = unLibelle;
        }

        public void SetType(string unType)
        {
            this.type = unType;
        }

        public void SetCapacite(int uneCapacite)
        {
            this.capacite = uneCapacite;
        }

        public void SetTarif(double unTarif)
        {
            this.tarif = unTarif;
        }



    }
}
