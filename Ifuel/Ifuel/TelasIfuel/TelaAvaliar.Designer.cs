namespace Ifuel
{
    partial class TelaAvaliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAvaliar));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvaliar = new System.Windows.Forms.Button();
            this.txtNomePosto = new System.Windows.Forms.TextBox();
            this.txtComent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVoltar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(137, 276);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(87, 23);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvaliar
            // 
            this.btnAvaliar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAvaliar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvaliar.Location = new System.Drawing.Point(267, 276);
            this.btnAvaliar.Name = "btnAvaliar";
            this.btnAvaliar.Size = new System.Drawing.Size(87, 23);
            this.btnAvaliar.TabIndex = 1;
            this.btnAvaliar.Text = "Avaliar";
            this.btnAvaliar.UseVisualStyleBackColor = false;
            this.btnAvaliar.Click += new System.EventHandler(this.btnAvaliar_Click);
            // 
            // txtNomePosto
            // 
            this.txtNomePosto.Location = new System.Drawing.Point(144, 84);
            this.txtNomePosto.Name = "txtNomePosto";
            this.txtNomePosto.Size = new System.Drawing.Size(200, 20);
            this.txtNomePosto.TabIndex = 2;
            // 
            // txtComent
            // 
            this.txtComent.Location = new System.Drawing.Point(146, 193);
            this.txtComent.Name = "txtComent";
            this.txtComent.Size = new System.Drawing.Size(200, 61);
            this.txtComent.TabIndex = 4;
            this.txtComent.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Avalie um Posto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.label2.Location = new System.Drawing.Point(158, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite o nome do Posto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Digite uma nota para o posto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Deixe um comentário";
            // 
            // textNota
            // 
            this.textNota.Location = new System.Drawing.Point(194, 133);
            this.textNota.Name = "textNota";
            this.textNota.Size = new System.Drawing.Size(100, 20);
            this.textNota.TabIndex = 10;
            // 
            // TelaAvaliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(494, 311);
            this.Controls.Add(this.textNota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComent);
            this.Controls.Add(this.txtNomePosto);
            this.Controls.Add(this.btnAvaliar);
            this.Controls.Add(this.btnVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAvaliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliar Posto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvaliar;
        private System.Windows.Forms.TextBox txtNomePosto;
        private System.Windows.Forms.RichTextBox txtComent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNota;
    }
}