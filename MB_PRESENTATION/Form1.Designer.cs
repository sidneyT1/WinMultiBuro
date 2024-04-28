
namespace MB_PRESENTATION
{
    partial class Multiburo
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.BUradio = new System.Windows.Forms.RadioButton();
            this.OSradio = new System.Windows.Forms.RadioButton();
            this.SRradio = new System.Windows.Forms.RadioButton();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.LibBox = new System.Windows.Forms.TextBox();
            this.CapNum = new System.Windows.Forms.NumericUpDown();
            this.TarBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CapNum)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numéro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Libéllé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(394, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Capacité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tarif";
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnValider.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.Location = new System.Drawing.Point(543, 384);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(82, 41);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // BUradio
            // 
            this.BUradio.AutoSize = true;
            this.BUradio.BackColor = System.Drawing.Color.Transparent;
            this.BUradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUradio.Location = new System.Drawing.Point(486, 242);
            this.BUradio.Name = "BUradio";
            this.BUradio.Size = new System.Drawing.Size(65, 17);
            this.BUradio.TabIndex = 9;
            this.BUradio.TabStop = true;
            this.BUradio.Text = "Bureau";
            this.BUradio.UseVisualStyleBackColor = false;
            this.BUradio.CheckedChanged += new System.EventHandler(this.BUradio_CheckedChanged);
            // 
            // OSradio
            // 
            this.OSradio.AutoSize = true;
            this.OSradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OSradio.Location = new System.Drawing.Point(560, 242);
            this.OSradio.Name = "OSradio";
            this.OSradio.Size = new System.Drawing.Size(95, 17);
            this.OSradio.TabIndex = 10;
            this.OSradio.TabStop = true;
            this.OSradio.Text = "Open Space";
            this.OSradio.UseVisualStyleBackColor = true;
            this.OSradio.CheckedChanged += new System.EventHandler(this.OSradio_CheckedChanged);
            // 
            // SRradio
            // 
            this.SRradio.AutoSize = true;
            this.SRradio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRradio.Location = new System.Drawing.Point(661, 242);
            this.SRradio.Name = "SRradio";
            this.SRradio.Size = new System.Drawing.Size(117, 17);
            this.SRradio.TabIndex = 11;
            this.SRradio.TabStop = true;
            this.SRradio.Text = "Salle de réunion";
            this.SRradio.UseVisualStyleBackColor = true;
            this.SRradio.CheckedChanged += new System.EventHandler(this.SRradio_CheckedChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAnnuler.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(453, 384);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(84, 41);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // NumBox
            // 
            this.NumBox.BackColor = System.Drawing.Color.GhostWhite;
            this.NumBox.Location = new System.Drawing.Point(486, 145);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(100, 20);
            this.NumBox.TabIndex = 13;
            this.NumBox.TextChanged += new System.EventHandler(this.NumBox_TextChanged);
            // 
            // LibBox
            // 
            this.LibBox.BackColor = System.Drawing.Color.GhostWhite;
            this.LibBox.Location = new System.Drawing.Point(486, 199);
            this.LibBox.Name = "LibBox";
            this.LibBox.Size = new System.Drawing.Size(100, 20);
            this.LibBox.TabIndex = 14;
            this.LibBox.TextChanged += new System.EventHandler(this.LibBox_TextChanged);
            // 
            // CapNum
            // 
            this.CapNum.BackColor = System.Drawing.Color.GhostWhite;
            this.CapNum.Location = new System.Drawing.Point(486, 288);
            this.CapNum.Name = "CapNum";
            this.CapNum.Size = new System.Drawing.Size(120, 20);
            this.CapNum.TabIndex = 15;
            this.CapNum.ValueChanged += new System.EventHandler(this.CapNum_ValueChanged);
            // 
            // TarBox
            // 
            this.TarBox.BackColor = System.Drawing.Color.GhostWhite;
            this.TarBox.Location = new System.Drawing.Point(486, 332);
            this.TarBox.Name = "TarBox";
            this.TarBox.Size = new System.Drawing.Size(100, 20);
            this.TarBox.TabIndex = 16;
            this.TarBox.TextChanged += new System.EventHandler(this.TarBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(606, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "€ / jour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Création d\'une ressource";
            // 
            // Multiburo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1165, 563);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TarBox);
            this.Controls.Add(this.CapNum);
            this.Controls.Add(this.LibBox);
            this.Controls.Add(this.NumBox);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.SRradio);
            this.Controls.Add(this.OSradio);
            this.Controls.Add(this.BUradio);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Multiburo";
            this.Text = "Multiburo";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CapNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.RadioButton BUradio;
        private System.Windows.Forms.RadioButton OSradio;
        private System.Windows.Forms.RadioButton SRradio;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.TextBox LibBox;
        private System.Windows.Forms.NumericUpDown CapNum;
        private System.Windows.Forms.TextBox TarBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

