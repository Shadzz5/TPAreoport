using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroport.DAL
{
    public class Constructeur
    {
        #region Attributs
        private int _Identifiant;
        private string _Nom;

        #endregion

        #region Propriétés
        public int Identifiant
        {
            get { return _Identifiant; }
            set { _Identifiant = value; }
        }


        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }


        #endregion
        public String CompleteName
        {
            get
            {
                return _Nom;
            }
        }
    }
}
 