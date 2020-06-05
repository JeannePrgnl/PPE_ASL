namespace PPE_ASL
{
    partial class FormCnx
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxAfficherMdp = new System.Windows.Forms.CheckBox();
            this.lblMdpFaux = new System.Windows.Forms.Label();
            this.btnConnecter = new System.Windows.Forms.Button();
            this.txbMdp = new System.Windows.Forms.TextBox();
            this.txbPseudo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxAfficherMdp);
            this.groupBox1.Controls.Add(this.lblMdpFaux);
            this.groupBox1.Controls.Add(this.btnConnecter);
            this.groupBox1.Controls.Add(this.txbMdp);
            this.groupBox1.Controls.Add(this.txbPseudo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connexion :";
            // 
            // cbxAfficherMdp
            // 
            this.cbxAfficherMdp.AutoSize = true;
            this.cbxAfficherMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAfficherMdp.Location = new System.Drawing.Point(118, 114);
            this.cbxAfficherMdp.Name = "cbxAfficherMdp";
            this.cbxAfficherMdp.Size = new System.Drawing.Size(96, 17);
            this.cbxAfficherMdp.TabIndex = 6;
            this.cbxAfficherMdp.Text = "Afficher le mdp";
            this.cbxAfficherMdp.UseVisualStyleBackColor = true;
            this.cbxAfficherMdp.CheckedChanged += new System.EventHandler(this.cbxAfficherMdp_CheckedChanged);
            // 
            // lblMdpFaux
            // 
            this.lblMdpFaux.AutoSize = true;
            this.lblMdpFaux.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMdpFaux.Location = new System.Drawing.Point(115, 98);
            this.lblMdpFaux.Name = "lblMdpFaux";
            this.lblMdpFaux.Size = new System.Drawing.Size(120, 13);
            this.lblMdpFaux.TabIndex = 1;
            this.lblMdpFaux.Text = "mot de passe incorrect !";
            this.lblMdpFaux.Visible = false;
            // 
            // btnConnecter
            // 
            this.btnConnecter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConnecter.Location = new System.Drawing.Point(65, 159);
            this.btnConnecter.Name = "btnConnecter";
            this.btnConnecter.Size = new System.Drawing.Size(125, 23);
            this.btnConnecter.TabIndex = 5;
            this.btnConnecter.Text = "Se connecter";
            this.btnConnecter.UseVisualStyleBackColor = false;
            this.btnConnecter.Click += new System.EventHandler(this.btnConnecter_Click);
            // 
            // txbMdp
            // 
            this.txbMdp.Location = new System.Drawing.Point(104, 75);
            this.txbMdp.Name = "txbMdp";
            this.txbMdp.Size = new System.Drawing.Size(131, 20);
            this.txbMdp.TabIndex = 4;
            this.txbMdp.UseSystemPasswordChar = true;
            // 
            // txbPseudo
            // 
            this.txbPseudo.Location = new System.Drawing.Point(104, 36);
            this.txbPseudo.Name = "txbPseudo";
            this.txbPseudo.Size = new System.Drawing.Size(131, 20);
            this.txbPseudo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pseudo :";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 206);
            this.Controls.Add(this.groupBox1);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnConnecter;
        private System.Windows.Forms.TextBox txbMdp;
        private System.Windows.Forms.TextBox txbPseudo;
        private System.Windows.Forms.Label lblMdpFaux;
        private System.Windows.Forms.CheckBox cbxAfficherMdp;
    }
}