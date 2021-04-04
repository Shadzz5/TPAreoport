
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
            this.ListConstruc = new System.Windows.Forms.ListBox();
            this.ListModele = new System.Windows.Forms.ListBox();
            this.ListAvion = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.Tab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.AjoutModifSup.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 419);
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
            this.Tab.Size = new System.Drawing.Size(638, 419);
            this.Tab.TabIndex = 3;
            // 
            // Avion
            // 
            this.Avion.AutoSize = true;
            this.Avion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Avion.Location = new System.Drawing.Point(6, 3);
            this.Avion.Name = "Avion";
            this.Avion.Size = new System.Drawing.Size(626, 37);
            this.Avion.TabIndex = 0;
            this.Avion.Text = "Avion";
            this.Avion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AjoutModifSup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 59);
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
            this.AjoutModifSup.Size = new System.Drawing.Size(626, 59);
            this.AjoutModifSup.TabIndex = 0;
            // 
            // Ajouter
            // 
            this.Ajouter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ajouter.Location = new System.Drawing.Point(3, 3);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(202, 53);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Modifier.Location = new System.Drawing.Point(211, 3);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(202, 53);
            this.Modifier.TabIndex = 1;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            // 
            // Supprimer
            // 
            this.Supprimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Supprimer.Location = new System.Drawing.Point(419, 3);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(204, 53);
            this.Supprimer.TabIndex = 2;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(6, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 299);
            this.panel3.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ListConstruc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListModele, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListAvion, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 299);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ListConstruc
            // 
            this.ListConstruc.FormattingEnabled = true;
            this.ListConstruc.Location = new System.Drawing.Point(419, 3);
            this.ListConstruc.Name = "ListConstruc";
            this.ListConstruc.Size = new System.Drawing.Size(204, 290);
            this.ListConstruc.TabIndex = 2;
            this.ListConstruc.SelectedIndexChanged += new System.EventHandler(this.ListConstruc_SelectedIndexChanged);
            // 
            // ListModele
            // 
            this.ListModele.FormattingEnabled = true;
            this.ListModele.Location = new System.Drawing.Point(211, 3);
            this.ListModele.Name = "ListModele";
            this.ListModele.Size = new System.Drawing.Size(202, 290);
            this.ListModele.TabIndex = 1;
            this.ListModele.SelectedIndexChanged += new System.EventHandler(this.ListModele_SelectedIndexChanged);
            // 
            // ListAvion
            // 
            this.ListAvion.FormattingEnabled = true;
            this.ListAvion.Location = new System.Drawing.Point(3, 3);
            this.ListAvion.Name = "ListAvion";
            this.ListAvion.Size = new System.Drawing.Size(202, 290);
            this.ListAvion.TabIndex = 0;
            // 
            // AjoutModifSupprAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 419);
            this.Controls.Add(this.panel1);
            this.Name = "AjoutModifSupprAvion";
            this.panel1.ResumeLayout(false);
            this.Tab.ResumeLayout(false);
            this.Tab.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.AjoutModifSup.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox ListConstruc;
        private System.Windows.Forms.ListBox ListModele;
        public System.Windows.Forms.ListBox ListAvion;
    }
}
