
namespace TPAréoport
{
    partial class AjoutModifSupprAvion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutModifSupprAvion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tab = new System.Windows.Forms.TableLayoutPanel();
            this.Avion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AjoutModifSup = new System.Windows.Forms.TableLayoutPanel();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ListAvion = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Modèle = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.textBoxAvionNom = new System.Windows.Forms.TextBox();
            this.Constructeur = new System.Windows.Forms.Label();
            this.comboBoxConst = new System.Windows.Forms.ComboBox();
            this.comboBoxModele = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.Tab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.AjoutModifSup.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 506);
            this.panel1.TabIndex = 1;
            // 
            // Tab
            // 
            this.Tab.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.Tab.ColumnCount = 1;
            this.Tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Tab.Controls.Add(this.Avion, 0, 0);
            this.Tab.Controls.Add(this.panel2, 0, 2);
            this.Tab.Controls.Add(this.panel3, 0, 1);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Left;
            this.Tab.Location = new System.Drawing.Point(0, 0);
            this.Tab.Name = "Tab";
            this.Tab.RowCount = 3;
            this.Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04167F));
            this.Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.95834F));
            this.Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.Tab.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Tab.Size = new System.Drawing.Size(867, 506);
            this.Tab.TabIndex = 3;
            // 
            // Avion
            // 
            this.Avion.AutoSize = true;
            this.Avion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Avion.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Avion.Location = new System.Drawing.Point(6, 3);
            this.Avion.Name = "Avion";
            this.Avion.Size = new System.Drawing.Size(855, 47);
            this.Avion.TabIndex = 0;
            this.Avion.Text = "Avion";
            this.Avion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AjoutModifSup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 441);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 59);
            this.panel2.TabIndex = 3;
            // 
            // AjoutModifSup
            // 
            this.AjoutModifSup.ColumnCount = 3;
            this.AjoutModifSup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AjoutModifSup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AjoutModifSup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.AjoutModifSup.Controls.Add(this.Ajouter, 0, 0);
            this.AjoutModifSup.Controls.Add(this.Modifier, 1, 0);
            this.AjoutModifSup.Controls.Add(this.Supprimer, 2, 0);
            this.AjoutModifSup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AjoutModifSup.Location = new System.Drawing.Point(0, 0);
            this.AjoutModifSup.Name = "AjoutModifSup";
            this.AjoutModifSup.RowCount = 1;
            this.AjoutModifSup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AjoutModifSup.Size = new System.Drawing.Size(855, 59);
            this.AjoutModifSup.TabIndex = 0;
            // 
            // Ajouter
            // 
            this.Ajouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ajouter.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Ajouter.Location = new System.Drawing.Point(3, 3);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(279, 53);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Modifier.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Modifier.Location = new System.Drawing.Point(288, 3);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(279, 53);
            this.Modifier.TabIndex = 1;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Supprimer.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Supprimer.Location = new System.Drawing.Point(573, 3);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(279, 53);
            this.Supprimer.TabIndex = 2;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(6, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 376);
            this.panel3.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 555F));
            this.tableLayoutPanel1.Controls.Add(this.ListAvion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 376);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ListAvion
            // 
            this.ListAvion.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.ListAvion.FormattingEnabled = true;
            this.ListAvion.ItemHeight = 15;
            this.ListAvion.Location = new System.Drawing.Point(3, 3);
            this.ListAvion.Name = "ListAvion";
            this.ListAvion.Size = new System.Drawing.Size(294, 364);
            this.ListAvion.TabIndex = 0;
            this.ListAvion.SelectedIndexChanged += new System.EventHandler(this.ListAvion_SelectedIndexChanged_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Modèle, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Nom, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxAvionNom, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Constructeur, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxConst, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxModele, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(303, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(549, 353);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // Modèle
            // 
            this.Modèle.AutoSize = true;
            this.Modèle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Modèle.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Modèle.Location = new System.Drawing.Point(3, 234);
            this.Modèle.Name = "Modèle";
            this.Modèle.Size = new System.Drawing.Size(268, 119);
            this.Modèle.TabIndex = 11;
            this.Modèle.Text = "Modèle";
            this.Modèle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nom.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Nom.Location = new System.Drawing.Point(3, 0);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(268, 117);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            this.Nom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAvionNom
            // 
            this.textBoxAvionNom.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.textBoxAvionNom.Location = new System.Drawing.Point(277, 30);
            this.textBoxAvionNom.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.textBoxAvionNom.Name = "textBoxAvionNom";
            this.textBoxAvionNom.Size = new System.Drawing.Size(121, 21);
            this.textBoxAvionNom.TabIndex = 7;
            // 
            // Constructeur
            // 
            this.Constructeur.AutoSize = true;
            this.Constructeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Constructeur.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.Constructeur.Location = new System.Drawing.Point(3, 117);
            this.Constructeur.Name = "Constructeur";
            this.Constructeur.Size = new System.Drawing.Size(268, 117);
            this.Constructeur.TabIndex = 10;
            this.Constructeur.Text = "Constructeur";
            this.Constructeur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxConst
            // 
            this.comboBoxConst.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.comboBoxConst.FormattingEnabled = true;
            this.comboBoxConst.Location = new System.Drawing.Point(277, 147);
            this.comboBoxConst.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.comboBoxConst.Name = "comboBoxConst";
            this.comboBoxConst.Size = new System.Drawing.Size(121, 23);
            this.comboBoxConst.TabIndex = 12;
            this.comboBoxConst.SelectedIndexChanged += new System.EventHandler(this.comboBoxConst_SelectedIndexChanged);
            // 
            // comboBoxModele
            // 
            this.comboBoxModele.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.comboBoxModele.FormattingEnabled = true;
            this.comboBoxModele.Location = new System.Drawing.Point(277, 264);
            this.comboBoxModele.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.comboBoxModele.Name = "comboBoxModele";
            this.comboBoxModele.Size = new System.Drawing.Size(121, 23);
            this.comboBoxModele.TabIndex = 13;
            // 
            // AjoutModifSupprAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 506);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AjoutModifSupprAvion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des avions ";
            this.panel1.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.Tab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.AjoutModifSup.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel Tab;
        private System.Windows.Forms.Label Avion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel AjoutModifSup;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ListBox ListAvion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.TextBox textBoxAvionNom;
        private System.Windows.Forms.Label Constructeur;
        private System.Windows.Forms.Label Modèle;
        private System.Windows.Forms.ComboBox comboBoxConst;
        private System.Windows.Forms.ComboBox comboBoxModele;
    }
}
