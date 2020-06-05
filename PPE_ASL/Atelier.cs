using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ASL
{
    class Atelier
    {
        #region Propriétés privées
        private int idAtelier;
        private string libelleAtelier;
        private int capMax;
        #endregion

        #region Constructeurs
        public Atelier(int unId, string unLibelleAtelier, int uneCapMax)
        {
            idAtelier = unId;
            libelleAtelier = unLibelleAtelier;
            capMax = uneCapMax;
        }
        #endregion

        #region Accesseurs
        public int IdAtelier
        {
            get
            {
                return idAtelier;
            }

            set
            {
                idAtelier = value;
            }
        }

        public string LibelleAtelier
        {
            get
            {
                return libelleAtelier;
            }

            set
            {
                libelleAtelier = value;
            }
        }

        public int CapMax
        {
            get
            {
                return capMax;
            }

            set
            {
                capMax = value;
            }
        }

        #endregion

        #region Méthodes publiques

        public void modifierNomAtelier(String unLibelleAtelier)
        {
            if (unLibelleAtelier != null)
            {
                this.libelleAtelier = unLibelleAtelier;
                this.modifierNomAtelierBDD();
            }
        }
        public void modifierCapMaxAtelier(int uneCapMax)
        {

        }

        public void modifierNomAtelierBDD()
        {
            DAOAsl.modifierNomAtelier(this);
        }

        public void deleteAtelier()
        {
            DAOAsl.deleteAtelierBDD(this);
        }

        #endregion

        #region Méthodes d'appel au DAO métier

        // Méthode statique qui retourne l'ensemble des ateliers sous forme de List
        public static List<Atelier> listeAteliers()
        {
            return DAOAsl.getAllAteliers();
        }

        // Méthode qui fait créer un atelier dans la BDD
        public void ajouterAtelier()
        {
            DAOAsl.creerAtelier(this);
        }


        #endregion

    }
}
