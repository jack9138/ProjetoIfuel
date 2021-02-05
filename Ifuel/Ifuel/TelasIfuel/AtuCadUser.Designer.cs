namespace Ifuel
{
    partial class AtuCadUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtuCadUser));
            this.cadUser = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textConfEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadUser
            // 
            this.cadUser.AutoSize = true;
            this.cadUser.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadUser.Location = new System.Drawing.Point(94, 9);
            this.cadUser.Name = "cadUser";
            this.cadUser.Size = new System.Drawing.Size(239, 22);
            this.cadUser.TabIndex = 3;
            this.cadUser.Text = "Atualizar Cadastro - Usuário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(330, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Para atualizar cadastro prencha os dados solicitados";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(23, 91);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(176, 20);
            this.textNome.TabIndex = 21;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(223, 91);
            this.textCPF.Mask = "000.000.000-00";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(176, 20);
            this.textCPF.TabIndex = 22;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(23, 145);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(176, 20);
            this.textCidade.TabIndex = 23;
            // 
            // textBairro
            // 
            this.textBairro.Location = new System.Drawing.Point(223, 145);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(176, 20);
            this.textBairro.TabIndex = 24;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(23, 211);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(176, 20);
            this.textEmail.TabIndex = 25;
            // 
            // textConfEmail
            // 
            this.textConfEmail.Location = new System.Drawing.Point(223, 211);
            this.textConfEmail.Name = "textConfEmail";
            this.textConfEmail.Size = new System.Drawing.Size(176, 20);
            this.textConfEmail.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(95, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "E-mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(287, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Confirmar E-mail";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(98, 297);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(83, 32);
            this.btnVoltar.TabIndex = 33;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(249, 297);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 32);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // AtuCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 341);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textConfEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cadUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtuCadUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Cadastro";
            this.Load += new System.EventHandler(this.AtuCadUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cadUser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textConfEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
    }
}