
namespace TPAréoport
{
    partial class ModifAvion
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxConstructeur = new System.Windows.Forms.ComboBox();
            this.NomAvion = new System.Windows.Forms.TextBox();
            this.Nom = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Constructeur = new System.Windows.Forms.Label();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.comboBoxVersion = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 445);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboBoxConstructeur, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NomAvion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Nom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Version, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Constructeur, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Enregistrer, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Annuler, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxVersion, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 445);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // comboBoxConstructeur
            // 
            this.comboBoxConstructeur.FormattingEnabled = true;
            this.comboBoxConstructeur.Location = new System.Drawing.Point(339, 253);
            this.comboBoxConstructeur.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.comboBoxConstructeur.Name = "comboBoxConstructeur";
            this.comboBoxConstructeur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConstructeur.TabIndex = 12;
            this.comboBoxConstructeur.SelectedIndexChanged += new System.EventHandler(this.comboBoxConstructeur_SelectedIndexChanged);
            // 
            // NomAvion
            // 
            this.NomAvion.Dock = System.Windows.Forms.DockStyle.Left;
            this.NomAvion.Location = new System.Drawing.Point(339, 31);
            this.NomAvion.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.NomAvion.Name = "NomAvion";
            this.NomAvion.Size = new System.Drawing.Size(122, 20);
            this.NomAvion.TabIndex = 7;
            this.NomAvion.TextChanged += new System.EventHandler(this.NomAvion_TextChanged);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(4, 1);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(4, 112);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(42, 13);
            this.Version.TabIndex = 1;
            this.Version.Text = "Version";
            // 
            // Constructeur
            // 
            this.Constructeur.AutoSize = true;
            this.Constructeur.Location = new System.Drawing.Point(4, 223);
            this.Constructeur.Name = "Constructeur";
            this.Constructeur.Size = new System.Drawing.Size(67, 13);
            this.Constructeur.TabIndex = 2;
            this.Constructeur.Text = "Constructeur";
            // 
            // Enregistrer
            // 
            this.Enregistrer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enregistrer.Location = new System.Drawing.Point(4, 337);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(328, 104);
            this.Enregistrer.TabIndex = 4;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Annuler
            // 
            this.Annuler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Annuler.Location = new System.Drawing.Point(339, 337);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(328, 104);
            this.Annuler.TabIndex = 10;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // comboBoxVersion
            // 
            this.comboBoxVersion.FormattingEnabled = true;
            this.comboBoxVersion.Location = new System.Drawing.Point(339, 142);
            this.comboBoxVersion.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.comboBoxVersion.Name = "comboBoxVersion";
            this.comboBoxVersion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVersion.TabIndex = 11;
            this.comboBoxVersion.SelectedIndexChanged += new System.EventHandler(this.comboBoxVersion_SelectedIndexChanged);
            // 
            // ModifAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 445);
            this.Controls.Add(this.panel1);
            this.Name = "ModifAvion";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxConstructeur;
        private System.Windows.Forms.TextBox NomAvion;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Constructeur;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.ComboBox comboBoxVersion;
    }
}
