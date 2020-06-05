using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_ASL
{
    public partial class FormASL : Form
    {

        public FormASL()
        {
            InitializeComponent();
        }

        #region Onglet Accueil
        private void TabAccueil_Enter_1(object sender, EventArgs e)
        {
            // on supprime le contenu actuel éventuel de la combobox
            CbxChoixAtelier1.Items.Clear();
            CbxChoixAtelier1.ResetText();
            //DgvListeThemes.Rows.Clear();

            // on remplit la combobox avec la structure itérative "foreach".
            foreach (Atelier unAtelier in Atelier.listeAteliers())
            {
                CbxChoixAtelier1.Items.Add(unAtelier.LibelleAtelier);
            }
        }

        private void CbxChoixAtelier1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // on récupère l'index de la sélection dans la combobox
            int i = CbxChoixAtelier1.SelectedIndex;
            Atelier unAtelier;

            unAtelier = Atelier.listeAteliers().ElementAt(i);

            DgvListeThemes.Rows.Clear();
            DgvListeThemes.DataSource = null;

            // on redimensionne automatiquement la largeur des colonnes du datagridview
            //isteThemes.AutoResizeColumns();

            foreach (Theme unTheme in Theme.listeThemes())
            {
                if (unTheme.IdAtelierTheme.Equals(unAtelier.IdAtelier))
                {
                    DgvListeThemes.Rows.Add(unTheme.LibelleTheme);
                    DgvListeThemes.AutoResizeColumns();
                }
            }
        }
        #endregion

        #region Onglet Ateliers

        private void TabAtelier_Enter(object sender, EventArgs e)
        {
            CbxChoixAtelier2.ResetText();
            TxbNumAtelier.Clear();
            TxbCapMax.Clear();
            TxbNomAtelier.Clear();
        }

        private void CbxChoixAtelier2_Enter_1(object sender, EventArgs e)
        {
            // on supprime le contenu actuel éventuel de la combobox
            CbxChoixAtelier2.Items.Clear();
            CbxChoixAtelier2.ResetText();

            // on remplit la combobox avec la structure itérative "foreach".
            foreach (Atelier unAtelier in Atelier.listeAteliers())
            {
                CbxChoixAtelier2.Items.Add(unAtelier.LibelleAtelier);
            }
        }
        private void CbxChoixAtelier2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // on récupère l'index de la sélection dans la combobos
            int i = CbxChoixAtelier2.SelectedIndex;
            Atelier unAtelier;

            unAtelier = Atelier.listeAteliers().ElementAt(i);

            TxbNumAtelier.Text = unAtelier.IdAtelier.ToString();
            TxbNomAtelier.Text = unAtelier.LibelleAtelier;
            TxbCapMax.Text = unAtelier.CapMax.ToString();
        }
        private void BtnModifAtelier1_Click(object sender, EventArgs e)
        {
            int i = CbxChoixAtelier2.SelectedIndex;
            Atelier atelier1;
            atelier1 = Atelier.listeAteliers().ElementAt(i);

            if (TxbNomAtelier.Text.Length == 0)
            {
                LblModifNomAtelier.Text = "Pas de nom rentré";
                LblModifNomAtelier.ForeColor = Color.Red;
            }
            else
            {
                atelier1.modifierNomAtelier(TxbNomAtelier.Text);
                LblModifNomAtelier.Text = "Nom modifié";
                LblModifNomAtelier.ForeColor = Color.Green;
            }
        }
        private void BtnModifAtelier2_Click(object sender, EventArgs e)
        {
            int i = CbxChoixAtelier2.SelectedIndex;
            Atelier atelier1;
            atelier1 = Atelier.listeAteliers().ElementAt(i);
            //atelier1.modifierCapMaxAtelier(TxbCapMax.);
            if (TxbNomAtelier.Text.Length == 0)
            {
                LblModifNomAtelier.Text = "Pas de nombre rentré";
                LblModifNomAtelier.ForeColor = Color.Red;
            }
            else
            {
                LblModifNomAtelier.Text = "Capacité maximale modifié";
                LblModifNomAtelier.ForeColor = Color.Green;
            }
        }

        private void BtnCreerAtelier_Click(object sender, EventArgs e)
        {
            Atelier Atl;
            Atl = new Atelier(int.Parse(TxbNumAtelier.Text), TxbNomAtelier.Text, int.Parse(TxbCapMax.Text));
           
            Atl.ajouterAtelier();
        }
        private void BtnSuppAtelier_Click(object sender, EventArgs e)
        {
            int i = CbxChoixAtelier2.SelectedIndex;
            Atelier Atelier1;
            Atelier1 = Atelier.listeAteliers().ElementAt(i);
            Atelier1.deleteAtelier();
            
        }

        #endregion

        #region Onglet Thèmes

        private void CbxChoixAtelier3_Enter(object sender, EventArgs e)
        {
            // on supprime le contenu actuel éventuel de la combobox
            CbxChoixAtelier3.Items.Clear();
            CbxChoixAtelier3.ResetText();

            // on remplit la combobox avec la structure itérative "foreach".
            foreach (Atelier unAtelier in Atelier.listeAteliers())
            {
                CbxChoixAtelier3.Items.Add(unAtelier.LibelleAtelier);
            }
        }
        private void CbxChoixAtelier3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // on récupère l'index de la sélection dans la combobos
            int i = CbxChoixAtelier3.SelectedIndex;
            Atelier unAtelier;

            unAtelier = Atelier.listeAteliers().ElementAt(i);

            // on supprime le contenu actuel éventuel de la combobox choix theme
            CbxChoixTheme1.Items.Clear();
            CbxChoixTheme1.ResetText();

            // on remplit la combobox avec la structure itérative "foreach".
            foreach (Theme unTheme in Theme.listeThemes())
            {
                if(unTheme.IdAtelierTheme.Equals(unAtelier.IdAtelier)){
                    CbxChoixTheme1.Items.Add(unTheme.LibelleTheme);
                }
            }
        }

        private void CbxChoixTheme1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // on récupère l'index de la sélection dans la combobos
            int i = CbxChoixTheme1.SelectedIndex;
            Theme unTheme;

            unTheme = Theme.listeThemes().ElementAt(i);

            TxbNumTheme.Text = unTheme.IdTheme.ToString();
            TxbNomTheme.Text = unTheme.LibelleTheme;
        }


        #endregion

        #region Procédures et Fonctions utilisateurs




        #endregion

    }

}
