namespace Ifuel
{
    partial class MenuPosto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPosto));
            this.btnAtuPreco = new System.Windows.Forms.Button();
            this.btnverAvaliacao = new System.Windows.Forms.Button();
            this.btnAtuCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtuPreco
            // 
            this.btnAtuPreco.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtuPreco.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtuPreco.Location = new System.Drawing.Point(172, 102);
            this.btnAtuPreco.Name = "btnAtuPreco";
            this.btnAtuPreco.Size = new System.Drawing.Size(124, 38);
            this.btnAtuPreco.TabIndex = 0;
            this.btnAtuPreco.Text = "Atualizar Preços";
            this.btnAtuPreco.UseVisualStyleBackColor = false;
            this.btnAtuPreco.Click += new System.EventHandler(this.btnAtuPreco_Click);
            // 
            // btnverAvaliacao
            // 
            this.btnverAvaliacao.BackColor = System.Drawing.SystemColors.Control;
            this.btnverAvaliacao.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverAvaliacao.Location = new System.Drawing.Point(172, 159);
            this.btnverAvaliacao.Name = "btnverAvaliacao";
            this.btnverAvaliacao.Size = new System.Drawing.Size(124, 38);
            this.btnverAvaliacao.TabIndex = 1;
            this.btnverAvaliacao.Text = "Avaliações";
            this.btnverAvaliacao.UseVisualStyleBackColor = false;
            this.btnverAvaliacao.Click += new System.EventHandler(this.btnverAvaliacao_Click);
            // 
            // btnAtuCad
            // 
            this.btnAtuCad.BackColor = System.Drawing.SystemColors.Control;
            this.btnAtuCad.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtuCad.Location = new System.Drawing.Point(172, 218);
            this.btnAtuCad.Name = "btnAtuCad";
            this.btnAtuCad.Size = new System.Drawing.Size(124, 38);
            this.btnAtuCad.TabIndex = 2;
            this.btnAtuCad.Text = "Atualizar Dados";
            this.btnAtuCad.UseVisualStyleBackColor = false;
            this.btnAtuCad.Click += new System.EventHandler(this.btnAtuCad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione uma das opções";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(185, 276);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(157, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(494, 311);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtuCad);
            this.Controls.Add(this.btnverAvaliacao);
            this.Controls.Add(this.btnAtuPreco);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPosto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu-Posto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtuPreco;
        private System.Windows.Forms.Button btnverAvaliacao;
        private System.Windows.Forms.Button btnAtuCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}