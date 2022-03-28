namespace Mundo_SENAI_Camila_Felipe_Lucas
{
    partial class Escola
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
            this.btnVoz = new System.Windows.Forms.Button();
            this.pbProximo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProximo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoz
            // 
            this.btnVoz.BackColor = System.Drawing.Color.Transparent;
            this.btnVoz.BackgroundImage = global::Mundo_SENAI_Camila_Felipe_Lucas.Properties.Resources.som;
            this.btnVoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoz.Location = new System.Drawing.Point(479, 12);
            this.btnVoz.Name = "btnVoz";
            this.btnVoz.Size = new System.Drawing.Size(65, 60);
            this.btnVoz.TabIndex = 11;
            this.btnVoz.UseVisualStyleBackColor = false;
            this.btnVoz.Click += new System.EventHandler(this.btnVoz_Click);
            // 
            // pbProximo
            // 
            this.pbProximo.BackColor = System.Drawing.Color.Transparent;
            this.pbProximo.Image = global::Mundo_SENAI_Camila_Felipe_Lucas.Properties.Resources.flecha;
            this.pbProximo.Location = new System.Drawing.Point(444, 474);
            this.pbProximo.Name = "pbProximo";
            this.pbProximo.Size = new System.Drawing.Size(100, 50);
            this.pbProximo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProximo.TabIndex = 14;
            this.pbProximo.TabStop = false;
            this.pbProximo.Click += new System.EventHandler(this.pbProximo_Click);
            // 
            // Escola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mundo_SENAI_Camila_Felipe_Lucas.Properties.Resources.sala;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(556, 535);
            this.Controls.Add(this.pbProximo);
            this.Controls.Add(this.btnVoz);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(572, 574);
            this.MinimumSize = new System.Drawing.Size(572, 574);
            this.Name = "Escola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escola";
            ((System.ComponentModel.ISupportInitialize)(this.pbProximo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoz;
        private System.Windows.Forms.PictureBox pbProximo;
    }
}