
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
            this.label2.Location = new System.Drawing.Point(319, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numéro";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Libéllé";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Capacité";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tarif";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(465, 315);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(82, 41);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "VALIDER";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // BUradio
            // 
            this.BUradio.AutoSize = true;
            this.BUradio.Location = new System.Drawing.Point(389, 179);
            this.BUradio.Name = "BUradio";
            this.BUradio.Size = new System.Drawing.Size(40, 17);
            this.BUradio.TabIndex = 9;
            this.BUradio.TabStop = true;
            this.BUradio.Text = "BU";
            this.BUradio.UseVisualStyleBackColor = true;
            this.BUradio.CheckedChanged += new System.EventHandler(this.BUradio_CheckedChanged);
            // 
            // OSradio
            // 
            this.OSradio.AutoSize = true;
            this.OSradio.Location = new System.Drawing.Point(465, 179);
            this.OSradio.Name = "OSradio";
            this.OSradio.Size = new System.Drawing.Size(85, 17);
            this.OSradio.TabIndex = 10;
            this.OSradio.TabStop = true;
            this.OSradio.Text = "Open Space";
            this.OSradio.UseVisualStyleBackColor = true;
            this.OSradio.CheckedChanged += new System.EventHandler(this.OSradio_CheckedChanged);
            // 
            // SRradio
            // 
            this.SRradio.AutoSize = true;
            this.SRradio.Location = new System.Drawing.Point(571, 179);
            this.SRradio.Name = "SRradio";
            this.SRradio.Size = new System.Drawing.Size(101, 17);
            this.SRradio.TabIndex = 11;
            this.SRradio.TabStop = true;
            this.SRradio.Text = "Salle de réunion";
            this.SRradio.UseVisualStyleBackColor = true;
            this.SRradio.CheckedChanged += new System.EventHandler(this.SRradio_CheckedChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(361, 315);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(84, 41);
            this.btnAnnuler.TabIndex = 12;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // NumBox
            // 
            this.NumBox.Location = new System.Drawing.Point(409, 64);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(100, 20);
            this.NumBox.TabIndex = 13;
            this.NumBox.TextChanged += new System.EventHandler(this.NumBox_TextChanged);
            // 
            // LibBox
            // 
            this.LibBox.Location = new System.Drawing.Point(409, 119);
            this.LibBox.Name = "LibBox";
            this.LibBox.Size = new System.Drawing.Size(100, 20);
            this.LibBox.TabIndex = 14;
            this.LibBox.TextChanged += new System.EventHandler(this.LibBox_TextChanged);
            // 
            // CapNum
            // 
            this.CapNum.Location = new System.Drawing.Point(409, 226);
            this.CapNum.Name = "CapNum";
            this.CapNum.Size = new System.Drawing.Size(120, 20);
            this.CapNum.TabIndex = 15;
            this.CapNum.ValueChanged += new System.EventHandler(this.CapNum_ValueChanged);
            // 
            // TarBox
            // 
            this.TarBox.Location = new System.Drawing.Point(409, 273);
            this.TarBox.Name = "TarBox";
            this.TarBox.Size = new System.Drawing.Size(100, 20);
            this.TarBox.TabIndex = 16;
            this.TarBox.TextChanged += new System.EventHandler(this.TarBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "€ / jour";
            // 
            // Multiburo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 537);
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
    }
}

