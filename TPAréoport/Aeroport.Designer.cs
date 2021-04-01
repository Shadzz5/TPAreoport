
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ListAvion = new System.Windows.Forms.ListBox();
            this.Avion = new System.Windows.Forms.Label();
            this.ButtonAvion = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ListModele = new System.Windows.Forms.ListBox();
            this.Modèle = new System.Windows.Forms.Label();
            this.ButtonModele = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Constructeur = new System.Windows.Forms.Label();
            this.ListboxConstructeur = new System.Windows.Forms.ListBox();
            this.ButtonConstruc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 501);
            this.panel1.TabIndex = 0;
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(560, 0);
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
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ListModele, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Modèle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonModele, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(280, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.95834F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 501);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ListModele
            // 
            this.ListModele.FormattingEnabled = true;
            this.ListModele.Location = new System.Drawing.Point(6, 55);
            this.ListModele.Name = "ListModele";
            this.ListModele.Size = new System.Drawing.Size(268, 368);
            this.ListModele.TabIndex = 2;
            this.ListModele.SelectedIndexChanged += new System.EventHandler(this.ListModele_SelectedIndexChanged);
            // 
            // Modèle
            // 
            this.Modèle.AutoSize = true;
            this.Modèle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Modèle.Location = new System.Drawing.Point(6, 3);
            this.Modèle.Name = "Modèle";
            this.Modèle.Size = new System.Drawing.Size(268, 46);
            this.Modèle.TabIndex = 0;
            this.Modèle.Text = "Modèle";
            this.Modèle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonModele
            // 
            this.ButtonModele.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonModele.Location = new System.Drawing.Point(6, 436);
            this.ButtonModele.Name = "ButtonModele";
            this.ButtonModele.Size = new System.Drawing.Size(268, 59);
            this.ButtonModele.TabIndex = 3;
            this.ButtonModele.Text = "Gestion des modèles";
            this.ButtonModele.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Constructeur, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ListboxConstructeur, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ButtonConstruc, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04167F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.95834F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(280, 501);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Constructeur
            // 
            this.Constructeur.AutoSize = true;
            this.Constructeur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Constructeur.Location = new System.Drawing.Point(6, 3);
            this.Constructeur.Name = "Constructeur";
            this.Constructeur.Size = new System.Drawing.Size(268, 46);
            this.Constructeur.TabIndex = 0;
            this.Constructeur.Text = "Constructeur";
            this.Constructeur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListboxConstructeur
            // 
            this.ListboxConstructeur.FormattingEnabled = true;
            this.ListboxConstructeur.Location = new System.Drawing.Point(6, 55);
            this.ListboxConstructeur.Name = "ListboxConstructeur";
            this.ListboxConstructeur.Size = new System.Drawing.Size(268, 368);
            this.ListboxConstructeur.TabIndex = 1;
            this.ListboxConstructeur.SelectedIndexChanged += new System.EventHandler(this.ListboxConstructeur_SelectedIndexChanged);
            // 
            // ButtonConstruc
            // 
            this.ButtonConstruc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonConstruc.Location = new System.Drawing.Point(6, 436);
            this.ButtonConstruc.Name = "ButtonConstruc";
            this.ButtonConstruc.Size = new System.Drawing.Size(268, 59);
            this.ButtonConstruc.TabIndex = 2;
            this.ButtonConstruc.Text = "Gestion des constructeurs";
            this.ButtonConstruc.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Avion;
        private System.Windows.Forms.Label Modèle;
        private System.Windows.Forms.Label Constructeur;
        private System.Windows.Forms.ListBox ListAvion;
        private System.Windows.Forms.Button ButtonAvion;
        private System.Windows.Forms.ListBox ListModele;
        private System.Windows.Forms.Button ButtonModele;
        private System.Windows.Forms.ListBox ListboxConstructeur;
        private System.Windows.Forms.Button ButtonConstruc;
    }
}

