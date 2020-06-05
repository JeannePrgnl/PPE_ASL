using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ASL
{
    class Vacation
    {
        #region Propriétés privées
        private int idVacation;
        private string libelleVacation;
        private int idThemeVacation;
        #endregion

        #region Constructeurs
        public Vacation(int unId, string unLibelleVacation, int unidThemeVacation)
        {
            idVacation = unId;
            libelleVacation = unLibelleVacation;
            idThemeVacation = unidThemeVacation;
        }
        #endregion

        #region Accesseurs
        public int IdVacation
        {
            get
            {
                return idVacation;
            }

            set
            {
                idVacation = value;
            }
        }

        public string LibelleVacation
        {
            get
            {
                return libelleVacation;
            }

            set
            {
                libelleVacation = value;
            }
        }

        public int IdThemeVacation
        {
            get
            {
                return idThemeVacation;
            }

            set
            {
                idThemeVacation = value;
            }
        }
        #endregion

        #region Méthodes d'appel au DAO métier

        // Méthode statique qui retourne l'ensemble des thèmes sous forme de List
        //public static List<Theme> listeVacation()
        
            //return DAOAsl.getAllVacations();
        
        #endregion
    }
}
