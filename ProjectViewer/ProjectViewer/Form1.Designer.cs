namespace ProjectViewer
{
    partial class Form1
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
            this.btn_creerAlbum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_creerAlbum
            // 
            this.btn_creerAlbum.Location = new System.Drawing.Point(13, 13);
            this.btn_creerAlbum.Name = "btn_creerAlbum";
            this.btn_creerAlbum.Size = new System.Drawing.Size(114, 23);
            this.btn_creerAlbum.TabIndex = 0;
            this.btn_creerAlbum.Text = "Créer un album";
            this.btn_creerAlbum.UseVisualStyleBackColor = true;
            this.btn_creerAlbum.Click += new System.EventHandler(this.btn_creerAlbum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.btn_creerAlbum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_creerAlbum;
    }
}

