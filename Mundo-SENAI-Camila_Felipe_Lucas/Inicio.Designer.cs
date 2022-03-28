namespace Mundo_SENAI_Camila_Felipe_Lucas
{
    partial class Inicio
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCriadores = new System.Windows.Forms.Label();
            this.lblSENAI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Mundo_SENAI_Camila_Felipe_Lucas.Properties.Resources.Capturar_cópia;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(532, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.BackgroundImage = global::Mundo_SENAI_Camila_Felipe_Lucas.Properties.Resources.ASDASD4;
            this.btnJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJogar.Location = new System.Drawing.Point(337, 226);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(179, 72);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnTutorial
            // 
            this.btnTutorial.BackColor = System.Drawing.Color.Transparent;
            this.btnTutorial.BackgroundImage = global::Mundo_SENAI_Camila_Felipe_Lucas.Properties.Resources.tutorial_png;
            this.btnTutorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTutorial.Location = new System.Drawing.Point(337, 328);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(179, 72);
            this.btnTutorial.TabIndex = 2;
            this.btnTutorial.UseVisualStyleBackColor = false;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::Mundo_SENAI_Camila_Felipe_Lucas.Properties.Resources.Nico_OFFICIAL_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 309);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblCriadores
            // 
            this.lblCriadores.AutoSize = true;
            this.lblCriadores.BackColor = System.Drawing.Color.Transparent;
            this.lblCriadores.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriadores.Location = new System.Drawing.Point(214, 512);
            this.lblCriadores.Name = "lblCriadores";
            this.lblCriadores.Size = new System.Drawing.Size(340, 15);
            this.lblCriadores.TabIndex = 4;
            this.lblCriadores.Text = "© Camila Delarosa, Felipe Davelli e Lucas Pereira - SENAI 2016";
            this.lblCriadores.Click += new System.EventHandler(this.lblCriadores_Click);
            // 
            // lblSENAI
            // 
            this.lblSENAI.AutoSize = true;
            this.lblSENAI.BackColor = System.Drawing.Color.Transparent;
            this.lblSENAI.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSENAI.Location = new System.Drawing.Point(478, 512);
            this.lblSENAI.Name = "lblSENAI";
            this.lblSENAI.Size = new System.Drawing.Size(48, 15);
            this.lblSENAI.TabIndex = 5;
            this.lblSENAI.Text = "-SENAI";
            this.lblSENAI.Click += new System.EventHandler(this.lblSENAI_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Mundo_SENAI_Camila_Felipe_Lucas.Properties.Resources._00118620003_verde_esmeralda__1;
            this.ClientSize = new System.Drawing.Size(556, 535);
            this.Controls.Add(this.lblSENAI);
            this.Controls.Add(this.lblCriadores);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnTutorial);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(572, 574);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(572, 574);
            this.Name = "Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mundo SENAI";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCriadores;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblSENAI;
    }
}