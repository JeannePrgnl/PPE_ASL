using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ASL
{
    class Utilisateur
    {
        #region Propriétés privées
        private int idUtilisateur;
        private string pseudo;
        private string mdp;
        #endregion

        #region Constructeurs
        public Utilisateur(int unIdUtilisateur, string unPseudo, string unMdp)
        {
            idUtilisateur = unIdUtilisateur;
            pseudo = unPseudo;
            mdp = unMdp;
        }
        #endregion

        #region Accesseurs
        public int IdUtilisateur
        {
            get
            {
                return idUtilisateur;
            }

            set
            {
                idUtilisateur = value;
            }
        }

        public string Pseudo
        {
            get
            {
                return pseudo;
            }

            set
            {
                pseudo = value;
            }
        }

        public string Mdp
        {
            get
            {
                return mdp;
            }

            set
            {
                mdp = value;
            }
        }
        #endregion

        #region Méthodes d'appel au DAO métier

        // Méthode statique qui retourne l'ensemble des utilisateurs sous forme de List
        public static List<Utilisateur> listeUtilisateur()
        {
            return DAOAsl.getAllUtilisateurs();
        }

        #endregion
    }
}
