using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PPE_ASL
{
    class DAOFactory
    {
        SqlConnection connexion;

        public DAOFactory()
        {
            connexion = new SqlConnection("Data Source = '172.17.21.10'; Initial Catalog = SIO2_M2L_JeanneClement; User ID = SIO2-dev; Password = btssio-slam-2019");
            //Data Source='LAPTOP-GFO130UH';Initial Catalog=ASL;Integrated Security=true
        }

        public void connecter()
        {
            connexion.Open();
        }

        public void deconnecter()
        {
            connexion.Close();
        }

        // Exécution d'une requête de lecture ; retourne un Datareader
        public SqlDataReader excecSQLRead(string requete)
        {
            SqlCommand maCommand;
            SqlDataAdapter monDataAdapter;
            maCommand = new SqlCommand();
            maCommand.CommandText = requete;
            maCommand.Connection = connexion;

            monDataAdapter = new SqlDataAdapter();
            monDataAdapter.SelectCommand = maCommand;

            SqlDataReader monDR;
            monDR = maCommand.ExecuteReader();

            return monDR;
        }

        // Exécution d'une requete d'écriture (Insert ou Update) ; ne retourne rien
        public void execSQLWrite(string requete)
        {

            SqlCommand maCommand;
            maCommand = new SqlCommand();
            maCommand.CommandText = requete;
            maCommand.Connection = connexion;

            maCommand.ExecuteNonQuery();

        }
    }
}