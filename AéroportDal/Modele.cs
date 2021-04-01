using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroportDal
{
    public class Modele
    {

        #region Attributs
        private int _Identifiant;
        private string _Version;
        private int _IdentifiantConstructeur;
        private int _NombreDeMoteur;
        #endregion

        #region Propriétés
        public int Identifiant
        {
            get { return _Identifiant; }
            set { _Identifiant = value; }
        }


        public string Version
        {
            get { return _Version; }
            set { _Version = value; }
        }


        public int IdentifiantConstructeur
        {
            get { return _IdentifiantConstructeur; }
            set { _IdentifiantConstructeur = value; }
        }
        public int NombreDeMoteur
        {
            get { return _NombreDeMoteur; }
            set { _NombreDeMoteur = value; }
        }
        #endregion
    }
}
