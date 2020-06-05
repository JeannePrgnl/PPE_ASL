using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_ASL
{
    class Theme
    {
        #region Propriétés privées
        private int idTheme;
        private string libelleTheme;
        private int idAtelierTheme;
        #endregion

        #region Constructeurs
        public Theme(int unId, string unLibelleTheme, int unIdAtelierTheme)
        {
            idTheme = unId;
            libelleTheme = unLibelleTheme;
            idAtelierTheme = unIdAtelierTheme;
        }
        #endregion

        #region Accesseurs
        public int IdTheme
        {
            get
            {
                return idTheme;
            }

            set
            {
                idTheme = value;
            }
        }

        public string LibelleTheme
        {
            get
            {
                return libelleTheme;
            }

            set
            {
                libelleTheme = value;
            }
        }

        public int IdAtelierTheme
        {
            get
            {
                return idAtelierTheme;
            }

            set
            {
                idAtelierTheme = value;
            }
        }
        #endregion

        #region Méthodes d'appel au DAO métier

        // Méthode statique qui retourne l'ensemble des thèmes sous forme de List
        public static List<Theme> listeThemes()
        {
            return DAOAsl.getAllThemes();
        }
        #endregion
    }
}
