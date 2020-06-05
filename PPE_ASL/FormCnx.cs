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
    public partial class FormCnx : Form
    {
        public FormCnx()
        {
            InitializeComponent();           
        }

        private void cbxAfficherMdp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAfficherMdp.Checked)
                txbMdp.UseSystemPasswordChar = false;
            else
                txbMdp.UseSystemPasswordChar = true;
        }

        // vérifie les données rentrés et accéde a l'application
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if (txbPseudo.Text == "test")
            {
                if (txbMdp.Text == "test")
                {
                    FormASL f = new FormASL();
                    f.Show();
                    this.Hide(); // pour cacher l'interface d'authentification
                }
                else
                {
                    lblMdpFaux.Visible = true;
                }
            }
        }

        
    }
}


//string i = txbPseudo.Text;
//Utilisateur unUtilisateur;

//unUtilisateur = Utilisateur.listeUtilisateur().;

    //if (txbPseudo.Text == unUtilisateur.Pseudo)
    //{
        //if (txbMdp.Text == unUtilisateur.Mdp)
        //{
            //FormASL f = new FormASL();
            //f.Show();
            //this.Hide(); // pour cacher l'interface d'authentification
        //}
        //else
        //{
            //lblMdpFaux.Visible = true;
        //}
     //}
