using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PPE_ASL
{
    class DAOAsl
    {
        // Retourne une collection de tous les ateliers lus en BDD 
        public static List<Atelier> getAllAteliers()
        {
            List<Atelier> lesAteliers = new List<Atelier>();
            string req = "Select * from Atelier";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Atelier unAtelier = new Atelier(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()));
                lesAteliers.Add(unAtelier);
            }

            return lesAteliers;

        }

        // Retourne une collection de tous les thèmes lus en BDD 
        public static List<Theme> getAllThemes()
        {
            List<Theme> lesThemes = new List<Theme>();
            string req = "Select * from Theme";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Theme unTheme = new Theme(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()));
                lesThemes.Add(unTheme);
            }

            return lesThemes;
        }

        // Modifie dans la BDD le nom de l'atelier passé en paramètre
        public static void modifierNomAtelier(Atelier unAtelier)
        {
            string requete = "update Atelier set libelleAtelier ='" + unAtelier.LibelleAtelier + "' where idAtelier ='" + unAtelier.IdAtelier + "'";
            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }

        // Crée dans la BDD l'objet Atelier passé en paramètre
        public static void creerAtelier(Atelier unAtelier)
        {
            string requete = "insert into Atelier values('" + unAtelier.IdAtelier + "','" +
                unAtelier.LibelleAtelier.ToString() + "','" + unAtelier.CapMax + "')";
            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }

        // Supprimer de la BDD l'objet Atelier passé en paramètre
        public static void deleteAtelierBDD(Atelier unAtelier)
        {
            string requete = "delete from Atelier where idAtelier='" + unAtelier.IdAtelier + "'";
            DAOFactory db = new DAOFactory();
            db.connecter();
            db.execSQLWrite(requete);
        }

        // Retourne une collection de tous les utilisateurs lus en BDD 
        public static List<Utilisateur> getAllUtilisateurs()
        {
            List<Utilisateur> lesUtilisateurs = new List<Utilisateur>();
            string req = "Select * from Utilisateur";
            DAOFactory db = new DAOFactory();
            db.connecter();

            SqlDataReader reader = db.excecSQLRead(req);

            while (reader.Read())
            {
                Utilisateur unUtilisateur = new Utilisateur(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString());
                lesUtilisateurs.Add(unUtilisateur);
            }

            return lesUtilisateurs;

        }
    }
}
