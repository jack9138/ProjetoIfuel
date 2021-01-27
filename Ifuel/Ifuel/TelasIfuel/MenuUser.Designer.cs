namespace Ifuel
{
    partial class MenuUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtuCad = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesqPreco = new System.Windows.Forms.Button();
            this.btnAvaliar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(157, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(132, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecione uma das opções";
            // 
            // btnAtuCad
            // 
            this.btnAtuCad.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtuCad.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtuCad.Location = new System.Drawing.Point(175, 220);
            this.btnAtuCad.Name = "btnAtuCad";
            this.btnAtuCad.Size = new System.Drawing.Size(124, 38);
            this.btnAtuCad.TabIndex = 8;
            this.btnAtuCad.Text = "Atualizar Dados";
            this.btnAtuCad.UseVisualStyleBackColor = false;
            this.btnAtuCad.Click += new System.EventHandler(this.btnAtuCad_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(192, 276);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 23);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPesqPreco
            // 
            this.btnPesqPreco.BackColor = System.Drawing.SystemColors.Control;
            this.btnPesqPreco.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqPreco.Location = new System.Drawing.Point(175, 118);
            this.btnPesqPreco.Name = "btnPesqPreco";
            this.btnPesqPreco.Size = new System.Drawing.Size(124, 38);
            this.btnPesqPreco.TabIndex = 10;
            this.btnPesqPreco.Text = "Pesquisar Preço";
            this.btnPesqPreco.UseVisualStyleBackColor = false;
            this.btnPesqPreco.Click += new System.EventHandler(this.btnPesqPreco_Click);
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.BackColor = System.Drawing.SystemColors.Control;
            this.btnAvaliar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaliar.Location = new System.Drawing.Point(175, 168);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(124, 38);
            this.btnAvaliar.TabIndex = 11;
            this.btnAvaliar.Text = "Avaliar Posto";
            this.btnAvaliar.UseVisualStyleBackColor = false;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // MenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 311);
            this.Controls.Add(this.btnAvaliar);
            this.Controls.Add(this.btnPesqPreco);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtuCad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu-Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtuCad;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesqPreco;
        private System.Windows.Forms.Button btnAvaliar;
    }
}