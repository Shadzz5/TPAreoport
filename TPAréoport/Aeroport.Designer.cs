
namespace TPAreoport
{
    partial class Aeroport
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Version = new System.Windows.Forms.Label();
            this.ResultNom = new System.Windows.Forms.Label();
            this.ResultVersion = new System.Windows.Forms.Label();
            this.ResultConstructeur = new System.Windows.Forms.Label();
            this.Constructeur = new System.Windows.Forms.Label();
            this.NombreDeMoteur = new System.Windows.Forms.Label();
            this.ResultMoteur = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ListAvion = new System.Windows.Forms.ListBox();
            this.Avion = new System.Windows.Forms.Label();
            this.ButtonAvion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 501);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Version, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ResultNom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ResultVersion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ResultConstructeur, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Constructeur, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.NombreDeMoteur, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ResultMoteur, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Nom, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(280, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 501);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(3, 56);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(42, 13);
            this.Version.TabIndex = 1;
            this.Version.Text = "Version";
            // 
            // ResultNom
            // 
            this.ResultNom.AutoSize = true;
            this.ResultNom.Location = new System.Drawing.Point(282, 0);
            this.ResultNom.Name = "ResultNom";
            this.ResultNom.Size = new System.Drawing.Size(35, 13);
            this.ResultNom.TabIndex = 3;
            this.ResultNom.Text = "label4";
            // 
            // ResultVersion
            // 
            this.ResultVersion.AutoSize = true;
            this.ResultVersion.Location = new System.Drawing.Point(282, 56);
            this.ResultVersion.Name = "ResultVersion";
            this.ResultVersion.Size = new System.Drawing.Size(35, 13);
            this.ResultVersion.TabIndex = 4;
            this.ResultVersion.Text = "label5";
            // 
            // ResultConstructeur
            // 
            this.ResultConstructeur.AutoSize = true;
            this.ResultConstructeur.Location = new System.Drawing.Point(282, 112);
            this.ResultConstructeur.Name = "ResultConstructeur";
            this.ResultConstructeur.Size = new System.Drawing.Size(35, 13);
            this.ResultConstructeur.TabIndex = 5;
            this.ResultConstructeur.Text = "label6";
            // 
            // Constructeur
            // 
            this.Constructeur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Constructeur.AutoSize = true;
            this.Constructeur.Location = new System.Drawing.Point(3, 112);
            this.Constructeur.Name = "Constructeur";
            this.Constructeur.Size = new System.Drawing.Size(273, 13);
            this.Constructeur.TabIndex = 2;
            this.Constructeur.Text = "Constructeur";
            // 
            // NombreDeMoteur
            // 
            this.NombreDeMoteur.AutoSize = true;
            this.NombreDeMoteur.Location = new System.Drawing.Point(3, 181);
            this.NombreDeMoteur.Name = "NombreDeMoteur";
            this.NombreDeMoteur.Size = new System.Drawing.Size(40, 13);
            this.NombreDeMoteur.TabIndex = 6;
            this.NombreDeMoteur.Text = "Moteur";
            // 
            // ResultMoteur
            // 
            this.ResultMoteur.AutoSize = true;
            this.ResultMoteur.Location = new System.Drawing.Point(282, 181);
            this.ResultMoteur.Name = "ResultMoteur";
            this.ResultMoteur.Size = new System.Drawing.Size(35, 13);
            this.ResultMoteur.TabIndex = 7;
            this.ResultMoteur.Text = "label2";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(3, 0);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 0;
            this.Nom.Text = "Nom";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ListAvion, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Avion, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonAvion, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04167F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.95834F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(280, 501);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // ListAvion
            // 
            this.ListAvion.FormattingEnabled = true;
            this.ListAvion.Location = new System.Drawing.Point(6, 55);
            this.ListAvion.Name = "ListAvion";
            this.ListAvion.Size = new System.Drawing.Size(268, 368);
            this.ListAvion.TabIndex = 2;
            this.ListAvion.SelectedIndexChanged += new System.EventHandler(this.ListAvion_SelectedIndexChanged);
            // 
            // Avion
            // 
            this.Avion.AutoSize = true;
            this.Avion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Avion.Location = new System.Drawing.Point(6, 3);
            this.Avion.Name = "Avion";
            this.Avion.Size = new System.Drawing.Size(268, 46);
            this.Avion.TabIndex = 0;
            this.Avion.Text = "Avion";
            this.Avion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonAvion
            // 
            this.ButtonAvion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonAvion.Location = new System.Drawing.Point(6, 436);
            this.ButtonAvion.Name = "ButtonAvion";
            this.ButtonAvion.Size = new System.Drawing.Size(268, 59);
            this.ButtonAvion.TabIndex = 3;
            this.ButtonAvion.Text = "Gestion des avions";
            this.ButtonAvion.UseVisualStyleBackColor = true;
            this.ButtonAvion.Click += new System.EventHandler(this.ButtonAvion_Click);
            // 
            // Aeroport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 501);
            this.Controls.Add(this.panel1);
            this.Name = "Aeroport";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label Avion;
        private System.Windows.Forms.ListBox ListAvion;
        private System.Windows.Forms.Button ButtonAvion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label Constructeur;
        private System.Windows.Forms.Label ResultNom;
        private System.Windows.Forms.Label ResultVersion;
        private System.Windows.Forms.Label ResultConstructeur;
        private System.Windows.Forms.Label NombreDeMoteur;
        private System.Windows.Forms.Label ResultMoteur;
    }
}

